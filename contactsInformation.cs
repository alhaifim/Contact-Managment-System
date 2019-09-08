using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsManager;
using System.IO;

namespace ContactsManager
{
    // Variables and controls names are selfdescriptive  
    public partial class contactsInformation : Form

    {
        public bool EditMode = false;   // for the update
        // Global variables used to pass the values from one form to another
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public string AcademicDepartment;
        public string SnailMailAndOfficeLocation;
        public DateTime GraduationYear;


        public List<string> CourseList
        {
            get
            {
                return courseList;
            }
            set
            {
                courseList = value;
            }
        }

        // Variables used for validating input data controls

        private bool haveValidFirstName;
        private bool haveValidLastName;
        private bool havValidEmailAddress;
        private bool haveValidAcademicDepartment;
        private bool haveValidMailAndOfficeLocation;
        private bool haveValidGraduationDate;
        private List<string> haveValidCourseList;

        private List<string> courseList = new List<string>();

        // Variables used to show and hide controls in the form 

        public bool LoadFacultyForm = false;
        public bool LoadStudentForm = false;
        public bool ContactDetialMode = false;


        public contactsInformation()
        {
            InitializeComponent();
        }
        
        //Function used to hide controls used for student form 
        private void hideStudentForm()
        {
            LoadStudentForm = false;
            LoadFacultyForm = true;
            graduationYearLabel.Visible = false;
            graduationYearDateTimePicker.Visible = false;
            graduationYearDateTimePicker.Enabled = false;
            courseListLabel.Visible = false;
            courseListListBox.Visible = false;
            addCourseLabel.Visible = false;
            courseListComboBox.Visible = false;
            addCourseButton.Visible = false;
            this.Size = new System.Drawing.Size(750, 300);  // Resizing the form
            snailMailLabel.Text = "Office Location Building:";
        } 
        // Assigning values of textboxes to variables
        private void showFacultyFormUpdates()
        {

            firstNameTextBox.Text = FirstName;
            lastNameTextBox.Text = LastName;
            emailAddressTextBox.Text = EmailAddress;
            academicDepartmentTextBox.Text = AcademicDepartment;
            snailMailAndOfficeLocationTextBox.Text = SnailMailAndOfficeLocation;
            Addbutton.Text = "Update";
            this.Text = "Update Contact Information";
        }

