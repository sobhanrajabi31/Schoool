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

        private void buttons(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            this.Hide();

            if (button.Name == btn_Student.Name)
                new FrmStudent().ShowDialog();

            else if (button.Name == btn_Class.Name)
                new FrmClass().ShowDialog();

            else if (button.Name == btn_Register.Name)
                new FrmRegister().ShowDialog();

            this.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
