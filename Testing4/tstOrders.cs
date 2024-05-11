using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // Test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // Create some test data to assign to the property
            int TestData = 1;
            // Assign the data to the property
            AnOrder.OrderID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void TicketIDPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // Create some test data to assign to the property
            string TestData = "101AB";
            // Assign the data to the property
            AnOrder.TicketID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.TicketID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // Create some test data to assign to the property
            int TestData = 202;
            // Assign the data to the property
            AnOrder.CustomerID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // Create some test data to assign to the property
            string TestData = "Pending";
            // Assign the data to the property
            AnOrder.OrderStatus = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AnOrder.OrderDate = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void IsPaidPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // Create some test data to assign to the property
            bool TestData = true;
            // Assign the data to the property
            AnOrder.IsPaid = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.IsPaid, TestData);
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            // Create some test data to assign to the property
            decimal TestData = 199.99M;
            // Assign the data to the property
            AnOrder.TotalAmount = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }
    }
}
