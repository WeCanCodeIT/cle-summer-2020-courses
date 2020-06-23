using cle_summer_2020_courses.Models;
using cle_summer_2020_courses.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace cle_summer_2020_courses.Tests
{
    public class CourseRepositoryTests : IDisposable
    {
        private UniversityContext db;
        private CourseRepository underTest;

        public CourseRepositoryTests()
        {
            db = new UniversityContext();
            db.Database.BeginTransaction();

            underTest = new CourseRepository(db);
        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Create_Increases_Count_of_Courses()
        {
            var startCount = db.Courses.Count();

            underTest.Create(new Course()
            {
                Name = "new Course", 
                Description = "new Description", 
                InstructorId = 1
            });
            var endCount = db.Courses.Count();

            Assert.Equal(startCount + 1, endCount);
        }
    }
}
