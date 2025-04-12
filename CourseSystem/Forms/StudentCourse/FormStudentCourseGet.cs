using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem_BL;
using CourseSystem_BL.Managers;

namespace CourseSystem.Forms.StudentCourse
{
    public partial class FormStudentCourseGet : Form
    {
        public FormStudentCourseGet()
        {
            InitializeComponent();
            var managerCourseStudent = new ManagerCourseStudent();
            dgvdepartment.DataSource = managerCourseStudent.GetWithStudentAndCourse();
        }
    }
}
