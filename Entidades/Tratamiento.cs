namespace VeterinariaAPI.Models
{
    public class Tratamiento
    {
        public int TratamientoId { get; set; }

        public string Medicamento { get; set; }
        public string Dosis { get; set; }
        public string Indicaciones { get; set; }

        public int ConsultaId { get; set; }
        public Consulta? Consulta { get; set; }
    }
}
