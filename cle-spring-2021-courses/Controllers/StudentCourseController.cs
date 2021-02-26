using cle_spring_2021_courses.Models;
using cle_spring_2021_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Controllers
{
    public class StudentCourseController : Controller
    {
        IRepository<StudentCourse> studentCourseRepo;

        public StudentCourseController(IRepository<StudentCourse> studentCourseRepo)
        {
            this.studentCourseRepo = studentCourseRepo;
        }
        public ViewResult Index()
        {
            return View(studentCourseRepo.GetAll());
        }
    }
}
