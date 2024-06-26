﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        // Private data member for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();
        // Private member data for ThisOrder
        clsOrders mThisOrder = new clsOrders();

        // Public property for the orders list
        public List<clsOrders> OrdersList
        {
            get
            {
                // Return the private data
                return mOrdersList;
            }
            set
            {
                // Set the private data
                mOrdersList = value;
            }
        }

        // Public property for the count
        public int Count
        {
            get
            {
                // Return the count of the list
                return mOrdersList.Count;
            }
            set
            {
                // We shall worry about this later
            }
        }

        // Public property for ThisOrder
        public clsOrders ThisOrder
        {
            get
            {
                // Return the private data 
                return mThisOrder;
            }
            set
            {
                // Set the private data
                mThisOrder = value;
            }
        }

        // Constructor for the class
        public clsOrdersCollection()
        {
            // Variable for the index
            Int32 Index = 0;
            // Variable to store the record count
            Int32 RecordCount = 0;
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank order
                clsOrders AnOrder = new clsOrders();
                // Read in the fields for the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.PromoCode = Convert.ToString(DB.DataTable.Rows[Index]["PromoCode"]);
                AnOrder.OrderFeedback = Convert.ToString(DB.DataTable.Rows[Index]["OrderFeedback"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.IsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPaid"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                // Add the record to the private data member
                mOrdersList.Add(AnOrder);
                // Point at the next record
                Index++;
            }
        }

        public int Add()
        {
            // Adds a record to the database based on the values of mThisOrder
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@PromoCode", mThisOrder.PromoCode);
            DB.AddParameter("@OrderFeedback", mThisOrder.OrderFeedback);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@PromoCode", mThisOrder.PromoCode);
            DB.AddParameter("@OrderFeedback", mThisOrder.OrderFeedback);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            // deletes the record pointed to by ThisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByPromoCode(string PromoCode)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PromoCode parameter to the database
            DB.AddParameter("@PromoCode", PromoCode);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByPromoCode");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //variable for the index
            int Index = 0;
            //variable to store the record count
            int RecordCount = DB.Count;
            //clear the private array list
            mOrdersList = new List<clsOrders>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrders AnOrder = new clsOrders();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.PromoCode = Convert.ToString(DB.DataTable.Rows[Index]["PromoCode"]);
                AnOrder.OrderFeedback = Convert.ToString(DB.DataTable.Rows[Index]["OrderFeedback"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.IsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPaid"]);
                AnOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                //add the record to the private data member
                mOrdersList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
}