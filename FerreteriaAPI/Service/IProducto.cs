using FerreteriaAPI.Models;

namespace FerreteriaAPI.Service
{
    public interface IProducto
    {
        //CRUD
        public void Create(Producto objeto);
        public Producto Read(int id);
        public IList<Producto> Listar();
        public void Update(int id, Producto objeto);
        public void Delete(int id);
    }
}
