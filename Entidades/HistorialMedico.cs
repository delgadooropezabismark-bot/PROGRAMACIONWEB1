namespace VeterinariaAPI.Models
{
    public class HistorialMedico
    {
        public int HistorialMedicoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public int MascotaId { get; set; }
        public Mascota? Mascota { get; set; }
    }
}
