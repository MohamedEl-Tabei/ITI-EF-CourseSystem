using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem.Forms.CourseSession;

namespace CourseSystem.Forms.CourseSessionAttendance
{
    public partial class FormCourseSessionAttendanceMain : Form
    {
        public FormCourseSessionAttendanceMain()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var form = new FormCourseSessionAttendanceGet();
            form.ShowDialog();
        }

        private void btnInstructorAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCourseSessionAttendanceCreate();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCourseSessionAttendanceUpdateDelete();
            form.ShowDialog();
        }
    }
}
