using MisPrimerosPasos.Entity;

namespace MisPrimerosPasos.Application.Interfaces;
public interface IAlumnoApplication
{
    Task<List<Alumno>> ListarAlumnos();
}
