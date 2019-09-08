using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ContactsManager;

// names of controls and variables indicates their functions

namespace ContactsManager
{
    
    public partial class mainForm : Form
    {
        
         // Definig Global Variables
        public List<ContactsMain> ContactsDataList = new List<ContactsMain>();   //Defining a list to store student data values
        string Filepath = null;
        private bool alreadySaved = false; 
        private contactsInformation cif = new contactsInformation();

        Faculty FI = null;
        Student SI = null;
        ContactsMain CM = null;
        

        public mainForm()
        {
            InitializeComponent();
        }

        private void editFacultyContact(int index)
        {
            // Create Dialog and Configure for eidit
            contactsInformation cif = new contactsInformation();
            cif.EditMode = true;
            cif.LoadFacultyForm = true;

            Faculty f = (Faculty)ContactsDataList[index];

            cif.FirstName = f.FirstName;
            cif.LastName = f.LastName;
            cif.AcademicDepartment = f.AcademicDepartment;
            cif.EmailAddress = f.EmailAddress;
            cif.SnailMailAndOfficeLocation = f.OfficeLocationBuilding;

            // Show the Dialog and Wait for OK
            DialogResult result = cif.ShowDialog();

            // If Answer was OK update the ContactList with the new values

            if (result != DialogResult.OK)
                return;

            ContactsMain CM = new Faculty(cif.FirstName,
                                   cif.LastName,
                                   cif.AcademicDepartment,
                                   cif.EmailAddress,
                                   cif.SnailMailAndOfficeLocation);


            ContactsDataList[index] = CM;

            result = MessageBox.Show($"Are you sure to update {CM.FirstName}?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                ContactsDataList[index] = CM;

                contactListDiplayListBox.Items[index] = CM.ToFormattedString();

            }
            alreadySaved = false;


        }
        private void editStudentContact(int index)
        {
            // Create Dialog and Configure for eidit
            contactsInformation cis = new contactsInformation();
            cis.EditMode = true;
            cis.LoadStudentForm = true;
            Student S = (Student)ContactsDataList[index];

            cis.FirstName = S.FirstName;
            cis.LastName = S.LastName;
            cis.AcademicDepartment = S.AcademicDepartment;
            cis.EmailAddress = S.EmailAddress;
            cis.SnailMailAndOfficeLocation = S.SnailMailAddress;
            cis.GraduationYear = S.GraduationYear;
            cis.CourseList = S.CourseList;

            
            // Show the Dialog and Wait for OK
            DialogResult result = cis.ShowDialog();

            // If Answer was OK update the ContactList with the new values

            if (result != DialogResult.OK)
                return;

            ContactsMain CM = new Student(cis.FirstName,
                                   cis.LastName,
                                   cis.AcademicDepartment,
                                   cis.EmailAddress,
                                   cis.SnailMailAndOfficeLocation,
                                   cis.GraduationYear,
                                   cis.CourseList);


            ContactsDataList[index] = CM;

            result = MessageBox.Show($"Are you sure to update {CM.FirstName}?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                ContactsDataList[index] = CM;

                contactListDiplayListBox.Items[index] = CM.ToFormattedString();

            }
            alreadySaved = false;

        }




        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            contactsInformation cif = new contactsInformation();
            cif.LoadFacultyForm = true;
            cif.LoadStudentForm = false;
            DialogResult result;
          
            // Show the Dialog and Wait for OK
            result = cif.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }


            try
            {
                FI = new Faculty(cif.FirstName,
                                   cif.LastName,
                                   cif.AcademicDepartment,
                                   cif.EmailAddress,
                                   cif.SnailMailAndOfficeLocation);



            }
            catch
            {
                throw new ArgumentException("Unable to Create a New Faculty Entery. Invalid Entery");

            }
            ContactsDataList.Add(FI);
            contactListDiplayListBox.Items.Add(FI.ToFormattedString());
            alreadySaved = false;


        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactsInformation cis = new contactsInformation();
            cis.LoadStudentForm = true;
            DialogResult result;
            result = cis.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            try
            {
                SI = new Student(cis.FirstName,
                                   cis.LastName,
                                   cis.AcademicDepartment,
                                   cis.EmailAddress,
                                   cis.SnailMailAndOfficeLocation,
                                   cis.GraduationYear,
                                   cis.CourseList);



            }
            catch
            {
                throw new ArgumentException("Unable to Create a New Faculty Entery. Invalid Entery");

            }
            ContactsDataList.Add(SI);
            contactListDiplayListBox.Items.Add(SI.ToFormattedString());  // this is in the main form
            alreadySaved = false;

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            alreadySaved = true;
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check to see if we have something Selected first.  Message if not
            if (contactListDiplayListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item First");
            }

