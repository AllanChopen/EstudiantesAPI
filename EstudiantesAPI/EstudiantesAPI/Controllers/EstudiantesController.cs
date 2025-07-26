using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EstudiantesAPI.Data;
using EstudiantesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudiantesAPI.Controllers
{
    /// <summary>
    /// Controlador para gestionar operaciones relacionadas con estudiantes.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly EstudiantesContext _context;

        /// <summary>
        /// Constructor que recibe el contexto de base de datos.
        /// </summary>
        /// <param name="context">Contexto de base de datos.</param>
        public EstudiantesController(EstudiantesContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Crea un nuevo estudiante.
        /// </summary>
        /// <param name="estudiante">Datos del estudiante a crear.</param>
        /// <returns>Estudiante creado y la ubicación del recurso.</returns>
        /// <response code="201">Estudiante creado exitosamente.</response>
        /// <response code="400">Datos del estudiante inválidos o nulos.</response>
        [HttpPost]
        [ProducesResponseType(typeof(Estudiantes), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateEstudiante([FromBody] Estudiantes estudiante)
        {
            if (estudiante == null)
            {
                return BadRequest("Estudiante no puede ser nulo.");
            }

            _context.Estudiantes.Add(estudiante);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEstudiante), new { carnet = estudiante.CARNET }, estudiante);
        }

        /// <summary>
        /// Obtiene un estudiante por su número de carnet.
        /// </summary>
        /// <param name="carnet">Carnet del estudiante a buscar.</param>
        /// <returns>El estudiante correspondiente si existe.</returns>
        /// <response code="200">Estudiante encontrado.</response>
        /// <response code="404">No se encontró un estudiante con ese carnet.</response>
        [HttpGet("{carnet}")]
        [ProducesResponseType(typeof(Estudiantes), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Estudiantes>> GetEstudiante(int carnet)
        {
            var estudiante = await _context.Estudiantes.FindAsync(carnet);

            if (estudiante == null)
            {
                return NotFound();
            }

            return estudiante;
        }
    }
}

