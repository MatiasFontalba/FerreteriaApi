using FerreteriaAPI.Models;

namespace FerreteriaAPI.Service.Implements
{
    public class ProductoService : IProducto
    {

        static IList<Producto> lista = new List<Producto>();
        public ProductoService()
        {
            if (lista.Count == 0)
            {
                lista.Add(new Producto
                {
                    idProducto = 1,
                    nombre = "Clavillo",
                    descripcion = "clavito weonon",
                    imagen = "Deberia venir una url"
                });
            }
        }

        public void Create(Producto objeto)
        {
            lista.Add(objeto);
        }

        public void Delete(int id)
        {
            lista.Remove(lista.FirstOrDefault(x => x.idProducto == id));
        }

        public IList<Producto> Listar()
        {
            return lista;
        }

        public Producto Read(int id)
        {
            return lista.FirstOrDefault(x => x.idProducto == id);
        }

        public void Update(int id, Producto objeto)
        {
            objeto.idProducto = id;
            lista.Insert(lista.IndexOf(lista.First(x => x.idProducto == id)), objeto);
        }
    }
}
