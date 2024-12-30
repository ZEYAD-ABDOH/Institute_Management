using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Institute_Management.Data;
using Institute_Management.Model;

namespace Institute_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeadesController : ControllerBase
    {
        private readonly My_db_InMa _context;

        public GeadesController(My_db_InMa context)
        {
            _context = context;
        }

        // GET: api/Geades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Geade>>> GetGeade()
        {
            return await _context.Geade.ToListAsync();
        }

        // GET: api/Geades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Geade>> GetGeade(int id)
        {
            var geade = await _context.Geade.FindAsync(id);

            if (geade == null)
            {
                return NotFound();
            }

            return geade;
        }

        // PUT: api/Geades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeade(int id, Geade geade)
        {
            if (id != geade.ID)
            {
                return BadRequest();
            }

            _context.Entry(geade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeadeExists(id))
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

        // POST: api/Geades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Geade>> PostGeade(Geade geade)
        {
            _context.Geade.Add(geade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGeade", new { id = geade.ID }, geade);
        }

        // DELETE: api/Geades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGeade(int id)
        {
            var geade = await _context.Geade.FindAsync(id);
            if (geade == null)
            {
                return NotFound();
            }

            _context.Geade.Remove(geade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GeadeExists(int id)
        {
            return _context.Geade.Any(e => e.ID == id);
        }
    }
}
