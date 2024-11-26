namespace School
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.datagrid_register = new System.Windows.Forms.DataGridView();
            this.btn_addregister = new System.Windows.Forms.Button();
            this.btn_editregister = new System.Windows.Forms.Button();
            this.btn_deleteregister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_register)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_register
            // 
            this.datagrid_register.AllowUserToAddRows = false;
            this.datagrid_register.AllowUserToDeleteRows = false;
            this.datagrid_register.AllowUserToResizeColumns = false;
            this.datagrid_register.AllowUserToResizeRows = false;
            this.datagrid_register.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid_register.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagrid_register.Location = new System.Drawing.Point(0, 0);
            this.datagrid_register.Name = "datagrid_register";
            this.datagrid_register.ReadOnly = true;
            this.datagrid_register.Size = new System.Drawing.Size(593, 209);
            this.datagrid_register.TabIndex = 0;
            // 
            // btn_addregister
            // 
            this.btn_addregister.Location = new System.Drawing.Point(139, 219);
            this.btn_addregister.Name = "btn_addregister";
            this.btn_addregister.Size = new System.Drawing.Size(101, 33);
            this.btn_addregister.TabIndex = 1;
            this.btn_addregister.Text = "Add";
            this.btn_addregister.UseVisualStyleBackColor = true;
            // 
            // btn_editregister
            // 
            this.btn_editregister.Location = new System.Drawing.Point(246, 219);
            this.btn_editregister.Name = "btn_editregister";
            this.btn_editregister.Size = new System.Drawing.Size(101, 33);
            this.btn_editregister.TabIndex = 1;
            this.btn_editregister.Text = "Edit";
            this.btn_editregister.UseVisualStyleBackColor = true;
            // 
            // btn_deleteregister
            // 
            this.btn_deleteregister.Location = new System.Drawing.Point(353, 219);
            this.btn_deleteregister.Name = "btn_deleteregister";
            this.btn_deleteregister.Size = new System.Drawing.Size(101, 33);
            this.btn_deleteregister.TabIndex = 1;
            this.btn_deleteregister.Text = "Delete";
            this.btn_deleteregister.UseVisualStyleBackColor = true;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 262);
            this.Controls.Add(this.btn_deleteregister);
            this.Controls.Add(this.btn_editregister);
            this.Controls.Add(this.btn_addregister);
            this.Controls.Add(this.datagrid_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_register)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_register;
        private System.Windows.Forms.Button btn_addregister;
        private System.Windows.Forms.Button btn_editregister;
        private System.Windows.Forms.Button btn_deleteregister;
    }
}