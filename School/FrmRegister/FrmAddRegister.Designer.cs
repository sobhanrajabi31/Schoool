using School.Forms.FrmStudent;

namespace School.Forms.FrmRegister
{
    partial class FrmAddRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddRegister));
            this.lbl_studentid = new System.Windows.Forms.Label();
            this.lbl_classid = new System.Windows.Forms.Label();
            this.btn_addregister = new System.Windows.Forms.Button();
            this.combobox_studentid = new System.Windows.Forms.ComboBox();
            this.combobox_lessonid = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_studentid
            // 
            this.lbl_studentid.AutoSize = true;
            this.lbl_studentid.Location = new System.Drawing.Point(35, 77);
            this.lbl_studentid.Name = "lbl_studentid";
            this.lbl_studentid.Size = new System.Drawing.Size(53, 13);
            this.lbl_studentid.TabIndex = 1;
            this.lbl_studentid.Text = "StudentId";
            // 
            // lbl_classid
            // 
            this.lbl_classid.AutoSize = true;
            this.lbl_classid.Location = new System.Drawing.Point(35, 104);
            this.lbl_classid.Name = "lbl_classid";
            this.lbl_classid.Size = new System.Drawing.Size(41, 13);
            this.lbl_classid.TabIndex = 1;
            this.lbl_classid.Text = "ClassId";
            // 
            // btn_addregister
            // 
            this.btn_addregister.Location = new System.Drawing.Point(91, 127);
            this.btn_addregister.Name = "btn_addregister";
            this.btn_addregister.Size = new System.Drawing.Size(121, 23);
            this.btn_addregister.TabIndex = 2;
            this.btn_addregister.Text = "Add";
            this.btn_addregister.UseVisualStyleBackColor = true;
            // 
            // combobox_studentid
            // 
            this.combobox_studentid.FormattingEnabled = true;
            this.combobox_studentid.Location = new System.Drawing.Point(91, 74);
            this.combobox_studentid.Name = "combobox_studentid";
            this.combobox_studentid.Size = new System.Drawing.Size(121, 21);
            this.combobox_studentid.TabIndex = 3;
            // 
            // combobox_lessonid
            // 
            this.combobox_lessonid.FormattingEnabled = true;
            this.combobox_lessonid.Location = new System.Drawing.Point(91, 101);
            this.combobox_lessonid.Name = "combobox_lessonid";
            this.combobox_lessonid.Size = new System.Drawing.Size(121, 21);
            this.combobox_lessonid.TabIndex = 3;
            // 
            // FrmAddRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 224);
            this.Controls.Add(this.combobox_lessonid);
            this.Controls.Add(this.combobox_studentid);
            this.Controls.Add(this.btn_addregister);
            this.Controls.Add(this.lbl_classid);
            this.Controls.Add(this.lbl_studentid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_studentid;
        private System.Windows.Forms.Label lbl_classid;
        private System.Windows.Forms.Button btn_addregister;
        private System.Windows.Forms.ComboBox combobox_studentid;
        private System.Windows.Forms.ComboBox combobox_lessonid;
    }
}