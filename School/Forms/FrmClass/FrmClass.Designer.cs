namespace School
{
    partial class FrmClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClass));
            this.datagrid_class = new System.Windows.Forms.DataGridView();
            this.btn_addclass = new System.Windows.Forms.Button();
            this.btn_editclass = new System.Windows.Forms.Button();
            this.btn_deleteclass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_class
            // 
            this.datagrid_class.AllowUserToAddRows = false;
            this.datagrid_class.AllowUserToDeleteRows = false;
            this.datagrid_class.AllowUserToResizeColumns = false;
            this.datagrid_class.AllowUserToResizeRows = false;
            this.datagrid_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagrid_class.Location = new System.Drawing.Point(0, 0);
            this.datagrid_class.Name = "datagrid_class";
            this.datagrid_class.ReadOnly = true;
            this.datagrid_class.Size = new System.Drawing.Size(593, 209);
            this.datagrid_class.TabIndex = 0;
            // 
            // btn_addclass
            // 
            this.btn_addclass.Location = new System.Drawing.Point(139, 219);
            this.btn_addclass.Name = "btn_addclass";
            this.btn_addclass.Size = new System.Drawing.Size(101, 33);
            this.btn_addclass.TabIndex = 1;
            this.btn_addclass.Text = "Add";
            this.btn_addclass.UseVisualStyleBackColor = true;
            // 
            // btn_editclass
            // 
            this.btn_editclass.Location = new System.Drawing.Point(246, 219);
            this.btn_editclass.Name = "btn_editclass";
            this.btn_editclass.Size = new System.Drawing.Size(101, 33);
            this.btn_editclass.TabIndex = 1;
            this.btn_editclass.Text = "Edit";
            this.btn_editclass.UseVisualStyleBackColor = true;
            // 
            // btn_deleteclass
            // 
            this.btn_deleteclass.Location = new System.Drawing.Point(353, 219);
            this.btn_deleteclass.Name = "btn_deleteclass";
            this.btn_deleteclass.Size = new System.Drawing.Size(101, 33);
            this.btn_deleteclass.TabIndex = 1;
            this.btn_deleteclass.Text = "Delete";
            this.btn_deleteclass.UseVisualStyleBackColor = true;
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 262);
            this.Controls.Add(this.btn_deleteclass);
            this.Controls.Add(this.btn_editclass);
            this.Controls.Add(this.btn_addclass);
            this.Controls.Add(this.datagrid_class);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClass";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_class)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_class;
        private System.Windows.Forms.Button btn_addclass;
        private System.Windows.Forms.Button btn_editclass;
        private System.Windows.Forms.Button btn_deleteclass;
    }
}