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
            this.lbl_open = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.radiobtn_nodb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radiobtn_ado
            // 
            this.radiobtn_ado.AutoSize = true;
            this.radiobtn_ado.Checked = true;
            this.radiobtn_ado.Location = new System.Drawing.Point(62, 35);
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
            this.radiobtn_ef.Location = new System.Drawing.Point(62, 58);
            this.radiobtn_ef.Name = "radiobtn_ef";
            this.radiobtn_ef.Size = new System.Drawing.Size(38, 17);
            this.radiobtn_ef.TabIndex = 1;
            this.radiobtn_ef.Text = "EF";
            this.radiobtn_ef.UseVisualStyleBackColor = true;
            // 
            // lbl_open
            // 
            this.lbl_open.AutoSize = true;
            this.lbl_open.Location = new System.Drawing.Point(66, 13);
            this.lbl_open.Name = "lbl_open";
            this.lbl_open.Size = new System.Drawing.Size(58, 13);
            this.lbl_open.TabIndex = 2;
            this.lbl_open.Text = ":بازکردن با";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(17, 106);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(157, 38);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "باز کردن";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // radiobtn_nodb
            // 
            this.radiobtn_nodb.AutoSize = true;
            this.radiobtn_nodb.Location = new System.Drawing.Point(62, 81);
            this.radiobtn_nodb.Name = "radiobtn_nodb";
            this.radiobtn_nodb.Size = new System.Drawing.Size(57, 17);
            this.radiobtn_nodb.TabIndex = 1;
            this.radiobtn_nodb.Text = "No DB";
            this.radiobtn_nodb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 156);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lbl_open);
            this.Controls.Add(this.radiobtn_nodb);
            this.Controls.Add(this.radiobtn_ef);
            this.Controls.Add(this.radiobtn_ado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtn_ado;
        private System.Windows.Forms.RadioButton radiobtn_ef;
        private System.Windows.Forms.Label lbl_open;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.RadioButton radiobtn_nodb;
    }
}

