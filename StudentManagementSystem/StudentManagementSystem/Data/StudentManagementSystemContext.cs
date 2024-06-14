using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data
{
    public class StudentManagementSystemContext : DbContext
    {
        public StudentManagementSystemContext(DbContextOptions<StudentManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManagementSystem.Models.Student> Student { get; set; } = default!;

        public DbSet<StudentManagementSystem.Models.Course>? Course { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Math-Physical" },
                new Course { Id = 1, Name = "Math-IT" },
                new Course { Id = 1, Name = "Bio-Chemical" },
                new Course { Id = 1, Name = "Art-Geographical" },
                new Course { Id = 1, Name = "Art-Humanities" }
                );
        }
    }
}
