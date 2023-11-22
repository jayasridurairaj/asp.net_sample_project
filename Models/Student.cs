using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ? Name { get; set; }
        public string Address { get; set; } = null!;

        public int PhoneNo { get; set; }
    }
}
