using System.ComponentModel.DataAnnotations.Schema;

namespace Institute_Management.Model
{
    public class Certificate
    {
        public int ID  { get; set; }
        //public int CourseID { get; set; }
        //[ForeignKey("CourseID")]
        //public Course? Course { get; set; }
        //public int StudentID { get; set; }
        //[ForeignKey("StudentID")]
        //public Student? student { get; set; }

        public int GeadeID { get; set; }
        [ForeignKey("GeadeID")]
        public Geade? geade { get; set; }
        //public int RegistretionID { get; set; }
        //[ForeignKey("RegistretionID")]
        //public Registretion? registretion { get; set; }


    }
}
