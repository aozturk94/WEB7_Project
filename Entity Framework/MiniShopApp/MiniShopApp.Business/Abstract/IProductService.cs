using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        List<Product> GetHomePageProducts();
        List<Product> GetSeachResult(string searchString);
        int GetCountByCategory(string name);
        Product GetProductDetails(string url);
        Product GetByIdWithCategories(int id);
        public bool Create(Product entity, int[] categoryIds);
        public void Update(Product entity, int[] categoryIds);

    }
}
