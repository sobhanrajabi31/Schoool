using School.Model;
using School.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.EF
{
    public class StudentRepo : IStudent
    {
        SchoolDataContext db = new SchoolDataContext();

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

        public void Insert(StudentDto student)
        {
            var data = new Student
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Mobile = student.Mobile
            };

            db.Students.Add(data);
            db.SaveChanges();
        }

        public void Update(StudentDto student)
        {
            var st = db.Students.Where(s => s.Id == student.Id).Single();

            st.FirstName = student.FirstName;
            st.LastName = student.LastName;
            st.Mobile = student.Mobile;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = db.Students.Where(x => x.Id == id).Single();
            db.Students.Remove(student);
            db.SaveChanges();
        }

        public bool MobileValidation(string mobile, int? id = null)
        {
            if (db.Students.Where(s => s.Id == id && s.Mobile == mobile).Any())
                return false;

            return db.Students.Where(x => x.Mobile == mobile).Any();
        }
    }
}