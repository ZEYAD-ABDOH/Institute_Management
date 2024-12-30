using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Institute_Management.Model
{
    public class Geade
    {
        public int ID { get; set; }
        public int Rating { get; set; }
        //تقدير
        public DateTime GeadeDate { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(250, MinimumLength = 5)]
        public string level { get; set; }
        //public int CourseID { get; set; }
        //[ForeignKey("CourseID")]
        //public Course? Course { get; set; }
        //public int StudentID { get; set; }
        //[ForeignKey("StudentID")]
        //public Student? student { get; set; }
        public int ExamID { get; set; }
        [ForeignKey("ExamID")]
        public Exam? exam { get; set; }

        //public int InstructorID { get; set; }
        //[ForeignKey("InstructorID")]
        //public Instructor? instructor { get; set; }

        //public int RegistretionID { get; set; }
        //[ForeignKey("RegistretionID")]
        //public Registretion? registretion { get; set; }


    }
}
