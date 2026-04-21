namespace VeterinariaAPI.Models
{
    public class Veterinario
    {
        public int VeterinarioId { get; set; }
        public required string  Nombre { get; set; }
        public required string Especialidad { get; set; }
        public required string Telefono { get; set; }

        public ICollection<Cita>? Citas { get; set; }
    }
}
