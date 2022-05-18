using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        //[Required(ErrorMessage = "Lütfen ürün adınız giriniz!")]
        //[StringLength(50, MinimumLength = 10, ErrorMessage = "Lütfen 10 ile 50 karakter uzunluğunda bir ad giriniz.")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Lütfen ürün fiyatını giriniz!")]
        //[Range(1, 100000, ErrorMessage = "Lütfen 1-100000 aralığında bir fiyat giriniz.")]
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string Url { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
