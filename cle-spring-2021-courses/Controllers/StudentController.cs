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
    }
}
