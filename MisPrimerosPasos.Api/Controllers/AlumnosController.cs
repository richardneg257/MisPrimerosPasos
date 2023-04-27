using Microsoft.AspNetCore.Mvc;
using MisPrimerosPasos.Application.Interfaces;
using MisPrimerosPasos.Entity;

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

    [HttpGet]
    public async Task<ActionResult<List<Alumno>>> ListarAlumnos()
    {
        var alumnos = await _alumnoApplication.ListarAlumnos();
        return alumnos;
    }
}
