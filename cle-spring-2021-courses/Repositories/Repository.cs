﻿using cle_spring_2021_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private UniversityContext _db;
        public Repository(UniversityContext db)
        {
            this._db = db;
        }
        public void Create(T obj)
        {
            _db.Set<T>().Add(obj);
            _db.SaveChanges();
        }

        public void Delete(T obj)
        {
            _db.Set<T>().Remove(obj);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<Instructor> PopulateInstructorList()
        {
            return _db.Set<Instructor>().ToList();
        }
        public List<Feedback> GetReviewsByCourseId(int courseId)
        {
            return _db.Set<Feedback>().Where(f => f.CourseId == courseId).ToList();
        }

        public void Update(T obj)
        {
            _db.Set<T>().Update(obj);
            _db.SaveChanges();
        }
    }
}
