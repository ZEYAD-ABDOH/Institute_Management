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
    public class ExamsController : ControllerBase
    {
        private readonly My_db_InMa _context;

        public ExamsController(My_db_InMa context)
        {
            _context = context;
        }

        // GET: api/Exams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exam>>> Getexams()
        {
            return await _context.exams.ToListAsync();
        }

        // GET: api/Exams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exam>> GetExam(int id)
        {
            var exam = await _context.exams.FindAsync(id);

            if (exam == null)
            {
                return NotFound();
            }

            return exam;
        }

        // PUT: api/Exams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExam(int id, Exam exam)
        {
            if (id != exam.ID)
            {
                return BadRequest();
            }

            _context.Entry(exam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExamExists(id))
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

        // POST: api/Exams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Exam>> PostExam(Exam exam)
        {
            _context.exams.Add(exam);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExam", new { id = exam.ID }, exam);
        }

        // DELETE: api/Exams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExam(int id)
        {
            var exam = await _context.exams.FindAsync(id);
            if (exam == null)
            {
                return NotFound();
            }

            _context.exams.Remove(exam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExamExists(int id)
        {
            return _context.exams.Any(e => e.ID == id);
        }
    }
}
