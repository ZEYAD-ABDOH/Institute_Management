using Institute_Management.Data;
using Institute_Management.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Institute_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : Controller
    {
        private readonly My_db_InMa _context;
        public InfoController(My_db_InMa db_context)
        {
            _context = db_context;
        }
        [HttpGet] 
        public async Task <IActionResult> GetInfoStudent()
    {
            var response = await _context.Students.Join
                
                (



                 _context.attendances,
                 Students => Students.ID,
                Attendance => Attendance.ID,
                (Students, Attendance) 
                => new
                       {
                    studentName= Students.NameFull,
                    StartAttendanceDate = Attendance.StartAttendanceDate,
                    EndAttendanceDate = Attendance.EndAttendanceDate,
                    EmailOfStudents=Students.Email,
                    




                }
                ).ToListAsync();




                return Ok(response);

                
        }
    }
}
