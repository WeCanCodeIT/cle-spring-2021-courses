using cle_spring_2021_courses.Models;
using cle_spring_2021_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Controllers
{
    public class InstructorController : Controller
    {
        IRepository<Instructor> instructorRepo;

        public InstructorController(IRepository<Instructor> repo)
        {
            this.instructorRepo = repo;
        }

        public ViewResult Index()
        {
            return View(instructorRepo.GetAll());
        }
    }
}
