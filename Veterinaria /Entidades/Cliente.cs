namespace VeterinariaAPI.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; } 

        public ICollection<Mascota>? Mascotas { get; set; }
    }
}
