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
            clsOrders AnOrder = new clsOrders();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            int TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void TicketIDPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            string TestData = "101AB";
            AnOrder.TicketID = TestData;
            Assert.AreEqual(AnOrder.TicketID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            int TestData = 1001;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            string TestData = "Completed";
            AnOrder.OrderStatus = TestData;
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            DateTime TestData = Convert.ToDateTime("2023-05-10");
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void IsPaidPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            bool TestData = true;
            AnOrder.IsPaid = TestData;
            Assert.AreEqual(AnOrder.IsPaid, TestData);
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            clsOrders AnOrder = new clsOrders();
            decimal TestData = 199.95M;
            AnOrder.TotalAmount = TestData;
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            bool Found = AnOrder.Find(21);
            Assert.IsTrue(Found);
        }
    }
}