        private void contactsInformation_Load(object sender, EventArgs e)
        {
            
            // Code for loading the faculty form
            if (LoadFacultyForm)
            {
                // calling function that hides controls used for student form 
                hideStudentForm();  
                this.Text = "Faculty Contact Information";
            }
            // Code for loading the student form
            if (LoadStudentForm) 
            {
                
                this.Text = "Student Contact Information";
            }
            // Code for contactDetails to deisplay student Information
            if (ContactDetialMode && LoadStudentForm)
            {
                firstNameTextBox.Enabled= false;
                lastNameTextBox.Enabled = false;
                emailAddressTextBox.Enabled = false;
                academicDepartmentTextBox.Enabled = false;
                snailMailAndOfficeLocationTextBox.Enabled = false;
                graduationYearDateTimePicker.Enabled = false;
                this.Size = new System.Drawing.Size(750, 600);
                Addbutton.Visible = false;
                addCourseButton.Visible = false;
                addCourseLabel.Visible = false;
                courseListComboBox.Visible = false;
                courseListComboBox.Enabled = false;
                courseListListBox.Enabled = false;
            }
            // Code for contactDetails to deisplay Faculty Information
            if (ContactDetialMode && LoadFacultyForm)
            {
                hideStudentForm();
                // disabling properties -- will be used for displaying details
                firstNameTextBox.Enabled = false;
                lastNameTextBox.Enabled = false;
                emailAddressTextBox.Enabled = false;
                academicDepartmentTextBox.Enabled = false;
                snailMailAndOfficeLocationTextBox.Enabled = false;
                graduationYearDateTimePicker.Enabled = false;
                courseListComboBox.Enabled = false;
                Addbutton.Visible = false;
                addCourseButton.Visible = false;
                addCourseLabel.Visible = false;
                courseListComboBox.Visible = false;

            }
            // Eidt mode for Faculty
            if (EditMode && LoadFacultyForm)
            {
                hideStudentForm();
                showFacultyFormUpdates();

            }
            // Eidt mode for student
            if (EditMode && LoadStudentForm)
            {
                showFacultyFormUpdates();

                 
                foreach (string course in courseList)
                {
                    courseListListBox.Items.Add(course);
                }
            }
            
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            // Validating Form Controls
            string badFieldName = null;
            string adviceString = null;

            if (!haveValidFirstName)
            {
                badFieldName = "First Name";
                adviceString = "Must Enter A Valid First Name";
            }
            else if (!haveValidLastName)
            {
                badFieldName = "Last Name";
                adviceString = "Must Enter A Valid Last Name";
            }
            else if (!havValidEmailAddress)
            {
                badFieldName = "Email Address";
                adviceString = "Must have A Valid Email Address";
            }
            else if (!haveValidAcademicDepartment)
            {
                badFieldName = "Academic Department";
                adviceString = "Must Enter A Valid Academic Department";
            }
            else if (!haveValidMailAndOfficeLocation)
            {
                badFieldName = " Address";
                adviceString = "Must Enter A Valid Address";
            }



            else if (!haveValidGraduationDate && LoadStudentForm)
            {
                badFieldName = " Date";
                adviceString = "Graduation Date Must be in the Future";

            }



            if (badFieldName != null)
            {
                MessageBox.Show($"Invalid {badFieldName}.\n{adviceString}", "Data Entry Error");
                return;
            }




            DialogResult = DialogResult.OK;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Trim().Length == 0)
            {
                haveValidFirstName = false;
            }
            else
            {
                haveValidFirstName = true;
                FirstName = firstNameTextBox.Text.Trim();
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text.Trim().Length == 0)
            {
                haveValidLastName = false;
            }
            else
            {
                haveValidLastName = true;
                LastName = lastNameTextBox.Text.Trim();
            }
        }

        private void AcademicDepartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (academicDepartmentTextBox.Text.Trim().Length == 0)
            {
                haveValidAcademicDepartment = false;
            }
            else
            {
                haveValidAcademicDepartment = true;
                AcademicDepartment = academicDepartmentTextBox.Text.Trim();
            }
        }

        private void EmailAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailAddressTextBox.Text.Trim().Length == 0)
            {
                havValidEmailAddress = false;
            }
            else
            {
                havValidEmailAddress = true;
                EmailAddress = emailAddressTextBox.Text.Trim();
            }
        }

        private void SnailMailAndOfficeLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            if(snailMailAndOfficeLocationTextBox.Text.Trim().Length == 0)
            {
                haveValidMailAndOfficeLocation = false;
            }
            else
            {
                haveValidMailAndOfficeLocation = true;
                SnailMailAndOfficeLocation = snailMailAndOfficeLocationTextBox.Text.Trim();

            }


        }

        private void GraduationYearDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

                if ((graduationYearDateTimePicker.Value == null || graduationYearDateTimePicker.Value < DateTime.Today))
                {
                    haveValidGraduationDate = false;
                }

                else
                {
                    haveValidGraduationDate = true;
                    GraduationYear = graduationYearDateTimePicker.Value;
                }

            
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {

            if(courseListComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select A Course to Be added");
                return;
                
            }
            else if (courseListListBox.Items.Contains(courseListComboBox.Text.Trim()))
            {
                MessageBox.Show("Course Already Added to Your List of Courses");
                return;
            }
            else
            {
                courseList.Add(courseListComboBox.Text.Trim());
                courseListListBox.Items.Add(courseListComboBox.Text.Trim());
            }
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check to see if we have something Selected first.  Message if not
            if (courseListListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item First");
            }

            //Issue a confirmation dialog that item is really to be deleted 
            if (courseListListBox.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to delete the course", "RemoveItem", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Really Delete the item, Take it out of course list-
                    courseList.RemoveAt(courseListListBox.SelectedIndex);
                    courseListListBox.Items.RemoveAt(courseListListBox.SelectedIndex);
                    MessageBox.Show("Course Has been Removed");
                }

            }
        }
    }
}
