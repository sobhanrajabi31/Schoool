using School.DataAccess;
using School.Model.CreateModel;
using System;
using System.Windows.Forms;
using ADO = School.BLL.StudentService.ADO.StudentSv;
using EF = School.BLL.StudentService.EF.StudentSv;
using MEM = School.BLL.StudentService.MEM.StudentSv;

namespace School.Forms.FrmStudent
{
    public partial class FrmEditStudent : Form
    {
        public FrmEditStudent()
        {
            InitializeComponent();
        }

        public Action OnStudentInserted;

        private void EditStudent_EF()
        {
            EF st = new EF();

            var data = new StudentModel
            {
                Id = txtbox_id.Text.Parse(),
                FirstName = txtbox_firstname.Text,
                LastName = txtbox_lastname.Text,
                Mobile = txtbox_mobile.Text
            };

            var result = st.Update(data);

            if (result.Success)
                OnStudentInserted();

            MessageBox.Show(result.Message);
        }

        private void EditStudent_ADO()
        {
            ADO st = new ADO();

            var data = new StudentModel
            {
                Id = txtbox_id.Text.Parse(),
                FirstName = txtbox_firstname.Text,
                LastName = txtbox_lastname.Text,
                Mobile = txtbox_mobile.Text
            };

            var result = st.Update(data);

            if (result.Success)
                OnStudentInserted();

            MessageBox.Show(result.Message);
        }

        private void EditStudent_Mem()
        {
            MEM st = new MEM();

            var data = new StudentModel
            {
                Id = txtbox_id.Text.Parse(),
                FirstName = txtbox_firstname.Text,
                LastName = txtbox_lastname.Text,
                Mobile = txtbox_mobile.Text
            };

            var result = st.Update(data);

            if (result.Success)
                OnStudentInserted();

            MessageBox.Show(result.Message);
        }

        private void btn_editstudent_Click(object sender, EventArgs e)
        {
            if (DbFramework.Framework == Framework.EF)
                EditStudent_EF();
            else if (DbFramework.Framework == Framework.AdoNET)
                EditStudent_ADO();
            else if (DbFramework.Framework == Framework.InMemory)
                EditStudent_Mem();
        }
    }
}
