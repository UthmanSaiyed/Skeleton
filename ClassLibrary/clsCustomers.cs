using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        //private data member for the customer id property
        private Int32 mCustomerID;

        //customerid public property
        public Int32 CustomerID
        {
            get
            { //this sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this allows data into the property
                mCustomerID = value;
            }
        }



        //private data member for the Name property
        private string mName;
        public string Name
        {
            get
            { //this sends data out of the property
                return mName;
            }
            set
            {
                //this allows data into the property
                mName = value;
            }
        }



        //private data member for the email property
        private string mEmail;
        public string Email
        {
            get
            { //this sends data out of the property
                return mEmail;
            }
            set
            {
                //this allows data into the property
                mEmail = value;
            }
        }

        private DateTime mBirthDate;
        public DateTime BirthDate

        {
            get
            {
                return mBirthDate;
            }
            set
            {
                mBirthDate = value;
            }
        }

        private string mPhonenumber;
        public string Phonenumber
        {
            get
            { //this sends data out of the property
                return mPhonenumber;
            }
            set
            {
                //this allows data into the property
                mPhonenumber = value;
            }
        }

        private bool mNewsletter;
        public bool Newsletter
        {
            get
            { //this sends data out of the property
                return mNewsletter;
            }
            set
            {
                //this allows data into the property
                mNewsletter = value;
            }
        }


        private bool mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }


        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mBirthDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BirthDate"]);
                mPhonenumber = Convert.ToString(DB.DataTable.Rows[0]["Phonenumber"]);
                mNewsletter = Convert.ToBoolean(DB.DataTable.Rows[0]["Newsletter"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}
            
    