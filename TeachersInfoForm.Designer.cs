namespace Academy
{
    partial class TeachersInfoForm
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
            TeachersGridView = new DataGridView();
            teachersHeader = new Label();
            addTeacherButton = new Button();
            updateTeacherButton = new Button();
            deleteTeacherButton = new Button();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TeachersGridView).BeginInit();
            SuspendLayout();
            // 
            // TeachersGridView
            // 
            TeachersGridView.AllowUserToAddRows = false;
            TeachersGridView.AllowUserToDeleteRows = false;
            TeachersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeachersGridView.Location = new Point(54, 85);
            TeachersGridView.Name = "TeachersGridView";
            TeachersGridView.ReadOnly = true;
            TeachersGridView.RowHeadersWidth = 51;
            TeachersGridView.Size = new Size(769, 356);
            TeachersGridView.TabIndex = 0;
            // 
            // teachersHeader
            // 
            teachersHeader.AutoSize = true;
            teachersHeader.BorderStyle = BorderStyle.Fixed3D;
            teachersHeader.Font = new Font("Levenim MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teachersHeader.Location = new Point(344, 25);
            teachersHeader.Name = "teachersHeader";
            teachersHeader.Size = new Size(201, 40);
            teachersHeader.TabIndex = 1;
            teachersHeader.Text = "Teachers Info";
            // 
            // addTeacherButton
            // 
            addTeacherButton.BackColor = Color.SpringGreen;
            addTeacherButton.Font = new Font("Levenim MT", 12F, FontStyle.Bold);
            addTeacherButton.Location = new Point(104, 458);
            addTeacherButton.Name = "addTeacherButton";
            addTeacherButton.Size = new Size(165, 52);
            addTeacherButton.TabIndex = 2;
            addTeacherButton.Text = "Add";
            addTeacherButton.UseVisualStyleBackColor = false;
            addTeacherButton.Click += addTeacherButton_Click;
            // 
            // updateTeacherButton
            // 
            updateTeacherButton.BackColor = Color.Coral;
            updateTeacherButton.Font = new Font("Levenim MT", 12F, FontStyle.Bold);
            updateTeacherButton.Location = new Point(344, 458);
            updateTeacherButton.Name = "updateTeacherButton";
            updateTeacherButton.Size = new Size(165, 52);
            updateTeacherButton.TabIndex = 3;
            updateTeacherButton.Text = "Update";
            updateTeacherButton.UseVisualStyleBackColor = false;
            updateTeacherButton.Click += updateTeacherButton_Click;
            // 
            // deleteTeacherButton
            // 
            deleteTeacherButton.BackColor = Color.Firebrick;
            deleteTeacherButton.Font = new Font("Levenim MT", 12F, FontStyle.Bold);
            deleteTeacherButton.Location = new Point(594, 458);
            deleteTeacherButton.Name = "deleteTeacherButton";
            deleteTeacherButton.Size = new Size(165, 52);
            deleteTeacherButton.TabIndex = 4;
            deleteTeacherButton.Text = "Delete";
            deleteTeacherButton.UseVisualStyleBackColor = false;
            deleteTeacherButton.Click += deleteTeacherButton_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Levenim MT", 12F, FontStyle.Bold);
            backButton.Location = new Point(316, 537);
            backButton.Name = "backButton";
            backButton.Size = new Size(229, 52);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // TeachersInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 610);
            Controls.Add(backButton);
            Controls.Add(deleteTeacherButton);
            Controls.Add(updateTeacherButton);
            Controls.Add(addTeacherButton);
            Controls.Add(teachersHeader);
            Controls.Add(TeachersGridView);
            Name = "TeachersInfoForm";
            Text = "TeachersForm";
            Load += TeachersForm_Load;
            ((System.ComponentModel.ISupportInitialize)TeachersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TeachersGridView;
        private Label teachersHeader;
        private Button addTeacherButton;
        private Button updateTeacherButton;
        private Button deleteTeacherButton;
        private Button backButton;
    }
}