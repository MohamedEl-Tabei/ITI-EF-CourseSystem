using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem_BL.Managers;
using CourseSystem_BL;
using CourseSystem_DAL;
using CourseSystem_BL.DTOs.Instructor;

namespace CourseSystem.Forms.Instructor
{
    public partial class FormInstructorGetByDepartment : Form
    {
        private readonly ManagerDepartment managerDepartment;
        private readonly ManagerInstructor managerInstructor;
        private List<DTOInstructorRead> instructors { get; set; }
        public FormInstructorGetByDepartment()
        {
            managerDepartment = new ManagerDepartment();
            managerInstructor = new ManagerInstructor();
            InitializeComponent();
            var departments = managerDepartment.Get();
            cbDepartment.DataSource = departments;
            cbDepartment.DisplayMember = "Name";
            cbDepartment.ValueMember = "Id";
            instructors = managerInstructor.GetByDepartment(new Guid(cbDepartment.SelectedValue.ToString()));
            dgvInstructors.DataSource = instructors;
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            instructors = managerInstructor.GetByDepartment(new Guid(cbDepartment.SelectedValue.ToString()));
            dgvInstructors.DataSource = instructors;
        }
    }
}
