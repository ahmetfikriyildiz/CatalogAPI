using CatalogAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _prodcutWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository prodcutWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _prodcutWriteRepository = prodcutWriteRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _prodcutWriteRepository.AddRangeAsync(new()
            {
                new() { Id = 1, Name="product1", Description="kazak", Price= 50, StockStatus= "1"}
            });
            await _prodcutWriteRepository.SaveAsync();
        }
    }
}
