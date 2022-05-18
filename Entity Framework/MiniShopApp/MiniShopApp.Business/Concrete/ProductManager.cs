﻿using MiniShopApp.Business.Abstract;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public string ErrorMessage { get; set; }

        public bool Validation(Product entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += $"Ürün adı boş bırakılamaz!\n";
                isValid = false;
            }
            if (entity.Name.Length<10 || entity.Name.Length>50)
            {
                ErrorMessage += $"Ürün adı 10-50 karakter uzunluğunda olmalıdır.\n";
                isValid = false;
            }
            if (entity.Price == null)
            {
                ErrorMessage += $"Ürün fiyat boş bırakılamaz!\n";
                isValid = false;
            }
            if (entity.Price<0 || entity.Price>100000)
            {
                ErrorMessage += $"Ürün fiyatı 1-100000 arasında olmalıdır!\n";
                isValid = false;
            }
            return isValid;
        }
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return _productRepository.GetProductsByCategory(name, page, pageSize);
        }

        public List<Product> GetHomePageProducts()
        {
            return _productRepository.GetHomePageProducts();
        }
        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetSeachResult(string searchString)
        {
            return _productRepository.GetSearchResult(searchString);
        }

        public int GetCountByCategory(string name)
        {
            return _productRepository.GetCountByCategory(name);
        }

        public Product GetProductDetails(string url)
        {
            return _productRepository.GetProductDetails(url);
        }

        public bool Create(Product entity, int[] categoryIds)
        {
            if (Validation(entity))
            {
                _productRepository.Create(entity, categoryIds);
                return true;
            }
            return false;
        }

        public Product GetByIdWithCategories(int id)
        {
            return _productRepository.GetByIdWithCategories(id);
        }

        public void Update(Product entity, int[] categoryIds)
        {
            _productRepository.Update(entity, categoryIds);
        }
    }
}
