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
using CourseSystem_BL.DTOs;
using CourseSystem_BL.DTOs.Department;
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_BL.Managers;
using CourseSystem_DAL;

namespace CourseSystem.Forms.Instructor
{
    public partial class FormInstructorUpdate : Form
    {
        private readonly ManagerInstructor managerInstructor;
        private readonly ManagerDepartment managerDepartment;
        private DTOInstructorUpdate instructorUpdate;
        private List<DTOInstructorPhone> instructorPhones;
        private List<DTODepartmentRead> departments;

        public FormInstructorUpdate()
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
        private void formState(bool state, Guid id)
        {
            txtFName.Enabled = state;
            txtLastName.Enabled = state;
            txtPhone.Enabled = state;
            btnUpdate.Enabled = state;
            cbDepartment.Enabled = state;
            if (id != Guid.Empty)
            {
                instructorUpdate = managerInstructor.GetById(id);
                txtFName.Text = instructorUpdate.FirstName;
                txtLastName.Text = instructorUpdate.LastName;
                txtPhone.Text = instructorUpdate.Phone;
                if (instructorUpdate.DepartmentId != null)
                {
                    cbDepartment.SelectedValue = instructorUpdate.DepartmentId;
                }

            }
       
        }

        private void cbInstructorsPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbInstructorsPhone.ValueMember = "Phone";
            cbDepartment.ValueMember = "Id";
            if (cbInstructorsPhone.SelectedValue != null)
            {
                txtInstructorSearchByPhone.Text = cbInstructorsPhone.SelectedValue.ToString();
                var id = instructorPhones.FirstOrDefault(i => i.Phone == cbInstructorsPhone.SelectedValue.ToString()).Id;
                txtId.Text = id.ToString();
                formState(true, id);
            }
            else
            {
                formState(false, Guid.Empty);
                txtId.Text = "Not Exist";

            }
        }



        private void txtInstructorSearchByPhone_TextChanged(object sender, EventArgs e)
        {
            cbInstructorsPhone.SelectedValue = txtInstructorSearchByPhone.Text;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            instructorUpdate.FirstName=txtFName.Text;
            instructorUpdate.LastName = txtLastName.Text;
            instructorUpdate.DepartmentId = new Guid(cbDepartment.SelectedValue.ToString());
            instructorUpdate.Phone= txtPhone.Text;
            try
            {
                formState(false, Guid.Empty);

                managerInstructor.Update(instructorUpdate);
                var x = instructorPhones.Find(i => i.Id == instructorUpdate.Id);
                x.Name = $"{instructorUpdate.FirstName} {instructorUpdate.LastName}";
                x.Phone = txtPhone.Text;
                txtInstructorSearchByPhone.Text=instructorUpdate.Phone;
                errorProvider.Clear();

            }
            catch (Exception ex) 
            {
                formState(true, instructorUpdate.Id);
                errorProvider.SetError(txtPhone, "Phone is used");

            }
        }
    }
}
