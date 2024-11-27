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
            FrmMain frm = new FrmMain();
            frm.Text = string.Format("{0} - {1}", frm.Text, DbFramework.Framework.ToString());
            
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_framework.SelectedIndex == 0)
                DbFramework.Framework = Framework.EF;
            else if (combobox_framework.SelectedIndex == 1)
                DbFramework.Framework = Framework.AdoNET;
            else if (combobox_framework.SelectedIndex == 2)
                DbFramework.Framework = Framework.OnMemory;
        }
    }
}
