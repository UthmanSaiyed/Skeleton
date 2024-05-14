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
        private int mTicketID;
        //TicketID public property
        public int TicketID
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
        private int mCustomerID;
        //CustomerID public property
        public int CustomerID
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
                mTicketID = Convert.ToInt32(DB.DataTable.Rows[0]["TicketID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
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
    }
}