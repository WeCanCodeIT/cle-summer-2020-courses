using cle_summer_2020_courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses
{
    public class UniversityContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=UniversityDB_062020;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    Id = 1,
                    Name = "Machine Learning",
                    Description = "Machine learning for humans",
                    InstructorId = 1
                },

                new Course()
                {
                    Id = 2,
                    Name = "C# for Smarties",
                    Description = "It's all you need to learn it all",
                    InstructorId = 2
                },

                new Course()
                {
                    Id = 3,
                    Name = "HTML, CSS, JS, oh my!",
                    Description = "OMG, the front end will become your BFF",
                    InstructorId = 2
                });

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    Name = "Jen"
                },

                new Instructor()
                {
                    Id = 2,
                    Name = "Andy"
                });

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Name = "Ferris Bueller"
                },

               new Student()
               {
                   Id = 2,
                   Name = "Cameron Frye"
               },

               new Student()
               {
                   Id = 3,
                   Name = "Sloane Peterson"
               });

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse()
                {
                    Id = 1,
                    CourseId = 1,
                    StudentId = 1
                },

                new StudentCourse()
                {
                    Id = 2,
                    CourseId = 1,
                    StudentId = 2
                },

                new StudentCourse()
                {
                    Id = 3,
                    CourseId = 2,
                    StudentId = 2
                },

                new StudentCourse()
                {
                    Id = 4,
                    CourseId = 2,
                    StudentId = 3
                },

                new StudentCourse()
                {
                    Id = 5,
                    CourseId = 3,
                    StudentId = 1
                },

                new StudentCourse()
                {
                    Id = 6,
                    CourseId = 3,
                    StudentId = 3
                });

            base.OnModelCreating(modelBuilder);
        }


    }
}
