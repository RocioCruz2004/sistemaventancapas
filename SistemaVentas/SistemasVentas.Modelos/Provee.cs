namespace SistemasVentas.Modelos
{
    public class Provee
    {
        public int IdProvee { get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
    }
}
