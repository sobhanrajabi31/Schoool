using EF = School.BLL.StudentService.EF.StudentSv;
using ADO = School.BLL.StudentService.ADO.StudentSv;
using MEM = School.BLL.StudentService.MEM.StudentSv;
using School.BLL;
using School.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.BLL.StudentService.ADO;
using School.BLL.StudentService.EF;

namespace School.Forms.FrmStudent
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
            new MEM().Load();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            FillDataGV();
        }

        private void FillDataGV()
        {
            if (DbFramework.Framework == Framework.EF)
                datagrid_student.DataSource = new EF().GetData();

            else if (DbFramework.Framework == Framework.AdoNET)
                datagrid_student.DataSource = new ADO().GetData();

            else if (DbFramework.Framework == Framework.InMemory)
                datagrid_student.DataSource = new MEM().GetData().ToList();
        }

        private void Buttons(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == btn_addstudent.Name)
            {
                FrmAddStudent frm = new FrmAddStudent();
                frm.OnStudentInserted = FillDataGV;
                frm.IdIndex = datagrid_student.Rows.Count + 1;
                frm.ShowDialog();
            }

            else if (button.Name == btn_editstudent.Name)
            {
                if (datagrid_student.Rows.Count > 0 && datagrid_student.CurrentRow.Index != -1)
                {
                    FrmEditStudent frm = new FrmEditStudent();
                    frm.OnStudentInserted = FillDataGV;

                    frm.txtbox_id.Text = datagrid_student.CurrentRow.Cells[0].Value.ToString();
                    frm.txtbox_firstname.Text = datagrid_student.CurrentRow.Cells[1].Value.ToString();
                    frm.txtbox_lastname.Text = datagrid_student.CurrentRow.Cells[2].Value.ToString();
                    frm.txtbox_mobile.Text = datagrid_student.CurrentRow.Cells[3].Value.ToString();

                    frm.ShowDialog();
                }
            }

            else if (button.Name == btn_deletestudent.Name)
            {
                if (datagrid_student.Rows.Count > 0 && datagrid_student.CurrentRow.Index != -1)
                {
                    if (MessageBox.Show("Are you sure?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int id = int.Parse(datagrid_student.CurrentRow.Cells[0].Value.ToString());
                        if (DbFramework.Framework == Framework.EF)
                            new EF().Delete(id);

                        else if (DbFramework.Framework == Framework.AdoNET)
                            new ADO().Delete(id);

                        else if (DbFramework.Framework == Framework.InMemory)
                            new MEM().Delete(datagrid_student.CurrentRow.Index);
                    }
                }
            }

            FillDataGV();
        }

        private void datagrid_student_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid_student.Rows.Count > 0 && datagrid_student.CurrentRow.Index != -1)
                Buttons(btn_editstudent, e);
        }
    }
}
