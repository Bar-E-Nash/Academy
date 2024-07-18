namespace Academy
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CoursesButton = new Button();
            TeachersButton = new Button();
            exitButton = new Button();
            StudentsButton = new Button();
            incomeOutcomeButton = new Button();
            SuspendLayout();
            // 
            // CoursesButton
            // 
            CoursesButton.Location = new Point(466, 42);
            CoursesButton.Name = "CoursesButton";
            CoursesButton.Size = new Size(211, 94);
            CoursesButton.TabIndex = 0;
            CoursesButton.Text = "View Courses";
            CoursesButton.UseVisualStyleBackColor = true;
            CoursesButton.Click += CoursesButton_Click;
            // 
            // TeachersButton
            // 
            TeachersButton.Location = new Point(120, 42);
            TeachersButton.Name = "TeachersButton";
            TeachersButton.Size = new Size(211, 94);
            TeachersButton.TabIndex = 1;
            TeachersButton.Text = "View Teachers";
            TeachersButton.UseVisualStyleBackColor = true;
            TeachersButton.Click += TeachersButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.Location = new Point(291, 390);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(210, 90);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // StudentsButton
            // 
            StudentsButton.Location = new Point(120, 213);
            StudentsButton.Name = "StudentsButton";
            StudentsButton.Size = new Size(211, 94);
            StudentsButton.TabIndex = 3;
            StudentsButton.Text = "View Studnets";
            StudentsButton.UseVisualStyleBackColor = true;
            StudentsButton.Click += StudentsButton_Click;
            // 
            // incomeOutcomeButton
            // 
            incomeOutcomeButton.Location = new Point(466, 213);
            incomeOutcomeButton.Name = "incomeOutcomeButton";
            incomeOutcomeButton.Size = new Size(211, 94);
            incomeOutcomeButton.TabIndex = 4;
            incomeOutcomeButton.Text = "Income/Outcome";
            incomeOutcomeButton.UseVisualStyleBackColor = true;
            incomeOutcomeButton.Click += incomeOutcomeButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 492);
            Controls.Add(incomeOutcomeButton);
            Controls.Add(StudentsButton);
            Controls.Add(exitButton);
            Controls.Add(TeachersButton);
            Controls.Add(CoursesButton);
            Font = new Font("Levenim MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "AdminForm";
            RightToLeft = RightToLeft.Yes;
            Text = "Admin Form";
            Load += AdminForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button CoursesButton;
        private Button TeachersButton;
        private Button exitButton;
        private Button StudentsButton;
        private Button incomeOutcomeButton;
    }
}
