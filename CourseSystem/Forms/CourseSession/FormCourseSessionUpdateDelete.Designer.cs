namespace CourseSystem.Forms.CourseSession
{
    partial class FormCourseSessionUpdateDelete
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
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cbInstructorsPhone = new ComboBox();
            cbCourse = new ComboBox();
            dgvdepartment = new DataGridView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LightSeaGreen;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(206, 387);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(402, 51);
            btnCreate.TabIndex = 98;
            btnCreate.Text = "Update";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 317);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 97;
            label4.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(504, 344);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(285, 27);
            dateTimePicker1.TabIndex = 96;
            // 
            // txtName
            // 
            txtName.Location = new Point(13, 344);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 95;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 263);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 94;
            label1.Text = "Course";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 262);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 93;
            label3.Text = "Instructor";
            // 
            // cbInstructorsPhone
            // 
            cbInstructorsPhone.FormattingEnabled = true;
            cbInstructorsPhone.Location = new Point(504, 286);
            cbInstructorsPhone.Name = "cbInstructorsPhone";
            cbInstructorsPhone.Size = new Size(285, 28);
            cbInstructorsPhone.TabIndex = 92;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(13, 286);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(282, 28);
            cbCourse.TabIndex = 91;
            // 
            // dgvdepartment
            // 
            dgvdepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdepartment.Location = new Point(11, 81);
            dgvdepartment.Name = "dgvdepartment";
            dgvdepartment.ReadOnly = true;
            dgvdepartment.RowHeadersWidth = 51;
            dgvdepartment.Size = new Size(776, 178);
            dgvdepartment.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 13);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 100;
            label2.Text = "Course Session ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 28);
            comboBox1.TabIndex = 99;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 321);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 101;
            label5.Text = "Title";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(496, 24);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(291, 51);
            btnDelete.TabIndex = 102;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormCourseSessionUpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(cbInstructorsPhone);
            Controls.Add(cbCourse);
            Controls.Add(dgvdepartment);
            Name = "FormCourseSessionUpdateDelete";
            Text = "FormCourseSessionUpdate";
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtName;
        private Label label1;
        private Label label3;
        private ComboBox cbInstructorsPhone;
        private ComboBox cbCourse;
        private DataGridView dgvdepartment;
        private Label label2;
        private ComboBox comboBox1;
        private Label label5;
        private Button btnDelete;
    }
}