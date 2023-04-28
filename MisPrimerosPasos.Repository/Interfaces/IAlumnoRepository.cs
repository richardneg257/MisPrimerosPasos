using MisPrimerosPasos.Entity;

namespace MisPrimerosPasos.Repository.Interfaces;
public interface IAlumnoRepository
{
    Task<List<Alumno>> ListarAlumnos();
    Task<Alumno> ObtenerAlumno(int id);
    Task InsertarAlumno(Alumno alumno);
    Task EliminarAlumno(Alumno alumno);
}
