using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem.Forms.Course
{
    public partial class FormCourseMain : Form
    {
        public FormCourseMain()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var formCourseGetAll = new FormCourseGetAll();
            formCourseGetAll.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormCourseGetByDepartment();
            form.ShowDialog();
        }

        private void btnGetByInstructor_Click(object sender, EventArgs e)
        {

            var form = new FormCourseGetByInstructor();
            form.ShowDialog();
        }

        private void btnInstructorAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCourseCreate();
            form.ShowDialog();
        }

        private void btnGetAndUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCourseUpdateDelete();
            form.ShowDialog();
        }
    }
}
