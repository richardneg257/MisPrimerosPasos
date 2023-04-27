namespace MisPrimerosPasos.Application.Dtos;
public class AlumnoDetalleDto
{
    public int Id { get; set; }
    public string Dni { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool Sexo { get; set; }
}
