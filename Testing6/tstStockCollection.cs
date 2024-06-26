﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>(); 
            //Add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.TicketId = 4;
            TestItem.SKU = "97";
            TestItem.Quantity = 1000;
            TestItem.Price = 149.99M;
            TestItem.Supplier = "Rolling Loud";
            TestItem.TicketName = "Kanye West Set";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.InStock = true;
            TestStock.TicketId = 4;
            TestStock.SKU = "97";
            TestStock.Quantity = 1000;
            TestStock.Price = 149.99M;
            TestStock.Supplier = "Rolling Loud";
            TestStock.TicketName = "Kanye West Set";
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to the list 
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.TicketId = 4;
            TestItem.SKU = "97";
            TestItem.Quantity = 100;
            TestItem.Price = 149.99M;
            TestItem.Supplier = "Rolling Loud";
            TestItem.TicketName = "Kanye West Set";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.TicketId = 7;
            TestItem.SKU = "1001";
            TestItem.Quantity = 10031;
            TestItem.Price = 3499.99M;
            TestItem.Supplier = "Quebec";
            TestItem.TicketName = "2026 World Cup Knockout";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.TicketId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.SKU = "1001";
            TestItem.Quantity = 1001;
            TestItem.Price = 3499.99M;
            TestItem.Supplier = "Quebec";
            TestItem.TicketName = "2026 World Cup Knockout";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.TicketId = PrimaryKey;
            //modify the test record
            TestItem.InStock = false;
            TestItem.SKU = "399";
            TestItem.Quantity = 100;
            TestItem.Price = 4999.99M;
            TestItem.Supplier = "UEFA";
            TestItem.TicketName = "2024 Champions League Final";
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.TicketId = 1036;
            TestItem.SKU = "1001";
            TestItem.Quantity = 1001;
            TestItem.Price = 3499.99M;
            TestItem.Supplier = "Quebec";
            TestItem.TicketName = "2026 World Cup Knockout";
            //set thisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.TicketId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportBySupplierMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStock.ReportBySupplier("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportBySupplierNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a supplier that doesn't exist
            FilteredStock.ReportBySupplier("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportBySupplierTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //variable to store the collection
            Boolean OK = true;
            //apply a supplier that doesn't exist
            FilteredStock.ReportBySupplier("yyy yyy");
            //check that the correct number of records was found
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].TicketId != 1041)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].TicketId != 1042)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);  
        }
    }
}
