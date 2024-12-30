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
    public class CertificatesController : ControllerBase
    {
        private readonly My_db_InMa _context;

        public CertificatesController(My_db_InMa context)
        {
            _context = context;
        }

        // GET: api/Certificates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Certificate>>> Getcertificates()
        {
            return await _context.certificates.ToListAsync();
        }

        // GET: api/Certificates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Certificate>> GetCertificate(int id)
        {
            var certificate = await _context.certificates.FindAsync(id);

            if (certificate == null)
            {
                return NotFound();
            }

            return certificate;
        }

        // PUT: api/Certificates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCertificate(int id, Certificate certificate)
        {
            if (id != certificate.ID)
            {
                return BadRequest();
            }

            _context.Entry(certificate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CertificateExists(id))
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

        // POST: api/Certificates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Certificate>> PostCertificate(Certificate certificate)
        {
            _context.certificates.Add(certificate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCertificate", new { id = certificate.ID }, certificate);
        }

        // DELETE: api/Certificates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCertificate(int id)
        {
            var certificate = await _context.certificates.FindAsync(id);
            if (certificate == null)
            {
                return NotFound();
            }

            _context.certificates.Remove(certificate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CertificateExists(int id)
        {
            return _context.certificates.Any(e => e.ID == id);
        }
    }
}
