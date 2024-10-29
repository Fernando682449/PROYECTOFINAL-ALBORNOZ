using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practica_4_albornoz.Data;
using practica_4_albornoz.Modelo;

namespace practica_4_albornoz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsistenciasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AsistenciasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Asistencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asistencias>>> GetAsistencias()
        {
            return await _context.Asistencias.ToListAsync();
        }

        // GET: api/Asistencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asistencias>> GetAsistencia(int id)
        {
            var asistencia = await _context.Asistencias.FindAsync(id);

            if (asistencia == null)
            {
                return NotFound();
            }

            return asistencia;
        }

        // POST: api/Asistencias
        [HttpPost]
        public async Task<ActionResult<Asistencias>> PostAsistencia(Asistencias asistencia)
        {
            _context.Asistencias.Add(asistencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAsistencia), new { id = asistencia.ID_ASISTENCIA }, asistencia);
        }

        // PUT: api/Asistencias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsistencia(int id, Asistencias asistencia)
        {
            if (id != asistencia.ID_ASISTENCIA)
            {
                return BadRequest();
            }

            _context.Entry(asistencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsistenciaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Asistencias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsistencia(int id)
        {
            var asistencia = await _context.Asistencias.FindAsync(id);
            if (asistencia == null)
            {
                return NotFound();
            }

            _context.Asistencias.Remove(asistencia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AsistenciaExists(int id)
        {
            return _context.Asistencias.Any(e => e.ID_ASISTENCIA == id);
        }
    }
}
