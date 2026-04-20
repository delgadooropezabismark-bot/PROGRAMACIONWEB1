namespace VeterinariaAPI.Models
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public ICollection<Cita>? Citas { get; set; }
        public ICollection<HistorialMedico>? Historiales { get; set; }
    }
}
