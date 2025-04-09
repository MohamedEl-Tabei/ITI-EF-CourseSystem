namespace CourseSystem.Forms.Instructor
{
    partial class FormInstructorCreate
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
            dgvInstructors = new DataGridView();
            btnCreate = new Button();
            cbDepartment = new ComboBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFName = new TextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // dgvInstructors
            // 
            dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstructors.Location = new Point(12, 12);
            dgvInstructors.Name = "dgvInstructors";
            dgvInstructors.ReadOnly = true;
            dgvInstructors.RowHeadersWidth = 51;
            dgvInstructors.Size = new Size(776, 115);
            dgvInstructors.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkCyan;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(198, 367);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(402, 51);
            btnCreate.TabIndex = 23;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(502, 288);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(282, 28);
            cbDepartment.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 266);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 21;
            label5.Text = "Department";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(22, 289);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(282, 27);
            txtPhone.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 266);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 19;
            label4.Text = "Phone";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(502, 192);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 27);
            txtLastName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 169);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 17;
            label3.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(22, 192);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(282, 27);
            txtFName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 169);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 15;
            label2.Text = "First Name";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // FormInstructorCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(cbDepartment);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Controls.Add(dgvInstructors);
            Name = "FormInstructorCreate";
            Text = "FormInstructorCreate";
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInstructors;
        private Button btnCreate;
        private ComboBox cbDepartment;
        private Label label5;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFName;
        private Label label2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}