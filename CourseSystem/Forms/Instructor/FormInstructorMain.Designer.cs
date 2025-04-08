namespace CourseSystem.Forms.Instructor
{
    partial class FormInstructorMain
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
            SuspendLayout();
            // 
            // btnMainInstructor
            // 
            btnMainInstructor.BackColor = Color.MediumSeaGreen;
            btnMainInstructor.ForeColor = SystemColors.ControlLightLight;
            btnMainInstructor.Location = new Point(0, 0);
            btnMainInstructor.Name = "btnMainInstructor";
            btnMainInstructor.Size = new Size(94, 29);
            btnMainInstructor.TabIndex = 0;
            btnMainInstructor.Text = "Get";
            btnMainInstructor.UseVisualStyleBackColor = false;
            btnMainInstructor.Click += btnMainInstructor_Click;
            // 
            // FormInstructorMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMainInstructor);
            Name = "FormInstructorMain";
            Text = "FormInstructorMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainInstructor;
    }
}