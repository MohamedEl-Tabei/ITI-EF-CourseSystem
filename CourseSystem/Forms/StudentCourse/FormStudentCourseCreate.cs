using CourseSystem_BL.DTOs.CourseStudent;
using CourseSystem_BL.Managers;

namespace CourseSystem.Forms.StudentCourse
{
    public partial class FormStudentCourseCreate : Form
    {
        private readonly ManagerCourseStudent managerCourseStudent;
        public FormStudentCourseCreate()
        {
            InitializeComponent();
            managerCourseStudent = new ManagerCourseStudent();
            var managerCourse = new ManagerCourse();
            var managerStudent = new ManagerStudent();

            dgvdepartment.DataSource = managerCourseStudent.GetWithStudentAndCourse();
            cbCourse.DataSource = managerCourse.Get();
            cbStudent.DataSource = managerStudent.Get();

            cbCourse.ValueMember = "Id";
            cbCourse.DisplayMember = "Name";
            cbStudent.ValueMember = "Id";
            cbStudent.DisplayMember = "FirstName";

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {

                var data = new DTOCourseStudent
                {
                    CourseId = Guid.Parse(cbCourse.SelectedValue.ToString()),
                    StudentId = Guid.Parse(cbStudent.SelectedValue.ToString()),
                    CourseName = cbCourse.Text,
                    StudentName = cbStudent.Text,
                };
                managerCourseStudent.Create(data);
                dgvdepartment.DataSource = managerCourseStudent.GetWithStudentAndCourse();
                errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cbStudent, ex.Message);

            }
        }
    }
}
