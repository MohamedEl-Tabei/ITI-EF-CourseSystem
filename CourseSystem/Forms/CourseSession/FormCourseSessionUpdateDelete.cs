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
using CourseSystem_BL.DTOs.CourseSession;
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_BL.Managers;

namespace CourseSystem.Forms.CourseSession
{
    public partial class FormCourseSessionUpdateDelete : Form
    {
        private readonly ManagerInstructor managerInstructor;
        private readonly ManagerCourse managerCourse;
        private readonly ManagerCourseSession managerCourseSession;
        private List<DTOInstructorPhone> instructorPhones;
        private List<DTOCourseRead> courses { get; set; }
        private DTOCourseSession UpdatedSession { get; set; }
        public FormCourseSessionUpdateDelete()
        {
            InitializeComponent();
            managerCourseSession = new ManagerCourseSession();
            dgvdepartment.DataSource = managerCourseSession.GetDTOCourseSession();
            managerInstructor = new ManagerInstructor();
            managerCourse = new ManagerCourse();
            instructorPhones = managerInstructor.InstructorsPhone();
            #region instructors
            cbInstructorsPhone.DataSource = instructorPhones;
            cbInstructorsPhone.DisplayMember = "Name";
            cbInstructorsPhone.ValueMember = "Id";
            cbInstructorsPhone.DataSource = instructorPhones;

            #endregion
            cbCourse.DataSource = managerCourse.Get();
            cbCourse.DisplayMember = "Name";
            cbCourse.ValueMember = "Id";
            dgvdepartment.DataSource = managerCourseSession.GetDTOCourseSession();
            comboBox1.DataSource = managerCourseSession.GetDTOCourseSession();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Title";
            UpdatedSession = managerCourseSession.GetById(Guid.Parse(comboBox1.SelectedValue.ToString()));
            txtName.Text = UpdatedSession.Title;
            dateTimePicker1.Value = UpdatedSession.Date;
            cbCourse.SelectedValue = UpdatedSession.CourseId;
            cbInstructorsPhone.SelectedValue = UpdatedSession.InstructorId;

        }



        private void btnCreate_Click_1(object sender, EventArgs e)
        {

            var newData = new DTOCourseSession();
            newData.Title = txtName.Text;
            newData.Date = dateTimePicker1.Value;
            newData.CourseId = Guid.Parse(cbCourse.SelectedValue.ToString());
            newData.InstructorId = Guid.Parse(cbInstructorsPhone.SelectedValue.ToString());
            newData.Id = Guid.Parse(comboBox1.SelectedValue.ToString());
            managerCourseSession.Update(newData);
            dgvdepartment.DataSource = managerCourseSession.GetDTOCourseSession();
            comboBox1.DataSource = managerCourseSession.GetDTOCourseSession();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatedSession = managerCourseSession.GetById(Guid.Parse(comboBox1.SelectedValue.ToString()));
            txtName.Text = UpdatedSession.Title;
            dateTimePicker1.Value = UpdatedSession.Date;
            cbCourse.SelectedValue = UpdatedSession.CourseId;
            cbInstructorsPhone.SelectedValue = UpdatedSession.InstructorId;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = comboBox1.SelectedValue.ToString();
            managerCourseSession.Delete(Guid.Parse(id));
            dgvdepartment.DataSource = managerCourseSession.GetDTOCourseSession();
            comboBox1.DataSource = managerCourseSession.GetDTOCourseSession();
        }
    }
}
