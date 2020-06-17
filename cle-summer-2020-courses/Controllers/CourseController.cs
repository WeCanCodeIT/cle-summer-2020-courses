using cle_summer_2020_courses.Models;
using cle_summer_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Controllers
{
    public class CourseController : Controller
    {
        IRepository<Course> courseRepo;

        public CourseController(IRepository<Course> courseRepo)
        {
            this.courseRepo = courseRepo;
        }
        public ViewResult Index()
        {

            var model = courseRepo.GetAll();

            return View(model);

        }
        public ViewResult Details(int id)
        {

            var model = courseRepo.GetById(id);

            return View(model);
        }
    }
}
