
namespace Academy
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void CoursesButton_Click(object sender, EventArgs e)
        {
            Form tempCourseForm = new CoursesInfoForm();
            
            tempCourseForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TeachersButton_Click(object sender, EventArgs e)
        {
            Form tempTeachersForm = new TeachersInfoForm();
            tempTeachersForm.Show();
        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void incomeOutcomeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
