using cle_spring_2021_courses.Models;
using cle_spring_2021_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            // TODO: retrieve list of instructors with PopulateAllInstructors()
            var instructors = courseRepo.PopulateInstructorList();

            // TODO: set ViewBag.Instructors to a SelectList, mapping on {Id, Name}
            ViewBag.Instructors = new SelectList(instructors, "Id", "Name");

            return View(new Course());
        }

        [HttpPost]
        public ViewResult Create(Course model)
        {
            // TODO: populate ViewBag.Instructors with PopulateAllInstructors()
            var instructors = courseRepo.PopulateInstructorList();

            // TODO: set ViewBag.Instructors to a SelectList, mapping on {Id, Name}
            ViewBag.Instructors = new SelectList(instructors, "Id", "Name");

            courseRepo.Create(model);

            ViewBag.Result = "You have successfully saved this course.";

            return View(model);
        }

        public ViewResult HTMLFormExample()
        {
            // return the View without a model
            return View();
        }

        public ViewResult Update(int id)
        {
            // TODO: populate ViewBag.Instructors with PopulateAllInstructors()
            var instructors = courseRepo.PopulateInstructorList();

            // TODO: set ViewBag.Instructors to a SelectList, mapping on {Id, Name}
            ViewBag.Instructors = new SelectList(instructors, "Id", "Name");

            var course = courseRepo.GetById(id);

            return View(course);
        }

        [HttpPost]
        public ViewResult Update(Course model)
        {

            // TODO: populate ViewBag.Instructors with PopulateAllInstructors()
            var instructors = courseRepo.PopulateInstructorList();

            // TODO: set ViewBag.Instructors to a SelectList, mapping on {Id, Name}
            ViewBag.Instructors = new SelectList(instructors, "Id", "Name");

            courseRepo.Update(model);

            ViewBag.Result = "You have successfully updated this course.";

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var course = courseRepo.GetById(id);

            courseRepo.Delete(course);

            return RedirectToAction("Index");
        }
    }
}
