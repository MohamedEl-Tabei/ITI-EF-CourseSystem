using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseSystem_BL.DTOs.Department;
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_BL.Managers;
using CourseSystem_BL;
using CourseSystem_DAL;

namespace CourseSystem.Forms.Department
{
    public partial class FormDepartmentCreate : Form
    {
        private readonly ManagerInstructor managerInstructor;
        private readonly ManagerDepartment managerDepartment;
        private List<DTOInstructorPhone> instructorPhones;
        private DTODepartmentCreate departmentCreate { get; set; }
        public FormDepartmentCreate()
        {
            InitializeComponent();
            managerInstructor = new ManagerInstructor();
            managerDepartment = new ManagerDepartment();
            departmentCreate = new DTODepartmentCreate();
            dgvdepartment.DataSource = managerDepartment.GetDepartmentsWithManager();
            instructorPhones = managerInstructor.InstructorsPhone();
            #region instructors
            cbInstructorsPhone.DataSource = instructorPhones;
            cbInstructorsPhone.DisplayMember = "Name";
            cbInstructorsPhone.ValueMember = "Phone";
            #endregion

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (txtlocation.Text.Length > 0) departmentCreate.Location = txtlocation.Text;
            var phone = cbInstructorsPhone.SelectedValue.ToString();
            departmentCreate.ManagerId = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id; ;
            departmentCreate.Name = txtName.Text;
            try
            {
                managerDepartment.Create(departmentCreate);
                dgvdepartment.DataSource = managerDepartment.GetDepartmentsWithManager();
                errorProvider1.Clear();

            }
            catch
            {

                errorProvider1.SetError(cbInstructorsPhone, "Is Manager");
            }
        }

        private void cbInstructorsPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbInstructorsPhone.ValueMember = "Phone";
            if (cbInstructorsPhone.SelectedValue != null)
            {
                var phone = cbInstructorsPhone.SelectedValue.ToString();
                var id = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id;
                txtInstructorSearchByPhone.Text = phone;
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }
    }
}
