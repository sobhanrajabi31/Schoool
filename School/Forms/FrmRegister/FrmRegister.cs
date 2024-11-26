using School.BLL.Services;
using School.Forms.FrmRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FillDataGV()
        {
            RegisterService st = new RegisterService();
            datagrid_register.DataSource = st.GetData();
        }

        private void btn_addregister_Click(object sender, EventArgs e)
        {
            FrmAddRegister frm = new FrmAddRegister();
            frm.OnRegisterInserted = FillDataGV;
            frm.ShowDialog();
            FillDataGV();
        }

        private void btn_editregister_Click(object sender, EventArgs e)
        {
            FrmEditRegister frm = new FrmEditRegister();
            frm.OnRegisterInserted = FillDataGV;
            frm.ShowDialog();
            FillDataGV();
        }
    }
}
