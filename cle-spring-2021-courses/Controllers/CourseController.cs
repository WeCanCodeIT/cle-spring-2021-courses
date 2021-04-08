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

        public ViewResult Create(int? instructorId)
        {
            // TODO: retrieve list of instructors with PopulateAllInstructors()
            var instructors = courseRepo.PopulateInstructorList();

            // TODO: set ViewBag.Instructors to a SelectList, mapping on {Id, Name}
            ViewBag.Instructors = instructors;

            if(instructorId == null)
            {
                return View(new Course());
            }
            else
            {
                return View(new Course() { InstructorId = (int)instructorId });
            }
            
        }

        [HttpPost]
        public ViewResult Create(Course model)
        {
            SetupInstructorViewBag();

            if(courseRepo.GetCourseByName(model.Name) == null)
            {
                courseRepo.Create(model);
                ViewBag.Result = "You have successfully saved this course.";
            }
            else
            {
                ViewBag.Error = "That course already exists and cannot be added.";
            }

            ModelState.Clear();
            
            //return View(model);
            return View(); // return blank course once saved
            //return RedirectToAction("Update", new { id = model.Id }); // redirect to Update
        }

        public ViewResult CreateByInstructorId(int id)
        {
            SetupInstructorViewBag();

            return View(new Course() { InstructorId = id });
        }

        public ViewResult HTMLFormExample()
        {
            // return the View without a model
            return View();
        }

        public ViewResult Update(int id)
        {
            SetupInstructorViewBag();

            var course = courseRepo.GetById(id);

            return View(course);
        }

        [HttpPost]
        public ViewResult Update(Course model)
        {
            SetupInstructorViewBag();            

            courseRepo.Update(model);

            ViewBag.Result = "You have successfully updated this course.";

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var course = courseRepo.GetById(id);

            courseRepo.Delete(course);

            return RedirectToAction("Details", "Instructor", new { id = course.InstructorId });
        }

        private void SetupInstructorViewBag()
        {
            // TODO: populate ViewBag.Instructors with PopulateAllInstructors()
            var instructors = courseRepo.PopulateInstructorList();

            // TODO: set ViewBag.Instructors to a SelectList, mapping on {Id, Name}
            ViewBag.Instructors = instructors;
        }

    }
}
