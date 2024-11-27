using School.Model;
using School.Model.CreateModel;
using School.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Repository
{
    public class StudentRepository
    {
        SchoolDataContext db = new SchoolDataContext();

        public List<StudentDto> GetDataEF()
        {
            return db.Students.Select(x => new StudentDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Mobile = x.Mobile
            }).ToList();
        }

        public DataTable GetDataAdo()
        {
            AdoSqlCommands.StartAdoCon();
            return AdoSqlCommands.TableProc("GetDataAdo", null);
        }

        public void InsertEF(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void InsertAdo(Student student)
        {
            AdoSqlCommands.ExcNonQueryProc("InsertAdo", AdoSqlCommands.ModelToSqlParams(student).ToArray());
        }

        public void UpdateEF(Student student)
        {
            var st = db.Students.Where(s => s.Id == student.Id).Single();

            st.FirstName = student.FirstName;
            st.LastName = student.LastName;
            st.Mobile = student.Mobile;

            db.SaveChanges();
        }

        public void UpdateAdo(Student student)
        {
            AdoSqlCommands.ExcNonQueryProc("UpdateAdo", AdoSqlCommands.ModelToSqlParams(student).ToArray());
        }

        public void DeleteEF(int id)
        {
            Student student = db.Students.Where(x=>x.Id == id).Single();
            db.Students.Remove(student);
            db.SaveChanges();
        }

        public void DeleteAdo(int id)
        {
        }

        public bool MobileValidationEF(string mobile, int? id = null)
        {
            if (db.Students.Where(s => s.Id == id && s.Mobile == mobile).Any())
                return false;

            return db.Students.Where(x => x.Mobile == mobile).Any();
        }

        public bool MobileValidationAdo(string mobile, int? id = null)
        {
            DataTable dataTable = AdoSqlCommands.TableProc("MobileValidationAdo", new SqlParameter("mobile", mobile));

            foreach (DataRow row in dataTable.Rows)
            {
                if (row[0].ToString().Parse() == id && row[2].ToString() == mobile)
                    return false;
                else
                    return true;
            }

            return true;
        }
    }
}
