namespace FerreteriaAPI.Models
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }

        public Producto()
        {
            this.idProducto = new int();
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.imagen = string.Empty;
        }
    }
}
