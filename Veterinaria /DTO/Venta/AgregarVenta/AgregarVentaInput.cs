namespace VeterinariaAPI.DTO.Venta.AgregarVenta
{
    public class AgregarVentaInput
    {
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }

        public required decimal Total { get; set; }

        public required string MetodoPago { get; set; }
    }
}
