using System.ComponentModel.DataAnnotations;

namespace Client.Model
{
    public class Schedule
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string NameCourse { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string NameClassroom { get; set; }
        public DateTime Start_D { get; set; }
        public DateTime End_D { get; set; }
        public bool Is_Available { get; set; }

        //public void Check()
        //{
        //    var check_Available = (!Is_Available) ? "Is_Available" : "Is Not Available";
        //    Console.WriteLine(check_Available);
        //}
    }
}
