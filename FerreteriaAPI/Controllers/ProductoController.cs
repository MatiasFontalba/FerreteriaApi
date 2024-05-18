using FerreteriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FerreteriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        static IList<Producto> lista = new List<Producto>();
        // GET: api/<ProductoController>
        [HttpGet]
        public IList<Producto> Get()
        {
            return lista;
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public Producto Get(int id)
        {
            return lista.FirstOrDefault(x => x.idProducto == id);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public void Post([FromBody] Producto objeto)
        {
            lista.Add(objeto);
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            lista.Remove(lista.FirstOrDefault(x => x.idProducto == id));
        }
    }
}
