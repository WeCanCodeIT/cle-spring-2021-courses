using cle_spring_2021_courses.Models;
using cle_spring_2021_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Controllers
{
    public class StudentController : Controller
    {
        IRepository<Student> studentRepo;

        public StudentController(IRepository<Student> studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        public ViewResult Index()
        {
            var studentList = studentRepo.GetAll();

            return View(studentList);
        }

        public ViewResult Details(int id)
        {
            return View(studentRepo.GetById(id));
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student model)
        {
            studentRepo.Create(model);

            return RedirectToAction("Index");
        }

        public ViewResult Update(int id)
        {
            var student = studentRepo.GetById(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Update(Student model)
        {
            studentRepo.Update(model);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var student = studentRepo.GetById(id);
            studentRepo.Delete(student);

            return RedirectToAction("Index");
        }

    }
}
