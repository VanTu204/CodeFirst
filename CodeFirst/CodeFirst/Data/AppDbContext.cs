using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Students> Student { get; set; }
        public DbSet<Courses> Course { get; set; }
        public DbSet<StudentCourses> StudentCourse { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<StudentCourses>()
                .HasKey(sc => new { sc.StudentId, sc.CoursesId });

            builder.Entity<StudentCourses>()
                .HasOne(sc => sc.Students)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);
        }
    }
}
