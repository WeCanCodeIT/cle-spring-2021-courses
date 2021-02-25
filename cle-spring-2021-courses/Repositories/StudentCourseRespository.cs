using cle_spring_2021_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Repositories
{
    public class StudentCourseRespository : Repository<StudentCourse>
    {
        public StudentCourseRespository(UniversityContext db) : base(db)
        {

        }
    }
}
