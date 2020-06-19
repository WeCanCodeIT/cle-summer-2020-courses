using cle_summer_2020_courses.Controllers;
using cle_summer_2020_courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using NSubstitute;
using cle_summer_2020_courses.Repositories;
using System.Collections.Generic;

namespace cle_summer_2020_courses.Tests
{
    public class CourseControllerTests
    {
        CourseController underTest;
        IRepository<Course> courseRepo;

        public CourseControllerTests()
        {
            courseRepo = Substitute.For<IRepository<Course>>();
            underTest = new CourseController(courseRepo);
        }
        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Courses_To_View()
        {
            // Arrange
            var expectedCourses = new List<Course>();
            courseRepo.GetAll().Returns(expectedCourses);
            
            var result = underTest.Index();

            Assert.Equal(expectedCourses, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);
            
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            // Arrange with Mocking and NSubstitute
            var expectedCourse = new Course();
            courseRepo.GetById(1).Returns(expectedCourse);

            var result = underTest.Details(1);
            
            Assert.Equal(expectedCourse, result.Model);
        }

    }
}
