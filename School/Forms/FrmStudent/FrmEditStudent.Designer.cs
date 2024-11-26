namespace School.Forms.FrmStudent
{
    partial class FrmEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditStudent));
            this.txtbox_firstname = new System.Windows.Forms.TextBox();
            this.txtbox_lastname = new System.Windows.Forms.TextBox();
            this.txtbox_mobile = new System.Windows.Forms.TextBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.btn_editstudent = new System.Windows.Forms.Button();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
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
            // btn_editstudent
            // 
            this.btn_editstudent.Location = new System.Drawing.Point(95, 139);
            this.btn_editstudent.Name = "btn_editstudent";
            this.btn_editstudent.Size = new System.Drawing.Size(111, 23);
            this.btn_editstudent.TabIndex = 2;
            this.btn_editstudent.Text = "Edit";
            this.btn_editstudent.UseVisualStyleBackColor = true;
            // 
            // txtbox_id
            // 
            this.txtbox_id.Location = new System.Drawing.Point(95, 36);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(111, 20);
            this.txtbox_id.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(35, 39);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Id";
            // 
            // FrmEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 224);
            this.Controls.Add(this.btn_editstudent);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.txtbox_mobile);
            this.Controls.Add(this.txtbox_lastname);
            this.Controls.Add(this.txtbox_id);
            this.Controls.Add(this.txtbox_firstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditStudent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditStudent";
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
        private System.Windows.Forms.Button btn_editstudent;
        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.Label lbl_id;
    }
}