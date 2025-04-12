namespace CourseSystem.Forms.StudentCourse
{
    partial class FormStudentCourseCreate
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            cbCourse = new ComboBox();
            label1 = new Label();
            cbStudent = new ComboBox();
            label5 = new Label();
            btnCreate = new Button();
            dgvdepartment = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(cbCourse);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbStudent);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 114);
            panel1.TabIndex = 44;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(381, 58);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(282, 28);
            cbCourse.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(381, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 46;
            label1.Text = "Course";
            // 
            // cbStudent
            // 
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(33, 58);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(282, 28);
            cbStudent.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(33, 35);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 34;
            label5.Text = "Student";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkCyan;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(197, 387);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(402, 51);
            btnCreate.TabIndex = 45;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvdepartment
            // 
            dgvdepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdepartment.Location = new Point(12, 6);
            dgvdepartment.Name = "dgvdepartment";
            dgvdepartment.ReadOnly = true;
            dgvdepartment.RowHeadersWidth = 51;
            dgvdepartment.Size = new Size(776, 271);
            dgvdepartment.TabIndex = 46;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormStudentCourseCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvdepartment);
            Controls.Add(btnCreate);
            Controls.Add(panel1);
            Name = "FormStudentCourseCreate";
            Text = "FormStudentCourseCreate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbStudent;
        private Label label5;
        private Button btnCreate;
        private ComboBox cbCourse;
        private Label label1;
        private DataGridView dgvdepartment;
        private ErrorProvider errorProvider1;
    }
}