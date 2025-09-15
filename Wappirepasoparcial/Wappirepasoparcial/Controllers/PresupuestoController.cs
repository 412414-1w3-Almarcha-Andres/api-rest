using Microsoft.AspNetCore.Mvc;
using Wappirepasoparcial.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wappirepasoparcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestoController : ControllerBase
    {

        private IFacuraRepository _facuraRepository;
        public PresupuestoController(IFacuraRepository facuraRepository)
        {
            _facuraRepository = facuraRepository;
        }
        // GET: api/<PresupuestoController>
        [HttpGet]
        // public IEnumerable<string> Get()  //Consume de Repositorio  *****asi lo trae por defecto*****
        public IActionResult Get()  //AHORA TRABAJAMOSEN EL METODO GET , EL ENDPOINT 
        {
            try   //º1***** try TAB TAB
            {
                return Ok(_facuraRepository.GetAll()); // 2º*****implementar el facturarepository .. seria nuestro 
            }
            catch (Exception)
            {

                return StatusCode(500, "internal error!!");  // 3º****saber los status code
            }
        }

        // GET api/<PresupuestoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PresupuestoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PresupuestoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PresupuestoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
