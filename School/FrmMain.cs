using School.Forms.FrmStudent;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            FrmStudent student = new FrmStudent();
            this.Hide();
            student.ShowDialog();
            this.Show();
        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
            FrmClass Class = new FrmClass();
            this.Hide();
            Class.ShowDialog();
            this.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
