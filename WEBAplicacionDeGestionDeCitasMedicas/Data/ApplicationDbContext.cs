using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WEBAplicacionDeGestionDeCitasMedicas.Models;

namespace WEBAplicacionDeGestionDeCitasMedicas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WEBAplicacionDeGestionDeCitasMedicas.Models.CitaMedica> CitaMedica { get; set; } = default!;
        public DbSet<WEBAplicacionDeGestionDeCitasMedicas.Models.HistorialMedico> HistorialMedico { get; set; } = default!;
        public DbSet<WEBAplicacionDeGestionDeCitasMedicas.Models.Medico> Medico { get; set; } = default!;
        public DbSet<WEBAplicacionDeGestionDeCitasMedicas.Models.Paciente> Paciente { get; set; } = default!;
        public DbSet<WEBAplicacionDeGestionDeCitasMedicas.Models.Reporte> Reporte { get; set; } = default!;
        public DbSet<WEBAplicacionDeGestionDeCitasMedicas.Models.Tratamiento> Tratamiento { get; set; } = default!;
    }
}
