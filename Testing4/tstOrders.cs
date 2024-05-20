using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        //good test data
        //create some test data to pass the method
        string TicketID = "101";
        string CustomerID = "1001";
        string OrderDate = DateTime.Now.ToShortDateString();
        string TotalAmount = "199.95";

        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            int TestData = 11;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void TicketIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "101";
            //assign the data to the property
            AnOrder.TicketID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TicketID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "1001";
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "Active";
            //assign the data to the property
            AnOrder.OrderStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("2023-05-10");
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void IsPaidPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AnOrder.IsPaid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.IsPaid, TestData);
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            decimal TestData = 199.95M;
            //assign the data to the property
            AnOrder.TotalAmount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create some test data to use with the method
            int OrderID = 11;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int OrderID = 11;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id property
            if (AnOrder.OrderID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTicketIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int OrderID = 11;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the ticket id property
            if (AnOrder.TicketID != "101")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int OrderID = 11;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the customer id property
            if (AnOrder.CustomerID != "1001")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int OrderID = 11;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order status property
            if (AnOrder.OrderStatus != "Active" && AnOrder.OrderStatus != "Not Active")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int OrderID = 11;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order date property
            if (AnOrder.OrderDate != Convert.ToDateTime("2023-05-10"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsPaidFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int OrderID = 11;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the is paid property
            if (AnOrder.IsPaid != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int OrderID = 11;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the total amount property
            if (AnOrder.TotalAmount != 199.95M)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TicketIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TicketID = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TicketIDMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TicketID = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TicketIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TicketID = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TicketIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TicketID = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TicketIDMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TicketID = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TicketIDMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TicketID = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TicketIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TicketID = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TicketIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TicketID = "";
            TicketID = TicketID.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerID = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "-1"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "0"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "0.01"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "0.02"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "1000000"; //this should trigger an error
                                            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountInvalidData()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //set the TotalAmount to a non-numeric value
            string TotalAmount = "this is not a number";
            //invoke the method
            Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}