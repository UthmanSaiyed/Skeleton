using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member date for this member
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //do later
            }

        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }
        public clsStockCollection()
        {
            //variable to the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data to connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Selectall");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create the blank stock
                clsStock AStock = new clsStock();
                //read the fields for the current record
                AStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                AStock.TicketId = Convert.ToInt32(DB.DataTable.Rows[Index]["TicketId"]);
                AStock.EventId = Convert.ToInt32(DB.DataTable.Rows[Index]["EventId"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AStock.Supplier = Convert.ToString(DB.DataTable.Rows[Index]["Supplier"]);
                AStock.TicketName = Convert.ToString(DB.DataTable.Rows[Index]["TicketName"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }
        public int Add()
        {
            //adds a record to the database based on the values of mThisAddress
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EventId", mThisStock.EventId);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Supplier", mThisStock.Supplier);
            DB.AddParameter("@TicketName", mThisStock.TicketName);
            DB.AddParameter("@InStock", mThisStock.InStock);

            //return the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }
    }
}
