using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }
        [TestMethod]
        public void TicketIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.TicketId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.TicketId, TestData);
        }
        [TestMethod]
        public void EventIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.EventId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.EventId, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            decimal TestData = 69.99M;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }
        [TestMethod]
        public void SupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Interscope";
            //assign the data to the property
            AStock.Supplier = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Supplier, TestData);
        }
        [TestMethod]
        public void TicketNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "2Pac";
            //assign the data to the property
            AStock.TicketName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.TicketName, TestData);
        }
        [TestMethod]
        public void InStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.InStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.InStock, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create some test data to use with the method
            Int32 TicketId = 5;
            //invoke the method
            Found = AStock.Find(TicketId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestTicketIdFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int TicketId = 5;
            //invoke the method
            Found = AStock.Find(TicketId);
            //check the order id property
            if (AStock.TicketId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEventIdFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int TicketId = 5;
            //invoke the method
            Found = AStock.Find(TicketId);
            //check the ticket id property
            if (AStock.EventId != 101)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int TicketId = 5;
            //invoke the method
            Found = AStock.Find(TicketId);
            //check the ticket id property
            if (AStock.Quantity != 1001)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int TicketId = 5;
            //invoke the method
            Found = AStock.Find(TicketId);
            //check the ticket id property
            if (AStock.Price != 4999.99M)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int TicketId = 5;
            //invoke the method
            Found = AStock.Find(TicketId);
            //check the ticket id property
            if (AStock.Supplier.Equals("Adidas"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTicketNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int TicketId = 5;
            //invoke the method
            Found = AStock.Find(TicketId);
            //check the ticket id property
            if (AStock.InStock.Equals("2026 World Cup Final"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int TicketId = 5;
            //invoke the method
            Found = AStock.Find(TicketId);
            //check the ticket id property
            if (AStock.InStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
