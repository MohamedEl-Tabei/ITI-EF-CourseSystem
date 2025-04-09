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
            SuspendLayout();
            // 
            // btnMainInstructor
            // 
            btnMainInstructor.BackColor = Color.MediumSeaGreen;
            btnMainInstructor.Cursor = Cursors.Hand;
            btnMainInstructor.ForeColor = SystemColors.ControlLightLight;
            btnMainInstructor.Location = new Point(12, 12);
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
            btnGetById.Location = new Point(222, 10);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(182, 111);
            btnGetById.TabIndex = 3;
            btnGetById.Text = "Department";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetById);
            Controls.Add(btnMainInstructor);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainInstructor;
        private Button btnGetById;
    }
}