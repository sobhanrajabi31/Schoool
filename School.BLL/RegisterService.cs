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
    public class RegisterService
    {
        RegisterRepository db;
        public RegisterService()
        {
            db = new RegisterRepository();
        }
        public object GetData()
        {
            return db.GetData();
        }
    }
}
