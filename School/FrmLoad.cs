using School.DataAccess;
using School.Forms.FrmStudent;
using System;
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
            FrmStudent frm = new FrmStudent();
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
                DbFramework.Framework = Framework.InMemory;
        }
    }
}
