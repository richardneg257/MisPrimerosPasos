using MisPrimerosPasos.Entity;

namespace MisPrimerosPasos.Repository.Interfaces;
public interface IAlumnoRepository
{
    Task<List<Alumno>> ListarAlumnos();
}
