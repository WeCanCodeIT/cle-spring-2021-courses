using cle_spring_2021_courses.Models;
using cle_spring_2021_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Controllers
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
            var courseList = courseRepo.GetAll();
            
            return View(courseList);
        }

        public ViewResult Details(int id)
        {
            var course = courseRepo.GetById(id);

            return View(course);
        }

        public ViewResult Create()
        {
            return View(new Course());
        }

        [HttpPost]
        public ViewResult Create(Course model)
        {
            
            model.InstructorId = 2;

            courseRepo.Create(model);

            ViewBag.Result = "You have successfully saved your course.";

            return View(model);
        }
    }
}
