namespace CourseSystem.Forms.CourseSessionAttendance
{
    partial class FormCourseSessionAttendanceGet
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
            dgvdepartment = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).BeginInit();
            SuspendLayout();
            // 
            // dgvdepartment
            // 
            dgvdepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdepartment.Location = new Point(12, 12);
            dgvdepartment.Name = "dgvdepartment";
            dgvdepartment.ReadOnly = true;
            dgvdepartment.RowHeadersWidth = 51;
            dgvdepartment.Size = new Size(776, 288);
            dgvdepartment.TabIndex = 3;
            // 
            // FormCourseSessionAttendanceGet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvdepartment);
            Name = "FormCourseSessionAttendanceGet";
            Text = "FormCourseSessionAttendanceGet";
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvdepartment;
    }
}