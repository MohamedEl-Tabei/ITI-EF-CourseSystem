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
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_BL.Managers;
using CourseSystem_BL;

namespace CourseSystem.Forms.Course
{
    public partial class FormCourseUpdate : Form
    {
        private readonly ManagerDepartment managerDepartment;
        private readonly ManagerCourse managerCourse;
        private readonly ManagerInstructor managerInstructor;
        private List<DTOCourseRead> courses { get; set; }
        private DTOCourseUpdate courseUpdate { get; set; }
        private List<DTOInstructorPhone> instructorPhones;
        public FormCourseUpdate()
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
            cbCourse.DataSource = managerCourse.Get();
            cbCourse.DisplayMember = "Name";
            cbCourse.ValueMember = "Id";

        }



        private void cbInstructorsPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbInstructorsPhone.ValueMember = "Phone";
            if (cbInstructorsPhone.SelectedValue!=null)
            {
                var phone = cbInstructorsPhone.SelectedValue.ToString();
                txtInstructorSearchByPhone.Text = phone;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int.TryParse(txtDuration.Text, out int x);
            courseUpdate.Duration = x;
            courseUpdate.Name = txtName.Text;
            courseUpdate.DepartmentId = Guid.Parse(cbDepartment.SelectedValue.ToString());
            var phone = cbInstructorsPhone.SelectedValue.ToString();
            var id = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id;
            courseUpdate.InstructorId = id;
            managerCourse.Update(courseUpdate);
            cbCourse.DataSource = managerCourse.Get();
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourse.ValueMember = "Id";
            if (cbCourse.SelectedValue != null)
            {
                var id = cbCourse.SelectedValue.ToString();
                courseUpdate = managerCourse.GetById(Guid.Parse(id));
                cbDepartment.SelectedValue = courseUpdate.DepartmentId;
                cbInstructorsPhone.SelectedValue= courseUpdate.InstructorId;
                txtDuration.Text=courseUpdate.Duration.ToString();
                txtId.Text=courseUpdate.Id.ToString();
                txtName.Text=courseUpdate.Name;
                var phone = instructorPhones.FirstOrDefault(i => i.Id == courseUpdate.InstructorId).Phone;

                cbInstructorsPhone.SelectedValue = phone;
            }
        }
    }
}
