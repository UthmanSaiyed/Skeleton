using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass the method
        string EventId = "101";
        string Quantity = "1001";
        string Price = "4999.99";
        string Supplier = "Canada";
        string TicketName = "2026 World Cup Final";

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
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EventIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string EventId = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EventIdMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string EventId = "1"; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EventIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string EventId = "11"; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EventIdMaxlessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string EventId = "1111"; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EventIdMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string EventId = "11111"; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EventIdMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string EventId = "111"; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EventIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string EventId = "1111111"; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EventIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            EventId = EventId.PadRight(500, '1'); //this should fail
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Quantity = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "1"; //this should trigger an error
                                  //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "11"; //this should trigger an error
                                   //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxlessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "11111"; //this should trigger an error
                                     //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "111111"; //this should trigger an error
                                      //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "111"; //this should trigger an error
                                    //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "1111111"; //this should trigger an error
                                        //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            Quantity = Quantity.PadRight(500, '1'); //this should fail
                                                  //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Price = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Price = "1"; //this should trigger an error
                                   //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Price = "11"; //this should trigger an error
                                    //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxlessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Price = "11111"; //this should trigger an error
                                       //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Price = "111111"; //this should trigger an error
                                        //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Price = "111"; //this should trigger an error
                                     //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Price = ""; //this should trigger an error
            Price = Price.PadRight(8, '1');                      //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Price = "";
            Price = Price.PadRight(500, '1'); //this should fail
                                                    //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void SupplierMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Supplier = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Supplier = "a"; //this should trigger an error
                                //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Supplier = "aa"; //this should trigger an error
                                 //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierMaxlessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Supplier = "";
            Supplier = Supplier.PadRight(49, 'a');
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Supplier = "";
            Supplier = Supplier.PadRight(50, 'a');
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Supplier = "";
            Supplier = Supplier.PadRight(25, 'a');
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Supplier = "";
            Supplier = Supplier.PadRight(51, 'a');
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Supplier = "";
            Supplier = Supplier.PadRight(500, 'a'); //this should fail
                                              //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void TicketNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string TicketName = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TicketNameMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string TicketName = "a"; //this should trigger an error
                                   //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string TicketName = "aa"; //this should trigger an error
                                    //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketNameMaxlessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string TicketName = "";
            TicketName = TicketName.PadRight(49, 'a');
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketNameMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string TicketName = "";
            TicketName = TicketName.PadRight(50, 'a');
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketNameMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string TicketName = "";
            TicketName = TicketName.PadRight(25, 'a');
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TicketNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string TicketName = "";
            TicketName = TicketName.PadRight(51, 'a');
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TicketNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string TicketName = "";
            TicketName = TicketName.PadRight(500, 'a'); //this should fail
                                                    //invoke the method
            Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
