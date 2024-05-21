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
            // Simulate finding an event by setting the private data members to test data values
            mEventID = 1;
            mDateAdded = Convert.ToDateTime("23/12/2024");
            mTime = "10:00";
            mLocation = "Uthman's BackYard";
            mTitle = "Event Title";
            mDescription = "Event Description";
            mActive = true;
            return true;
        }
    }
}
