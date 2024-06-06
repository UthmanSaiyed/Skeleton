using System;
using System.Dynamic;

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

        private DateTime mDate;
        public DateTime Date

        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
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
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
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

        public string Valid(string name, string email, string date, string phonenumber)
        {

            //create a string variable to store the error
            String Error = "";
            //create a temprorary variable to store data values
            DateTime DateTemp;
            //if name is blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The name should not be blank: ";
            }
            //if the name is greater than 35 chracters 
            if (name.Length > 35)
            {
                //record the error
                Error = Error + "The name should not be blank: ";
            }
            /**************EMAIL********************/

            //if email is longer than 256 characters
            if (email.Length > 256)
            {
                //record the error
                Error = Error + "The email should be less than 256 characters: ";
            }

            //if the email is less than 2 characters
            if (email.Length == 0)
            {
                //record error
                Error = Error + "Email should be longer than 1 character: ";
            }



            try
            {
                //copy the date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(date);

                if (DateTemp < DateTime.Now.Date.AddYears(-100))//compare DateTemp with Date 
                {
                    //record the error
                    Error = Error + "The date cannot be more than 100 years in the past : ";
                }
                if (DateTemp > DateTime.Now.Date.AddYears(1))
                {
                    //record the error
                    Error = Error + "The date cannot be less than 15 years : ";
                }


            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date : ";
            }

            //if phone number less than 11 digits

            if (phonenumber.Length < 10)
            {
                //record the error
                Error = Error + "Phone number must be 11 digits";
            }

            //if phone number greater than 11 digits
            if (phonenumber.Length > 12)
            {
                //record the error
                Error = Error + "Phone number must be 11 digits";
            }



            //return any error messages
            //needs to be at end
            return Error;
        }


    }

}

