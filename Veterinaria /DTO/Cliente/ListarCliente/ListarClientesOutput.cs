namespace VeterinariaAPI.DTO.Cliente.ListarClientes
{
    public class ListarClientesOutput
    {
        public int ClienteId { get; set; }
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
    }
}
