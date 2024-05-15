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



        //private data member for the firstname property
        private string mFirstname;
        public string Firstname
        {
            get
            { //this sends data out of the property
                return mFirstname;
            }
            set
            {
                //this allows data into the property
                mFirstname = value;
            }
        }

        //private data member for the lastname property
        private string mLastname;
        public string Lastname
        {
            get
            { //this sends data out of the property
                return mLastname;
            }
            set
            {
                //this allows data into the property
                mLastname = value;
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
            //set the private data memebers to the test data value
            mCustomerID = 4;
            mFirstname = "Javk";
            mLastname = "Peter";
            mEmail = "paulopsa@gmail.com";
            mBirthDate = Convert.ToDateTime("21/07/1990");
            mPhonenumber = "07796895049";
            mNewsletter = true;
            mActive = true;
            //always return true
            return true;    
        }


    }
}