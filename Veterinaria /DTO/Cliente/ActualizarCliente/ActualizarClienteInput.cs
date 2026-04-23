namespace VeterinariaAPI.DTO.Cliente.ActualizarCliente
{
    public class ActualizarClienteInput
    {
        public int ClienteId { get; set; }

        public required string Nombre { get; set; }

        public required string Telefono { get; set; }

        public required string Direccion { get; set; }

        public string? Email { get; set; }
    }
}
