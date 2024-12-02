using School.Model;
using School.Model.CreateModel;
using System.Collections.Generic;

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
