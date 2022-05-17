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
        public void Create(Product entity, int[] categoryIds)
        {
            using (var context = new MiniShopContext())
            {
                context.Products.Add(entity);
                context.SaveChanges();
                entity.ProductCategories = categoryIds
                    .Select(catId => new ProductCategory
                    {
                        ProductId = entity.ProductId,
                        CategoryId = catId
                    }).ToList();
                context.SaveChanges();
            }
        }

        public void Update(Product entity, int[] categoryIds)
        {
            using (var context = new MiniShopContext())
            {
                var product = context
                    .Products
                    .Include(i => i.ProductCategories)
                    .FirstOrDefault(i => i.ProductId == entity.ProductId);

                product.Name = entity.Name;
                product.Price = entity.Price;
                product.Description = entity.Description;
                product.Url = entity.Url;
                product.ImgUrl = entity.ImgUrl;
                product.IsApproved = entity.IsApproved;
                product.IsHome = entity.IsHome;
                product.ProductCategories = categoryIds.Select(catId => new ProductCategory()
                {
                    ProductId = entity.ProductId,
                    CategoryId = catId
                }).ToList();

                context.SaveChanges();
            }
        }

        public Product GetByIdWithCategories(int id)
        {
            using (var context = new MiniShopContext())
            {
                return context.Products
                              .Where(i => i.ProductId == id)
                              .Include(i => i.ProductCategories)
                              .ThenInclude(i => i.Category)
                              .FirstOrDefault();
            }
        }

        public int GetCountByCategory(string name)
        {
            using (var context = new MiniShopContext())
            {
                var products = context.Products
                                      .Where(i => i.IsApproved)
                                      .AsQueryable();

                if (!string.IsNullOrEmpty(name))
                {
                    products = products
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategories.Any(a => a.Category.Url == name));
                }
                return products.Count();
            }
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

        public Product GetProductDetails(string url)
        {
            using (var context = new MiniShopContext())
            {
                return context.Products
                    .Where(i => i.Url == url)
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
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

                return products.Skip((page-1)*pageSize).Take(pageSize).ToList(); ;
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
