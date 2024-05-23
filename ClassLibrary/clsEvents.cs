using System;

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
    }
}
