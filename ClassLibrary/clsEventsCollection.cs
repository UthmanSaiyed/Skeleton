using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsEventsCollection
    {
        private List<clsEvents> mEventList = new List<clsEvents>();
        clsEvents mThisEvent = new clsEvents();
        public List<clsEvents> EventList
        {
            get
            {
                return mEventList;
            }
            set
            {
                mEventList = value;
            }
        }

        public int Count
        {
            get
            {
                return mEventList.Count;
            }
            set
            {
                // Empty setter, possibly needed for data binding or similar purposes
            }
        }


        public clsEvents ThisEvent 
        {
            get
            {
                return mThisEvent;
            }

            set
            { 
                mThisEvent = value;
            }
        }

        // Constructor to initialize the collection with test data
        public clsEventsCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;

            //object for data connect
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblEvents_SelectAll");

            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsEvents AnEvent = new clsEvents();

                //read in the fields from the current record
                AnEvent.EventID = Convert.ToInt32(DB.DataTable.Rows[Index]["EventsID"]);
                AnEvent.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnEvent.Time = Convert.ToString(DB.DataTable.Rows[Index]["Time"]);
                AnEvent.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                AnEvent.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AnEvent.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnEvent.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data member
                mEventList.Add(AnEvent);

                Index++;
             
            }

        }

    }
}