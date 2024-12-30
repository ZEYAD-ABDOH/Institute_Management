using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Institute_Management.Model
{
    public class Classroom
    {
        public int ID { get; set; }

        [Required (ErrorMessage ="هذا الحقل مطلوب ")]

        [StringLength(30,MinimumLength =5)]

        public string NameClassroom { get; set; }


        
        public int Capacity { get; set; }
       

        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student? student { get; set; }
    }
}
