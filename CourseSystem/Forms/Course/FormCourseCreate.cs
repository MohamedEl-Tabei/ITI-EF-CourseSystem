using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem_BL.DTOs.Course;
using CourseSystem_BL.Managers;
using CourseSystem_BL;
using CourseSystem_BL.DTOs.Instructor;

namespace CourseSystem.Forms.Course
{
    public partial class FormCourseCreate : Form
    {
        private readonly ManagerDepartment managerDepartment;
        private readonly ManagerCourse managerCourse;
        private readonly ManagerInstructor managerInstructor;
        private List<DTOCourseRead> courses { get; set; }
        private List<DTOInstructorPhone> instructorPhones;
        public FormCourseCreate()
        {
            managerDepartment = new ManagerDepartment();
            managerCourse = new ManagerCourse();
            managerInstructor = new ManagerInstructor();
            InitializeComponent();
            var departments = managerDepartment.Get();
            cbDepartment.DataSource = departments;
            cbDepartment.DisplayMember = "Name";
            cbDepartment.ValueMember = "Id";
            courses = managerCourse.GetByDepartment(new Guid(cbDepartment.SelectedValue.ToString()));
            instructorPhones = managerInstructor.InstructorsPhone();
            #region instructors
            cbInstructorsPhone.DataSource = instructorPhones;
            cbInstructorsPhone.DisplayMember = "Name";
            cbInstructorsPhone.ValueMember = "Phone";
            #endregion
            var phone = cbInstructorsPhone.SelectedValue.ToString();
            var id = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id;
            txtInstructorSearchByPhone.Text = phone;
            dgvdepartment.DataSource = managerCourse.GetWithDepartmentAndInstructor();

        }
        private void cbInstructorsPhone_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            cbInstructorsPhone.ValueMember = "Phone";
            var phone = cbInstructorsPhone.SelectedValue.ToString();
            var id = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id;
            txtInstructorSearchByPhone.Text = phone;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var newcourse = new DTOCourseCreate();
            int.TryParse(txtDuration.Text, out int x );
            newcourse.Duration = x;
            newcourse.Name = txtName.Text;
            newcourse.DepartmentId = Guid.Parse(cbDepartment.SelectedValue.ToString());
            var phone = cbInstructorsPhone.SelectedValue.ToString();
            var id = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id;
            newcourse.InstructorId = id;
            managerCourse.Create(newcourse);
            dgvdepartment.DataSource = managerCourse.GetWithDepartmentAndInstructor();
            txtDuration.Text = "";
            txtName.Text = "";
        }
    }
}
