using System.ComponentModel.DataAnnotations;

namespace Institute_Management.Model
{
    public class Meterial
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string Name_M { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string Title { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب ")]

        [StringLength(255, MinimumLength = 10)]
        public string Description { get; set; }
    }
}
