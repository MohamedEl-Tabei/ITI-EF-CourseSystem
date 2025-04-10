namespace CourseSystem.Forms.Course
{
    partial class FormCourseGetAll
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
            dgvInstructors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).BeginInit();
            SuspendLayout();
            // 
            // dgvInstructors
            // 
            dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstructors.Location = new Point(12, 12);
            dgvInstructors.Name = "dgvInstructors";
            dgvInstructors.ReadOnly = true;
            dgvInstructors.RowHeadersWidth = 51;
            dgvInstructors.Size = new Size(776, 384);
            dgvInstructors.TabIndex = 1;
            // 
            // FormCourseGetAll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvInstructors);
            Name = "FormCourseGetAll";
            Text = "FormCourseGetAll";
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInstructors;
    }
}