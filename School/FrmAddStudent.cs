using ADO = School.BLL.StudentService.ADO.StudentSv;
using EF = School.BLL.StudentService.EF.StudentSv;
using MEM = School.BLL.StudentService.MEM.StudentSv;
using School.Model.CreateModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.DataAccess;

namespace School.Forms.FrmStudent
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        public Action OnStudentInserted;
        public int IdIndex;

        private void AddStudent_EF()
        {
            EF st = new EF();

            var data = new StudentModel
            {
                FirstName = txtbox_firstname.Text,
                LastName = txtbox_lastname.Text,
                Mobile = txtbox_mobile.Text
            };

            var result = st.Insert(data);

            if (result.Success)
                OnStudentInserted();

            MessageBox.Show(result.Message);
        }

        private void AddStudent_ADO()
        {
            ADO st = new ADO();

            var data = new StudentModel
            {
                FirstName = txtbox_firstname.Text,
                LastName = txtbox_lastname.Text,
                Mobile = txtbox_mobile.Text
            };

            var result = st.Insert(data);

            if (result.Success)
                OnStudentInserted();

            MessageBox.Show(result.Message);
        }

        private void AddStudent_Mem()
        {
            MEM st = new MEM();

            var data = new StudentModel
            {
                Id = IdIndex,
                FirstName = txtbox_firstname.Text,
                LastName = txtbox_lastname.Text,
                Mobile = txtbox_mobile.Text
            };

            var result = st.Insert(data);

            if (result.Success)
                OnStudentInserted();

            MessageBox.Show(result.Message);
        }

        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            if (DbFramework.Framework == Framework.EF)
                AddStudent_EF();
            else if (DbFramework.Framework == Framework.AdoNET)
                AddStudent_ADO();
            else if (DbFramework.Framework == Framework.InMemory)
                AddStudent_Mem();
        }
    }
}
