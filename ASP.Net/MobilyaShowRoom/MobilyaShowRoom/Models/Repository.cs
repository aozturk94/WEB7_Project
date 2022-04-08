using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Models
{
    public static class Repository
    {
        public static List<Product> AllProduct()
        {
            var products = new List<Product>
            {
                new Product {ID=470, ProductName="Dolap", ProductDetail="İki kapılı ahşap dolap1", Price=5000},
                new Product {ID=570, ProductName="Koltuk", ProductDetail="İki kapılı ahşap dolap2", Price=6000},
                new Product {ID=670, ProductName="TV Sehpası", ProductDetail="İki kapılı ahşap dolap3", Price=7000},
                new Product {ID=430, ProductName="Yatak", ProductDetail="İki kapılı ahşap dolap4", Price=8000},
                new Product {ID=478, ProductName="Masa", ProductDetail="İki kapılı ahşap dolap5", Price=9000},
                new Product {ID=180, ProductName="Sandalye", ProductDetail="İki kapılı ahşap dolap6", Price=10000}
            };
            return products;
        }
    }
}
