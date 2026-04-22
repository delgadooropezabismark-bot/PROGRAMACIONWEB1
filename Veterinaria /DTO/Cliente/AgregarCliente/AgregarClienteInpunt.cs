namespace VeterinariaAPI.DTO.Cliente.AgregarCliente
{
    public class AgregarClienteInput
    {
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }
    }
}
