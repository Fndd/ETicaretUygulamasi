using ETicaret.Application.Abstractions;
using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductWriteRepository _productService;
        private readonly IProductReadRepository _productReadService;
        public ProductController(IProductWriteRepository productService, IProductReadRepository productReadService)
        {
            _productService = productService;
            _productReadService = productReadService;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            await _productService.AddRangeAsync(new()
            {
                new(){ Id = Guid.NewGuid(), Name ="Ürün 1", Stock = 5,CreatedDate = DateTime.UtcNow, Price = 50,Description = "Ürün Açıklaması"},
                new(){ Id = Guid.NewGuid(), Name ="Ürün 2", Stock = 5,CreatedDate = DateTime.UtcNow, Price = 50,Description = "Ürün Açıklaması"},
                new(){ Id = Guid.NewGuid(), Name ="Ürün 3", Stock = 5,CreatedDate = DateTime.UtcNow, Price = 50,Description = "Ürün Açıklaması"},
            });
            await _productService.SaveAsync();
            var products = _productReadService.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _productReadService.GetByIdAsync(id));
        }
        [HttpPost()]
        public async Task<IActionResult> CreateProduct()
        {
            Product product = new Product { Id = Guid.NewGuid(), Name = "Ürün 111", Stock = 5, CreatedDate = DateTime.UtcNow, Price = 50, Description = "Ürün Açıklaması" };

            await _productService.AddAsync(product);
            await _productService.SaveAsync();
            product.Description = "Açıklama yazısı değişti";
            await _productService.SaveAsync();
            return Ok(product);
        }
    }
}
