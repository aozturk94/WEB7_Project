using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Entity;
using MiniShopApp.WebApi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAll();

            //DTO (Data Transfer Object) kullanarak, veriyi istek sahinine belirlediğimiz bilgileri içerecek selilde yollayacağız.

            var productsDTO = new List<ProductDTO>();
            foreach (var product in products)
            {
                productsDTO.Add(productToDTO(product));
            }

            return Ok(productsDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetById(id);
            if (product==null)
            {
                return NotFound();
            }
            return Ok(productToDTO(product));
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product entity)
        {
            await _productService.CreateAsync(entity);
            return CreatedAtAction(nameof(GetProduct), new { id = entity.ProductId }, entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product entity)
        {
            if (id != entity.ProductId)
            {
                return BadRequest();
            }
            var product = await _productService.GetById(id);
            if (product==null)
            {
                return NotFound();
            }
            await _productService.UpdateProductAsync(product, entity);
            return NoContent();
        }

        private static ProductDTO productToDTO(Product product)
        {
            var productDTO = new ProductDTO
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Url = product.Url
            };

            return productDTO;
        }
    }
}
