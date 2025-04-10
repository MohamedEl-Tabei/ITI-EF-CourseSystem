namespace CourseSystem.Forms.Department
{
    partial class FormDepartmentCreate
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
            label3 = new Label();
            label1 = new Label();
            txtInstructorSearchByPhone = new TextBox();
            cbInstructorsPhone = new ComboBox();
            txtlocation = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            btnCreate = new Button();
            dgvdepartment = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 268);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 47;
            label3.Text = "Manager Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 268);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 46;
            label1.Text = "Manager Phone";
            // 
            // txtInstructorSearchByPhone
            // 
            txtInstructorSearchByPhone.Enabled = false;
            txtInstructorSearchByPhone.Location = new Point(494, 292);
            txtInstructorSearchByPhone.Name = "txtInstructorSearchByPhone";
            txtInstructorSearchByPhone.Size = new Size(282, 27);
            txtInstructorSearchByPhone.TabIndex = 45;
            // 
            // cbInstructorsPhone
            // 
            cbInstructorsPhone.FormattingEnabled = true;
            cbInstructorsPhone.Location = new Point(11, 292);
            cbInstructorsPhone.Name = "cbInstructorsPhone";
            cbInstructorsPhone.Size = new Size(285, 28);
            cbInstructorsPhone.TabIndex = 44;
            cbInstructorsPhone.SelectedIndexChanged += cbInstructorsPhone_SelectedIndexChanged;
            // 
            // txtlocation
            // 
            txtlocation.Location = new Point(496, 232);
            txtlocation.Name = "txtlocation";
            txtlocation.Size = new Size(282, 27);
            txtlocation.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 209);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 42;
            label4.Text = "Location";
            // 
            // txtName
            // 
            txtName.Location = new Point(16, 232);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 209);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 40;
            label2.Text = "Name";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LightSeaGreen;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(175, 365);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(402, 51);
            btnCreate.TabIndex = 48;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvdepartment
            // 
            dgvdepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdepartment.Location = new Point(14, 2);
            dgvdepartment.Name = "dgvdepartment";
            dgvdepartment.ReadOnly = true;
            dgvdepartment.RowHeadersWidth = 51;
            dgvdepartment.Size = new Size(764, 186);
            dgvdepartment.TabIndex = 49;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDepartmentCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvdepartment);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtInstructorSearchByPhone);
            Controls.Add(cbInstructorsPhone);
            Controls.Add(txtlocation);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "FormDepartmentCreate";
            Text = "FormDepartmentCreate";
            ((System.ComponentModel.ISupportInitialize)dgvdepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox txtInstructorSearchByPhone;
        private ComboBox cbInstructorsPhone;
        private TextBox txtlocation;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private Button btnCreate;
        private DataGridView dgvdepartment;
        private ErrorProvider errorProvider1;
    }
}