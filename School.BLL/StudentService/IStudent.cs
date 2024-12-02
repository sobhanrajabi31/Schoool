using School.Model;
using School.Model.CreateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BLL.StudentService
{
    public interface IStudent
    {
        List<StudentDto> GetData();

        OperationResult Insert(StudentModel studentDto);

        OperationResult Update(StudentModel studentDto);

        OperationResult Delete(int id);
    }
}
