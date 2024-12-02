using School.BLL;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.MEM
{
    public class StudentRepo : IStudent
    {
        public List<StudentDto> GetData()
        {
            return StudentMM.Students;
        }

        public void Insert(StudentDto student)
        {
            StudentMM.Students.Add(student);
        }

        public void Update(StudentDto student)
        {
            for (int i = 0; i < StudentMM.Students.Count; i++)
            {
                if (StudentMM.Students[i].Id == student.Id)
                {
                    StudentMM.Students[i].FirstName = student.FirstName;
                    StudentMM.Students[i].LastName = student.LastName;
                    StudentMM.Students[i].Mobile = student.Mobile;
                }
            }
        }

        public void Delete(int id)
        {
            StudentMM.Students.RemoveAt(id);
        }

        public bool MobileValidation(string mobile, int? id = null)
        {
            if (StudentMM.Students.Count > 0)
            {
                for (int i = 0; i < StudentMM.Students.Count; i++)
                {
                    if (StudentMM.Students[i].Id == id && StudentMM.Students[i].Mobile == mobile)
                        return false;
                }

                return true;
            }
            else
                return false;
        }
    }
}