            //Issue a confirmation dialog that item is really to be deleted 
            if (contactListDiplayListBox.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to delete the Item", "RemoveItem", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Really Delete the item, Take it out of Contact list-
                    ContactsDataList.RemoveAt(contactListDiplayListBox.SelectedIndex);
                    contactListDiplayListBox.Items.RemoveAt(contactListDiplayListBox.SelectedIndex);
                    MessageBox.Show("Contact Has been Removed");
                }

            }
            alreadySaved = false;
        }

        // Method Used for SAVE AS
        public void SaveAs(string filePath)
        {

            try
            {
                
                StreamWriter output = new StreamWriter(filePath);
                foreach (ContactsMain c in ContactsDataList)
                {
                    if (c is Student)
                    {
                        output.WriteLine("Student");
                        output.WriteLine(c.ToFileString());
                    }
                    else if (c is Faculty)
                    {
                        output.WriteLine("Faculty");
                        output.WriteLine(c.ToFileString());
                    }

                    
                }
                output.Close();

            }
            catch (Exception excp)
            {
                MessageBox.Show($"Error:File did not write.{excp.Message}");
                return;
            }
            MessageBox.Show($"Contacts List have been saved");
        }


        private void saveContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(contactListDiplayListBox.Items.Count !=0)
                {
                if (Filepath == null)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    SaveAs(Filepath);
                }
            }
            alreadySaved = true;


        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contactListDiplayListBox.Items.Count != 0)
            {
            // Get the fiel path
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".txt";
            sfd.Filter = "Text File|*.txt|All Files|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Filepath = sfd.FileName;

            SaveAs(sfd.FileName);
            }
            alreadySaved = true;
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = contactListDiplayListBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please Select an Item First");
                return;
            }
            // Create the edit Dialog, have it prepopulate the contents of the field and
            // Show the Dialog

            ContactsMain CM = ContactsDataList[index];

            if (CM is Student)
            {
                editStudentContact(index);
            }
            else if (CM is Faculty)
            {
                editFacultyContact(index);
            }
            else
            {
                MessageBox.Show("Unknow Product");
            }
            alreadySaved = false;

            //If the user selects cancel, give up, if the user selects upates then change all the 
            // fields in the object

        }



        private void contactDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = contactListDiplayListBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please Select an Item First");
                return;
            }

            // Create the edit Dialog, have it prepopulate the contents of the field and
            // Show the Dialog

            ContactsMain CM = ContactsDataList[index];

            if (CM is Student)
            {
                // Create Dialog and Configure for edit
                contactsInformation ci = new contactsInformation();
                ci.ContactDetialMode = true;
                ci.EditMode = true;
                ci.LoadStudentForm = true;
                Student S = (Student)ContactsDataList[index];

                ci.FirstName = S.FirstName;
                ci.LastName = S.LastName;
                ci.AcademicDepartment = S.AcademicDepartment;
                ci.EmailAddress = S.EmailAddress;
                ci.SnailMailAndOfficeLocation = S.SnailMailAddress;
                ci.GraduationYear = S.GraduationYear;
                ci.CourseList = S.CourseList;

                // Show the Dialog and Wait for OK
                DialogResult result = ci.ShowDialog();

                // If Answer was OK update the ContactList with the new values

                if (result != DialogResult.OK)
                    return;

                CM = new Student(ci.FirstName,
                                      ci.LastName,
                                      ci.AcademicDepartment,
                                      ci.EmailAddress,
                                      ci.SnailMailAndOfficeLocation,
                                      ci.GraduationYear,
                                      ci.CourseList);


                ContactsDataList[index] = CM;

            }
            else if (CM is Faculty)
            {
                // Create Dialog and Configure for eidit
                contactsInformation cif = new contactsInformation();
                cif.EditMode = true;
                cif.LoadFacultyForm = true;
                cif.ContactDetialMode = true;

                Faculty f = (Faculty)ContactsDataList[index];

                cif.FirstName = f.FirstName;
                cif.LastName = f.LastName;
                cif.AcademicDepartment = f.AcademicDepartment;
                cif.EmailAddress = f.EmailAddress;
                cif.SnailMailAndOfficeLocation = f.OfficeLocationBuilding;

                // Show the Dialog and Wait for OK
                DialogResult result = cif.ShowDialog();

                // If Answer was OK update the ContactList with the new values

                if (result != DialogResult.OK)
                    return;

                CM = new Faculty(cif.FirstName,
                                      cif.LastName,
                                      cif.AcademicDepartment,
                                      cif.EmailAddress,
                                      cif.SnailMailAndOfficeLocation);


                ContactsDataList[index] = CM;

            }
            else
            {
                MessageBox.Show("Unknow Product");
            }




        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a Text File";
            ofd.Filter = "Text File|*.txt|All Files|*.*";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            contactListDiplayListBox.Items.Clear();
            ContactsDataList.Clear();
            Filepath = ofd.FileName;

            // Read customer data from file and loading the data 

            ContactsMain CI = null;
            try
            {
                // file automatically will be saved to in the project Debug folder


                StreamReader input = new StreamReader(ofd.FileName);
                while (!input.EndOfStream)
                {
                   
                    string Type = input.ReadLine();
                    switch (Type)
                    {
                        case "Faculty": CI = new Faculty(input.ReadLine()); break;
                        case "Student": CI = new Student(input.ReadLine()); break;
                   

                        default:
                            MessageBox.Show("Unknow Value");
                            break;

                    }

                    if (CI != null)
                    {
                        ContactsDataList.Add(CI);
                        contactListDiplayListBox.Items.Add(CI.ToFormattedString());


                    }
                    CI = null;

                }
                input.Close();

            }

            catch (IOException excp)
            {
                MessageBox.Show($"File did not Load.{excp.Message}");
                return;
            }
            MessageBox.Show("File has been loaded");
            alreadySaved = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
                          

        }

        private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            searchForm sF = new searchForm();
            contactListDiplayListBox.ClearSelected();
            contactListDiplayListBox.SelectionMode = SelectionMode.MultiExtended;
            sF.SearchByFirstName = true;
            DialogResult result;
            result = sF.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            foreach(ContactsMain item in ContactsDataList)
            {
                if(item.FirstName.Trim().ToLower() == sF.FirstName.Trim().ToLower())
                {
                    contactListDiplayListBox.SetSelected(ContactsDataList.IndexOf(item), true);
                }
            }
            MessageBox.Show($"{contactListDiplayListBox.SelectedItems.Count.ToString()} items found");

        }

        private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchForm sF = new searchForm();
            contactListDiplayListBox.ClearSelected();
            contactListDiplayListBox.SelectionMode = SelectionMode.MultiExtended;
            sF.SearchByLastName = true;
            DialogResult result;
            result = sF.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            foreach (ContactsMain item in ContactsDataList)
            {
                if (item.LastName.Trim().ToLower() == sF.LastName.Trim().ToLower())
                {
                     contactListDiplayListBox.SetSelected(ContactsDataList.IndexOf(item), true);

                }
                
            }
            MessageBox.Show($"{contactListDiplayListBox.SelectedItems.Count.ToString()} items found");
        }

        private void firstAndLastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchForm sF = new searchForm();
            contactListDiplayListBox.ClearSelected();
            contactListDiplayListBox.SelectionMode = SelectionMode.MultiExtended;
            DialogResult result;
            result = sF.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            foreach (ContactsMain item in ContactsDataList)
            {
                if ((item.FirstName.Trim().ToLower() == sF.FirstName.Trim().ToLower()) && (item.LastName.Trim().ToLower() == sF.LastName.Trim().ToLower()))
                {
                    contactListDiplayListBox.SetSelected(ContactsDataList.IndexOf(item), true);
                }
            }
            MessageBox.Show($"{contactListDiplayListBox.SelectedItems.Count.ToString()} items found");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm aF = new aboutForm();
            DialogResult result;
            result = aF.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
        }



        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!alreadySaved)   // to check if the file already saved before exiting
            {
                //calling the save event
                DialogResult result = MessageBox.Show("Do you want to save your changes before closing", "Confirm Close without Saving", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    saveContactsToolStripMenuItem_Click(sender, e);
                }

                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
    
}
    


