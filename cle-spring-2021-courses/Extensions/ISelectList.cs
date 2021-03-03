using cle_spring_2021_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Extensions
{
    public interface ISelectList
    {
        // Add template to retrieve all Instructors
        List<Instructor> PopulateInstructorList();

        List<Feedback> GetReviewsByCourseId(int courseId);

        Course GetCourseByName(string name);
    }
}
