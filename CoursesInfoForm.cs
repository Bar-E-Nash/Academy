namespace Academy
{
    public partial class CoursesInfoForm : Form
    {
        public CoursesInfoForm()
        {
            InitializeComponent();
        }

        private void CoursesInfoForm_Load(object sender, EventArgs e)
        {
            CoursesGridView.DataSource = DBmethods.GetCoursesTable();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void CoursesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
