﻿namespace CourseSystem.Forms.Department
{
    partial class FormDepartmentMain
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
            btnGetAndUpdate = new Button();
            SuspendLayout();
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.MediumSeaGreen;
            btnGetAll.Cursor = Cursors.Hand;
            btnGetAll.ForeColor = SystemColors.ControlLightLight;
            btnGetAll.Location = new Point(23, 26);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(141, 111);
            btnGetAll.TabIndex = 1;
            btnGetAll.Text = "Get";
            btnGetAll.UseVisualStyleBackColor = false;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnGetAndUpdate
            // 
            btnGetAndUpdate.BackColor = Color.SeaGreen;
            btnGetAndUpdate.Cursor = Cursors.Hand;
            btnGetAndUpdate.ForeColor = SystemColors.ControlLightLight;
            btnGetAndUpdate.Location = new Point(199, 26);
            btnGetAndUpdate.Name = "btnGetAndUpdate";
            btnGetAndUpdate.Size = new Size(183, 111);
            btnGetAndUpdate.TabIndex = 3;
            btnGetAndUpdate.Text = "Get And Update";
            btnGetAndUpdate.UseVisualStyleBackColor = false;
            btnGetAndUpdate.Click += btnGetAndUpdate_Click;
            // 
            // FormDepartmentMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetAndUpdate);
            Controls.Add(btnGetAll);
            Name = "FormDepartmentMain";
            Text = "FormDepartmentMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetAll;
        private Button btnGetAndUpdate;
    }
}