namespace CourseSystem.Forms.Course
{
    partial class FormCourseGetByInstructor
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
            label3 = new Label();
            label1 = new Label();
            txtInstructorSearchByPhone = new TextBox();
            cbInstructorsPhone = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).BeginInit();
            SuspendLayout();
            // 
            // dgvdepartment
            // 
            dgvdepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdepartment.Location = new Point(25, 113);
            dgvdepartment.Name = "dgvdepartment";
            dgvdepartment.ReadOnly = true;
            dgvdepartment.RowHeadersWidth = 51;
            dgvdepartment.Size = new Size(764, 315);
            dgvdepartment.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 36);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 62;
            label3.Text = "Instructor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(507, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 61;
            label1.Text = "Instructor Phone";
            // 
            // txtInstructorSearchByPhone
            // 
            txtInstructorSearchByPhone.Enabled = false;
            txtInstructorSearchByPhone.Location = new Point(507, 60);
            txtInstructorSearchByPhone.Name = "txtInstructorSearchByPhone";
            txtInstructorSearchByPhone.Size = new Size(282, 27);
            txtInstructorSearchByPhone.TabIndex = 60;
            // 
            // cbInstructorsPhone
            // 
            cbInstructorsPhone.FormattingEnabled = true;
            cbInstructorsPhone.Location = new Point(24, 60);
            cbInstructorsPhone.Name = "cbInstructorsPhone";
            cbInstructorsPhone.Size = new Size(285, 28);
            cbInstructorsPhone.TabIndex = 59;
            cbInstructorsPhone.SelectedIndexChanged += cbInstructorsPhone_SelectedIndexChanged;
            // 
            // FormCourseGetByInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtInstructorSearchByPhone);
            Controls.Add(cbInstructorsPhone);
            Controls.Add(dgvdepartment);
            Name = "FormCourseGetByInstructor";
            Text = "FormCourseGetByInstructor";
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdepartment;
        private Label label3;
        private Label label1;
        private TextBox txtInstructorSearchByPhone;
        private ComboBox cbInstructorsPhone;
    }
}