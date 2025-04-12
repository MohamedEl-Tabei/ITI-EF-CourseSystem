using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem.Forms.Course;
using CourseSystem.Forms.CourseSession;
using CourseSystem.Forms.CourseSessionAttendance;
using CourseSystem.Forms.Department;
using CourseSystem.Forms.Instructor;
using CourseSystem.Forms.Student;
using CourseSystem.Forms.StudentCourse;

namespace CourseSystem.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnMainInstructor_Click(object sender, EventArgs e)
        {
            var formMainInstructor = new FormInstructorMain();
            formMainInstructor.ShowDialog();

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            var formMainDepartment = new FormDepartmentMain();
            formMainDepartment.ShowDialog();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            var formMainCourse = new FormCourseMain();
            formMainCourse.ShowDialog();
        }

        private void btnInstructorAdd_Click(object sender, EventArgs e)
        {
            var form = new FormStudentMain();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormStudentCourseMain();
            form.ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var form = new FormCourseSessionMain();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FormCourseSessionAttendanceMain();
            form.ShowDialog();
        }
    }
}
