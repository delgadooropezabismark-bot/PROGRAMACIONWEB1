namespace VeterinariaAPI.Models
{
    public class Venta
    {
        public int VentaId { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Total { get; set; }

        public required string FormaDePago { get; set; } // Efectivo, QR, Tarjeta

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
