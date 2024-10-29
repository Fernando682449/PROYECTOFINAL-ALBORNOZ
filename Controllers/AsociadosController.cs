using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practica_4_albornoz.Data;
using practica_4_albornoz.Modelo;

namespace practica_4_albornoz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsociadosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AsociadosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Asociados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asociados>>> GetAsociados()
        {
            return await _context.Asociados.ToListAsync();
        }

        // GET: api/Asociados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asociados>> GetAsociado(int id)
        {
            var asociado = await _context.Asociados.FindAsync(id);

            if (asociado == null)
            {
                return NotFound();
            }

            return asociado;
        }

        // POST: api/Asociados
        [HttpPost]
        public async Task<ActionResult<Asociados>> PostAsociado(Asociados asociado)
        {
            _context.Asociados.Add(asociado);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAsociado), new { id = asociado.ID_ASOCIADO }, asociado);
        }

        // PUT: api/Asociados/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsociado(int id, Asociados asociado)
        {
            if (id != asociado.ID_ASOCIADO)
            {
                return BadRequest();
            }

            _context.Entry(asociado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsociadoExists(id))
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

        // DELETE: api/Asociados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsociado(int id)
        {
            var asociado = await _context.Asociados.FindAsync(id);
            if (asociado == null)
            {
                return NotFound();
            }

            _context.Asociados.Remove(asociado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AsociadoExists(int id)
        {
            return _context.Asociados.Any(e => e.ID_ASOCIADO == id);
        }
    }
}
