namespace School
{
    partial class FrmLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoad));
            this.btn_open = new System.Windows.Forms.Button();
            this.combobox_framework = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(17, 71);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(157, 38);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Load";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // combobox_framework
            // 
            this.combobox_framework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_framework.FormattingEnabled = true;
            this.combobox_framework.Items.AddRange(new object[] {
            "EF",
            "Ado.NET",
            "OnMemory"});
            this.combobox_framework.Location = new System.Drawing.Point(17, 44);
            this.combobox_framework.Name = "combobox_framework";
            this.combobox_framework.Size = new System.Drawing.Size(157, 21);
            this.combobox_framework.TabIndex = 4;
            this.combobox_framework.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Launch With:";
            // 
            // FrmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_framework);
            this.Controls.Add(this.btn_open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ComboBox combobox_framework;
        private System.Windows.Forms.Label label1;
    }
}

