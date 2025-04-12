namespace CourseSystem.Forms.CourseSessionAttendance
{
    partial class FormCourseSessionAttendanceCreate
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
            btnCreate = new Button();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbCourse = new ComboBox();
            dgvdepartment = new DataGridView();
            label4 = new Label();
            cbStudent = new ComboBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LightSeaGreen;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(206, 401);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(402, 51);
            btnCreate.TabIndex = 99;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(13, 358);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 96;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 335);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 95;
            label2.Text = "Notes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 277);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 94;
            label1.Text = "Course Session ";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(13, 300);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(282, 28);
            cbCourse.TabIndex = 91;
            // 
            // dgvdepartment
            // 
            dgvdepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdepartment.Location = new Point(11, 26);
            dgvdepartment.Name = "dgvdepartment";
            dgvdepartment.ReadOnly = true;
            dgvdepartment.RowHeadersWidth = 51;
            dgvdepartment.Size = new Size(776, 247);
            dgvdepartment.TabIndex = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 335);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 100;
            label4.Text = "Grades";
            // 
            // cbStudent
            // 
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(504, 300);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(282, 28);
            cbStudent.TabIndex = 103;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(504, 277);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 102;
            label5.Text = "Student";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(504, 358);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(282, 27);
            numericUpDown1.TabIndex = 104;
            // 
            // FormCourseSessionAttendanceCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(numericUpDown1);
            Controls.Add(cbStudent);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCreate);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbCourse);
            Controls.Add(dgvdepartment);
            Name = "FormCourseSessionAttendanceCreate";
            Text = "FormCourseSessionAttendanceCreate";
            Load += FormCourseSessionAttendanceCreate_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private ComboBox cbCourse;
        private DataGridView dgvdepartment;
        private Label label4;
        private ComboBox cbStudent;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}