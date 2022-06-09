using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Core;
using MiniShopApp.WebUI.EmailServices;
using MiniShopApp.WebUI.Identity;
using MiniShopApp.WebUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private ICardService _cardService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, ICardService cardService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _cardService = cardService;
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginModel() 
            {
                ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                ModelState.AddModelError("","Böyle bir kullanıcı bululamadı!");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Hesabınız onaylanmamıştır! Lütfen mailinizi kontrol ediniz.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);

            if (result.Succeeded)
            {
                if (!String.IsNullOrEmpty(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                else { return RedirectToAction("Index","Home"); }
            }

            TempData["Message"] = JobManager.CreateMessage("DİKKAT!","Şifreniz hatalı!", "danger");

            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName=model.FirstName,
                LastName=model.LastName,
                UserName=model.UserName,
                Email=model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)//Başarılı bir şekilde create gerçekleştiyse
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                //email gönderme işlemi
                await _emailSender.SendEmailAsync(model.Email, "MiniShopApp Confirm Account!", $"Lütfen email adresinizi onaylamak için <a href='https://localhost:5001{url}'>tıklayınız!</a>");
                TempData["Message"] = JobManager.CreateMessage("DİKKAT!", "Kayıt işleminizi tamamlamak için mailinize gönderilen onaylama linkine tıklayınız!", "danger");
                return RedirectToAction("Login", "Account");
            }


            return View();
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token==null)
            {
                TempData["Message"] = JobManager.CreateMessage("DİKKAT!", "Bir sorun oluştu.", "warning");
                return View();
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user!=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    //Card oluşturulacak
                    _cardService.InitializeCard(userId);
                    TempData["Message"] = JobManager.CreateMessage("BAŞARILI!", "Hesabınız onaylanmıştır!", "success");;
                }
                return View();
            }

            TempData["Message"] = JobManager.CreateMessage("DİKKAT!","Hesabınız onaylanamamıştır! Lütfen daha sonra yeniden deneyiniz.","danger");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                TempData["Message"] = JobManager.CreateMessage("DİKKAT!", "Lütfen email adresinizi giriniz", "warning");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user==null)
            {
                TempData["Message"] = JobManager.CreateMessage("DİKKAT!","Böyle bir email hatası bulunamadı!","danger");
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new 
            {
                userId = user.Id,
                token = code
            });

            await _emailSender.SendEmailAsync(email,"MiniShopApp Reset Password", $"Lütfen parolanızı sıfırlamak için <a href='https://localhost:5001{url}'>TIKLAYINIZ</a>");
            TempData["Message"] = JobManager.CreateMessage("BİLGİLENDİRME!","Şifre sıfırlama linki kayıtlı mail adresinize gönderilmiştir. Lütfen kontrol ediniz.", "warning");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData["Message"] = JobManager.CreateMessage("DİKKAT!","Bir sorun oluştu, tekrar deneyiniz!","danger");
                return RedirectToAction("Index", "Home");
            }

            var model = new ResetPasswordModel()
            {
                Token = token
            };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                TempData["Message"] = JobManager.CreateMessage("DİKKAT!","Bir sorun oluştu. Lütfen bilgileri kontrol ederek yeniden deneyiniz.", "danger");
                return View();
            }

            var result = await _userManager.ResetPasswordAsync(
                
                    user,
                    model.Token,
                    model.Password
                );

            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }

            TempData["Message"] = JobManager.CreateMessage("DİKKAT!", "Bir sorun oluştu. Lütfen Admin'e başvurunuz", "danger");
            return Redirect("~/");

        }

    }
}
