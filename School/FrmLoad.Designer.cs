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
            this.radiobtn_ado = new System.Windows.Forms.RadioButton();
            this.radiobtn_ef = new System.Windows.Forms.RadioButton();
            this.btn_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radiobtn_ado
            // 
            this.radiobtn_ado.AutoSize = true;
            this.radiobtn_ado.Checked = true;
            this.radiobtn_ado.Location = new System.Drawing.Point(62, 34);
            this.radiobtn_ado.Name = "radiobtn_ado";
            this.radiobtn_ado.Size = new System.Drawing.Size(66, 17);
            this.radiobtn_ado.TabIndex = 0;
            this.radiobtn_ado.TabStop = true;
            this.radiobtn_ado.Text = "Adio.Net";
            this.radiobtn_ado.UseVisualStyleBackColor = true;
            // 
            // radiobtn_ef
            // 
            this.radiobtn_ef.AutoSize = true;
            this.radiobtn_ef.Location = new System.Drawing.Point(62, 57);
            this.radiobtn_ef.Name = "radiobtn_ef";
            this.radiobtn_ef.Size = new System.Drawing.Size(38, 17);
            this.radiobtn_ef.TabIndex = 1;
            this.radiobtn_ef.Text = "EF";
            this.radiobtn_ef.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(17, 84);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(157, 38);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // FrmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 156);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.radiobtn_ef);
            this.Controls.Add(this.radiobtn_ado);
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

        private System.Windows.Forms.RadioButton radiobtn_ado;
        private System.Windows.Forms.RadioButton radiobtn_ef;
        private System.Windows.Forms.Button btn_open;
    }
}

