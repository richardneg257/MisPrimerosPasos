using AutoMapper;
using MisPrimerosPasos.Application.Dtos;
using MisPrimerosPasos.Entity;

namespace MisPrimerosPasos.Application.Profiles;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Alumno, AlumnoDetalleDto>();
        CreateMap<Alumno, AlumnoDto>();
        CreateMap<AlumnoCreacionDto, Alumno>();
        CreateMap<AlumnoActualizarDto, Alumno>();
    }
}
