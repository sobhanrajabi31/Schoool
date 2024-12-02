using School.Model;
using System.Collections.Generic;

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
