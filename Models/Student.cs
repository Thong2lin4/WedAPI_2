using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Student
    {
        [Key]
        public Guid? StudentId { get; set; }
        public string? Name { get; set; }
        public List<StudentCourses>? StudentCourses { get; set; }
    }
}
