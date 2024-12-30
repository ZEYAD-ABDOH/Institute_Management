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
    public class RegistretionsController : ControllerBase
    {
        private readonly My_db_InMa _context;

        public RegistretionsController(My_db_InMa context)
        {
            _context = context;
        }

        // GET: api/Registretions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registretion>>> Getregistretions()
        {
            return await _context.registretions.ToListAsync();
        }

        // GET: api/Registretions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Registretion>> GetRegistretion(int id)
        {
            var registretion = await _context.registretions.FindAsync(id);

            if (registretion == null)
            {
                return NotFound();
            }

            return registretion;
        }

        // PUT: api/Registretions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegistretion(int id, Registretion registretion)
        {
            if (id != registretion.ID)
            {
                return BadRequest();
            }

            _context.Entry(registretion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistretionExists(id))
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

        // POST: api/Registretions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Registretion>> PostRegistretion(Registretion registretion)
        {
            _context.registretions.Add(registretion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegistretion", new { id = registretion.ID }, registretion);
        }

        // DELETE: api/Registretions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegistretion(int id)
        {
            var registretion = await _context.registretions.FindAsync(id);
            if (registretion == null)
            {
                return NotFound();
            }

            _context.registretions.Remove(registretion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegistretionExists(int id)
        {
            return _context.registretions.Any(e => e.ID == id);
        }
    }
}
