using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        private int mOrderID;
        private int mTicketID;
        private int mCustomerID;
        private string mOrderStatus;
        private DateTime mOrderDate;
        private bool mIsPaid;
        private decimal mTotalAmount;

        public int OrderID
        {
            get { return mOrderID; }
            set { mOrderID = value; }
        }

        public int TicketID
        {
            get { return mTicketID; }
            set { mTicketID = value; }
        }

        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        public string OrderStatus
        {
            get { return mOrderStatus; }
            set { mOrderStatus = value; }
        }

        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }

        public bool IsPaid
        {
            get { return mIsPaid; }
            set { mIsPaid = value; }
        }

        public decimal TotalAmount
        {
            get { return mTotalAmount; }
            set { mTotalAmount = value; }
        }

        public bool Find(int OrderID)
        {
            // Simulate fetching data
            mOrderID = OrderID;
            mTicketID = 101;
            mCustomerID = 1001;
            mOrderStatus = "Completed";
            mOrderDate = Convert.ToDateTime("2023-05-10");
            mIsPaid = true;
            mTotalAmount = 199.95M;
            return true; // Simulation always finds an order
        }
    }
}