using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

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
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Selectall");
            //populate array list with data table
            PopulateArray(DB);
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
        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the new stored procedure
            DB.AddParameter("TicketId", mThisStock.TicketId);
            DB.AddParameter("EventId", mThisStock.EventId);
            DB.AddParameter("Quantity", mThisStock.Quantity);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("Supplier", mThisStock.Supplier);
            DB.AddParameter("TicketName", mThisStock.TicketName);
            DB.AddParameter("InStock", mThisStock.InStock);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }
        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TicketId", mThisStock.TicketId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }
        public void ReportBySupplier(string Supplier)
        {
            //filters the records based on a 
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Supplier parameter to the database
            DB.AddParameter("@Supplier", Supplier);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterBySupplier");
            //populate the array list with the data tabl
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //varaiable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock object
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                AStock.TicketId = Convert.ToInt32(DB.DataTable.Rows[Index]["TicketId"]);
                AStock.EventId = Convert.ToInt32(DB.DataTable.Rows[Index]["EventId"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AStock.Supplier = Convert.ToString(DB.DataTable.Rows[Index]["Supplier"]);
                AStock.TicketName = Convert.ToString(DB.DataTable.Rows[Index]["Supplier"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //points at the next record
                Index++;
            }
        }
    }
}
