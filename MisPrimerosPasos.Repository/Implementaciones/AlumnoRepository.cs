﻿using Microsoft.EntityFrameworkCore;
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
}
