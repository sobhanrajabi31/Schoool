using School.Model;
using School.Model.CreateModel;
using School.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Repository
{
    public class StudentRepository
    {
        SchoolDataContext db = new SchoolDataContext();

        public void Insert(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void Update(Student student)
        {
            var st = db.Students.Where(s => s.Id == student.Id).Single();

            st.FirstName = student.FirstName;
            st.LastName = student.LastName;
            st.Mobile = student.Mobile;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = db.Students.Where(x=>x.Id == id).Single();
            db.Students.Remove(student);
            db.SaveChanges();
        }

        public bool MobileValidation(string mobile, int? id = null)
        {
            if (db.Students.Where(s => s.Id == id && s.Mobile == mobile).Any())
                return false;

            return db.Students.Where(x => x.Mobile == mobile).Any();
        }

        public List<StudentDto> GetData()
        {
            return db.Students.Select(x => new StudentDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Mobile = x.Mobile
            }).ToList();
        }
    }
}
