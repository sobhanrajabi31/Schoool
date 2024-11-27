namespace School.Forms.FrmClass
{
    partial class FrmAddClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddClass));
            this.txtbox_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_addcapacity = new System.Windows.Forms.Button();
            this.txtbox_capacity = new System.Windows.Forms.TextBox();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_title
            // 
            this.txtbox_title.Location = new System.Drawing.Point(92, 75);
            this.txtbox_title.Name = "txtbox_title";
            this.txtbox_title.Size = new System.Drawing.Size(111, 20);
            this.txtbox_title.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(38, 78);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(27, 13);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Title";
            // 
            // btn_addcapacity
            // 
            this.btn_addcapacity.Location = new System.Drawing.Point(92, 127);
            this.btn_addcapacity.Name = "btn_addcapacity";
            this.btn_addcapacity.Size = new System.Drawing.Size(111, 23);
            this.btn_addcapacity.TabIndex = 2;
            this.btn_addcapacity.Text = "Add";
            this.btn_addcapacity.UseVisualStyleBackColor = true;
            // 
            // txtbox_capacity
            // 
            this.txtbox_capacity.Location = new System.Drawing.Point(92, 101);
            this.txtbox_capacity.Name = "txtbox_capacity";
            this.txtbox_capacity.Size = new System.Drawing.Size(111, 20);
            this.txtbox_capacity.TabIndex = 0;
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.Location = new System.Drawing.Point(38, 104);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(48, 13);
            this.lbl_capacity.TabIndex = 1;
            this.lbl_capacity.Text = "Capacity";
            // 
            // FrmAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 224);
            this.Controls.Add(this.btn_addcapacity);
            this.Controls.Add(this.lbl_capacity);
            this.Controls.Add(this.txtbox_capacity);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txtbox_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddClass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_addcapacity;
        private System.Windows.Forms.TextBox txtbox_capacity;
        private System.Windows.Forms.Label lbl_capacity;
    }
}