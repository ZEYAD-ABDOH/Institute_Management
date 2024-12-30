using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Institute_Management.Model
{
    public class Course
    { 
        public int ID { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(50, MinimumLength = 10)]

        public string NameCoures { get; set; }

        public double CostCoures { get; set; }
        public DateTime DateOfCoures { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string Description { get; set; }

        public int InstructorID { get; set; }
        [ForeignKey("InstructorID")]
        public Instructor? instructors { get; set; }

    }
}
