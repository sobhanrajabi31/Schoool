namespace School
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btn_Student = new System.Windows.Forms.Button();
            this.btn_Class = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Student
            // 
            this.btn_Student.Location = new System.Drawing.Point(15, 12);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(115, 33);
            this.btn_Student.TabIndex = 0;
            this.btn_Student.Text = "Student";
            this.btn_Student.UseVisualStyleBackColor = true;
            this.btn_Student.Click += new System.EventHandler(this.buttons);
            // 
            // btn_Class
            // 
            this.btn_Class.Location = new System.Drawing.Point(136, 12);
            this.btn_Class.Name = "btn_Class";
            this.btn_Class.Size = new System.Drawing.Size(115, 33);
            this.btn_Class.TabIndex = 0;
            this.btn_Class.Text = "Class";
            this.btn_Class.UseVisualStyleBackColor = true;
            this.btn_Class.Click += new System.EventHandler(this.buttons);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(257, 12);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(115, 33);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.buttons);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 56);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Class);
            this.Controls.Add(this.btn_Student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Button btn_Class;
        private System.Windows.Forms.Button btn_Register;
    }
}