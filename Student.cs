using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager
{
    public class Student : ContactsMain
    {
        List<ContactsMain> Contacts = new List<ContactsMain>();
        //public properties
        public string Type = "Student";
        public string SnailMailAddress { get { return snailMailAddress; } }
        public DateTime GraduationYear { get { return graduationYear; } }
        public List<string> CourseList { get { return courseList; } }

        //Shadow Private Properties

        private string snailMailAddress;
        private DateTime graduationYear;
        private List<string> courseList = new List<string>();

        public Student(string firstname,
                              string lastname,
                              string academicdepartment,
                              string emailaddress,
                              string snailmailaddress,
                              DateTime graduationyear,
                              List<string> courselist) : base(firstname, lastname, academicdepartment, emailaddress)
        {
            if (!(validateInputString(snailmailaddress)))
            {
                throw new ArgumentException("Unspported first name syntax");

            }
            snailMailAddress = snailmailaddress;
            graduationYear = graduationyear;
            courseList = courselist;
        }

        // Constructor when opening a new file
        public Student(string fromFile) : base(fromFile)
        {

            char[] delimeters = { '|', ',' };
            char[] coursesDelimiters = { ';' };
            string[] tokens = fromFile.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            snailMailAddress = tokens[4];
            graduationYear = Convert.ToDateTime(tokens[5].Trim());
            string[] courseTokens = tokens[6].Split(coursesDelimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in courseTokens)
            {
                courseList.Add(item);
            }

        }
        //Formating saved data into a file
        public override string ToFileString()
        {
            string theString = base.ToFileString() + $"|{ snailMailAddress}" +
                $"|{ graduationYear}|";
            foreach(string item in courseList)
            {
                theString += item+";";
            }


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
