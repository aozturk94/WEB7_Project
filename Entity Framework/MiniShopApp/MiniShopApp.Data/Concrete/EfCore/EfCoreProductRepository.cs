using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, MiniShopContext>, IProductRepository
    {
        public Product GetByIdWithProducts(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetHomePageProducts()
        {
            using (var context = new MiniShopContext())
            {
                return context
                    .Products
                    .Where(i => i.IsApproved && i.IsHome)
                    .ToList();
            }
        }

        public List<Product> GetProductsByCategory(string name)
        {
            using (var context = new MiniShopContext())
            {
                var products = context
                    .Products
                    .Where(i => i.IsApproved)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(name))
                {
                    products = products
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategories.Any(a => a.Category.Url == name));
                }

                return products.ToList();
            }
        }

        public List<Product> GetSearchResult(string searchString)
        {
            searchString = searchString.ToLower();
            using (var context = new MiniShopContext())
            {
                var products = context
                    .Products
                    .Where(i => i.IsApproved && (i.Name.ToLower().Contains(searchString) || i.Description.ToLower().Contains(searchString)))
                    .ToList();
                return products;
            }
        }
    }
}
