using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem.Forms.CourseSession
{
    public partial class FormCourseSessionMain : Form
    {
        public FormCourseSessionMain()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var form = new FormCourseSessionGet();
            form.ShowDialog();
        }

        private void btnInstructorAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCourseSessionCreate();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormCourseSessionUpdateDelete();
            form.ShowDialog();
        }
    }
}
