using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem.Forms.Instructor
{
    public partial class FormInstructorMain : Form
    {
        public FormInstructorMain()
        {
            InitializeComponent();
        }

        private void btnMainInstructor_Click(object sender, EventArgs e)
        {
            var formInstructorGetAll = new FormInstructorGetAll();
            formInstructorGetAll.ShowDialog();
        }
    }
}
