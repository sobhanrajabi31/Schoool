using School.Forms.FrmStudent;

namespace School.Forms.FrmLesson
{
    partial class FrmAddLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddLesson));
            this.txtbox_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_addlesson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_title
            // 
            this.txtbox_title.Location = new System.Drawing.Point(81, 88);
            this.txtbox_title.Name = "txtbox_title";
            this.txtbox_title.Size = new System.Drawing.Size(111, 20);
            this.txtbox_title.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(48, 91);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(27, 13);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Title";
            // 
            // btn_addlesson
            // 
            this.btn_addlesson.Location = new System.Drawing.Point(81, 114);
            this.btn_addlesson.Name = "btn_addlesson";
            this.btn_addlesson.Size = new System.Drawing.Size(111, 23);
            this.btn_addlesson.TabIndex = 2;
            this.btn_addlesson.Text = "Add";
            this.btn_addlesson.UseVisualStyleBackColor = true;
            // 
            // FrmAddLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 224);
            this.Controls.Add(this.btn_addlesson);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txtbox_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddLesson";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddLesson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_addlesson;
    }
}