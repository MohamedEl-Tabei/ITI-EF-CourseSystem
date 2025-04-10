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

namespace CourseSystem.Forms.Course
{
    public partial class FormCourseGetAll : Form
    {
        private readonly ManagerCourse managerCourse;
        public FormCourseGetAll()
        {
            InitializeComponent();
            managerCourse= new ManagerCourse();
            dgvInstructors.DataSource = managerCourse.GetWithDepartmentAndInstructor();
        }
    }
}
