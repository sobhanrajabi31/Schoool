using School.BLL;
using School.BLL.Services;
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

namespace School.Forms.FrmStudent
{
    public partial class FrmStudent : Form
    {
        StudentService stt = new StudentService();
        public FrmStudent()
        {
            InitializeComponent();
            stt.LoadMemoryDB();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            FillDataGV();
        }

        private void FillDataGV()
        {
            StudentService st = new StudentService();

            if (DbFramework.Framework == Framework.EF)
                datagrid_student.DataSource = st.GetDataEF();

            else if (DbFramework.Framework == Framework.AdoNET)
                datagrid_student.DataSource = st.GetDataAdo();

            else if (DbFramework.Framework == Framework.InMemory)
            {
                datagrid_student.DataSource = st.MemoryDB().ToList();
            }
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
                        StudentService st = new StudentService();

                        if (DbFramework.Framework == Framework.EF)
                            st.DeleteEF(id);

                        else if (DbFramework.Framework == Framework.AdoNET)
                            st.DeleteAdo(id);

                        else if (DbFramework.Framework == Framework.InMemory)
                            st.DeleteMem(datagrid_student.CurrentRow.Index);
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
