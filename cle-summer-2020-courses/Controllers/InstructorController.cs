using cle_summer_2020_courses.Models;
using cle_summer_2020_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Controllers
{
    public class InstructorController : Controller
    {
        IRepository<Instructor> instructorRepo;

        public InstructorController(IRepository<Instructor> instructorRepo)
        {
            this.instructorRepo = instructorRepo;
        }

        public ViewResult Index()
        {
            var model = instructorRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = instructorRepo.GetById(id);
            return View(model);
        }


    }
}
