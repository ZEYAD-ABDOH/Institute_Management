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
    public class MeterialsController : ControllerBase
    {
        private readonly My_db_InMa _context;

        public MeterialsController(My_db_InMa context)
        {
            _context = context;
        }

        // GET: api/Meterials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meterial>>> GetMeterials()
        {
            return await _context.Meterials.ToListAsync();
        }

        // GET: api/Meterials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meterial>> GetMeterial(int id)
        {
            var meterial = await _context.Meterials.FindAsync(id);

            if (meterial == null)
            {
                return NotFound();
            }

            return meterial;
        }

        // PUT: api/Meterials/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeterial(int id, Meterial meterial)
        {
            if (id != meterial.ID)
            {
                return BadRequest();
            }

            _context.Entry(meterial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeterialExists(id))
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

        // POST: api/Meterials
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Meterial>> PostMeterial(Meterial meterial)
        {
            _context.Meterials.Add(meterial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeterial", new { id = meterial.ID }, meterial);
        }

        // DELETE: api/Meterials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeterial(int id)
        {
            var meterial = await _context.Meterials.FindAsync(id);
            if (meterial == null)
            {
                return NotFound();
            }

            _context.Meterials.Remove(meterial);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MeterialExists(int id)
        {
            return _context.Meterials.Any(e => e.ID == id);
        }
    }
}
