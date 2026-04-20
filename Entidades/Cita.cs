namespace VeterinariaAPI.Models
{
    public class Cita
    {
        public int CitaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public int MascotaId { get; set; }
        public Mascota? Mascota { get; set; }

        public int VeterinarioId { get; set; }
        public Veterinario? Veterinario { get; set; }

        public Consulta? Consulta { get; set; }
    }
}
