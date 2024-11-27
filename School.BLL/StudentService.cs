using School.DataAccess.Repository;
using School.Model;
using School.Model.CreateModel;
using School.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<StudentDto> GetDataEF()
        {
            return db.GetDataEF();
        }

        public DataTable GetDataAdo()
        {
            return db.GetDataAdo();
        }

        public OperationResult InsertEF(StudentModel studentDto)
        {
            if (!studentDto.IsValid)
            {
                return new OperationResult
                {
                    Success = studentDto.IsValid,
                    Message = studentDto.ErrorMessage
                };
            }

            if (db.MobileValidationEF(studentDto.Mobile))
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

            db.InsertEF(student);

            return new OperationResult 
            {
                Success = true,
                Message = "عملیات ثبت با موفقیت انجام شد"
            };
        }

        public OperationResult InsertAdo(StudentModel studentDto)
        {
            if (!studentDto.IsValid)
            {
                return new OperationResult
                {
                    Success = studentDto.IsValid,
                    Message = studentDto.ErrorMessage
                };
            }

            if (db.MobileValidationAdo(studentDto.Mobile))
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

            db.InsertAdo(student);

            return new OperationResult
            {
                Success = true,
                Message = "عملیات ثبت با موفقیت انجام شد"
            };
        }

        public OperationResult UpdateEF(StudentModel studentDto)
        {
            if (!studentDto.IsValid)
            {
                return new OperationResult
                {
                    Success = studentDto.IsValid,
                    Message = studentDto.ErrorMessage
                };
            }

            if (db.MobileValidationEF(studentDto.Mobile, studentDto.Id))
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

            db.UpdateEF(data);

            return new OperationResult
            {
                Success = true,
                Message = "عملیات ثبت با موفقیت انجام شد"
            };
        }

        public OperationResult UpdateAdo(StudentModel studentDto)
        {
            return new OperationResult
            { Success = true };
        }

        public OperationResult DeleteEF(int id)
        {
            db.DeleteEF(id);

            return new OperationResult
            {
                Success = true,
                Message = "عملیات حذف با موفقیت انجام شد"
            };
        }

        public OperationResult DeleteAdo(int id)
        {
            return new OperationResult
            { Success = true };
        }
    }
}
