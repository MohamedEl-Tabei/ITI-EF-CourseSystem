namespace CourseSystem.Forms.CourseSession
{
    partial class FormCourseSessionCreate
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
            cbCourse = new ComboBox();
            label3 = new Label();
            cbInstructorsPhone = new ComboBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnCreate = new Button();
            dateTimePicker1 = new DateTimePicker();
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
            dgvdepartment.Size = new Size(776, 247);
            dgvdepartment.TabIndex = 4;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(14, 286);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(282, 28);
            cbCourse.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 262);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 83;
            label3.Text = "Instructor";
            // 
            // cbInstructorsPhone
            // 
            cbInstructorsPhone.FormattingEnabled = true;
            cbInstructorsPhone.Location = new Point(505, 286);
            cbInstructorsPhone.Name = "cbInstructorsPhone";
            cbInstructorsPhone.Size = new Size(285, 28);
            cbInstructorsPhone.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 263);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 84;
            label1.Text = "Course";
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 344);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 321);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 85;
            label2.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 317);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 88;
            label4.Text = "Date";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LightSeaGreen;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(207, 387);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(402, 51);
            btnCreate.TabIndex = 89;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(505, 344);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(285, 27);
            dateTimePicker1.TabIndex = 87;
            // 
            // FormCourseSessionCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(cbInstructorsPhone);
            Controls.Add(cbCourse);
            Controls.Add(dgvdepartment);
            Name = "FormCourseSessionCreate";
            Text = "FormCourseSessionCreate";
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdepartment;
        private ComboBox cbCourse;
        private Label label3;
        private ComboBox cbInstructorsPhone;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label4;
        private Button btnCreate;
        private DateTimePicker dateTimePicker1;
    }
}