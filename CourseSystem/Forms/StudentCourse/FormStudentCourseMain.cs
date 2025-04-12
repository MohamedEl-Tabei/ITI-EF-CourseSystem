using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem.Forms.StudentCourse
{
    public partial class FormStudentCourseMain : Form
    {
        public FormStudentCourseMain()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var form = new FormStudentCourseGet();
            form.ShowDialog();
        }

        private void btnInstructorAdd_Click(object sender, EventArgs e)
        {
            var form = new FormStudentCourseCreate();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormStudentCourseDelete();
            form.ShowDialog();
        }
    }
}
