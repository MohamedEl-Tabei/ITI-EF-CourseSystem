using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem_BL.DTOs.CourseSessionAttendance;
using CourseSystem_BL.Managers;

namespace CourseSystem.Forms.CourseSessionAttendance
{
    public partial class FormCourseSessionAttendanceUpdateDelete : Form
    {
        private readonly ManagerCourseSessionAttendance managerCourseSessionAttendance;
        private readonly ManagerCourseSession managerCourseSession;
        private readonly ManagerStudent managerStudent;
        private DTOCourseSessionAttendance newCourseAttendance;
        public FormCourseSessionAttendanceUpdateDelete()
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
            comboBox1.DataSource = managerCourseSessionAttendance.GetDTOCourseSessionAttendances();
            comboBox1.DisplayMember = "Id";
            comboBox1.ValueMember = "Id";

        }

        private void FormCourseSessionAttendanceCreate_Load(object sender, EventArgs e)
        {

        }



        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            newCourseAttendance.Notes = txtName.Text;
            newCourseAttendance.Grade = int.Parse(numericUpDown1.Value.ToString());
            newCourseAttendance.StudentId = Guid.Parse(cbStudent.SelectedValue.ToString());
            newCourseAttendance.CourseSessionId = Guid.Parse(cbCourse.SelectedValue.ToString());
            managerCourseSessionAttendance.Update(newCourseAttendance);
            dgvdepartment.DataSource = managerCourseSessionAttendance.GetDTOCourseSessionAttendances();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            newCourseAttendance = managerCourseSessionAttendance.GetById(Guid.Parse(comboBox1.SelectedValue.ToString()));
            txtName.Text = newCourseAttendance.Notes;
            numericUpDown1.Value = newCourseAttendance.Grade;
            cbCourse.SelectedValue = newCourseAttendance.CourseSessionId;
            cbStudent.SelectedValue = newCourseAttendance.StudentId;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(comboBox1.SelectedValue.ToString());
            managerCourseSessionAttendance.Delete(id);
            comboBox1.DataSource = managerCourseSessionAttendance.GetDTOCourseSessionAttendances();
            dgvdepartment.DataSource = managerCourseSessionAttendance.GetDTOCourseSessionAttendances();
        }
    }
}
