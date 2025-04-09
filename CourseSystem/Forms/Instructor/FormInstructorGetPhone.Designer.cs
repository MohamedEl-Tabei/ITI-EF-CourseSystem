namespace CourseSystem.Forms.Instructor
{
    partial class FormInstructorGetPhone
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
            label5 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnSearch = new Button();
            txtInstructorSearchByPhone = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtPhone = new TextBox();
            txtDepartment = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(510, 277);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 22;
            label5.Text = "Department";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(30, 300);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 27);
            txtName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(30, 277);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtInstructorSearchByPhone);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 193);
            panel1.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(690, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtInstructorSearchByPhone
            // 
            txtInstructorSearchByPhone.Location = new Point(33, 133);
            txtInstructorSearchByPhone.Name = "txtInstructorSearchByPhone";
            txtInstructorSearchByPhone.Size = new Size(420, 27);
            txtInstructorSearchByPhone.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(33, 110);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(30, 374);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 20;
            label4.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Enabled = false;
            txtPhone.Location = new Point(30, 397);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(282, 27);
            txtPhone.TabIndex = 21;
            // 
            // txtDepartment
            // 
            txtDepartment.Enabled = false;
            txtDepartment.Location = new Point(510, 300);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(282, 27);
            txtDepartment.TabIndex = 23;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(30, 219);
            txtId.Name = "txtId";
            txtId.Size = new Size(762, 27);
            txtId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(30, 196);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 24;
            label6.Text = "Id";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormInstructorGetPhone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 496);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(txtDepartment);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormInstructorGetPhone";
            Text = "FormInstructorGetById";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Panel panel1;
        private TextBox txtInstructorSearchByPhone;
        private Label label1;
        private Button btnSearch;
        private Label label4;
        private TextBox txtPhone;
        private TextBox txtDepartment;
        private TextBox txtId;
        private Label label6;
        private ErrorProvider errorProvider1;
    }
}