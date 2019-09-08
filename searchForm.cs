using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsManager
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();

        }

        // Initializing variables used for validations 
        // names of controls and variables indicates their functions
        public bool SearchByFirstName = false;
        public bool SearchByLastName = false;
        public string FirstName;
        public string LastName;
        public string SearchMethod;

        private void searchForm_Load(object sender, EventArgs e)
        {
            if (SearchByFirstName)

            {
                // Disabling LastName properties
                searchLastNameTextBox.Visible = false;
                searchLastNameTextBox.Enabled = false;
                searchLastNameLabel.Visible = false;
                this.Size = new Size(450, 200);



            }

            if (SearchByLastName)

            {
                // Disabling FirstName properties
                searchFirstNameTextBox.Visible = false;
               searchFirstNameTextBox.Enabled = false;
                searchFirstNameLabel.Visible = false;

                this.Size = new Size(450, 200);

            }

        }

        // variables used for validating first and last name textboxes
        private bool haveValidFirstName;
        private bool haveValidLastName;

        private void searchButton_Click(object sender, EventArgs e)
        {
            string badFieldName = null;
            string adviceString = null;

            if (!haveValidFirstName && SearchByFirstName)
            {
                badFieldName = "First Name";
                adviceString = "Must Enter A Valid First Name";
            }
       else if (!haveValidLastName && SearchByLastName)
            {
                badFieldName = "Last Name";
                adviceString = "Must Enter A Valid Last Name";
            }
            else if (!haveValidLastName && !haveValidFirstName)
            {
                badFieldName = "Name";
                adviceString = "Must Enter A Valid Name";
            }
            if (badFieldName != null)
            {
                MessageBox.Show($"Invalid {badFieldName}.\n{adviceString}", "Data Entry Error");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void searchFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchFirstNameTextBox.Text.Trim().Length == 0)  // Checking if the textbox is not empty
            {
                haveValidFirstName = false;
            }
            else
            {
                haveValidFirstName = true;
                FirstName = searchFirstNameTextBox.Text.Trim();
            }
        }

        private void searchLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchLastNameTextBox.Text.Trim().Length == 0) // Checking if the textbox is not empty
            {
                haveValidLastName = false;
            }
            else
            {
                haveValidLastName = true;
                LastName = searchLastNameTextBox.Text.Trim();
            }
        }

        private void searchFormCancelButton_Click(object sender, EventArgs e)
        {
            // Cancel Button Code
            DialogResult = DialogResult.Cancel;   
        }
    }
    
}
