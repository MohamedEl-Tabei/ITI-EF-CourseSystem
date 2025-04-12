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

namespace CourseSystem.Forms.CourseSessionAttendance
{
    public partial class FormCourseSessionAttendanceGet : Form
    {
        public FormCourseSessionAttendanceGet()
        {
            InitializeComponent();
            var manager = new ManagerCourseSession();
            dgvdepartment.DataSource = manager.GetDTOCourseSession();
        }
    }
}
