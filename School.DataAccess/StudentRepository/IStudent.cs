using School.Model;
using School.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess
{
    public interface IStudent
    {
        List<StudentDto> GetData();

        void Insert(StudentDto student);

        void Update(StudentDto student);

        void Delete(int id);

        bool MobileValidation(string mobile, int? id = null);
    }
}
