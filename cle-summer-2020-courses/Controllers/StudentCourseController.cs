using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cle_summer_2020_courses.Models;
using cle_summer_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace cle_summer_2020_courses.Controllers
{
    public class StudentCourseController : Controller
    {
        IRepository<StudentCourse> studentCourseRepo;

        public StudentCourseController(IRepository<StudentCourse> studentCourseRepo)
        {
            this.studentCourseRepo = studentCourseRepo;
        }

        [HttpGet]
        public ViewResult CreateByCourseId(int id)
        {
            ViewBag.CourseId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentCourse studentCourse)
        {

            if (!studentCourseRepo.IsStudentAlreadyEnrolled(studentCourse.CourseId, studentCourse.StudentId))
            {
                studentCourseRepo.Create(studentCourse);
            }
            return RedirectToAction("Index", "Course");
        }

    }
}
