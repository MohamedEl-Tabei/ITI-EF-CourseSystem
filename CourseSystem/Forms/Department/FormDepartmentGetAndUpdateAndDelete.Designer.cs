namespace CourseSystem.Forms.Department
{
    partial class FormDepartmentGetAndUpdateAndDelete
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
            label6 = new Label();
            txtId = new TextBox();
            txtlocation = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            cbDepartment = new ComboBox();
            label5 = new Label();
            txtInstructorSearchByPhone = new TextBox();
            cbInstructorsPhone = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            btnUpdate = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 156);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 33;
            label6.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(20, 179);
            txtId.Name = "txtId";
            txtId.Size = new Size(762, 27);
            txtId.TabIndex = 25;
            // 
            // txtlocation
            // 
            txtlocation.Location = new Point(500, 242);
            txtlocation.Name = "txtlocation";
            txtlocation.Size = new Size(282, 27);
            txtlocation.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(500, 219);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 29;
            label4.Text = "Location";
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 242);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 219);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 27;
            label2.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cbDepartment);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-13, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 132);
            panel1.TabIndex = 26;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(33, 58);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(282, 28);
            cbDepartment.TabIndex = 35;
            cbDepartment.SelectedIndexChanged += cbDepartment_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(33, 35);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 34;
            label5.Text = "Department";
            // 
            // txtInstructorSearchByPhone
            // 
            txtInstructorSearchByPhone.Enabled = false;
            txtInstructorSearchByPhone.Location = new Point(498, 302);
            txtInstructorSearchByPhone.Name = "txtInstructorSearchByPhone";
            txtInstructorSearchByPhone.Size = new Size(282, 27);
            txtInstructorSearchByPhone.TabIndex = 35;
            // 
            // cbInstructorsPhone
            // 
            cbInstructorsPhone.FormattingEnabled = true;
            cbInstructorsPhone.Location = new Point(15, 302);
            cbInstructorsPhone.Name = "cbInstructorsPhone";
            cbInstructorsPhone.Size = new Size(285, 28);
            cbInstructorsPhone.TabIndex = 34;
            cbInstructorsPhone.SelectedIndexChanged += cbInstructorsPhone_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(498, 278);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 38;
            label1.Text = "Manager Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 278);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 39;
            label3.Text = "Manager Name";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.WindowFrame;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(199, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(402, 51);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(504, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(291, 51);
            btnDelete.TabIndex = 118;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormDepartmentGetAndUpdateAndDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtInstructorSearchByPhone);
            Controls.Add(cbInstructorsPhone);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(txtlocation);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormDepartmentGetAndUpdateAndDelete";
            Text = "FormDepartmentGetAndUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtId;
        private TextBox txtlocation;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private TextBox txtInstructorSearchByPhone;
        private ComboBox cbInstructorsPhone;
        private Label label1;
        private Label label3;
        private ComboBox cbDepartment;
        private Button btnUpdate;
        private ErrorProvider errorProvider1;
        private Button btnDelete;
    }
}