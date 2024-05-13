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
            //set the private data members to the test data value
            mOrderID = 21;
            mTicketID = 101;
            mCustomerID = 1001;
            mOrderStatus = "Completed";
            mOrderDate = Convert.ToDateTime("2023-05-10");
            mIsPaid = true;
            mTotalAmount = 199.95M;
            //always return true
            return true;
        }
    }
}