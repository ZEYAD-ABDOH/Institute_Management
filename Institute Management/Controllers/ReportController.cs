using Institute_Management.Data;
using Institute_Management.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Institute_Management.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : Controller
    {

        private readonly My_db_InMa _context;

        public ReportController(My_db_InMa _InMa) 
        {
            _context = _InMa;
        }
        [HttpGet]
        public async Task<IActionResult> GetReport()
        {
            var Response = await _context.Geade.Join(

                _context.exams,
                Geade => Geade.ExamID,
                Exam => Exam.ID,

                (Geade, Exam) => new
                {
                    Geade,
                    Exam
                }


                ).Join(

               _context.attendances,
               attendances_Geade => attendances_Geade.Geade.ExamID,
               attendances => attendances.ID,

               (attendances_Geade, attendances) => new
               {
                   studentName = attendances.student.NameFull,
                   CourseName= attendances_Geade.Exam.Course.NameCoures,
                   GeadeStudent= attendances_Geade.Geade.Rating,
                  instructorName=attendances.instructor.NameFull,
                  StartAttendanceDate = attendances.StartAttendanceDate,
                  EndAttendanceDate = attendances. EndAttendanceDate,

               }
                ).ToListAsync();

                




            return Ok(Response);
        }
    }
}
