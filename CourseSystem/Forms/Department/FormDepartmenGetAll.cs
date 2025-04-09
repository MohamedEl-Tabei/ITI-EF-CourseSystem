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

namespace CourseSystem.Forms.Department
{
    public partial class FormDepartmenGetAll : Form
    {
        public FormDepartmenGetAll()
        {
            InitializeComponent();
            var managerDepartment= new ManagerDepartment();
            dgvdepartment.DataSource = managerDepartment.GetDepartmentsWithManager();
        }
    }
}
