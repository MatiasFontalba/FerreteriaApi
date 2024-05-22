using FerreteriaAPI.Models;
using FerreteriaAPI.Service;
using FerreteriaAPI.Service.Implements;
using Microsoft.AspNetCore.Mvc;

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
        public IList<Producto> Get()
        {
            return service.Listar();
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public Producto Get(int id)
        {
            return service.Read(id);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public void Post([FromBody] Producto objeto)
        {
            service.Create(objeto);
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Producto value)
        {
            service.Update(id, value);
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
