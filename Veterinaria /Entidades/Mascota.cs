namespace VeterinariaAPI.Models
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        public required string Nombre { get; set; }
        public required string Especie { get; set; }
        public required string Raza { get; set; }
        public int Edad { get; set; }

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public ICollection<Cita>? Citas { get; set; }
        public ICollection<HistorialMedico>? Historiales { get; set; }
    }
}
