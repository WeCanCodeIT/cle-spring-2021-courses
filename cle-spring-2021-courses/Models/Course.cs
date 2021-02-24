using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        public string Name { get; set; }
        [Display(Name = "Course Description")]
        public string Description { get; set; }

        [Display(Name = "Instructor")]
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public virtual List<StudentCourse> StudentCourses { get; set; }

        public Course()
        {

        }

        public Course(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }





    }
}
