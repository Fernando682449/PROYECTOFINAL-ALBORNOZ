using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practica_4_albornoz.Data;
using practica_4_albornoz.Modelo;

namespace practica_4_albornoz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CVController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CV
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CV>>> GetCVs()
        {
            return await _context.CV.ToListAsync();
        }

        // GET: api/CV/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CV>> GetCV(int id)
        {
            var cv = await _context.CV.FindAsync(id);

            if (cv == null)
            {
                return NotFound();
            }

            return cv;
        }

        // POST: api/CV
        [HttpPost]
        public async Task<ActionResult<CV>> PostCV(CV cv)
        {
            _context.CV.Add(cv);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCV), new { id = cv.ID_CV }, cv);
        }

        // PUT: api/CV/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCV(int id, CV cv)
        {
            if (id != cv.ID_CV)
            {
                return BadRequest();
            }

            _context.Entry(cv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CVExists(id))
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

        // DELETE: api/CV/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCV(int id)
        {
            var cv = await _context.CV.FindAsync(id);
            if (cv == null)
            {
                return NotFound();
            }

            _context.CV.Remove(cv);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CVExists(int id)
        {
            return _context.CV.Any(e => e.ID_CV == id);
        }
    }
}
