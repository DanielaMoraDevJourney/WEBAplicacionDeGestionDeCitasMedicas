using System.ComponentModel.DataAnnotations;

namespace WEBAplicacionDeGestionDeCitasMedicas.Models
{
    public class HistorialMedico
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Allergy { get; set; }

        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }
    }
}
