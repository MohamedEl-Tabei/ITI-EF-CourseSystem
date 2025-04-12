namespace CourseSystem.Forms
{
    partial class FormMain
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
            btnMainInstructor = new Button();
            btnGetById = new Button();
            btnCourse = new Button();
            btnInstructorAdd = new Button();
            button1 = new Button();
            btn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnMainInstructor
            // 
            btnMainInstructor.BackColor = Color.MediumSeaGreen;
            btnMainInstructor.Cursor = Cursors.Hand;
            btnMainInstructor.ForeColor = SystemColors.ControlLightLight;
            btnMainInstructor.Location = new Point(86, 42);
            btnMainInstructor.Name = "btnMainInstructor";
            btnMainInstructor.Size = new Size(182, 107);
            btnMainInstructor.TabIndex = 1;
            btnMainInstructor.Text = "Instructor";
            btnMainInstructor.UseVisualStyleBackColor = false;
            btnMainInstructor.Click += btnMainInstructor_Click;
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.SeaGreen;
            btnGetById.Cursor = Cursors.Hand;
            btnGetById.ForeColor = SystemColors.ControlLightLight;
            btnGetById.Location = new Point(296, 40);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(182, 111);
            btnGetById.TabIndex = 3;
            btnGetById.Text = "Department";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // btnCourse
            // 
            btnCourse.BackColor = Color.LightSeaGreen;
            btnCourse.Cursor = Cursors.Hand;
            btnCourse.ForeColor = SystemColors.ControlLightLight;
            btnCourse.Location = new Point(512, 44);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(182, 107);
            btnCourse.TabIndex = 4;
            btnCourse.Text = "Course";
            btnCourse.UseVisualStyleBackColor = false;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnInstructorAdd
            // 
            btnInstructorAdd.BackColor = Color.DarkCyan;
            btnInstructorAdd.Cursor = Cursors.Hand;
            btnInstructorAdd.ForeColor = SystemColors.ControlLightLight;
            btnInstructorAdd.Location = new Point(86, 155);
            btnInstructorAdd.Name = "btnInstructorAdd";
            btnInstructorAdd.Size = new Size(182, 111);
            btnInstructorAdd.TabIndex = 5;
            btnInstructorAdd.Text = "Student";
            btnInstructorAdd.UseVisualStyleBackColor = false;
            btnInstructorAdd.Click += btnInstructorAdd_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(296, 157);
            button1.Name = "button1";
            button1.Size = new Size(182, 111);
            button1.TabIndex = 6;
            button1.Text = "Student and Course";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn
            // 
            btn.BackColor = Color.CornflowerBlue;
            btn.Cursor = Cursors.Hand;
            btn.ForeColor = SystemColors.ControlLightLight;
            btn.Location = new Point(512, 157);
            btn.Name = "btn";
            btn.Size = new Size(182, 111);
            btn.TabIndex = 7;
            btn.Text = "Course Session";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(86, 272);
            button2.Name = "button2";
            button2.Size = new Size(608, 111);
            button2.TabIndex = 8;
            button2.Text = "Course Session Attendence";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btn);
            Controls.Add(button1);
            Controls.Add(btnInstructorAdd);
            Controls.Add(btnCourse);
            Controls.Add(btnGetById);
            Controls.Add(btnMainInstructor);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainInstructor;
        private Button btnGetById;
        private Button btnCourse;
        private Button btnInstructorAdd;
        private Button button1;
        private Button btn;
        private Button button2;
    }
}