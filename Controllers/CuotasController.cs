using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practica_4_albornoz.Data;
using practica_4_albornoz.Modelo;

namespace practica_4_albornoz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuotasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CuotasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Cuotas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cuotas>>> GetCuotas()
        {
            return await _context.Cuotas.ToListAsync();
        }

        // GET: api/Cuotas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cuotas>> GetCuota(int id)
        {
            var cuota = await _context.Cuotas.FindAsync(id);

            if (cuota == null)
            {
                return NotFound();
            }

            return cuota;
        }

        // POST: api/Cuotas
        [HttpPost]
        public async Task<ActionResult<Cuotas>> PostCuota(Cuotas cuota)
        {
            _context.Cuotas.Add(cuota);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCuota), new { id = cuota.ID_CUOTA }, cuota);
        }

        // PUT: api/Cuotas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuota(int id, Cuotas cuota)
        {
            if (id != cuota.ID_CUOTA)
            {
                return BadRequest();
            }

            _context.Entry(cuota).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuotaExists(id))
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

        // DELETE: api/Cuotas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCuota(int id)
        {
            var cuota = await _context.Cuotas.FindAsync(id);
            if (cuota == null)
            {
                return NotFound();
            }

            _context.Cuotas.Remove(cuota);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CuotaExists(int id)
        {
            return _context.Cuotas.Any(e => e.ID_CUOTA == id);
        }
    }
}
