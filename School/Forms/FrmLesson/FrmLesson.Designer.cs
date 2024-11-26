namespace School
{
    partial class FrmLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLesson));
            this.datagrid_lesson = new System.Windows.Forms.DataGridView();
            this.btn_addlesson = new System.Windows.Forms.Button();
            this.btn_editlesson = new System.Windows.Forms.Button();
            this.btn_deletelesson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_lesson)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_lesson
            // 
            this.datagrid_lesson.AllowUserToAddRows = false;
            this.datagrid_lesson.AllowUserToDeleteRows = false;
            this.datagrid_lesson.AllowUserToResizeColumns = false;
            this.datagrid_lesson.AllowUserToResizeRows = false;
            this.datagrid_lesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid_lesson.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagrid_lesson.Location = new System.Drawing.Point(0, 0);
            this.datagrid_lesson.Name = "datagrid_lesson";
            this.datagrid_lesson.ReadOnly = true;
            this.datagrid_lesson.Size = new System.Drawing.Size(593, 209);
            this.datagrid_lesson.TabIndex = 0;
            // 
            // btn_addlesson
            // 
            this.btn_addlesson.Location = new System.Drawing.Point(139, 219);
            this.btn_addlesson.Name = "btn_addlesson";
            this.btn_addlesson.Size = new System.Drawing.Size(101, 33);
            this.btn_addlesson.TabIndex = 1;
            this.btn_addlesson.Text = "Add";
            this.btn_addlesson.UseVisualStyleBackColor = true;
            // 
            // btn_editlesson
            // 
            this.btn_editlesson.Location = new System.Drawing.Point(246, 219);
            this.btn_editlesson.Name = "btn_editlesson";
            this.btn_editlesson.Size = new System.Drawing.Size(101, 33);
            this.btn_editlesson.TabIndex = 1;
            this.btn_editlesson.Text = "Edit";
            this.btn_editlesson.UseVisualStyleBackColor = true;
            // 
            // btn_deletelesson
            // 
            this.btn_deletelesson.Location = new System.Drawing.Point(353, 219);
            this.btn_deletelesson.Name = "btn_deletelesson";
            this.btn_deletelesson.Size = new System.Drawing.Size(101, 33);
            this.btn_deletelesson.TabIndex = 1;
            this.btn_deletelesson.Text = "Delete";
            this.btn_deletelesson.UseVisualStyleBackColor = true;
            // 
            // FrmLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 262);
            this.Controls.Add(this.btn_deletelesson);
            this.Controls.Add(this.btn_editlesson);
            this.Controls.Add(this.btn_addlesson);
            this.Controls.Add(this.datagrid_lesson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLesson";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLesson";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_lesson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_lesson;
        private System.Windows.Forms.Button btn_addlesson;
        private System.Windows.Forms.Button btn_editlesson;
        private System.Windows.Forms.Button btn_deletelesson;
    }
}