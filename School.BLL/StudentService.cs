﻿using School.DataAccess.Repository;
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

        public void LoadMemoryDB()
        {
            StudentMM.Students = new List<Student>();
        }

        public List<Student> MemoryDB()
        {
            return db.MemoryDB();
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
                    Message = "شماره موبایل وارد شده نامعتبر است"
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
                    Message = "شماره موبایل وارد شده نامعتبر است"
                };
            }

            var student = new StudentDto
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

        public OperationResult InsertMem(StudentModel studentDto)
        {
            if (!studentDto.IsValid)
            {
                return new OperationResult
                {
                    Success = studentDto.IsValid,
                    Message = studentDto.ErrorMessage
                };
            }

            if (db.MobileValidationMem(studentDto.Mobile))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره موبایل وارد شده نامعتبر است"
                };
            }

            var student = new Student
            {
                Id = studentDto.Id,
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                Mobile = studentDto.Mobile,
            };

            db.InsertMem(student);

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
                    Message = "شماره موبایل وارد شده تکراری است"
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
                Message = "عملیات ویرایش با موفقیت انجام شد"
            };
        }

        public OperationResult UpdateAdo(StudentModel studentDto)
        {
            if (!studentDto.IsValid)
            {
                return new OperationResult
                {
                    Success = studentDto.IsValid,
                    Message = studentDto.ErrorMessage
                };
            }

            if (db.MobileValidationAdo(studentDto.Mobile, studentDto.Id))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره موبایل وارد شده تکراری است"
                };
            }

            var data = new Student
            {
                Id = studentDto.Id,
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                Mobile = studentDto.Mobile,
            };

            db.UpdateAdo(data);

            return new OperationResult
            {
                Success = true,
                Message = "عملیات ویرایش با موفقیت انجام شد"
            };
        }

        public OperationResult UpdateMem(StudentModel studentDto)
        {
            if (!studentDto.IsValid)
            {
                return new OperationResult
                {
                    Success = studentDto.IsValid,
                    Message = studentDto.ErrorMessage
                };
            }

            if (db.MobileValidationMem(studentDto.Mobile, studentDto.Id))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره موبایل وارد شده تکراری است"
                };
            }

            var data = new Student
            {
                Id = studentDto.Id,
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                Mobile = studentDto.Mobile,
            };

            db.UpdateMem(data);

            return new OperationResult
            {
                Success = true,
                Message = "عملیات ویرایش با موفقیت انجام شد"
            };
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
            db.DeleteAdo(id);

            return new OperationResult
            {
                Success = true,
                Message = "عملیات حذف با موفقیت انجام شد"
            };
        }

        public OperationResult DeleteMem(int id)
        {
            db.DeleteMem(id);

            return new OperationResult
            {
                Success = true,
                Message = "عملیات حذف با موفقیت انجام شد"
            };
        }
    }
}
