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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=UniversityDB_062019;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);

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
                },

                new Course()
                {
                    Id = 2,
                    Name = "C# for Smarties",
                    Description = "It's all you need to learn it all",
                },

                new Course()
                {
                    Id = 3,
                    Name = "HTML, CSS, JS, oh my!",
                    Description = "OMG, the front end will become your BFF",
                });

            base.OnModelCreating(modelBuilder);
        }


    }
}
