using Microsoft.EntityFrameworkCore;
using MisPrimerosPasos.Entity;

namespace MisPrimerosPasos.Repository;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Alumno> Alumnos { get; set; }
}
