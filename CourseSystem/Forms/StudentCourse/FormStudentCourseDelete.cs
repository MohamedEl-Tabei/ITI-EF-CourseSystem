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

namespace CourseSystem.Forms.StudentCourse
{
    public partial class FormStudentCourseDelete : Form
    {
        private readonly ManagerCourseStudent managerCourseStudent;
        public FormStudentCourseDelete()
        {
            InitializeComponent();
            managerCourseStudent = new ManagerCourseStudent();
            var managerCourse = new ManagerCourse();
            var managerStudent = new ManagerStudent();

            dgvdepartment.DataSource = managerCourseStudent.GetWithStudentAndCourse();
            cbCourse.DataSource = managerCourseStudent.GetWithStudentAndCourse();
            cbStudent.DataSource = managerCourseStudent.GetWithStudentAndCourse();

            cbCourse.ValueMember = "CourseId";
            cbCourse.DisplayMember = "CourseName";
            cbStudent.ValueMember = "CourseId";
            cbStudent.DisplayMember = "StudentName";

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            managerCourseStudent.Delete(Guid.Parse(cbCourse.SelectedValue.ToString()), cbStudent.Text);
            dgvdepartment.DataSource = managerCourseStudent.GetWithStudentAndCourse();
            cbCourse.DataSource = managerCourseStudent.GetWithStudentAndCourse();
            cbStudent.DataSource = managerCourseStudent.GetWithStudentAndCourse();
        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourse.SelectedValue = cbStudent.SelectedValue;
        }
    }
}
