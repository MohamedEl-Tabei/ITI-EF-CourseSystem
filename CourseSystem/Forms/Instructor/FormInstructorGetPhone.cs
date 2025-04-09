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
using CourseSystem_DAL;

namespace CourseSystem.Forms.Instructor
{
    public partial class FormInstructorGetPhone : Form
    {
        private readonly ManagerInstructor managerInstructor;
        public FormInstructorGetPhone()
        {
            managerInstructor = new ManagerInstructor();
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtInstructorSearchByPhone.Text.Length > 0)
            {
                var instructor = managerInstructor.GetByPhone(txtInstructorSearchByPhone.Text);
                if (instructor != null)
                {
                    txtDepartment.Text = instructor.Department;
                    txtName.Text = instructor.Name;
                    txtPhone.Text = instructor.Phone;
                    txtId.Text = instructor.Id.ToString();
                    errorProvider1.Clear();
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtInstructorSearchByPhone, "Phone is not exist");
                }
            }
            else
            {
                errorProvider1.SetError(txtInstructorSearchByPhone, "Please enter phone");
            }
            txtDepartment.Text = "";
            txtName.Text = "";
            txtPhone.Text ="";
            txtId.Text = "";
        }

        
    }
}
