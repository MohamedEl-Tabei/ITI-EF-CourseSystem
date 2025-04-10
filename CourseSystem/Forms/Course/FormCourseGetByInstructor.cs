using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem_BL.DTOs.Department;
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_BL.Managers;
using CourseSystem_BL;
using System.Xml.Linq;

namespace CourseSystem.Forms.Course
{
    public partial class FormCourseGetByInstructor : Form
    {
        private readonly ManagerInstructor managerInstructor;
        private readonly ManagerCourse managerCourse;
        private List<DTOInstructorPhone> instructorPhones;
        public FormCourseGetByInstructor()
        {
            InitializeComponent();
            managerInstructor = new ManagerInstructor();
            managerCourse= new ManagerCourse();
            instructorPhones = managerInstructor.InstructorsPhone();
            #region instructors
            cbInstructorsPhone.DataSource = instructorPhones;
            cbInstructorsPhone.DisplayMember = "Name";
            cbInstructorsPhone.ValueMember = "Phone";
            #endregion
            var phone = cbInstructorsPhone.SelectedValue.ToString();
            var id = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id;
            txtInstructorSearchByPhone.Text = phone;

            var courses = managerCourse.GetByInstructor(id);

            dgvdepartment.DataSource = courses;
        }

        private void cbInstructorsPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbInstructorsPhone.SelectedValue != null)
            {
                cbInstructorsPhone.ValueMember = "Phone";
                var phone = cbInstructorsPhone.SelectedValue.ToString();
                var id = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id;
                txtInstructorSearchByPhone.Text = phone;
                var courses = managerCourse.GetByInstructor(id);

                dgvdepartment.DataSource = courses;
            }
        }



    }
}
