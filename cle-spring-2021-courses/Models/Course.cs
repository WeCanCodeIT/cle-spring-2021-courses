using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

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
