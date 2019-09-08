namespace ContactsManager
{
    partial class contactsInformation
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
            this.components = new System.ComponentModel.Container();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.academicDepartmentLabel = new System.Windows.Forms.Label();
            this.contactInformationLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.snailMailLabel = new System.Windows.Forms.Label();
            this.graduationYearLabel = new System.Windows.Forms.Label();
            this.courseListLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.academicDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.snailMailAndOfficeLocationTextBox = new System.Windows.Forms.TextBox();
            this.courseListListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelButton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.graduationYearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addCourseLabel = new System.Windows.Forms.Label();
            this.courseListComboBox = new System.Windows.Forms.ComboBox();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(69, 15);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(178, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(436, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(70, 38);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // academicDepartmentLabel
            // 
            this.academicDepartmentLabel.AutoSize = true;
            this.academicDepartmentLabel.Location = new System.Drawing.Point(16, 64);
            this.academicDepartmentLabel.Name = "academicDepartmentLabel";
            this.academicDepartmentLabel.Size = new System.Drawing.Size(115, 13);
            this.academicDepartmentLabel.TabIndex = 3;
            this.academicDepartmentLabel.Text = "Academic Department:";
            // 
            // contactInformationLabel
            // 
            this.contactInformationLabel.AutoSize = true;
            this.contactInformationLabel.Location = new System.Drawing.Point(30, 90);
            this.contactInformationLabel.Name = "contactInformationLabel";
            this.contactInformationLabel.Size = new System.Drawing.Size(96, 13);
            this.contactInformationLabel.TabIndex = 4;
            this.contactInformationLabel.Text = "Conact Information";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(53, 116);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.emailAddressLabel.TabIndex = 5;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // snailMailLabel
            // 
            this.snailMailLabel.AutoSize = true;
            this.snailMailLabel.Location = new System.Drawing.Point(41, 148);
            this.snailMailLabel.Name = "snailMailLabel";
            this.snailMailLabel.Size = new System.Drawing.Size(94, 13);
            this.snailMailLabel.TabIndex = 6;
            this.snailMailLabel.Text = "snail Mail Address:";
            // 
            // graduationYearLabel
            // 
            this.graduationYearLabel.AutoSize = true;
            this.graduationYearLabel.Location = new System.Drawing.Point(41, 183);
            this.graduationYearLabel.Name = "graduationYearLabel";
            this.graduationYearLabel.Size = new System.Drawing.Size(87, 13);
            this.graduationYearLabel.TabIndex = 7;
            this.graduationYearLabel.Text = "Graduation Year:";
            // 
            // courseListLabel
            // 
            this.courseListLabel.AutoSize = true;
            this.courseListLabel.Location = new System.Drawing.Point(66, 251);
            this.courseListLabel.Name = "courseListLabel";
            this.courseListLabel.Size = new System.Drawing.Size(62, 13);
            this.courseListLabel.TabIndex = 8;
            this.courseListLabel.Text = "Course List:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(178, 38);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(433, 20);
            this.lastNameTextBox.TabIndex = 9;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // academicDepartmentTextBox
            // 
            this.academicDepartmentTextBox.Location = new System.Drawing.Point(178, 64);
            this.academicDepartmentTextBox.Name = "academicDepartmentTextBox";
            this.academicDepartmentTextBox.Size = new System.Drawing.Size(433, 20);
            this.academicDepartmentTextBox.TabIndex = 10;
            this.academicDepartmentTextBox.TextChanged += new System.EventHandler(this.AcademicDepartmentTextBox_TextChanged);
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(178, 116);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(433, 20);
            this.emailAddressTextBox.TabIndex = 12;
            this.emailAddressTextBox.TextChanged += new System.EventHandler(this.EmailAddressTextBox_TextChanged);
            // 
            // snailMailAndOfficeLocationTextBox
            // 
            this.snailMailAndOfficeLocationTextBox.Location = new System.Drawing.Point(178, 148);
            this.snailMailAndOfficeLocationTextBox.Name = "snailMailAndOfficeLocationTextBox";
            this.snailMailAndOfficeLocationTextBox.Size = new System.Drawing.Size(433, 20);
            this.snailMailAndOfficeLocationTextBox.TabIndex = 13;
            this.snailMailAndOfficeLocationTextBox.TextChanged += new System.EventHandler(this.SnailMailAndOfficeLocationTextBox_TextChanged);
            // 
            // courseListListBox
            // 
            this.courseListListBox.BackColor = System.Drawing.SystemColors.Info;
            this.courseListListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.courseListListBox.FormattingEnabled = true;
            this.courseListListBox.Location = new System.Drawing.Point(178, 251);
            this.courseListListBox.Name = "courseListListBox";
            this.courseListListBox.Size = new System.Drawing.Size(433, 173);
            this.courseListListBox.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(636, 484);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Addbutton.Location = new System.Drawing.Point(540, 483);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 19;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // graduationYearDateTimePicker
            // 
            this.graduationYearDateTimePicker.Location = new System.Drawing.Point(178, 178);
            this.graduationYearDateTimePicker.Name = "graduationYearDateTimePicker";
            this.graduationYearDateTimePicker.Size = new System.Drawing.Size(433, 20);
            this.graduationYearDateTimePicker.TabIndex = 20;
            this.graduationYearDateTimePicker.ValueChanged += new System.EventHandler(this.GraduationYearDateTimePicker_ValueChanged);
            // 
            // addCourseLabel
            // 
            this.addCourseLabel.AutoSize = true;
            this.addCourseLabel.Location = new System.Drawing.Point(61, 216);
            this.addCourseLabel.Name = "addCourseLabel";
            this.addCourseLabel.Size = new System.Drawing.Size(65, 13);
            this.addCourseLabel.TabIndex = 21;
            this.addCourseLabel.Text = "Add Course:";
            // 
            // courseListComboBox
            // 
            this.courseListComboBox.FormattingEnabled = true;
            this.courseListComboBox.Items.AddRange(new object[] {
            "C#",
            "ASP.NET",
            "JavaScript",
            "PHP",
            "HTML",
            "CSS",
            "Python",
            "UML",
            "Tech Sales",
            "SQL",
            ""});
            this.courseListComboBox.Location = new System.Drawing.Point(178, 207);
            this.courseListComboBox.Name = "courseListComboBox";
            this.courseListComboBox.Size = new System.Drawing.Size(287, 21);
            this.courseListComboBox.TabIndex = 22;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(489, 207);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(122, 23);
            this.addCourseButton.TabIndex = 23;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // contactsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(733, 519);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.courseListComboBox);
            this.Controls.Add(this.addCourseLabel);
            this.Controls.Add(this.graduationYearDateTimePicker);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.courseListListBox);
            this.Controls.Add(this.snailMailAndOfficeLocationTextBox);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.academicDepartmentTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.courseListLabel);
            this.Controls.Add(this.graduationYearLabel);
            this.Controls.Add(this.snailMailLabel);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.contactInformationLabel);
            this.Controls.Add(this.academicDepartmentLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "contactsInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Contact Information";
            this.Load += new System.EventHandler(this.contactsInformation_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label academicDepartmentLabel;
        private System.Windows.Forms.Label contactInformationLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label snailMailLabel;
        private System.Windows.Forms.Label graduationYearLabel;
        private System.Windows.Forms.Label courseListLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox academicDepartmentTextBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox snailMailAndOfficeLocationTextBox;
        private System.Windows.Forms.ListBox courseListListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.DateTimePicker graduationYearDateTimePicker;
        private System.Windows.Forms.Label addCourseLabel;
        private System.Windows.Forms.ComboBox courseListComboBox;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}