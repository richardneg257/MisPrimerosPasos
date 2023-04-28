using AutoMapper;
using MisPrimerosPasos.Application.Dtos;
using MisPrimerosPasos.Application.Interfaces;
using MisPrimerosPasos.Entity;
using MisPrimerosPasos.Repository.Interfaces;

namespace MisPrimerosPasos.Application.Implementaciones;
public class AlumnoApplication : IAlumnoApplication
{
    private readonly IAlumnoRepository _alumnoRepository;
    private readonly IMapper _mapper;

    public AlumnoApplication(IAlumnoRepository alumnoRepository, IMapper mapper)
    {
        _alumnoRepository = alumnoRepository;
        _mapper = mapper;
    }

    public async Task<List<AlumnoDto>> ListarAlumnos()
    {
        var alumnos = await _alumnoRepository.ListarAlumnos();

        var alumnosDto = _mapper.Map<List<AlumnoDto>>(alumnos);

        return alumnosDto;
    }

    public async Task<AlumnoDetalleDto> ObtenerAlumno(int id)
    {
        var alumno = await _alumnoRepository.ObtenerAlumno(id);

        var alumnoDetalleDto = _mapper.Map<AlumnoDetalleDto>(alumno);

        return alumnoDetalleDto;
    }

    public async Task InsertarAlumno(AlumnoCreacionDto alumnoCreacion)
    {
        var alumno = _mapper.Map<Alumno>(alumnoCreacion);
        await _alumnoRepository.InsertarAlumno(alumno);
    }

    public async Task EliminarAlumno(int id)
    {
        var alumno = await _alumnoRepository.ObtenerAlumno(id);
        await _alumnoRepository.EliminarAlumno(alumno);
    }
}
