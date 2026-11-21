namespace Salam_Database.Models
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public decimal Capacidad { get; set; }
        public string UnidadCapacidad { get; set; }
        public int Estado { get; set; }

        public string InfoParcial { get; set; }
    }
}