using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.RestApi.Entities;
using MielczarekFurniture.RestApi.Extensions;
using MielczarekFurniture.RestApi.Repositories.Contracts;

namespace MielczarekFurniture.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly IProducerRepository producerRepository;

        public ProductController(IProductRepository productRepository, IProducerRepository producerRepository)
        {
            this.productRepository = productRepository;
            this.producerRepository = producerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                var products = await productRepository.GetItems();
                var producers = await producerRepository.GetProducers();

                if (products == null || producers == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = products.ConvertToDto(producers);

                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");

            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDto>> GetItem(int id)
        {
            try
            {
                var product = await productRepository.GetItem(id);
                if (product == null)
                {
                    return BadRequest();
                }
                else
                {
                    var producer = await producerRepository.GetProducer(product.Producer.Id);
                    var productDtos = product.ConvertToDto(producer);
                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");

            }
        }
        [HttpPost]
        public async Task<ActionResult<ProductDto>> PostItem([FromBody] ProductFormDto item)
        {
            try
            {
                var product = await productRepository.AddItem(item);
                if (product == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrive product (Product Name: ({item.Name})");
                }

                var producer = await producerRepository.GetProducer(product.Producer.Id);

                var newProductDto = product.ConvertToDto(producer);

                return CreatedAtAction(nameof(PostItem), new { id = newProductDto.Id }, newProductDto);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ProductDto>> DeleteItem(int id)
        {
            try
            {
                var item = await productRepository.DeleteItem(id);
                if (item == null)
                {
                    return NotFound();
                }
                var productDtos = item.ConvertToDto(item.Producer);
                return Ok(productDtos);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProductDto>> ModifyItem(int id, [FromBody] ProductFormDto item)
        {
            try
            {
                var product = await productRepository.UpdateItem(id, item);
                if (product == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrive product (productId: ({item.Name})");
                }

                var newProductDto = product.ConvertToDto(product.Producer);

                return CreatedAtAction(nameof(ModifyItem), new { id = newProductDto.Id }, newProductDto);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
