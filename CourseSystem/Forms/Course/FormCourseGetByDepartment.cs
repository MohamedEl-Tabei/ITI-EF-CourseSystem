using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_BL.Managers;
using CourseSystem_BL;
using CourseSystem_BL.DTOs.Course;
using CourseSystem_DAL;

namespace CourseSystem.Forms.Course
{
    public partial class FormCourseGetByDepartment : Form
    {
        private readonly ManagerDepartment managerDepartment;
        private readonly ManagerCourse managerCourse;
        private List<DTOCourseRead> courses { get; set; }
        public FormCourseGetByDepartment()
        {

            managerDepartment = new ManagerDepartment();
            managerCourse = new ManagerCourse();
            InitializeComponent();
            var departments = managerDepartment.Get();
            cbDepartment.DataSource = departments;
            cbDepartment.DisplayMember = "Name";
            cbDepartment.ValueMember = "Id";
            courses = managerCourse.GetByDepartment(new Guid(cbDepartment.SelectedValue.ToString()));
            dgvInstructors.DataSource = courses;
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            courses = managerCourse.GetByDepartment(new Guid(cbDepartment.SelectedValue.ToString()));
            dgvInstructors.DataSource = courses;
        }
    }
}
