using School.DataAccess.Repository;
using School.Model;
using School.Model.CreateModel;
using School.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BLL.Services
{
    public class StudentService
    {
        StudentRepository db;
        public StudentService()
        {
            db = new StudentRepository();
        }

        public List<StudentDto> GetData()
        {
            return db.GetData();
        }

        public OperationResult Insert(StudentModel studentDto)
        {
            if (!studentDto.IsValid)
            {
                return new OperationResult
                {
                    Success = studentDto.IsValid,
                    Message = studentDto.ErrorMessage
                };
            }

            if (db.MobileValidation(studentDto.Mobile))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره موبایل تکراری است"
                };
            }

            var student = new Student
            {
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                Mobile = studentDto.Mobile,
            };

            db.Insert(student);

            return new OperationResult 
            {
                Success = true,
                Message = "عملیات ثبت با موفقیت انجام شد"
            };
        }

        public OperationResult Update(StudentModel studentDto)
        {
            if (!studentDto.IsValid)
            {
                return new OperationResult
                {
                    Success = studentDto.IsValid,
                    Message = studentDto.ErrorMessage
                };
            }

            if (db.MobileValidation(studentDto.Mobile, studentDto.Id))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره موبایل تکراری است"
                };
            }

            var data = new Student
            {
                Id = studentDto.Id,
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                Mobile = studentDto.Mobile,
            };

            db.Update(data);

            return new OperationResult
            {
                Success = true,
                Message = "عملیات ثبت با موفقیت انجام شد"
            };
        }

        public OperationResult Delete(int id)
        {
            db.Delete(id);

            return new OperationResult
            {
                Success = true,
                Message = "عملیات حذف با موفقیت انجام شد"
            };
        }
    }
}
