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
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_BL.Managers;

namespace CourseSystem.Forms.Instructor
{
    public partial class FormInstructorCreate : Form
    {
        private readonly ManagerDepartment managerDepartment;
        private readonly ManagerInstructor managerInstructor;
        private DTOInstructorCreate newInstructor { get; set; }
        private List<DTOInstructorRead> instructors { get; set; }
        public FormInstructorCreate()
        {
            newInstructor = new DTOInstructorCreate();
            managerDepartment = new ManagerDepartment();
            managerInstructor = new ManagerInstructor();
            InitializeComponent();
            var departments = managerDepartment.Get();
            cbDepartment.DataSource = departments;
            cbDepartment.DisplayMember = "Name";
            cbDepartment.ValueMember = "Id";
            instructors = managerInstructor.GetWithDepartment();
            dgvInstructors.DataSource = instructors;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                errorProvider1.SetError(txtFName, "First Name Required");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (txtLastName.Text == "")
            {
                errorProvider2.SetError(txtLastName, "Last Name Required");
                return;
            }
            else
            {
                errorProvider2.Clear();
            }
            if (txtPhone.Text.Length != 11)
            {
                errorProvider3.SetError(txtPhone, "Invalid Phone");
                return;
            }
            else
            {
                errorProvider3.Clear();
            }
            try
            {

                newInstructor.Phone = txtPhone.Text;
                newInstructor.LastName = txtLastName.Text;
                newInstructor.FirstName = txtFName.Text;
                newInstructor.DepartmentId = new Guid(cbDepartment.SelectedValue.ToString());
                managerInstructor.Create(newInstructor);
                errorProvider3.Clear();
                txtPhone.Text = "";
                txtLastName.Text = "";
                txtFName.Text = "";
                instructors = managerInstructor.GetWithDepartment();
                dgvInstructors.DataSource = instructors;
            }
            catch (Exception ex)
            {

                errorProvider3.SetError(txtPhone, "Phone is used");
            }

        }
    }
}
