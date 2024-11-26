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
    public partial class FrmLoad : Form
    {
        public FrmLoad()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string fw;
            if (radiobtn_ado.Checked)
                fw = "School | Ado.net";
            else
                fw = "School | EF";

            FrmMain frm = new FrmMain();
            frm.Text = fw;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
