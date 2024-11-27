namespace School.Forms.FrmStudent
{
    partial class FrmStudent
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
            this.datagrid_student = new System.Windows.Forms.DataGridView();
            this.btn_addstudent = new System.Windows.Forms.Button();
            this.btn_editstudent = new System.Windows.Forms.Button();
            this.btn_deletestudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_student)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_student
            // 
            this.datagrid_student.AllowUserToAddRows = false;
            this.datagrid_student.AllowUserToDeleteRows = false;
            this.datagrid_student.AllowUserToResizeColumns = false;
            this.datagrid_student.AllowUserToResizeRows = false;
            this.datagrid_student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datagrid_student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagrid_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagrid_student.Location = new System.Drawing.Point(0, 0);
            this.datagrid_student.MultiSelect = false;
            this.datagrid_student.Name = "datagrid_student";
            this.datagrid_student.ReadOnly = true;
            this.datagrid_student.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_student.ShowCellErrors = false;
            this.datagrid_student.ShowCellToolTips = false;
            this.datagrid_student.ShowEditingIcon = false;
            this.datagrid_student.ShowRowErrors = false;
            this.datagrid_student.Size = new System.Drawing.Size(593, 209);
            this.datagrid_student.TabIndex = 0;
            this.datagrid_student.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_student_CellDoubleClick);
            // 
            // btn_addstudent
            // 
            this.btn_addstudent.Location = new System.Drawing.Point(139, 219);
            this.btn_addstudent.Name = "btn_addstudent";
            this.btn_addstudent.Size = new System.Drawing.Size(101, 33);
            this.btn_addstudent.TabIndex = 1;
            this.btn_addstudent.Text = "Add";
            this.btn_addstudent.UseVisualStyleBackColor = true;
            this.btn_addstudent.Click += new System.EventHandler(this.Buttons);
            // 
            // btn_editstudent
            // 
            this.btn_editstudent.Location = new System.Drawing.Point(246, 219);
            this.btn_editstudent.Name = "btn_editstudent";
            this.btn_editstudent.Size = new System.Drawing.Size(101, 33);
            this.btn_editstudent.TabIndex = 1;
            this.btn_editstudent.Text = "Edit";
            this.btn_editstudent.UseVisualStyleBackColor = true;
            this.btn_editstudent.Click += new System.EventHandler(this.Buttons);
            // 
            // btn_deletestudent
            // 
            this.btn_deletestudent.Location = new System.Drawing.Point(353, 219);
            this.btn_deletestudent.Name = "btn_deletestudent";
            this.btn_deletestudent.Size = new System.Drawing.Size(101, 33);
            this.btn_deletestudent.TabIndex = 1;
            this.btn_deletestudent.Text = "Delete";
            this.btn_deletestudent.UseVisualStyleBackColor = true;
            this.btn_deletestudent.Click += new System.EventHandler(this.Buttons);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 262);
            this.Controls.Add(this.btn_deletestudent);
            this.Controls.Add(this.btn_editstudent);
            this.Controls.Add(this.btn_addstudent);
            this.Controls.Add(this.datagrid_student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_student;
        private System.Windows.Forms.Button btn_addstudent;
        private System.Windows.Forms.Button btn_editstudent;
        private System.Windows.Forms.Button btn_deletestudent;
    }
}