using Microsoft.EntityFrameworkCore;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new MiniShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                if (context.ProductCategories.Count() == 0)
                {
                    context.ProductCategories.AddRange(ProductCategories);
                }
            }
            context.SaveChanges();
        }
        private static Category[] Categories =
        {
            new Category() {Name="Telefon", Description="Telefon Kategorisi", Url="telefon"},
            new Category() {Name="Bilgisayar", Description="Bilgisayar Kategorisi", Url="bilgisayar"},
            new Category() {Name="Elektronik", Description="Elektronik Kategorisi", Url="elektronik"},
            new Category() {Name="Beyaz Eşya", Description="Beyaz Eşya Kategorisi", Url="beyaz-esya"}
        };
        private static Product[] Products =
        {
            new Product()
            {
                Name = "Samsung Galaxy A50",
                Price = 10000,
                Description = "İyi Telefon",
                ImgUrl = "1.png",
                IsApproved = true,
                IsHome = true,
                Url = "samsung-galaxy-a50"
            },
            new Product()
            {
                Name = "Samsung Galaxy A70",
                Price = 11000,
                Description = "İyi Telefon",
                ImgUrl = "2.png",
                IsApproved = true,
                IsHome = true,
                Url = "samsung-galaxy-a70"
            },
            new Product()
            {
                Name = "Samsung Galaxy S20",
                Price = 12000,
                Description = "İyi Telefon",
                ImgUrl = "3.png",
                IsApproved = true,
                IsHome = true,
                Url = "samsung-galaxy-s20"
            },
            new Product()
            {
                Name = "Samsung Galaxy Overall",
                Price = 13000,
                Description = "İyi Telefon",
                ImgUrl = "4.png",
                IsApproved = true,
                IsHome = true,
                Url = "samsung-galaxy-overall"
            },       
            

            new Product()
            {
                Name = "Xaomi RedMi Note 9",
                Price = 9000,
                Description = "İyi Telefon",
                ImgUrl = "5.png",
                IsApproved = true,
                IsHome = true,
                Url = "xaomi-redmi-note-9"
            },            
            new Product()
            {
                Name = "Xaomi RedMi Note 10",
                Price = 11000,
                Description = "İyi Telefon",
                ImgUrl = "6.png",
                IsApproved = true,
                IsHome = true,
                Url = "xaomi-redmi-note-10"
            },            
            new Product()
            {
                Name = "Xaomi RedMi Note 11",
                Price = 13000,
                Description = "İyi Telefon",
                ImgUrl = "7.png",
                IsApproved = true,
                IsHome = true,
                Url = "xaomi-redmi-note-11"
            },            
            new Product()
            {
                Name = "Xaomi RedMi Note 11 Plus",
                Price = 15000,
                Description = "İyi Telefon",
                ImgUrl = "8.png",
                IsApproved = true,
                IsHome = true,
                Url = "xaomi-redmi-note-11-plus"
            },
            

            new Product()
            {
                Name = "Iphone XR",
                Price = 20000,
                Description = "İyi Telefon",
                ImgUrl = "9.png",
                IsApproved = true,
                IsHome = true,
                Url = "iphone-xr"
            },            
            new Product()
            {
                Name = "Iphone 11",
                Price = 21000,
                Description = "İyi Telefon",
                ImgUrl = "10.png",
                IsApproved = true,
                IsHome = true,
                Url = "iphone-11"
            },            
            new Product()
            {
                Name = "Iphone 12",
                Price = 22000,
                Description = "İyi Telefon",
                ImgUrl = "11.png",
                IsApproved = true,
                IsHome = true,
                Url = "iphone-12"
            },            
            new Product()
            {
                Name = "Iphone 13",
                Price = 23000,
                Description = "İyi Telefon",
                ImgUrl = "12.png",
                IsApproved = true,
                IsHome = true,
                Url = "iphone-13"
            },            
            new Product()
            {
                Name = "Huawei Mate 20 Pro",
                Price = 19000,
                Description = "İyi Telefon",
                ImgUrl = "13.png",
                IsApproved = true,
                IsHome = true,
                Url = "huawei-mate-20-pro"
            }
        };
        private static ProductCategory[] ProductCategories =
        {
            new ProductCategory() { Product=Products[0], Category=Categories[0]},
            new ProductCategory() { Product=Products[0], Category=Categories[2]},

            new ProductCategory() { Product=Products[1], Category=Categories[0]},
            new ProductCategory() { Product=Products[1], Category=Categories[2]},

            new ProductCategory() { Product=Products[2], Category=Categories[0]},
            new ProductCategory() { Product=Products[2], Category=Categories[2]},

            new ProductCategory() { Product=Products[3], Category=Categories[0]},
            new ProductCategory() { Product=Products[3], Category=Categories[2]},

            new ProductCategory() { Product=Products[4], Category=Categories[0]},
            new ProductCategory() { Product=Products[4], Category=Categories[2]},


            new ProductCategory() { Product=Products[5], Category=Categories[1]},
            new ProductCategory() { Product=Products[6], Category=Categories[1]},
            new ProductCategory() { Product=Products[7], Category=Categories[1]},
            new ProductCategory() { Product=Products[8], Category=Categories[1]},
            new ProductCategory() { Product=Products[9], Category=Categories[1]},
            new ProductCategory() { Product=Products[10], Category=Categories[1]},
            new ProductCategory() { Product=Products[11], Category=Categories[1]},
            new ProductCategory() { Product=Products[12], Category=Categories[1]}
        };
    }
}
