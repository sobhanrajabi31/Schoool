﻿using School.DataAccess.EF;
using School.Model;
using School.Model.CreateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BLL.StudentService.EF
{
    public class StudentSv : IStudent
    {
        StudentRepo db = new StudentRepo();

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
                    Message = "شماره موبایل وارد شده نامعتبر است"
                };
            }

            var student = new StudentDto
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
                    Message = "شماره موبایل وارد شده تکراری است"
                };
            }

            var data = new StudentDto
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
                Message = "عملیات ویرایش با موفقیت انجام شد"
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