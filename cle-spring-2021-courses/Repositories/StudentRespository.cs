using cle_spring_2021_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses.Repositories
{
    public class StudentRespository : Repository<Student>
    {
        //private UniversityContext _db;
        public StudentRespository(UniversityContext db) : base(db)
        {
            //this._db = db;
        }

        //public void Create(Student obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Student obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Student> GetAll()
        //{
        //    return _db.Students.ToList();
        //}

        //public Student GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Student obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
