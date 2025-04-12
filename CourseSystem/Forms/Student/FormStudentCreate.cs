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

namespace CourseSystem.Forms.Student
{
    public partial class FormStudentCreate : Form
    {
        private readonly ManagerStudent managerStudent;
        public FormStudentCreate()
        {
            managerStudent = new ManagerStudent();
            InitializeComponent();
            dgvInstructors.DataSource = managerStudent.Get();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            var student = new DTOStudent();
            student.Phone=txtPhone.Text;
            student.FirstName=txtFName.Text;
            student.LastName=txtLastName.Text;
            managerStudent.Create(student);
            dgvInstructors.DataSource = managerStudent.Get();

        }
    }
}
