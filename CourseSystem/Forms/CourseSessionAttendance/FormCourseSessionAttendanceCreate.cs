using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem_BL.DTOs.CourseSession;
using CourseSystem_BL.DTOs.CourseSessionAttendance;
using CourseSystem_BL.Managers;

namespace CourseSystem.Forms.CourseSessionAttendance
{
    public partial class FormCourseSessionAttendanceCreate : Form
    {
        private readonly ManagerCourseSessionAttendance managerCourseSessionAttendance;
        private readonly ManagerCourseSession managerCourseSession;
        private readonly ManagerStudent managerStudent;
        public FormCourseSessionAttendanceCreate()
        {
            InitializeComponent();
            managerCourseSessionAttendance = new ManagerCourseSessionAttendance();
            managerCourseSession = new ManagerCourseSession();
            managerStudent = new ManagerStudent();
            dgvdepartment.DataSource = managerCourseSessionAttendance.GetDTOCourseSessionAttendances();
            cbCourse.DataSource = managerCourseSession.GetDTOCourseSession();
            cbCourse.DisplayMember = "Title";
            cbCourse.ValueMember = "Id";
            cbStudent.DataSource = managerStudent.Get();
            cbStudent.DisplayMember = "FirstName";
            cbStudent.ValueMember = "Id";
        }

        private void FormCourseSessionAttendanceCreate_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            var newData = new DTOCourseSessionAttendance();
            newData.Notes = txtName.Text;
            newData.Grade = int.Parse(numericUpDown1.Value.ToString());
            newData.StudentId=Guid.Parse(cbStudent.SelectedValue.ToString());
            newData.CourseSessionId = Guid.Parse(cbCourse.SelectedValue.ToString());
            managerCourseSessionAttendance.Create(newData);
            dgvdepartment.DataSource = managerCourseSessionAttendance.GetDTOCourseSessionAttendances();
        }
    }
}
