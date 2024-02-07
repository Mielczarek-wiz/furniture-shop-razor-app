using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.RestApi.Extensions;
using MielczarekFurniture.RestApi.Repositories.Contracts;

namespace MielczarekFurniture.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private readonly IProducerRepository producerRepository;

        public ProducerController(IProducerRepository producerRepository)
        {
            this.producerRepository = producerRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProducerDto>>> GetProducers()
        {
            try
            {
                var producers = await producerRepository.GetProducers();

                if (producers == null)
                {
                    return NotFound();
                }
                else
                {
                    var producersDtos = producers.ConvertToDto();

                    return Ok(producersDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");

            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProducerDto>> GetProducer(int id)
        {
            try
            {
                var producer = await producerRepository.GetProducer(id);
                if (producer == null)
                {
                    return BadRequest();
                }
                else
                {
                    var productDtos = producer.ConvertToDto();
                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");

            }
        }
        [HttpPost]
        public async Task<ActionResult<ProducerDto>> PostProducer([FromBody] ProducerFormDto producerForm)
        {
            try
            {
                var producer = await producerRepository.AddProducer(producerForm);
                if (producer == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrive product (Producer Name: ({producerForm.Name})");
                }

                var newProducerDto = producer.ConvertToDto();

                return CreatedAtAction(nameof(PostProducer), new { id = newProducerDto.Id }, newProducerDto);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteProducer(int id)
        {
            try
            {
                var producer = await producerRepository.DeleteProducer(id);
                if (producer == null)
                {
                    return NotFound();
                }
                var producerDtos = producer.ConvertToDto();
                return Ok(producerDtos);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProducerDto>> ModifyProducer(int id, [FromBody] ProducerFormDto producerForm)
        {
            try
            {
                var producer = await producerRepository.UpdateProducer(id, producerForm);
                if (producer == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrive product (productId: ({producerForm.Name})");
                }
                var producerDtos = producer.ConvertToDto();
                return CreatedAtAction(nameof(ModifyProducer), new { id = producerDtos.Id }, producerDtos);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
