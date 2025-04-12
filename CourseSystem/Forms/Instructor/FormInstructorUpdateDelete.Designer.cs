namespace CourseSystem.Forms.Instructor
{
    partial class FormInstructorUpdateDelete
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
            cbInstructorsPhone = new ComboBox();
            txtInstructorSearchByPhone = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtFName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbDepartment = new ComboBox();
            btnUpdate = new Button();
            errorProvider = new ErrorProvider(components);
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cbInstructorsPhone
            // 
            cbInstructorsPhone.FormattingEnabled = true;
            cbInstructorsPhone.Location = new Point(15, 86);
            cbInstructorsPhone.Name = "cbInstructorsPhone";
            cbInstructorsPhone.Size = new Size(204, 28);
            cbInstructorsPhone.TabIndex = 0;
            cbInstructorsPhone.SelectedIndexChanged += cbInstructorsPhone_SelectedIndexChanged;
            // 
            // txtInstructorSearchByPhone
            // 
            txtInstructorSearchByPhone.Location = new Point(233, 85);
            txtInstructorSearchByPhone.Name = "txtInstructorSearchByPhone";
            txtInstructorSearchByPhone.Size = new Size(204, 27);
            txtInstructorSearchByPhone.TabIndex = 3;
            txtInstructorSearchByPhone.TextChanged += txtInstructorSearchByPhone_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(233, 62);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Phone";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtInstructorSearchByPhone);
            panel1.Controls.Add(cbInstructorsPhone);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 150);
            panel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDarkDark;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(15, 62);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 15;
            label7.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDarkDark;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(454, 62);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 15;
            label6.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(454, 86);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(323, 27);
            txtId.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 189);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "First Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(12, 212);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(282, 27);
            txtFName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(492, 212);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 27);
            txtLastName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 189);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 309);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(282, 27);
            txtPhone.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 286);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(492, 286);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 12;
            label5.Text = "Department";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(492, 308);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(282, 28);
            cbDepartment.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSeaGreen;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(12, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(402, 51);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(497, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(291, 51);
            btnDelete.TabIndex = 119;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormInstructorUpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(cbDepartment);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormInstructorUpdateDelete";
            Text = "FormInstructorUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbInstructorsPhone;
        private TextBox txtInstructorSearchByPhone;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtFName;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private Label label5;
        private ComboBox cbDepartment;
        private Button btnUpdate;
        private Label label7;
        private Label label6;
        private TextBox txtId;
        private ErrorProvider errorProvider;
        private Button btnDelete;
    }
}