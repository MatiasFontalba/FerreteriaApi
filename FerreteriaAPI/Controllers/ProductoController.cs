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
            try {
                //foreach(Producto elemento in Producto) { }
                return Ok(service.Listar()); 
            }
            catch (Exception e) {
                return NotFound(e.Message);
            }
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int id)
        {
            try {
                Console.WriteLine("Vengo del controlador del producto en su metodo de obtener por id a decir");
                Console.WriteLine("El id consultado es el " + id);
                Console.WriteLine("---------------------------------------");
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
                Console.WriteLine("Vengo desde el controlador del producto en su metodo post para decir que se realizo bien la peticion");
                Console.WriteLine("El nombre del producto es:" + objeto.nombre);
                Console.WriteLine("El precio del producto es:" + objeto.precio);
                Console.WriteLine("El stock del producto es:" + objeto.stock);
                Console.WriteLine(objeto.descripcion);
                Console.WriteLine("-------------------------------------");
                //Console.WriteLine("De donde viene el log (File) y el dato que entrega");
                return Ok("Producto ingresado correctamente");
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
            Console.WriteLine("Vengo del controlador de producto en su metodo Delete para decir: ");
            Console.WriteLine("El producto que se acaba de eliminar contenia el id" + id);
            Console.WriteLine("----------------------------------------");
            service.Delete(id);
            return Ok("Producto eliminado");
        }
    }
}
