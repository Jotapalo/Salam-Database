namespace Salam_Database.Models
{
    public class PresentationDTO
    {
        public int IdPresentacion { get; set; }
        public string ProductoNombre { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int CantidadUnidades { get; set; }
        public float Costo { get; set; }
        public float Precio { get; set; }
    }
}