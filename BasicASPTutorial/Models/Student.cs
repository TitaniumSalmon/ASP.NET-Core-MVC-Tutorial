using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicASPTutorial.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Student Name")]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100.")]
        [DisplayName("Student Score")]
        public int Score { get; set; }
    }
}
