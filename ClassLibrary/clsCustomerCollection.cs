using ClassLibrary;
using System;
using System.Collections.Generic;

public class clsCustomerCollection
{

    //private data member for the list
    private List<clsCustomers> mCustomerList = new List<clsCustomers>();

    public List<clsCustomers> CustomerList
    {
        get
        {
            //return to private data                   
            return mCustomerList;
        }
        set
        {
            //set the private data
            mCustomerList = value;
        }
    }

    public int Count
    {
        get
        {
            //return the count of the list
            return mCustomerList.Count;
        }
        set
        {
            //we shall worry about this later
        }
    }

    public clsCustomers ThisCustomer { get; set; }

    //public clsCustomers ThisCustomer { get; set; }


    //constructor  for the class
    /* public clsCustomerCollection()
     { 
         //create the items of the test data
         clsCustomers TestItem = new clsCustomers();
         //set its properties
         TestItem.Active = true;
         TestItem.Newsletter = true;
         TestItem.CustomerID = 1;
         TestItem.Name = "Twelve";
         TestItem.Email = "Twelve@gmail.com";
         TestItem.Date = DateTime.Now;
         TestItem.Phonenumber = "00000000000";
         //aadd the test item to the test list
         mCustomerList.Add(TestItem);
         //reinitialise the object for some new data
         TestItem = new clsCustomers();
         //set its properties
         TestItem.Active = true;
         TestItem.Newsletter = true;
         TestItem.CustomerID = 2;
         TestItem.Name = "Twelve";
         TestItem.Email = "Twelve@gmail.com";
         TestItem.Date = DateTime.Now;
         TestItem.Phonenumber = "11111111111";
         //add the item to the test list
         mCustomerList.Add(TestItem);


     }*/
    public clsCustomerCollection()
    {
        //variable for the index 
        Int32 Index = 0;
        //variable to store the record event
        Int32 RecordCount = 0;
        //online for the data connect
        clsDataConnection DB = new clsDataConnection();
        //execute the stored procedure
        DB.Execute("sproc_tblCustomer_SelectAll");
        //get the count of records
        RecordCount = DB.Count;
        //while there are records to process
        while (Index < RecordCount)
        {
            //creae a blank address
            clsCustomers ACustomer = new clsCustomers();
            //read in the fields for the cureent record 
            ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
            ACustomer.Newsletter = Convert.ToBoolean(DB.DataTable.Rows[Index]["Newsletter"]);
            ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
            ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
            ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
            ACustomer.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
            ACustomer.Phonenumber = Convert.ToString(DB.DataTable.Rows[Index]["Phonenumber"]);
            //point at the next record to the private data memebr
            mCustomerList.Add(ACustomer);
            //point at the next record
            Index++;
        }
    }

}