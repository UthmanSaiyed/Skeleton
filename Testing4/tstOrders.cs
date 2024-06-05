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
        string PromoCode = "101";
        string OrderFeedback = "1001";
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
        public void PromoCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "101";
            //assign the data to the property
            AnOrder.PromoCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PromoCode, TestData);
        }

        [TestMethod]
        public void OrderFeedbackPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "1001";
            //assign the data to the property
            AnOrder.OrderFeedback = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderFeedback, TestData);
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
        public void TestPromoCodeFound()
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
            if (AnOrder.PromoCode != "101")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderFeedbackFound()
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
            if (AnOrder.OrderFeedback != "Feedback 1001")
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
            if (AnOrder.OrderStatus != "Active")
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
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        /******************TICKET ID VALIDATION TESTS******************/
        [TestMethod]
        public void PromoCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PromoCode = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PromoCodeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PromoCode = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PromoCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PromoCode = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PromoCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PromoCode = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PromoCodeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PromoCode = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PromoCodeMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PromoCode = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PromoCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PromoCode = new string('a', 21); //this should fail
                                                    //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PromoCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string PromoCode = "";
            PromoCode = PromoCode.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************ORDER DATE VALIDATION TESTS******************/
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToShortDateString();
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual("", Error); // Past dates should be valid
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
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 101 years (to fail the validation)
            TestDate = TestDate.AddYears(-101);
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToShortDateString();
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual("", Error); // Extremely past dates should be invalid
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
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
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
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
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
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the data variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
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
            //set the OrderDate to a non-date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************CUSTOMER ID VALIDATION TESTS******************/
        [TestMethod]
        public void OrderFeedbackMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderFeedback = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderFeedbackMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderFeedback = "1"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderFeedbackMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderFeedback = "11"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderFeedbackMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderFeedback = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderFeedbackMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderFeedback = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderFeedbackMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderFeedback = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderFeedbackMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderFeedback = new string('a', 251); //this should fail
                                                         //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderFeedbackExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderFeedback = "";
            OrderFeedback = OrderFeedback.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******************TOTAL AMOUNT VALIDATION TESTS******************/
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
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
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
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
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
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
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
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "999999.98"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "999999.99"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "500000.00"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "1000000"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string TotalAmount = "";
            TotalAmount = TotalAmount.PadRight(500, '1'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
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
            Error = AnOrder.Valid(PromoCode, OrderFeedback, OrderDate, TotalAmount);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}