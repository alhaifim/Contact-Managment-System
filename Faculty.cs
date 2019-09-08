using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager
{
    public class Faculty : ContactsMain
    {
        //Public variables 
        public string OfficeLocationBuilding { get { return officeLocationBuilding; } }
        public string Type = "Faculty";

        //Privates variables
        private string officeLocationBuilding;

        // Constructors .  It should be exactly the same name of the class
        public Faculty(string firstname,
                               string lastname,
                               string academicdepartment,
                               string emailaddress,
                               string officelocationbuilding): base(firstname, lastname, academicdepartment, emailaddress)
        {
            if (!(validateInputString(officelocationbuilding)))
            {
                throw new ArgumentException("Unspported last name syntax");

            }
            officeLocationBuilding = officelocationbuilding;
        }

        // Constructor when opening a new file
        public Faculty(string fromFile) : base(fromFile)
        {

            char[] delimeters = { '|', ',' };

            string[] tokens = fromFile.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            officeLocationBuilding = tokens[4];
        }
        //Formating saved data into a file
        public override string ToFileString()
        {


            string theString = base.ToFileString() + $"|{ officeLocationBuilding}";

            return theString;
        }
        // Display data in the listbox
        public override string ToFormattedString()
        {
            string theString = base.ToFormattedString() + $"{ Type,30}";

            return theString;
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