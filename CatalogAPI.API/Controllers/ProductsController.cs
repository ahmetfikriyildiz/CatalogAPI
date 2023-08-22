using CatalogAPI.Application.Repositories;
using CatalogAPI.Domain.Entities;
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
        public async Task Get()
        {

            await _prodcutWriteRepository.AddAsync(new()
            {
              Id=1,Name ="name",Description="kazak",Price=1,StockStatus="1",

            });
            await _prodcutWriteRepository.SaveAsync();





            //await _prodcutWriteRepository.AddRangeAsync(new()
            //{
            //    new() { Id = 0, Name="product1", Description="kazak", Price= 50, StockStatus= "1"}
            //});
            //await _prodcutWriteRepository.SaveAsync();


            //Product p = await _productReadRepository.GetByIdAsync("1",false);
            //    p.Name = "fici";
            //await _prodcutWriteRepository.SaveAsync();

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
