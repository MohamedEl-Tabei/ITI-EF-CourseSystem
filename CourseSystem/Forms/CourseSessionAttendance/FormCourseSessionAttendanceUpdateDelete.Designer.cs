namespace CourseSystem.Forms.CourseSessionAttendance
{
    partial class FormCourseSessionAttendanceUpdateDelete
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
            numericUpDown1 = new NumericUpDown();
            cbStudent = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            btnCreate = new Button();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbCourse = new ComboBox();
            dgvdepartment = new DataGridView();
            label3 = new Label();
            comboBox1 = new ComboBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(505, 344);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(282, 27);
            numericUpDown1.TabIndex = 114;
            // 
            // cbStudent
            // 
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(505, 286);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(282, 28);
            cbStudent.TabIndex = 113;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(505, 263);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 112;
            label5.Text = "Student";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 321);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 111;
            label4.Text = "Grades";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LightSeaGreen;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(207, 387);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(402, 51);
            btnCreate.TabIndex = 110;
            btnCreate.Text = "Update";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 344);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 109;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 321);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 108;
            label2.Text = "Notes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 263);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 107;
            label1.Text = "Course Session ";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(14, 286);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(282, 28);
            cbCourse.TabIndex = 106;
            // 
            // dgvdepartment
            // 
            dgvdepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdepartment.Location = new Point(12, 66);
            dgvdepartment.Name = "dgvdepartment";
            dgvdepartment.ReadOnly = true;
            dgvdepartment.RowHeadersWidth = 51;
            dgvdepartment.Size = new Size(776, 193);
            dgvdepartment.TabIndex = 105;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 9);
            label3.Name = "label3";
            label3.Size = new Size(204, 20);
            label3.TabIndex = 116;
            label3.Text = "Course Session Attendance Id";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 28);
            comboBox1.TabIndex = 115;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(497, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(291, 51);
            btnDelete.TabIndex = 117;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormCourseSessionAttendanceUpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(comboBox1);
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
            Name = "FormCourseSessionAttendanceUpdateDelete";
            Text = "FormCourseSessionAttendanceUpdate";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private ComboBox cbStudent;
        private Label label5;
        private Label label4;
        private Button btnCreate;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private ComboBox cbCourse;
        private DataGridView dgvdepartment;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnDelete;
    }
}