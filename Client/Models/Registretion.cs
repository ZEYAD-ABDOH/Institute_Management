using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Client.Model
{
    public class Registretion
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(100, MinimumLength = 10)]
        
        public string FullName { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(100, MinimumLength = 10)]
        public string Email { get; set; }

        

        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string Geneder { get; set; }

        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course? Course { get; set; }
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student? student { get; set; }




    }
}
