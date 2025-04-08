using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem.Forms.Instructor;

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
            
            var formMainInstructor=new FormInstructorMain();
            formMainInstructor.ShowDialog();
            
        }
    }
}
