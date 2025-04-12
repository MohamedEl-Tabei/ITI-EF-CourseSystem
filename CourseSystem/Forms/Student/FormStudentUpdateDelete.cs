using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem_BL.DTOs.Student;
using CourseSystem_BL.Managers;
using CourseSystem_DAL;

namespace CourseSystem.Forms.Student
{
    public partial class FormStudentUpdateDelete : Form
    {
        private readonly ManagerStudent managerStudent;
        private DTOStudent newStudent;
        public FormStudentUpdateDelete()
        {
            managerStudent = new ManagerStudent();
            InitializeComponent();
            cbStudent.DataSource = managerStudent.Get();
            cbStudent.DisplayMember = "FirstName";
            cbStudent.ValueMember = "Id";

        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Guid.Parse(cbStudent.SelectedValue.ToString());
            newStudent = managerStudent.GetById(id);
            txtFName.Text = newStudent.FirstName;
            txtLastName.Text = newStudent.LastName;
            txtPhone.Text = newStudent.Phone;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            newStudent.FirstName = txtFName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.Phone = txtPhone.Text;
            managerStudent.Update(newStudent);
            cbStudent.DataSource = managerStudent.Get();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = cbStudent.SelectedValue.ToString();
            managerStudent.Delete(Guid.Parse(id));
            cbStudent.DataSource = managerStudent.Get();
        }
    }
}
