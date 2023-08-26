using CatalogAPI.Application.Repositories;
using CatalogAPI.Application.ViewModels.Products;
using CatalogAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CatalogAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _prodcutWriteRepository;
        readonly private ICategoryReadRepository _categoryReadRepository;
        readonly ICategoryWriteRepository 
            _categoryWriteRepository;


        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository prodcutWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _prodcutWriteRepository = prodcutWriteRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_productReadRepository.GetAll(false));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _productReadRepository.GetByIdAsync(id,false));
        }
        [HttpPost]
        public async Task<IActionResult> Post(Create_Product model)
        {
            await _prodcutWriteRepository.AddAsync(new()
            {
                Id = (int)model.Id,
                Name = model.Name,
                CreatedDate = DateTime.Now,
                Price = (double)model.Price,
                Description = model.Description,
                StockStatus = model.StockStatus,
            });
            await _prodcutWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Put(Update_Product model)
        {
            Product product = await _productReadRepository.GetByIdAsync(model.Id);
            product.Price = (double)model.Price;
            product.Description = model.Description;
            product.StockStatus = model.StockStatus;
       
          
            await _prodcutWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(string id)
        {
            await _prodcutWriteRepository.RemoveAsync(id);
            await _prodcutWriteRepository.SaveAsync();
            return Ok();
        }

    }
}
