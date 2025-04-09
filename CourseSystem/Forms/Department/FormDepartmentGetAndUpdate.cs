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
using CourseSystem_BL.DTOs;
using CourseSystem_BL.Managers;
using CourseSystem_BL;
using CourseSystem_DAL;

namespace CourseSystem.Forms.Department
{
    public partial class FormDepartmentGetAndUpdate : Form
    {
        private readonly ManagerInstructor managerInstructor;
        private readonly ManagerDepartment managerDepartment;
        private List<DTOInstructorPhone> instructorPhones;
        private List<DTODepartmentRead> departments;
        private DTODepartmentUpdate departmentUpdate { get; set; }
        public FormDepartmentGetAndUpdate()
        {
            InitializeComponent();

            managerInstructor = new ManagerInstructor();
            managerDepartment = new ManagerDepartment();
            instructorPhones = managerInstructor.InstructorsPhone();
            departments = managerDepartment.Get();
            #region instructors
            cbInstructorsPhone.DataSource = instructorPhones;
            cbInstructorsPhone.DisplayMember = "Name";
            cbInstructorsPhone.ValueMember = "Phone";
            #endregion
            #region Departments
            cbDepartment.DataSource = departments;
            cbDepartment.ValueMember = "Id";
            cbDepartment.DisplayMember = "Name";
            #endregion
        }


        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentUpdate = managerDepartment.GetById(new Guid(cbDepartment.SelectedValue.ToString()));
            txtId.Text = departmentUpdate.Id.ToString();
            cbInstructorsPhone.SelectedValue = instructorPhones.FirstOrDefault(i => i.Id.Equals(departmentUpdate.ManagerId)).Phone ;
            txtlocation.Text = departmentUpdate.Location;
            txtName.Text = departmentUpdate.Name;
        }

        private void cbInstructorsPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbInstructorsPhone.ValueMember = "Phone";
            cbDepartment.ValueMember = "Id";
            if (cbInstructorsPhone.SelectedValue != null)
            {
                var phone = cbInstructorsPhone.SelectedValue.ToString();
                var id = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id;
                txtInstructorSearchByPhone.Text = phone;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtlocation.Text.Length > 0) departmentUpdate.Location = txtlocation.Text;
            var phone = cbInstructorsPhone.SelectedValue.ToString();
            departmentUpdate.ManagerId = instructorPhones.FirstOrDefault(i => i.Phone == phone).Id; ;
            departmentUpdate.Name = txtName.Text;
            try
            {
                managerDepartment.Update(departmentUpdate);
                errorProvider1.Clear();
            }
            catch {

                errorProvider1.SetError(cbInstructorsPhone, "Is Manager");
            }

        }
    }
}
