using System.ComponentModel.DataAnnotations;

namespace EstudiantesAPI.Models
{
    /// <summary>
    /// Representa un estudiante dentro del sistema académico.
    /// </summary>
    public class Estudiantes
    {
        /// <summary>
        /// Carnet único del estudiante. Actúa como clave primaria.
        /// </summary>
        [Key]
        public int CARNET { get; set; }

        /// <summary>
        /// Nombre del estudiante.
        /// </summary>
        public string NOMBRE { get; set; }

        /// <summary>
        /// Apellido del estudiante.
        /// </summary>
        public string APELLIDO { get; set; }

        /// <summary>
        /// Semestre que actualmente cursa el estudiante.
        /// </summary>
        public int SEMESTRE { get; set; }
    }
}
