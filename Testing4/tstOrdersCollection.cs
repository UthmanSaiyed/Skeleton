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
            TestItem.TicketID = "101";
            TestItem.CustomerID = "1001";
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
            TestOrder.TicketID = "101";
            TestOrder.CustomerID = "1001";
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
            TestItem.TicketID = "101";
            TestItem.CustomerID = "1001";
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
    }
}