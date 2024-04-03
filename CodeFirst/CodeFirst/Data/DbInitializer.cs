using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;
        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;

        }
        public void seed()
        {
            _builder.Entity<Courses>(a =>
            {
                a.HasData(new Courses
                {
                    CoursesId = new Guid("1"),
                    CoursesName = "tu",
                    Description = "tot",
                });
            });
        }
    }
}
