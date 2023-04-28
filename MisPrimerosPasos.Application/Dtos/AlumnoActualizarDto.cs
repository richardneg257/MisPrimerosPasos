using System.ComponentModel.DataAnnotations;

namespace MisPrimerosPasos.Application.Dtos;
public class AlumnoActualizarDto
{
    [Required]
    [StringLength(8)]
    public string Dni { get; set; }
    [Required]
    [StringLength(50)]
    public string Nombres { get; set; }
    [Required]
    [StringLength(50)]
    public string Apellidos { get; set; }
    [Required]
    public DateTime FechaNacimiento { get; set; }
    [Required]
    public bool Sexo { get; set; } // 0: Femenino, 1: Masculino
}
