using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class StudentCourses
    {
        public Guid StudentId { get; set; }
        public Students Students { get; set; }
        public Guid CoursesId { get; set; }
        public Courses Courses { get; set; }
    }
}
