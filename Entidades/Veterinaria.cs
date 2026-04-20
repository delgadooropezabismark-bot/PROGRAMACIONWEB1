namespace VeterinariaAPI.Models
{
    public class Veterinario
    {
        public int VeterinarioId { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }

        public ICollection<Cita>? Citas { get; set; }
    }
}
