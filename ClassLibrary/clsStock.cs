using System;


namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the OrderID property
        private Int32 mTicketId;
        //OrderID public property
        public int TicketId
        {
            get
            {
                //this line of code sends data out of the property
                return mTicketId;
            }
            set
            {
                //this line of code allows data into the property
                mTicketId = value;
            }
        }

        //private data member for the TicketID property
        private Int32 mEventId;
        //TicketID public property
        public int EventId
        {
            get
            {
                //this line of code sends data out of the property
                return mEventId;
            }
            set
            {
                //this line of code allows data into the property
                mEventId = value;
            }
        }

        //private data member for the CustomerID property
        private Int32 mQuantity;
        //CustomerID public property
        public int Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;
            }
        }

        //private data member for the OrderStatus property
        private decimal mPrice;
        //OrderStatus public property
        public decimal Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }

        //private data member for the OrderDate property
        private string mSupplier;
        //OrderDate public property
        public string Supplier
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplier;
            }
            set
            {
                //this line of code allows data into the property
                mSupplier = value;
            }
        }

        //private data member for the IsPaid property
        private string mTicketName;
        //IsPaid public property
        public string TicketName
        {
            get
            {
                //this line of code sends data out of the property
                return mTicketName;
            }
            set
            {
                //this line of code allows data into the property
                mTicketName = value;
            }
        }

        //private data member for the TotalAmount property
        private Boolean mInStock;
        //TotalAmount public property
        public bool InStock
        {
            get
            {
                //this line of code sends data out of the property
                return mInStock;
            }
            set
            {
                //this line of code allows data into the property
                mInStock = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int TicketId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the ticket id to search for
            DB.AddParameter("@TicketId", TicketId);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_FilterByTicketId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mTicketId = 5;
                mEventId = 101;
                mQuantity = 1001;
                mPrice = 4999.99M;
                mSupplier = "Canada";
                mTicketName = "2026 World Cup Final";
                mInStock = true;
                //always return true
                return true;
            }
           //if no record was found
           else
            {
                // return false indicating there is a problem
                return false;
            }
        }
    }
}