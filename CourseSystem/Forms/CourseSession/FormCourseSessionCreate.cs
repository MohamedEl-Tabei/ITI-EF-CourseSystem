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
using CourseSystem_BL.DTOs.Course;
using CourseSystem_BL.DTOs.CourseSession;

namespace CourseSystem.Forms.CourseSession
{
    public partial class FormCourseSessionCreate : Form
    {
        private readonly ManagerInstructor managerInstructor;
        private readonly ManagerCourse managerCourse;
        private readonly ManagerCourseSession managerCourseSession;
        private List<DTOInstructorPhone> instructorPhones;
        private List<DTOCourseRead> courses { get; set; }
        private DTOCourseSession newCourseSession { get; set; }
        public FormCourseSessionCreate()
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

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var newData = new DTOCourseSession();
            newData.Title = txtName.Text;
            newData.Date = dateTimePicker1.Value ;
            newData.CourseId = Guid.Parse(cbCourse.SelectedValue.ToString());
            newData.InstructorId = Guid.Parse(cbInstructorsPhone.SelectedValue.ToString());

            managerCourseSession.Create(newData);
            dgvdepartment.DataSource = managerCourseSession.GetDTOCourseSession();
        }
    }
}
