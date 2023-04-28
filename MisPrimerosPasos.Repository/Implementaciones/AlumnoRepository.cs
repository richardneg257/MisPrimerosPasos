using Microsoft.EntityFrameworkCore;
using MisPrimerosPasos.Entity;
using MisPrimerosPasos.Repository.Interfaces;

namespace MisPrimerosPasos.Repository.Implementaciones;
public class AlumnoRepository : IAlumnoRepository
{
    private readonly ApplicationDbContext _context;

    public AlumnoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Alumno>> ListarAlumnos()
    {
        var alumnos = await _context.Alumnos.ToListAsync();
        return alumnos;
    }

    public async Task<Alumno> ObtenerAlumno(int id)
    {
        var alumno = await _context.Alumnos.FirstOrDefaultAsync(al => al.Id == id);
        return alumno;
    }

    public async Task InsertarAlumno(Alumno alumno)
    {
        _context.Alumnos.Add(alumno);
        await _context.SaveChangesAsync();
    }

    public async Task EliminarAlumno(Alumno alumno)
    {
        _context.Alumnos.Remove(alumno);
        await _context.SaveChangesAsync();
    }

    public async Task ActualizarAlumno(Alumno alumno)
    {
        _context.Alumnos.Update(alumno);
        await _context.SaveChangesAsync();
    }
}
