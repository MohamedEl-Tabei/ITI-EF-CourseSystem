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
            btnGetAll = new Button();
            btnUpdate = new Button();
            btnGetById = new Button();
            btnInstructorAdd = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.MediumSeaGreen;
            btnGetAll.Cursor = Cursors.Hand;
            btnGetAll.ForeColor = SystemColors.ControlLightLight;
            btnGetAll.Location = new Point(76, 62);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(141, 111);
            btnGetAll.TabIndex = 0;
            btnGetAll.Text = "Get";
            btnGetAll.UseVisualStyleBackColor = false;
            btnGetAll.Click += btnMainInstructor_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSeaGreen;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(393, 62);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 111);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update And Delete";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnInstructorUpdate_Click;
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.SeaGreen;
            btnGetById.Cursor = Cursors.Hand;
            btnGetById.ForeColor = SystemColors.ControlLightLight;
            btnGetById.Location = new Point(233, 62);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(141, 111);
            btnGetById.TabIndex = 2;
            btnGetById.Text = "Get By Phone";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // btnInstructorAdd
            // 
            btnInstructorAdd.BackColor = Color.DarkCyan;
            btnInstructorAdd.Cursor = Cursors.Hand;
            btnInstructorAdd.ForeColor = SystemColors.ControlLightLight;
            btnInstructorAdd.Location = new Point(570, 62);
            btnInstructorAdd.Name = "btnInstructorAdd";
            btnInstructorAdd.Size = new Size(141, 111);
            btnInstructorAdd.TabIndex = 3;
            btnInstructorAdd.Text = "Create";
            btnInstructorAdd.UseVisualStyleBackColor = false;
            btnInstructorAdd.Click += btnInstructorAdd_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(76, 202);
            button1.Name = "button1";
            button1.Size = new Size(298, 111);
            button1.TabIndex = 4;
            button1.Text = "Get By Department";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormInstructorMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnInstructorAdd);
            Controls.Add(btnGetById);
            Controls.Add(btnUpdate);
            Controls.Add(btnGetAll);
            Name = "FormInstructorMain";
            Text = "FormInstructorMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetAll;
        private Button btnUpdate;
        private Button btnGetById;
        private Button btnInstructorAdd;
        private Button button1;
    }
}