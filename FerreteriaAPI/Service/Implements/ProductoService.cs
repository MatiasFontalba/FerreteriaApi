using FerreteriaAPI.Models;

namespace FerreteriaAPI.Service.Implements
{
    public class ProductoService : IProducto
    {

        static IList<Producto> lista = new List<Producto>();
        //public ProductoService()
        //{
        //    if (lista.Count == 0)
        //    {
        //        lista.Add(new Producto
        //        {
        //            idProducto = 1,
        //            nombre = "Clavillo",
        //            stock = 1,
        //            descripcion = "clavito weonon",
        //            imagen = "Deberia venir una url"
        //        });
        //    }
        //}


        public void Create(Producto objeto)
        {
            int nuevoId = objeto.idProducto;
            bool idIguales = lista.Any(x => x.idProducto == nuevoId);
            if (idIguales)
            {
                throw new Exception("Id del objeto ingresado con problemas");
            }
            lista.Add(objeto);
        }

        public void Delete(int id)
        {
            lista.Remove(lista.FirstOrDefault(x => x.idProducto == id));
        }

        public IList<Producto> Listar()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("La lista se encuentra vacia");
                throw new Exception("La lista se encuentra vacia");
            } else if(lista.Count > 0){
                Console.WriteLine("Lista de productos disponibles");
                foreach (Producto elemento in lista) {
                    //Console.WriteLine(elemento);
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Id: " + elemento.idProducto);
                    Console.WriteLine("Nombre: " + elemento.nombre);
                    Console.WriteLine("Precio: " + elemento.precio);
                    Console.WriteLine("Stock: " + elemento.stock);
                    Console.WriteLine("Descripcion: " + elemento.descripcion);
                    //Console.WriteLine(elemento.idProducto);
                }
            }
            return lista;
        }

        public Producto Read(int id)
        {

            if(lista.FirstOrDefault(x => x.idProducto == id) == null)
            {
                throw new Exception("Error al encontrar la cosa");
            }
            return lista.FirstOrDefault(x => x.idProducto == id);
        }

        public void Update(int id, Producto objeto)
        {
            Producto productoInicial = lista.FirstOrDefault(x => x.idProducto == id);
            if (productoInicial != null) {
                Console.WriteLine("El Service del producto nos indicara los datos que trae el producto original y el nuevo");
                Console.WriteLine("El id a modificar es el: " + productoInicial.idProducto);
                Console.WriteLine("Nombre original: " + productoInicial.nombre);
                Console.WriteLine("Precio original: " + productoInicial.precio);
                Console.WriteLine("Stock original: " + productoInicial.stock);
                Console.WriteLine("Descripcion original: " + productoInicial.descripcion);
                Console.WriteLine("Nombre nuevo: " + objeto.nombre);
                Console.WriteLine("Precio nuevo: " + objeto.precio);
                Console.WriteLine("Stock nuevo: " + objeto.stock);
                Console.WriteLine("Descripcion nueva: " + objeto.descripcion);
                Console.WriteLine("--------------------------------");
            }
            int indice = lista.IndexOf(productoInicial);
            lista[indice] = objeto;
            //objeto.idProducto = id;
            //lista.Insert(lista.IndexOf(lista.First(x => x.idProducto == id)), objeto);
            //lista.Remove(lista.FirstOrDefault(x => x.idProducto == id));
            //lista.Remove(lista.First(x => x.idProducto == id));
        }
    }
}
