namespace CourseSystem.Forms.Course
{
    partial class FormCourseMain
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
            btnGetAndUpdate = new Button();
            btnGetAll = new Button();
            button1 = new Button();
            btnGetByInstructor = new Button();
            SuspendLayout();
            // 
            // btnInstructorAdd
            // 
            btnInstructorAdd.BackColor = Color.LightSeaGreen;
            btnInstructorAdd.Cursor = Cursors.Hand;
            btnInstructorAdd.ForeColor = SystemColors.ControlLightLight;
            btnInstructorAdd.Location = new Point(468, 92);
            btnInstructorAdd.Name = "btnInstructorAdd";
            btnInstructorAdd.Size = new Size(141, 111);
            btnInstructorAdd.TabIndex = 7;
            btnInstructorAdd.Text = "Create";
            btnInstructorAdd.UseVisualStyleBackColor = false;
            btnInstructorAdd.Click += btnInstructorAdd_Click;
            // 
            // btnGetAndUpdate
            // 
            btnGetAndUpdate.BackColor = Color.SeaGreen;
            btnGetAndUpdate.Cursor = Cursors.Hand;
            btnGetAndUpdate.ForeColor = SystemColors.ControlLightLight;
            btnGetAndUpdate.Location = new Point(224, 92);
            btnGetAndUpdate.Name = "btnGetAndUpdate";
            btnGetAndUpdate.Size = new Size(238, 111);
            btnGetAndUpdate.TabIndex = 6;
            btnGetAndUpdate.Text = "Get And Update";
            btnGetAndUpdate.UseVisualStyleBackColor = false;
            btnGetAndUpdate.Click += btnGetAndUpdate_Click;
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.MediumSeaGreen;
            btnGetAll.Cursor = Cursors.Hand;
            btnGetAll.ForeColor = SystemColors.ControlLightLight;
            btnGetAll.Location = new Point(77, 92);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(141, 111);
            btnGetAll.TabIndex = 5;
            btnGetAll.Text = "Get";
            btnGetAll.UseVisualStyleBackColor = false;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(346, 209);
            button1.Name = "button1";
            button1.Size = new Size(263, 111);
            button1.TabIndex = 8;
            button1.Text = "Get By Department";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnGetByInstructor
            // 
            btnGetByInstructor.BackColor = Color.DarkCyan;
            btnGetByInstructor.Cursor = Cursors.Hand;
            btnGetByInstructor.ForeColor = SystemColors.ControlLightLight;
            btnGetByInstructor.Location = new Point(77, 209);
            btnGetByInstructor.Name = "btnGetByInstructor";
            btnGetByInstructor.Size = new Size(263, 111);
            btnGetByInstructor.TabIndex = 9;
            btnGetByInstructor.Text = "Get By Instructor";
            btnGetByInstructor.UseVisualStyleBackColor = false;
            btnGetByInstructor.Click += btnGetByInstructor_Click;
            // 
            // FormCourseMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetByInstructor);
            Controls.Add(button1);
            Controls.Add(btnInstructorAdd);
            Controls.Add(btnGetAndUpdate);
            Controls.Add(btnGetAll);
            Name = "FormCourseMain";
            Text = "FormCourseMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInstructorAdd;
        private Button btnGetAndUpdate;
        private Button btnGetAll;
        private Button button1;
        private Button btnGetByInstructor;
    }
}