using System;
using System.Linq;

namespace ClassLibrary
{
    public class clsEvents
    {
        // Private data members
        private int mEventID;
        private DateTime mDateAdded;
        private string mTime;
        private string mLocation;
        private string mTitle;
        private string mDescription;
        private bool mActive;

        // Public properties
        public int EventID
        {
            get { return mEventID; }
            set { mEventID = value; }
        }

        public DateTime DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
        }

        public string Time
        {
            get { return mTime; }
            set { mTime = value; }
        }

        public string Location
        {
            get { return mLocation; }
            set { mLocation = value; }
        }

        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }

        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        public bool Active
        {
            get { return mActive; }
            set { mActive = value; }
        }

        // Find Method for EventsID
        public bool Find(int EventsID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EventsID", EventsID);
            DB.Execute("sproc_tblEvents_FilterByEventID");
            if (DB.Count == 1)
            {
                // Simulate finding an event by setting the private data members to test data values
                mEventID = Convert.ToInt32(DB.DataTable.Rows[0]["EventsID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mTime = Convert.ToString(DB.DataTable.Rows[0]["Time"]);
                mLocation = Convert.ToString(DB.DataTable.Rows[0]["Location"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string Title, string Location, string DateAdded, string Time, string Description)
        {
            // Create a string variable to store the error
            string Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            // If the Title is blank
            if (Title.Length == 0)
            {
                // Record the error
                Error = Error + "The title may not be blank : ";
            }

            // If the title character length is less than the min value or exceeds the max value
            if (Title.Length < 1 || Title.Length > 50)
            {
                Error = Error + "The Title must be between 1 and 50 characters";
            }

            // Check for invalid characters in the Title
            char[] invalidChars = { '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '=', '{', '}', '[', ']', '|', '\\', ';', ':', '"', '<', '>', ',', '.', '?', '/', '~', '`' };
            foreach (char invalidChar in invalidChars)
            {
                if (Title.Contains(invalidChar))
                {
                    Error = Error + "The Title contains invalid characters. ";
                    break;
                }
            }

            // Location validation

            // If the Location is blank
            if (Location.Length == 0)
            {
                // Record the error
                Error = Error + "The location field may not be blank : ";
            }

            if (Location.Length  < 1 || Location.Length > 100)
            {
                Error = Error + "The location field must be between 1 and 50 characters";
            }

            // Check for invalid characters in the Title
           
            foreach (char invalidChar in invalidChars)
            {
                if (Location.Contains(invalidChar))
                {
                    Error = Error + "The Location contains invalid characters. ";
                    break;
                }
            }
            try
            {

                //copy the dateAdded vlaue to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);

                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "the date cannot be in the past: ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }

            // Location validation
            // If the Time is blank
            if (Time.Length == 0)
            {
                // Record the error
                Error = Error + "The Time field may not be blank : ";
            }

            //if the time is too long

            if (Time.Length > 5 || Time.Length < 5)
            {
                // Record the error
                Error = Error + "The Time field should be 5 characters long : ";
            }
            try
            {
                TimeSpan.Parse(Time);
                // If the Time is blank
            }
            catch
            {
                //record the error
                Error = Error + "hi";
            }

            // If the Description character length is less than the min value or exceeds the max value
            if (Description.Length < 1 || Description.Length > 1000)
            {
                Error = Error + "The Description must be between 1 and 50 characters";
            }

            //return any error messages
            return Error;
        }



    }
}
