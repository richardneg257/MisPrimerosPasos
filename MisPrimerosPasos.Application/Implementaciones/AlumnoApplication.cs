using MisPrimerosPasos.Application.Interfaces;
using MisPrimerosPasos.Entity;
using MisPrimerosPasos.Repository.Interfaces;

namespace MisPrimerosPasos.Application.Implementaciones;
public class AlumnoApplication : IAlumnoApplication
{
    private readonly IAlumnoRepository _alumnoRepository;

    public AlumnoApplication(IAlumnoRepository alumnoRepository)
    {
        _alumnoRepository = alumnoRepository;
    }

    public async Task<List<Alumno>> ListarAlumnos()
    {
        var alumnos = await _alumnoRepository.ListarAlumnos();
        return alumnos;
    }
}
