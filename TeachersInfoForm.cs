namespace Academy
{
    public partial class TeachersInfoForm : Form
    {
        public TeachersInfoForm()
        {
            InitializeComponent();
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            TeachersGridView.DataSource = DBmethods.GetTeachersTable();
        }
        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            Form tempAddTeacherForm = new TeacherAddForm();
            tempAddTeacherForm.Show();
        }


        private void updateTeacherButton_Click(object sender, EventArgs e)
        {

        }
        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {

        }


        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
