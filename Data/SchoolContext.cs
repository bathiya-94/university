using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace university.Data
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Course> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;database=university;uid=root;pwd=root;");
        }
    }

}
