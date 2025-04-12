namespace CourseSystem.Forms.Student
{
    partial class FormStudentUpdateDelete
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
            txtPhone = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            cbStudent = new ComboBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(25, 296);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(282, 27);
            txtPhone.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 273);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 38;
            label4.Text = "Phone";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(505, 199);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 27);
            txtLastName.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 176);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 36;
            label3.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(25, 199);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(282, 27);
            txtFName.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 176);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 34;
            label2.Text = "First Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cbStudent);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 125);
            panel1.TabIndex = 43;
            // 
            // cbStudent
            // 
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(33, 58);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(282, 28);
            cbStudent.TabIndex = 35;
            cbStudent.SelectedIndexChanged += cbCourse_SelectedIndexChanged;
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
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.WindowFrame;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(264, 357);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(291, 51);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(482, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(291, 51);
            btnDelete.TabIndex = 120;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormStudentUpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(panel1);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Name = "FormStudentUpdateDelete";
            Text = "FormStudentUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFName;
        private Label label2;
        private Panel panel1;
        private ComboBox cbStudent;
        private Label label5;
        private Button btnUpdate;
        private Button btnDelete;
    }
}