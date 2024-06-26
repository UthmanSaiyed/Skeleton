﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrdersListOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //Add an item to the List
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderID = 11;
            TestItem.PromoCode = "101";
            TestItem.OrderFeedback = "Feedback 1001";
            TestItem.OrderDate = Convert.ToDateTime("10/05/2023");
            TestItem.IsPaid = true;
            TestItem.TotalAmount = 199.95M;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            clsOrders TestOrder = new clsOrders();
            //set the properties of the test object
            TestOrder.OrderID = 11;
            TestOrder.PromoCode = "101";
            TestOrder.OrderFeedback = "Feedback 1001";
            TestOrder.OrderStatus = "Active";
            TestOrder.OrderDate = Convert.ToDateTime("2023-05-10");
            TestOrder.IsPaid = true;
            TestOrder.TotalAmount = 199.95M;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            // Add an item to the List
            // create the item of test data
            clsOrders TestItem = new clsOrders();
            // set its properties
            TestItem.OrderID = 11;
            TestItem.PromoCode = "101";
            TestItem.OrderFeedback = "Feedback 1001";
            TestItem.OrderStatus = "Active";
            TestItem.OrderDate = Convert.ToDateTime("10/05/2023");
            TestItem.IsPaid = true;
            TestItem.TotalAmount = 199.95M;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrdersList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 11;
            TestItem.PromoCode = "101";
            TestItem.OrderFeedback = "Feedback 1001";
            TestItem.OrderStatus = "Active";
            TestItem.OrderDate = Convert.ToDateTime("10/05/2023");
            TestItem.IsPaid = true;
            TestItem.TotalAmount = 199.95M;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.PromoCode = "12345";
            TestItem.OrderFeedback = "Feedback 54321";
            TestItem.OrderStatus = "Active";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.IsPaid = true;
            TestItem.TotalAmount = 100.00M;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.PromoCode = "54321";
            TestItem.OrderFeedback = "Feedback 12345";
            TestItem.OrderStatus = "Inactive";
            TestItem.OrderDate = DateTime.Now.Date.AddDays(1);
            TestItem.IsPaid = false;
            TestItem.TotalAmount = 200.00M;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 11;
            TestItem.PromoCode = "101";
            TestItem.OrderFeedback = "Feedback 1001";
            TestItem.OrderStatus = "Active";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.IsPaid = true;
            TestItem.TotalAmount = 199.95m;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPromoCodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply a blank string (should return all records);
            FilteredOrders.ReportByPromoCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByPromoCodeNoneFound()
        {
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply a promo code that doesn't exist
            FilteredOrders.ReportByPromoCode("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByPromoCodeTestDataFound()
        {
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a promo code that exists
            FilteredOrders.ReportByPromoCode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check to see that the first record is ID 2119
                if (FilteredOrders.OrdersList[0].OrderID != 2119)
                {
                    OK = false;
                }
                //check to see that the second record is ID 2120
                if (FilteredOrders.OrdersList[1].OrderID != 2120)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}