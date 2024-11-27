using School.Forms.FrmStudent;

namespace School.Forms.FrmRegister
{
    partial class FrmEditRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditRegister));
            this.combobox_lessonid = new System.Windows.Forms.ComboBox();
            this.combobox_studentid = new System.Windows.Forms.ComboBox();
            this.btn_editregister = new System.Windows.Forms.Button();
            this.lbl_lessonid = new System.Windows.Forms.Label();
            this.lbl_studentid = new System.Windows.Forms.Label();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combobox_lessonid
            // 
            this.combobox_lessonid.FormattingEnabled = true;
            this.combobox_lessonid.Location = new System.Drawing.Point(88, 101);
            this.combobox_lessonid.Name = "combobox_lessonid";
            this.combobox_lessonid.Size = new System.Drawing.Size(121, 21);
            this.combobox_lessonid.TabIndex = 7;
            // 
            // combobox_studentid
            // 
            this.combobox_studentid.FormattingEnabled = true;
            this.combobox_studentid.Location = new System.Drawing.Point(88, 74);
            this.combobox_studentid.Name = "combobox_studentid";
            this.combobox_studentid.Size = new System.Drawing.Size(121, 21);
            this.combobox_studentid.TabIndex = 8;
            // 
            // btn_editregister
            // 
            this.btn_editregister.Location = new System.Drawing.Point(88, 127);
            this.btn_editregister.Name = "btn_editregister";
            this.btn_editregister.Size = new System.Drawing.Size(121, 23);
            this.btn_editregister.TabIndex = 6;
            this.btn_editregister.Text = "Edit";
            this.btn_editregister.UseVisualStyleBackColor = true;
            // 
            // lbl_lessonid
            // 
            this.lbl_lessonid.AutoSize = true;
            this.lbl_lessonid.Location = new System.Drawing.Point(32, 104);
            this.lbl_lessonid.Name = "lbl_lessonid";
            this.lbl_lessonid.Size = new System.Drawing.Size(50, 13);
            this.lbl_lessonid.TabIndex = 4;
            this.lbl_lessonid.Text = "LessonId";
            // 
            // lbl_studentid
            // 
            this.lbl_studentid.AutoSize = true;
            this.lbl_studentid.Location = new System.Drawing.Point(32, 78);
            this.lbl_studentid.Name = "lbl_studentid";
            this.lbl_studentid.Size = new System.Drawing.Size(53, 13);
            this.lbl_studentid.TabIndex = 5;
            this.lbl_studentid.Text = "StudentId";
            // 
            // txtbox_id
            // 
            this.txtbox_id.Location = new System.Drawing.Point(88, 48);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(121, 20);
            this.txtbox_id.TabIndex = 9;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(32, 51);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "Id";
            // 
            // FrmEditRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 224);
            this.Controls.Add(this.txtbox_id);
            this.Controls.Add(this.combobox_lessonid);
            this.Controls.Add(this.combobox_studentid);
            this.Controls.Add(this.btn_editregister);
            this.Controls.Add(this.lbl_lessonid);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_studentid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_lessonid;
        private System.Windows.Forms.ComboBox combobox_studentid;
        private System.Windows.Forms.Button btn_editregister;
        private System.Windows.Forms.Label lbl_lessonid;
        private System.Windows.Forms.Label lbl_studentid;
        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.Label lbl_id;
    }
}