using MisPrimerosPasos.Application.Dtos;

namespace MisPrimerosPasos.Application.Interfaces;
public interface IAlumnoApplication
{
    Task<List<AlumnoDto>> ListarAlumnos();
    Task<AlumnoDetalleDto> ObtenerAlumno(int id);
}
