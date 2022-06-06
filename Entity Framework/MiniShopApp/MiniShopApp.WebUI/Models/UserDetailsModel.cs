using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class UserDetailsModel
    {
        public string UserId { get; set; }

        [Required(ErrorMessage = "FirstName zorunludur!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName zorunludur!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "UserName zorunludur!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email zorunludur!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen geçerli bir mail adresi giriniz.")]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public IEnumerable<string> SelectedRoles { get; set; }

    }
}
