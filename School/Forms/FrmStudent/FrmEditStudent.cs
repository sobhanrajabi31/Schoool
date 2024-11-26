using School.BLL.Services;
using School.Model;
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
    public partial class FrmEditStudent : Form
    {
        public FrmEditStudent()
        {
            InitializeComponent();
        }

        public Action OnStudentInserted;

        private void btn_editstudent_Click(object sender, EventArgs e)
        {
            StudentService st = new StudentService();

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
    }
}
