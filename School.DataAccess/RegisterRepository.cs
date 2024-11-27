using School.Model;
using School.Model.Dto;
using School.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Repository
{
    public class RegisterRepository
    {
        SchoolDataContext db = new SchoolDataContext();

        public object GetData()
        {
            return db.Registers
                .Select(x => new
                {
                    x.Id,
                    x.StudentId,
                    x.Student.FirstName,
                    x.ClassId,
                    x.Class.Title
                });
        }
    }
}
