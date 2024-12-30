using System.ComponentModel.DataAnnotations.Schema;

namespace Client.Model
{
    public class Exam
    {
        public int ID { get; set; }

        
        public DateTime period { get; set; }
        public DateTime TextDay { get; set; }

        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course? Course { get; set; } 
        public int ClassroomID { get; set; }
        [ForeignKey("ClassroomID")]
        public Classroom? classroom { get; set; }

        public int InstructorID { get; set; }
        [ForeignKey("InstructorID")]
        public Instructor? instructor { get; set; }

        public int AttendanceID { get; set; }
        [ForeignKey("AttendanceID ")]
        public Attendance? attendance { get; set; }

        public int RegistretionID { get; set; }
        [ForeignKey("RegistretionID")]
        public Registretion? registretion { get; set; }

    }
}
