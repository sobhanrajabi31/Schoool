using School.BLL.Services;
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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            FillDataGV();
        }

        private void FillDataGV()
        {
            StudentService st = new StudentService();
            datagrid_student.DataSource = st.GetData();
        }

        private void Buttons(object sender, EventArgs e)
        {
            
        }

        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent frm = new FrmAddStudent();
            frm.OnStudentInserted = FillDataGV;
            frm.ShowDialog();
            FillDataGV();
        }

        private void btn_editstudent_Click(object sender, EventArgs e)
        {
            if (datagrid_student.Rows.Count > 0 && datagrid_student.CurrentRow.Index != -1)
            {
                FrmEditStudent frm = new FrmEditStudent();
                frm.OnStudentInserted = FillDataGV;
                frm.txtbox_id.Text = datagrid_student.CurrentRow.Cells[0].Value.ToString();
                frm.ShowDialog();
                FillDataGV();
            }
        }

        private void btn_deletestudent_Click(object sender, EventArgs e)
        {
            if (datagrid_student.Rows.Count > 0 && datagrid_student.CurrentRow.Index != -1)
            {
                if (MessageBox.Show("Are you sure?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(datagrid_student.CurrentRow.Cells[0].Value.ToString());

                    StudentService st = new StudentService();
                    var result = st.Delete(id);

                    if (result.Success)
                        FillDataGV();
                }
            }
        }

        private void datagrid_student_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid_student.Rows.Count > 0 && datagrid_student.CurrentRow.Index != -1)
            {
                btn_editstudent_Click(sender, e);
            }
        }
    }
}
