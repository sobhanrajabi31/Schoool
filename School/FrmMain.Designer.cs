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
            this.btn_Lesson = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Student
            // 
            this.btn_Student.Location = new System.Drawing.Point(14, 12);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(115, 33);
            this.btn_Student.TabIndex = 0;
            this.btn_Student.Text = "Student";
            this.btn_Student.UseVisualStyleBackColor = true;
            // 
            // btn_Class
            // 
            this.btn_Class.Location = new System.Drawing.Point(14, 51);
            this.btn_Class.Name = "btn_Class";
            this.btn_Class.Size = new System.Drawing.Size(115, 33);
            this.btn_Class.TabIndex = 0;
            this.btn_Class.Text = "Class";
            this.btn_Class.UseVisualStyleBackColor = true;
            // 
            // btn_Lesson
            // 
            this.btn_Lesson.Location = new System.Drawing.Point(135, 12);
            this.btn_Lesson.Name = "btn_Lesson";
            this.btn_Lesson.Size = new System.Drawing.Size(115, 33);
            this.btn_Lesson.TabIndex = 0;
            this.btn_Lesson.Text = "Lesson";
            this.btn_Lesson.UseVisualStyleBackColor = true;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(135, 51);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(115, 33);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 97);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Lesson);
            this.Controls.Add(this.btn_Class);
            this.Controls.Add(this.btn_Student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{ Framework Type } ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Button btn_Class;
        private System.Windows.Forms.Button btn_Lesson;
        private System.Windows.Forms.Button btn_Register;
    }
}