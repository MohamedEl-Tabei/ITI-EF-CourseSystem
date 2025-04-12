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

        private void btnInstructorUpdate_Click(object sender, EventArgs e)
        {
            var formInstructorUpdate = new FormInstructorUpdateDelete();
            formInstructorUpdate.ShowDialog();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            var formInstructorGetPhone = new FormInstructorGetPhone();
            formInstructorGetPhone.ShowDialog();
        }

        private void btnInstructorAdd_Click(object sender, EventArgs e)
        {
            var formInstructorCreate = new FormInstructorCreate();
            formInstructorCreate.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formInstructorGetByDepartment = new FormInstructorGetByDepartment();
            formInstructorGetByDepartment.ShowDialog();
        }
    }
}
