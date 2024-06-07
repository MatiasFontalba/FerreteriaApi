namespace FerreteriaAPI.Models
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }

        public Producto()
        {
            this.idProducto = new int();
            this.nombre = string.Empty;
            this.precio = new int();
            this.stock = new int();
            this.descripcion = string.Empty;
            this.imagen = string.Empty;
        }
    }
}
