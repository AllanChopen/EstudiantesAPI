using Microsoft.EntityFrameworkCore;
using EstudiantesAPI.Models;

namespace EstudiantesAPI.Data
{
    public class EstudiantesContext : DbContext
    {
        public EstudiantesContext(DbContextOptions<EstudiantesContext> options)
            : base(options)
        {
        }
        public DbSet<Estudiantes> Estudiantes { get; set; }
    }
}