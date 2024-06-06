using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
     clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblEvents_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedures
            DB.AddParameter("@Title", mThisEvent.Title);
            DB.AddParameter("@Location", mThisEvent.Location);
            DB.AddParameter("@DateAdded", mThisEvent.DateAdded);
            DB.AddParameter("@Time", mThisEvent.Time);
            DB.AddParameter("@Description", mThisEvent.Description);
            DB.AddParameter("@Active", mThisEvent.Active);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblEvents_Insert");
        }

        public void Update()
        {
            //updates an exisitng record in the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedures
            DB.AddParameter("@EventID", mThisEvent.EventID);
            DB.AddParameter("@Title", mThisEvent.Title);
            DB.AddParameter("@Location", mThisEvent.Location);
            DB.AddParameter("@DateAdded", mThisEvent.DateAdded);
            DB.AddParameter("@Time", mThisEvent.Time);
            DB.AddParameter("@Description", mThisEvent.Description);
            DB.AddParameter("@Active", mThisEvent.Active);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblEvents_Update");
        }

        public void Delete()
        {
           //delete method
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for stored procedure
            DB.AddParameter("@EventID", mThisEvent.EventID);
            //execute the stored procedure
            DB.Execute("sproc_tblEvents_Delete");
        }

        public void ReportByLocation(string Location)
        {
          clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Location", Location);
            DB.Execute("sproc_tblEvents_FilterByLocation");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mEventList = new List<clsEvents>();
            
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
