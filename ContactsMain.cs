using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager
{
    public class ContactsMain
    { // Public properties of Contact Manager Class
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string AcademicDepartment { get { return academicDepartment; } }
        public string EmailAddress { get { return emailAddress; } }


        // Private SHADOW Properties
        private string firstName;
        private string lastName;
        private string academicDepartment;
        private string emailAddress;

        // Constructors .  It should be exactly the same name of the class

        public ContactsMain(string firstname,
                               string lastname,
                               string academicdepartment,
                               string emailaddress)
        {
            if (!(validateInputString(firstname)))
            {
                throw new ArgumentException("Unspported first name syntax");

            }
            if (!(validateInputString(lastname)))
            {
                throw new ArgumentException("Unspported last name syntax");

            }
            if (!(validateInputString(academicdepartment)))
            {
                throw new ArgumentException("Unspported last name syntax");

            }
            if (!(validateInputString(emailaddress)))
            {
                throw new ArgumentException("Unspported last contact email syntax");

            }
            firstName = firstname;
            lastName = lastname;
            academicDepartment = academicdepartment;
            emailAddress = emailaddress;

        }
        //Formating saved data into a file
        public virtual string ToFileString()
        {
            string theString = "";
            theString += $"{ firstName}|"; 
            theString += $"{ lastName}|";
            theString += $"{ academicDepartment}|";
            theString += $"{ emailAddress}";

            return theString;
        }
        // Display data in the listbox
        public virtual string ToFormattedString()
        {
            string theString = "";
            theString += $"{ firstName, -20}"; // 30 mean 30 chars wide minus me left justify
            theString += $"{ lastName, -10}";
            theString += $"{ academicDepartment ,15}";

            return theString;
        }
        // Constructor when opening a new file
        public ContactsMain(string fromFile)
        {

            char[] delimeters = { '|', ',' };

            string[] tokens = fromFile.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            firstName            = tokens[0];
            lastName             = tokens[1];
            academicDepartment   = tokens[2];
            emailAddress         = tokens[3];
        }


        // Private Helper Method
        private bool validateInputString(string inputstring)
        {
            if (!(inputstring != null) && (inputstring.Length > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}

