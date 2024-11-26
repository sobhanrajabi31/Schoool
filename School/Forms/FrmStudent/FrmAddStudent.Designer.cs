namespace School.Forms.FrmStudent
{
    partial class FrmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudent));
            this.txtbox_firstname = new System.Windows.Forms.TextBox();
            this.txtbox_lastname = new System.Windows.Forms.TextBox();
            this.txtbox_mobile = new System.Windows.Forms.TextBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.btn_addstudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_firstname
            // 
            this.txtbox_firstname.Location = new System.Drawing.Point(95, 62);
            this.txtbox_firstname.Name = "txtbox_firstname";
            this.txtbox_firstname.Size = new System.Drawing.Size(111, 20);
            this.txtbox_firstname.TabIndex = 0;
            // 
            // txtbox_lastname
            // 
            this.txtbox_lastname.Location = new System.Drawing.Point(95, 87);
            this.txtbox_lastname.Name = "txtbox_lastname";
            this.txtbox_lastname.Size = new System.Drawing.Size(111, 20);
            this.txtbox_lastname.TabIndex = 0;
            // 
            // txtbox_mobile
            // 
            this.txtbox_mobile.Location = new System.Drawing.Point(95, 113);
            this.txtbox_mobile.Name = "txtbox_mobile";
            this.txtbox_mobile.Size = new System.Drawing.Size(111, 20);
            this.txtbox_mobile.TabIndex = 0;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(35, 65);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(54, 13);
            this.lbl_firstname.TabIndex = 1;
            this.lbl_firstname.Text = "FirstName";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(35, 90);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(55, 13);
            this.lbl_lastname.TabIndex = 1;
            this.lbl_lastname.Text = "LastName";
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Location = new System.Drawing.Point(35, 116);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(38, 13);
            this.lbl_mobile.TabIndex = 1;
            this.lbl_mobile.Text = "Mobile";
            // 
            // btn_addstudent
            // 
            this.btn_addstudent.Location = new System.Drawing.Point(95, 139);
            this.btn_addstudent.Name = "btn_addstudent";
            this.btn_addstudent.Size = new System.Drawing.Size(111, 23);
            this.btn_addstudent.TabIndex = 2;
            this.btn_addstudent.Text = "Add";
            this.btn_addstudent.UseVisualStyleBackColor = true;
            this.btn_addstudent.Click += new System.EventHandler(this.btn_addstudent_Click);
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 224);
            this.Controls.Add(this.btn_addstudent);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.txtbox_mobile);
            this.Controls.Add(this.txtbox_lastname);
            this.Controls.Add(this.txtbox_firstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddStudent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddStudent";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_firstname;
        private System.Windows.Forms.TextBox txtbox_lastname;
        private System.Windows.Forms.TextBox txtbox_mobile;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Button btn_addstudent;
    }
}