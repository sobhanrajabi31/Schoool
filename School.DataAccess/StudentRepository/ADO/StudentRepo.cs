using School.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace School.DataAccess.ADO
{
    public class StudentRepo : IStudent
    {
        public List<StudentDto> GetData()
        {
            AdoSqlCommands.StartAdoCon();
            List<DataRow> data = AdoSqlCommands.TableProc("GetDataAdo", null);

            return data.Select(x => new StudentDto
            {
                Id = int.Parse(x[0].ToString()),
                FirstName = x[1].ToString(),
                LastName = x[2].ToString(),
                Mobile = x[3].ToString()
            }).ToList();
        }

        public void Insert(StudentDto student)
        {
            AdoSqlCommands.ExcNonQueryProc("InsertAdo",
                new SqlParameter("FirstName", student.FirstName),
                new SqlParameter("LastName", student.LastName),
                new SqlParameter("Mobile", student.Mobile));
        }

        public void Update(StudentDto student)
        {
            AdoSqlCommands.ExcNonQueryProc("UpdateAdo", AdoSqlCommands.ModelToSqlParams(student).ToArray());
        }

        public void Delete(int id)
        {
            AdoSqlCommands.ExcNonQueryProc("DeleteAdo", new SqlParameter("Id", id));
        }

        public bool MobileValidation(string mobile, int? id = null)
        {
            List<DataRow> datas = AdoSqlCommands.TableProc("MobileValidationAdo", new SqlParameter("mobile", mobile));

            if (datas.Count > 0)
            {
                foreach (DataRow row in datas)
                {
                    if (row[0].ToString().Parse() == id && row[3].ToString() == mobile)
                        return false;
                }

                return true;
            }
            else
                return false;
        }
    }
}
