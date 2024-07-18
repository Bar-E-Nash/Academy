namespace Academy
{
    partial class CoursesInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backButton = new Button();
            deleteCourseButton = new Button();
            updateCourseButton = new Button();
            addCourseButton = new Button();
            coursesHeader = new Label();
            CoursesGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CoursesGridView).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Font = new Font("Levenim MT", 12F, FontStyle.Bold);
            backButton.Location = new Point(316, 539);
            backButton.Name = "backButton";
            backButton.Size = new Size(229, 52);
            backButton.TabIndex = 11;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // deleteCourseButton
            // 
            deleteCourseButton.BackColor = Color.Firebrick;
            deleteCourseButton.Font = new Font("Levenim MT", 12F, FontStyle.Bold);
            deleteCourseButton.Location = new Point(594, 455);
            deleteCourseButton.Name = "deleteCourseButton";
            deleteCourseButton.Size = new Size(165, 52);
            deleteCourseButton.TabIndex = 10;
            deleteCourseButton.Text = "Delete";
            deleteCourseButton.UseVisualStyleBackColor = false;
            deleteCourseButton.Click += deleteCourseButton_Click;
            // 
            // updateCourseButton
            // 
            updateCourseButton.BackColor = Color.Coral;
            updateCourseButton.Font = new Font("Levenim MT", 12F, FontStyle.Bold);
            updateCourseButton.Location = new Point(344, 455);
            updateCourseButton.Name = "updateCourseButton";
            updateCourseButton.Size = new Size(165, 52);
            updateCourseButton.TabIndex = 9;
            updateCourseButton.Text = "Update";
            updateCourseButton.UseVisualStyleBackColor = false;
            updateCourseButton.Click += updateCourseButton_Click;
            // 
            // addCourseButton
            // 
            addCourseButton.BackColor = Color.SpringGreen;
            addCourseButton.Font = new Font("Levenim MT", 12F, FontStyle.Bold);
            addCourseButton.Location = new Point(104, 455);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(165, 52);
            addCourseButton.TabIndex = 8;
            addCourseButton.Text = "Add";
            addCourseButton.UseVisualStyleBackColor = false;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // coursesHeader
            // 
            coursesHeader.AutoSize = true;
            coursesHeader.BorderStyle = BorderStyle.Fixed3D;
            coursesHeader.Font = new Font("Levenim MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coursesHeader.Location = new Point(344, 22);
            coursesHeader.Name = "coursesHeader";
            coursesHeader.Size = new Size(187, 40);
            coursesHeader.TabIndex = 7;
            coursesHeader.Text = "Courses Info";
            // 
            // CoursesGridView
            // 
            CoursesGridView.AllowUserToAddRows = false;
            CoursesGridView.AllowUserToDeleteRows = false;
            CoursesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesGridView.Location = new Point(54, 82);
            CoursesGridView.Name = "CoursesGridView";
            CoursesGridView.ReadOnly = true;
            CoursesGridView.RowHeadersWidth = 51;
            CoursesGridView.Size = new Size(769, 356);
            CoursesGridView.TabIndex = 6;
            CoursesGridView.CellContentClick += CoursesGridView_CellContentClick;
            // 
            // CoursesInfoForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(877, 610);
            Controls.Add(backButton);
            Controls.Add(deleteCourseButton);
            Controls.Add(updateCourseButton);
            Controls.Add(addCourseButton);
            Controls.Add(coursesHeader);
            Controls.Add(CoursesGridView);
            Name = "CoursesInfoForm";
            Text = "CoursesInfoForm";
            Load += CoursesInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)CoursesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button deleteCourseButton;
        private Button updateCourseButton;
        private Button addCourseButton;
        private Label coursesHeader;
        private DataGridView CoursesGridView;
    }
}