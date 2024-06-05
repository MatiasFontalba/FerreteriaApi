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
                throw new Exception("La lista se encuentra vacia");
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
            int indice = lista.IndexOf(productoInicial);
            lista[indice] = objeto;
            //objeto.idProducto = id;
            //lista.Insert(lista.IndexOf(lista.First(x => x.idProducto == id)), objeto);
            //lista.Remove(lista.FirstOrDefault(x => x.idProducto == id));
            //lista.Remove(lista.First(x => x.idProducto == id));
        }
    }
}
