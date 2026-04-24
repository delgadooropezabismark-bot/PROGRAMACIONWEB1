namespace VeterinariaAPI.DTO.Venta.AgregarVenta
{
    public class AgregarVentaOutput
    {
        public int VentaId { get; set; }

        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }

        public required decimal Total { get; set; }

        public required string MetodoPago { get; set; }
    }
}
