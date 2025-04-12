﻿namespace CourseSystem.Forms.Student
{
    partial class FormStudentMain
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
            btnInstructorAdd.Location = new Point(525, 153);
            btnInstructorAdd.Name = "btnInstructorAdd";
            btnInstructorAdd.Size = new Size(141, 111);
            btnInstructorAdd.TabIndex = 7;
            btnInstructorAdd.Text = "Create";
            btnInstructorAdd.UseVisualStyleBackColor = false;
            btnInstructorAdd.Click += btnInstructorAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSeaGreen;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(348, 153);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 111);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update And Delete";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.MediumSeaGreen;
            btnGetAll.Cursor = Cursors.Hand;
            btnGetAll.ForeColor = SystemColors.ControlLightLight;
            btnGetAll.Location = new Point(181, 153);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(141, 111);
            btnGetAll.TabIndex = 4;
            btnGetAll.Text = "Get";
            btnGetAll.UseVisualStyleBackColor = false;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // FormStudentMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInstructorAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnGetAll);
            Name = "FormStudentMain";
            Text = "FormStudentMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInstructorAdd;
        private Button btnUpdate;
        private Button btnGetAll;
    }
}