namespace VeterinariaAPI.Models
{
    public class Tratamiento
    {
        public int TratamientoId { get; set; }

        public required string Medicamento { get; set; }
        public required string Dosis { get; set; }
        public required string Indicaciones { get; set; }

        public int ConsultaId { get; set; }
        public Consulta? Consulta { get; set; }
      
    }
}
