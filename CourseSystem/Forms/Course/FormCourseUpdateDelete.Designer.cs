namespace CourseSystem.Forms.Course
{
    partial class FormCourseUpdateDelete
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
            btnUpdate = new Button();
            label6 = new Label();
            txtId = new TextBox();
            panel1 = new Panel();
            cbCourse = new ComboBox();
            label5 = new Label();
            txtDuration = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label7 = new Label();
            cbDepartment = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtInstructorSearchByPhone = new TextBox();
            cbInstructorsPhone = new ComboBox();
            btnDelete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.WindowFrame;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(485, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(291, 51);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 125);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 47;
            label6.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(20, 148);
            txtId.Name = "txtId";
            txtId.Size = new Size(762, 27);
            txtId.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(cbCourse);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-13, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 107);
            panel1.TabIndex = 42;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(33, 58);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(282, 28);
            cbCourse.TabIndex = 35;
            cbCourse.SelectedIndexChanged += cbCourse_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(33, 35);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 34;
            label5.Text = "Course";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(494, 204);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(282, 27);
            txtDuration.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 181);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 86;
            label1.Text = "Duration";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 213);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 190);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 84;
            label7.Text = "Name";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(12, 348);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(282, 28);
            cbDepartment.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 326);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 82;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 257);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 81;
            label3.Text = "Instructor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 257);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 80;
            label4.Text = "Instructor Phone";
            // 
            // txtInstructorSearchByPhone
            // 
            txtInstructorSearchByPhone.Enabled = false;
            txtInstructorSearchByPhone.Location = new Point(495, 281);
            txtInstructorSearchByPhone.Name = "txtInstructorSearchByPhone";
            txtInstructorSearchByPhone.Size = new Size(282, 27);
            txtInstructorSearchByPhone.TabIndex = 79;
            // 
            // cbInstructorsPhone
            // 
            cbInstructorsPhone.FormattingEnabled = true;
            cbInstructorsPhone.Location = new Point(12, 281);
            cbInstructorsPhone.Name = "cbInstructorsPhone";
            cbInstructorsPhone.Size = new Size(285, 28);
            cbInstructorsPhone.TabIndex = 78;
            cbInstructorsPhone.SelectedIndexChanged += cbInstructorsPhone_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(485, 393);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(291, 51);
            btnDelete.TabIndex = 88;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormCourseUpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtDuration);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(cbDepartment);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtInstructorSearchByPhone);
            Controls.Add(cbInstructorsPhone);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(panel1);
            Name = "FormCourseUpdateDelete";
            Text = "FormCourseUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label6;
        private TextBox txtId;
        private Panel panel1;
        private ComboBox cbCourse;
        private Label label5;
        private TextBox txtDuration;
        private Label label1;
        private TextBox txtName;
        private Label label7;
        private ComboBox cbDepartment;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtInstructorSearchByPhone;
        private ComboBox cbInstructorsPhone;
        private Button btnDelete;
    }
}