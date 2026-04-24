namespace VeterinariaAPI.DTO.Venta.ListarVenta
{
    public class ListarVentaOutput
    {
        public int VentaId { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Total { get; set; }

        public required string MetodoPago { get; set; }

        public required string NombreCliente { get; set; }
    }
}
