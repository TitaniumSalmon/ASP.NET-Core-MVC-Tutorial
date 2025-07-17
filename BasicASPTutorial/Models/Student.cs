using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicASPTutorial.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อนักเรียน")]
        [DisplayName("ชื่อนักเรียน")]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage = "กรุณาป้อนคะแนนสอบระหว่าง 0 - 100")]
        [DisplayName("คะแนนสอบ")]
        public int Score { get; set; }
    }
}
