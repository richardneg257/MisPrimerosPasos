using Microsoft.AspNetCore.Mvc;
using MisPrimerosPasos.Application.Dtos;
using MisPrimerosPasos.Application.Implementaciones;
using MisPrimerosPasos.Application.Interfaces;

namespace MisPrimerosPasos.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AlumnosController : ControllerBase
{
    private readonly IAlumnoApplication _alumnoApplication;

    public AlumnosController(IAlumnoApplication alumnoApplication)
    {
        _alumnoApplication = alumnoApplication;
    }

    [HttpGet] // GET http://localhost/api/alumnos
    public async Task<ActionResult<List<AlumnoDto>>> ListarAlumnos()
    {
        var alumnos = await _alumnoApplication.ListarAlumnos();
        return alumnos;
    }

    [HttpGet("{id}")]  // GET http://localhost/api/alumnos/5
    public async Task<ActionResult<AlumnoDetalleDto>> ObtenerAlumno([FromRoute] int id)
    {
        var alumno = await _alumnoApplication.ObtenerAlumno(id);

        if(alumno == null)
        {
            return NotFound($"Ups! No se encontró el Alumno con ID {id}");
        }

        return alumno;
    }

    [HttpPost]
    public async Task<ActionResult> InsertarAlumno([FromBody] AlumnoCreacionDto alumnoCreacion)
    {
        await _alumnoApplication.InsertarAlumno(alumnoCreacion);

        return Ok();
    }
}

