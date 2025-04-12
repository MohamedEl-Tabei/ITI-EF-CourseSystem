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

namespace CourseSystem.Forms.Student
{
    public partial class FormStudentGet : Form
    {
        private readonly ManagerStudent managerStudent;
        public FormStudentGet()
        {
            managerStudent = new ManagerStudent();
            InitializeComponent();

            dgvInstructors.DataSource = managerStudent.Get();
        }
    }
}
