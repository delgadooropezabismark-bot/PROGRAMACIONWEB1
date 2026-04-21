namespace VeterinariaAPI.Models
{
    public class Consulta
    {
        public int ConsultaId { get; set; }

        public string Diagnostico { get; set; }
        public string Observaciones { get; set; }

        public int CitaId { get; set; }
        public Cita? Cita { get; set; }

        public ICollection<Tratamiento>? Tratamientos { get; set; }
    }
}
