using System.ComponentModel.DataAnnotations.Schema;

namespace Client.Model
{
    public class Attendance
    {
        public int ID { get; set; }
        public DateTime StartAttendanceDate { get; set; }
        public DateTime EndAttendanceDate { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course? Course { get; set; }
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student? student { get; set; }
        public int ClassroomID { get; set; }
        [ForeignKey("ClassroomID")]
        public Classroom? classroom { get; set; } 
        public int InstructorID { get; set; }
        [ForeignKey("InstructorID")]
        public Instructor? instructor { get; set; }

    }
}
