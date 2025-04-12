using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem.Forms.Student
{
    public partial class FormStudentMain : Form
    {
        public FormStudentMain()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var form = new FormStudentGet();
            form.ShowDialog();
        }

        private void btnInstructorAdd_Click(object sender, EventArgs e)
        {
            var form = new FormStudentCreate();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormStudentUpdateDelete();
            form.ShowDialog();
        }
    }
}
