namespace CourseSystem.Forms.Course
{
    partial class FormCourseGetByDepartment
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
            cbDepartment = new ComboBox();
            label5 = new Label();
            dgvInstructors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).BeginInit();
            SuspendLayout();
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(12, 35);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(282, 28);
            cbDepartment.TabIndex = 27;
            cbDepartment.SelectedIndexChanged += cbDepartment_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 13);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 26;
            label5.Text = "Department";
            // 
            // dgvInstructors
            // 
            dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstructors.Location = new Point(12, 69);
            dgvInstructors.Name = "dgvInstructors";
            dgvInstructors.ReadOnly = true;
            dgvInstructors.RowHeadersWidth = 51;
            dgvInstructors.Size = new Size(776, 369);
            dgvInstructors.TabIndex = 25;
            // 
            // FormCourseGetByDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbDepartment);
            Controls.Add(label5);
            Controls.Add(dgvInstructors);
            Name = "FormCourseGetByDepartment";
            Text = "FormCourseGetByDepartment";
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDepartment;
        private Label label5;
        private DataGridView dgvInstructors;
    }
}