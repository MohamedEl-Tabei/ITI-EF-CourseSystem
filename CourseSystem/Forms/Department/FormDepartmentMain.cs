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

namespace CourseSystem.Forms.Department
{
    public partial class FormDepartmentMain : Form
    {
        public FormDepartmentMain()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var formDepartmenGetAll = new FormDepartmenGetAll();
            formDepartmenGetAll.ShowDialog();
        }

        private void btnGetAndUpdate_Click(object sender, EventArgs e)
        {
            var formDepartmentGetAndUpdate = new FormDepartmentGetAndUpdateAndDelete();
            formDepartmentGetAndUpdate.ShowDialog();
        }

        private void btnInstructorAdd_Click(object sender, EventArgs e)
        {
            var formDepartmentCreate = new FormDepartmentCreate();
            formDepartmentCreate.ShowDialog();
        }
    }
}
