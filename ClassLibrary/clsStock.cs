using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;


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
                //copy the data from the database to the private data members
                mTicketId = Convert.ToInt32(DB.DataTable.Rows[0]["TicketId"]);
                mEventId = Convert.ToInt32(DB.DataTable.Rows[0]["EventId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mSupplier = Convert.ToString(DB.DataTable.Rows[0]["Supplier"]);
                mTicketName = Convert.ToString(DB.DataTable.Rows[0]["TicketName"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                //return that everything worked OK
                return true;
            }
           //if no record was found
           else
            {
                // return false indicating there is a problem
                return false;
            }
            
        }

        public string Valid(string eventId, string quantity, string price, string supplier, string ticketName)
        {
            //create a string variable to store the error
            String Error = "";
            //if the eventid is blank
            if (eventId.Length == 0)
            {
                //record the error
                Error = Error + "The eventid may be blank: ";
            }
            if (eventId.Length > 6)
            {
                //record the error
                Error = Error + "The eventid must be less than 6 characters: ";
            }
            if (quantity.Length == 0)
            {
                //record the error
                Error = Error + "The quantity may be blank: ";
            }
            if (quantity.Length > 6)
            {
                //record the error
                Error = Error + "The quantity must be less than 6 characters: ";
            }
            if (price.Length == 0)
            {
                //record the error
                Error = Error + "The price must be less than 9 characters ";
            }
            if (price.Length > 7)
            {
                //record the error
                Error = Error + "The price must be less than 6 characters: ";
            }
            if (supplier.Length == 0)
            {
                //record the error
                Error = Error + "The price may be blank: ";
            }
            if (supplier.Length > 50)
            {
                //record the error
                Error = Error + "The supplier must be less than 50 characters: ";
            }
            if (ticketName.Length == 0)
            {
                //record the error
                Error = Error + "The ticket name may be blank: ";
            }
            if (ticketName.Length > 50)
            {
                //if the ticketname is too long
                Error = Error + "The ticket name must be less than 50 characters: ";
            }
            //return any error message
            return Error;
        }
        public DataTable StatisticsGroupedBySupplier()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Count_GroupBySupplier");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }
        public DataTable StatisticsGroupedByPrice()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Count_GroupByPrice");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }
    }
}
