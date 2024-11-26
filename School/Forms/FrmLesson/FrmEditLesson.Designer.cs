using School.Forms.FrmStudent;

namespace School.Forms.FrmLesson
{
    partial class FrmEditLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditLesson));
            this.txtbox_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_editlesson = new System.Windows.Forms.Button();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_title
            // 
            this.txtbox_title.Location = new System.Drawing.Point(81, 101);
            this.txtbox_title.Name = "txtbox_title";
            this.txtbox_title.Size = new System.Drawing.Size(111, 20);
            this.txtbox_title.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(48, 104);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(27, 13);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Title";
            // 
            // btn_editlesson
            // 
            this.btn_editlesson.Location = new System.Drawing.Point(81, 127);
            this.btn_editlesson.Name = "btn_editlesson";
            this.btn_editlesson.Size = new System.Drawing.Size(111, 23);
            this.btn_editlesson.TabIndex = 2;
            this.btn_editlesson.Text = "Edit";
            this.btn_editlesson.UseVisualStyleBackColor = true;
            // 
            // txtbox_id
            // 
            this.txtbox_id.Location = new System.Drawing.Point(81, 75);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(111, 20);
            this.txtbox_id.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(48, 78);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Id";
            // 
            // FrmEditLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 224);
            this.Controls.Add(this.btn_editlesson);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txtbox_title);
            this.Controls.Add(this.txtbox_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditLesson";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_editlesson;
        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.Label lbl_id;
    }
}