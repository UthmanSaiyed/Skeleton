using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

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
        private string mPromoCode;
        //TicketID public property
        public string PromoCode
        {
            get
            {
                //this line of code sends data out of the property
                return mPromoCode;
            }
            set
            {
                //this line of code allows data into the property
                mPromoCode = value;
            }
        }

        //private data member for the CustomerID property
        private string mOrderFeedback;
        //CustomerID public property
        public string OrderFeedback
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderFeedback;
            }
            set
            {
                //this line of code allows data into the property
                mOrderFeedback = value;
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
                mPromoCode = Convert.ToString(DB.DataTable.Rows[0]["PromoCode"]);
                mOrderFeedback = Convert.ToString(DB.DataTable.Rows[0]["OrderFeedback"]);
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

        public string Valid(string promoCode, string orderFeedback, string orderDate, string totalAmount)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the TicketID is blank
            if (promoCode.Length == 0)
            {
                //record the error
                Error = Error + "The Promo Code may be blank : ";
            }
            //if the TicketID is greater than 6 characters
            if (promoCode.Length > 20)
            {
                //record the error 
                Error = Error + "The Promo Code must be less than 20 characters : ";
            }

            //if the CustomerID is blank
            if (orderFeedback.Length == 0)
            {
                //record the error
                Error = Error + "The Order Feedback may be blank : ";
            }
            //if the OrderFeedback is greater than 250 characters
            if (orderFeedback.Length > 250)
            {
                //record the error 
                Error = Error + "The Order Feedback must be less than 250 characters : ";
            }

            //validate the OrderDate
            try
            {
                //copy the OrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error
                    Error = Error + "The date cannot be more than 100 years in the past : ";
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

        /****** Statistics Grouped by order status METHOD ******/
        public DataTable StatisticsGroupedByOrderStatus()
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_Count_GroupByOrderStatus");
            // There should be either zero, one, or more records
            return DB.DataTable;
        }

        /****** Statistics Grouped by order date METHOD ******/
        public DataTable StatisticsGroupedByOrderDate()
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_Count_GroupByOrderDate");
            // There should be either zero, one, or more records
            return DB.DataTable;
        }
    }
}