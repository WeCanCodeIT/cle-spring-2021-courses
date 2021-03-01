using cle_spring_2021_courses.Models;
using cle_spring_2021_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Controllers
{
    public class FeedbackController : Controller
    {
        IRepository<Feedback> feedbackRepo;

        public FeedbackController(IRepository<Feedback> feedbackRepo)
        {
            this.feedbackRepo = feedbackRepo;
        }

        public ViewResult Index(int courseId)
        {

            return View(feedbackRepo.GetReviewsByCourseId(courseId));
        }
    }
}
