using cle_spring_2021_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Repositories
{
    public class InstructorRepository : IRepository<Instructor>
    {
        private UniversityContext _db;
        public InstructorRepository(UniversityContext db)
        {
            this._db = db;
        }

        public void Create(Instructor obj)
        {
            _db.Instructors.Add(obj);
            _db.SaveChanges();
        }

        public void Delete(Instructor obj)
        {
            _db.Instructors.Remove(obj);
            _db.SaveChanges();
        }

        public IEnumerable<Instructor> GetAll()
        {
            return _db.Instructors.ToList();
        }

        public Instructor GetById(int id)
        {
            var instructor = _db.Instructors.Find(id);

            return instructor;
        }

        public void Update(Instructor obj)
        {
            _db.Instructors.Update(obj);
            _db.SaveChanges();
        }
    }
}
