using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the OrderID property
        private int mOrderID;
        //OrderID public property
        public int OrderID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }

        //private data member for the TicketID property
        private string mTicketID;
        //TicketID public property
        public string TicketID
        {
            get
            {
                //this line of code sends data out of the property
                return mTicketID;
            }
            set
            {
                //this line of code allows data into the property
                mTicketID = value;
            }
        }

        //private data member for the CustomerID property
        private string mCustomerID;
        //CustomerID public property
        public string CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //private data member for the OrderStatus property
        private string mOrderStatus;
        //OrderStatus public property
        public string OrderStatus
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderStatus;
            }
            set
            {
                //this line of code allows data into the property
                mOrderStatus = value;
            }
        }

        //private data member for the OrderDate property
        private DateTime mOrderDate;
        //OrderDate public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }

        //private data member for the IsPaid property
        private bool mIsPaid;
        //IsPaid public property
        public bool IsPaid
        {
            get
            {
                //this line of code sends data out of the property
                return mIsPaid;
            }
            set
            {
                //this line of code allows data into the property
                mIsPaid = value;
            }
        }

        //private data member for the TotalAmount property
        private decimal mTotalAmount;
        //TotalAmount public property
        public decimal TotalAmount
        {
            get
            {
                //this line of code sends data out of the property
                return mTotalAmount;
            }
            set
            {
                //this line of code allows data into the property
                mTotalAmount = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderID to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mTicketID = Convert.ToString(DB.DataTable.Rows[0]["TicketID"]);
                mCustomerID = Convert.ToString(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mIsPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPaid"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
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

        public string Valid(string ticketID, string customerID, string orderDate, string totalAmount)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the TicketID is blank
            if (ticketID.Length == 0)
            {
                //record the error
                Error = Error + "The Ticket ID may not be blank : ";
            }
            //if the TicketID is greater than 6 characters
            if (ticketID.Length > 6)
            {
                //record the error 
                Error = Error + "The Ticket ID must be less than 6 characters : ";
            }

            //if the CustomerID is blank
            if (customerID.Length == 0)
            {
                //record the error
                Error = Error + "The Customer ID may not be blank : ";
            }
            //if the CustomerID is greater than 6 characters
            if (customerID.Length > 6)
            {
                //record the error 
                Error = Error + "The Customer ID must be less than 6 characters : ";
            }

            //validate the OrderDate
            try
            {
                //copy the OrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date : ";
            }

            //validate the TotalAmount
            try
            {
                decimal TotalAmountTemp = Convert.ToDecimal(totalAmount);
                if (TotalAmountTemp <= 0)
                {
                    Error = Error + "The total amount must be greater than zero : ";
                }
                if (TotalAmountTemp > 999999.99M)
                {
                    Error = Error + "The total amount must be less than 1,000,000 : ";
                }
            }
            catch
            {
                Error = Error + "The total amount is not a valid decimal : ";
            }

            //return any error messages
            return Error;
        }
    }
}