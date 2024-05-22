using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        // private data member for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();

        // public property for the orders list
        public List<clsOrders> OrdersList
        {
            get
            {
                // return the private data
                return mOrdersList;
            }
            set
            {
                // set the private data
                mOrdersList = value;
            }
        }

        // public property for the count
        public int Count
        {
            get
            {
                // return the count of the list
                return mOrdersList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }

        public clsOrders ThisOrder { get; set; }

        // constructor for the class
        public clsOrdersCollection()
        {
            // variable for the index
            Int32 Index = 0;
            // variable to store the record count
            Int32 RecordCount = 0;
            // object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank order
                clsOrders AnOrder = new clsOrders();
                // read in the fields for the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.TicketID = Convert.ToString(DB.DataTable.Rows[Index]["TicketID"]);
                AnOrder.CustomerID = Convert.ToString(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.IsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPaid"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                // add the record to the private data member
                mOrdersList.Add(AnOrder);
                // point at the next record
                Index++;
            }
        }
    }
}