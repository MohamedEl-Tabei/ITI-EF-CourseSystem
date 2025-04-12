namespace CourseSystem.Forms.CourseSession
{
    partial class FormCourseSessionMain
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
            btnInstructorAdd = new Button();
            btnUpdate = new Button();
            btnGetAll = new Button();
            SuspendLayout();
            // 
            // btnInstructorAdd
            // 
            btnInstructorAdd.BackColor = Color.DarkCyan;
            btnInstructorAdd.Cursor = Cursors.Hand;
            btnInstructorAdd.ForeColor = SystemColors.ControlLightLight;
            btnInstructorAdd.Location = new Point(515, 170);
            btnInstructorAdd.Name = "btnInstructorAdd";
            btnInstructorAdd.Size = new Size(141, 111);
            btnInstructorAdd.TabIndex = 10;
            btnInstructorAdd.Text = "Create";
            btnInstructorAdd.UseVisualStyleBackColor = false;
            btnInstructorAdd.Click += btnInstructorAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSeaGreen;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(325, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 111);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update And Delete";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.MediumSeaGreen;
            btnGetAll.Cursor = Cursors.Hand;
            btnGetAll.ForeColor = SystemColors.ControlLightLight;
            btnGetAll.Location = new Point(158, 170);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(141, 111);
            btnGetAll.TabIndex = 8;
            btnGetAll.Text = "Get";
            btnGetAll.UseVisualStyleBackColor = false;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // FormCourseSessionMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInstructorAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnGetAll);
            Name = "FormCourseSessionMain";
            Text = "FormCourseSessionMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInstructorAdd;
        private Button btnUpdate;
        private Button btnGetAll;
    }
}