namespace Academy
{
    partial class TeacherAddForm
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
            addTeacherHeader = new Label();
            fstNameLabel = new Label();
            lstNameLabel = new Label();
            HourFeeLbl = new Label();
            fstNameBox = new TextBox();
            lastNameBox = new TextBox();
            feeBox = new TextBox();
            cancelButton = new Button();
            addButton = new Button();
            SuspendLayout();
            // 
            // addTeacherHeader
            // 
            addTeacherHeader.AutoSize = true;
            addTeacherHeader.BorderStyle = BorderStyle.Fixed3D;
            addTeacherHeader.Font = new Font("Levenim MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeacherHeader.Location = new Point(141, 27);
            addTeacherHeader.Name = "addTeacherHeader";
            addTeacherHeader.Size = new Size(275, 48);
            addTeacherHeader.TabIndex = 0;
            addTeacherHeader.Text = "Teacher Details";
            // 
            // fstNameLabel
            // 
            fstNameLabel.AutoSize = true;
            fstNameLabel.Location = new Point(62, 115);
            fstNameLabel.Name = "fstNameLabel";
            fstNameLabel.Size = new Size(131, 32);
            fstNameLabel.TabIndex = 1;
            fstNameLabel.Text = "First Name";
            // 
            // lstNameLabel
            // 
            lstNameLabel.AutoSize = true;
            lstNameLabel.Location = new Point(61, 194);
            lstNameLabel.Name = "lstNameLabel";
            lstNameLabel.Size = new Size(132, 32);
            lstNameLabel.TabIndex = 2;
            lstNameLabel.Text = "Last Name";
            // 
            // HourFeeLbl
            // 
            HourFeeLbl.AutoSize = true;
            HourFeeLbl.Location = new Point(61, 280);
            HourFeeLbl.Name = "HourFeeLbl";
            HourFeeLbl.Size = new Size(133, 32);
            HourFeeLbl.TabIndex = 3;
            HourFeeLbl.Text = "Hourly Fee";
            // 
            // fstNameBox
            // 
            fstNameBox.Location = new Point(213, 112);
            fstNameBox.Name = "fstNameBox";
            fstNameBox.Size = new Size(243, 40);
            fstNameBox.TabIndex = 4;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(213, 191);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(243, 40);
            lastNameBox.TabIndex = 5;
            // 
            // feeBox
            // 
            feeBox.Location = new Point(213, 277);
            feeBox.Name = "feeBox";
            feeBox.Size = new Size(243, 40);
            feeBox.TabIndex = 6;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Tomato;
            cancelButton.Location = new Point(321, 363);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(135, 86);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightGreen;
            addButton.Location = new Point(62, 363);
            addButton.Name = "addButton";
            addButton.Size = new Size(135, 86);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // TeacherAddForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(553, 490);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(feeBox);
            Controls.Add(lastNameBox);
            Controls.Add(fstNameBox);
            Controls.Add(HourFeeLbl);
            Controls.Add(lstNameLabel);
            Controls.Add(fstNameLabel);
            Controls.Add(addTeacherHeader);
            Font = new Font("Levenim MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "TeacherAddForm";
            Text = "TeacherAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addTeacherHeader;
        private Label fstNameLabel;
        private Label lstNameLabel;
        private Label HourFeeLbl;
        private TextBox fstNameBox;
        private TextBox lastNameBox;
        private TextBox feeBox;
        private Button cancelButton;
        private Button addButton;
    }
}