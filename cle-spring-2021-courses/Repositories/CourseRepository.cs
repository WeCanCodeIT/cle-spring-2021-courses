using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cle_spring_2021_courses.Models;
using Microsoft.EntityFrameworkCore;

namespace cle_spring_2021_courses.Repositories
{
    public class CourseRepository : Repository<Course>
    {
        //private UniversityContext _db;

        public CourseRepository(UniversityContext db) : base(db)
        {
            //this._db = db;
        }

        //public void Create(Course obj)
        //{
        //    //add the course to the list
        //    //courseList.Add(obj);
        //    _db.Courses.Add(obj);
        //    _db.SaveChanges();
        //}

        //public void Delete(Course obj)
        //{
        //    //remove course from list
        //    //courseList.Remove(obj);
        //    _db.Courses.Remove(obj);
        //    _db.SaveChanges();
        //}

        //public IEnumerable<Course> GetAll()
        //{
        //    //returning all courses
        //    return _db.Courses.ToList();
        //}

        //public Course GetById(int id)
        //{
        //    var course = _db.Courses.Find(id);
        //    //var course = _db.Courses.Include()
        //    return course;

        //    //return to the course based on the inputted id
        //    //return courses.Find(id);
        //    //foreach(var course in courseList)
        //    //{
        //    //    if(course.Id == id)
        //    //    {
        //    //        return course;
        //    //    }
        //    //}

        //    //return null;

        //}

        //public void Update(Course obj)
        //{
        //    //updating the course that is passed in
        //    _db.Courses.Update(obj);
        //    _db.SaveChanges();
        //    //foreach(var course in courseList)
        //    //{
        //    //    if(course.Id == obj.Id)
        //    //    {
        //    //        //update course
        //    //        //course = obj;

        //    //    }
        //    //}

        //}
    }
}
