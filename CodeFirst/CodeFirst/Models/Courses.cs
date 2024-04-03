using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Courses
    {
        [Key]
        public Guid CoursesId { get; set; }
        public string? CoursesName { get; set; }
        public string? Description { get; set; }
        public List<StudentCourses> StudentCourses { get; set; }
    }
}
