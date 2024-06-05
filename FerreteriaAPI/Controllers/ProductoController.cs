using FerreteriaAPI.Models;
using FerreteriaAPI.Service;
using FerreteriaAPI.Service.Implements;
using Microsoft.AspNetCore.Mvc;
using System.Timers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FerreteriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        IProducto service = new ProductoService();
        // GET: api/<ProductoController>
        [HttpGet]
        public ActionResult<IList<Producto>> Get()
        {
            try { return Ok(service.Listar()); }
            catch (Exception e) {
                return NotFound(e.Message);
            }
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int id)
        {
            try {
                return Ok( service.Read(id));
            }
            catch(Exception e) {
                return BadRequest(e.Message);
            }
            
        }

        // POST api/<ProductoController>
        [HttpPost]
        public ActionResult Post([FromBody] Producto objeto)
        {
            try {
                service.Create(objeto);
                return Ok("Existe un error con el dato ingresado");
                    }
            catch (Exception e)
            {
                return Conflict(e.Message);
            }
            //service.Create(objeto);
            //return Ok("El objeto se creo satisfactoriamente");
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Producto value)
        {
            service.Update(id, value);
            return Ok("El objeto se modifico correctamente");
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            service.Delete(id);
            return Ok("Producto eliminado");
        }
    }
}
