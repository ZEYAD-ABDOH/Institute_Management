using System.ComponentModel.DataAnnotations;

namespace Client.Model
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string NameFull { get; set; }
        public int Phone { get; set; }
        public DateTime Date_B { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string Geneder { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string Email { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string Address { get; set; }


    }
}
