using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practica_4_albornoz.Data;
using practica_4_albornoz.Modelo;

namespace practica_4_albornoz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OfertasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Ofertas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ofertas>>> GetOfertas()
        {
            return await _context.Ofertas.ToListAsync();
        }

        // GET: api/Ofertas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ofertas>> GetOferta(int id)
        {
            var oferta = await _context.Ofertas.FindAsync(id);

            if (oferta == null)
            {
                return NotFound();
            }

            return oferta;
        }

        // POST: api/Ofertas
        [HttpPost]
        public async Task<ActionResult<Ofertas>> PostOferta(Ofertas oferta)
        {
            _context.Ofertas.Add(oferta);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOferta), new { id = oferta.ID_OFERTA }, oferta);
        }

        // PUT: api/Ofertas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOferta(int id, Ofertas oferta)
        {
            if (id != oferta.ID_OFERTA)
            {
                return BadRequest();
            }

            _context.Entry(oferta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfertaExists(id))
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

        // DELETE: api/Ofertas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOferta(int id)
        {
            var oferta = await _context.Ofertas.FindAsync(id);
            if (oferta == null)
            {
                return NotFound();
            }

            _context.Ofertas.Remove(oferta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OfertaExists(int id)
        {
            return _context.Ofertas.Any(e => e.ID_OFERTA == id);
        }
    }
}
