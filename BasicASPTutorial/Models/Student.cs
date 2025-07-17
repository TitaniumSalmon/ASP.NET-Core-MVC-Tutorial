using System.ComponentModel.DataAnnotations;

namespace BasicASPTutorial.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100.")]
        public int Score { get; set; }
    }
}
