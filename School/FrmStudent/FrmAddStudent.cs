using School.BLL.Services;
using School.DataAccess;
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

namespace School.Forms.FrmStudent
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        public Action OnStudentInserted;

        private void AddStudent_EF()
        {
            StudentService st = new StudentService();

            var data = new StudentModel
            {
                FirstName = txtbox_firstname.Text,
                LastName = txtbox_lastname.Text,
                Mobile = txtbox_mobile.Text
            };

            var result = st.InsertEF(data);

            if (result.Success)
                OnStudentInserted();

            MessageBox.Show(result.Message);
        }

        private void AddStudent_ADO()
        {
            StudentService st = new StudentService();

            var data = new StudentModel
            {
                FirstName = txtbox_firstname.Text,
                LastName = txtbox_lastname.Text,
                Mobile = txtbox_mobile.Text
            };

            var result = st.InsertAdo(data);

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
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
