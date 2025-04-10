namespace CourseSystem.Forms.Course
{
    partial class FormCourseCreate
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
            cbDepartment = new ComboBox();
            label5 = new Label();
            btnCreate = new Button();
            txtDuration = new TextBox();
            label6 = new Label();
            txtName = new TextBox();
            label7 = new Label();
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
            dgvdepartment.Size = new Size(764, 123);
            dgvdepartment.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 222);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 71;
            label3.Text = "Instructor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 222);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 70;
            label1.Text = "Instructor Phone";
            // 
            // txtInstructorSearchByPhone
            // 
            txtInstructorSearchByPhone.Enabled = false;
            txtInstructorSearchByPhone.Location = new Point(495, 246);
            txtInstructorSearchByPhone.Name = "txtInstructorSearchByPhone";
            txtInstructorSearchByPhone.Size = new Size(282, 27);
            txtInstructorSearchByPhone.TabIndex = 69;
            // 
            // cbInstructorsPhone
            // 
            cbInstructorsPhone.FormattingEnabled = true;
            cbInstructorsPhone.Location = new Point(12, 246);
            cbInstructorsPhone.Name = "cbInstructorsPhone";
            cbInstructorsPhone.Size = new Size(285, 28);
            cbInstructorsPhone.TabIndex = 68;
            cbInstructorsPhone.SelectedIndexChanged += cbInstructorsPhone_SelectedIndexChanged_1;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(12, 313);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(282, 28);
            cbDepartment.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 291);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 72;
            label5.Text = "Department";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LightSeaGreen;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(182, 387);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(402, 51);
            btnCreate.TabIndex = 82;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(494, 169);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(282, 27);
            txtDuration.TabIndex = 77;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 146);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 76;
            label6.Text = "Duration";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 178);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 75;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 155);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 74;
            label7.Text = "Name";
            // 
            // FormCourseCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(txtDuration);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(cbDepartment);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtInstructorSearchByPhone);
            Controls.Add(cbInstructorsPhone);
            Controls.Add(dgvdepartment);
            Name = "FormCourseCreate";
            Text = "FormCourseCreate";
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
        private ComboBox cbDepartment;
        private Label label5;
        private Button btnCreate;
        private TextBox txtDuration;
        private Label label6;
        private TextBox txtName;
        private Label label7;
    }
}