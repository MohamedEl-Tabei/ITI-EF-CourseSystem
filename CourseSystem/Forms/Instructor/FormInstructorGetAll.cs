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

namespace CourseSystem.Forms.Instructor
{
    public partial class FormInstructorGetAll : Form
    {
        private readonly ManagerInstructor managerInstructor;
        public FormInstructorGetAll()
        {
            InitializeComponent();
            managerInstructor = new ManagerInstructor();
            dgvInstructors.DataSource = managerInstructor.GetWithDepartment();
        }

        private void btnInstructorMain_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
