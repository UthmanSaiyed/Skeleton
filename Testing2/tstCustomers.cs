using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomers
    {
        //good test data
        //create some test data to pass the method
        string Name = "Twelve";
        string Email = "twelve@gmail.com";
        string Date = DateTime.Now.ToString();
        string Phonenumber = "00000000000";
        /****************************Instance OF THE CLASS TEST************************************************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        /***************************PROPERTY OK TESTS***************************/
        [TestMethod]
        public void CustomerIDProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void NameProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "Peter";
            //assign the data to the property
            ACustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Name, TestData);
        }



        [TestMethod]
        public void EmailProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "Peter";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void DateProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("2007-02-03");
            //assign the data to the property
            ACustomer.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Date, TestData);
        }

        [TestMethod]
        public void PhoneNumberProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "07768443321";
            //assign the data to the property
            ACustomer.Phonenumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Phonenumber, TestData);
        }


        [TestMethod]
        public void NewsletterProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Newsletter = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Newsletter, TestData);
        }


        [TestMethod]
        public void ActiveProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign data to a property
            ACustomer.Active = TestData;
            //test to see 2 values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        /************************FIND METHOD TEST***************/
        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class i am going to create
            clsCustomers ACustomer = new clsCustomers();

            //create a boolean variable to store results of validation
            bool Found = false;

            //create some test data to use with the method
            Int32 CustomerID = 12;

            //invoke the method
            Found = ACustomer.Find(CustomerID);

            //test to see if result is true
            Assert.IsTrue(Found);
        }

        /***************PROPERTY DATA TESTS************************/
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();

            //create a boolean variable to store the result of the search
            bool Found = false;

            //create a boolean variable to record if data is ok
            bool OK = true;

            //create some test data to use with the method
            Int32 CustomerID = 12;

            //invoke the method
            Found = ACustomer.Find(CustomerID);

            //check customerid
            if (ACustomer.CustomerID != 12)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            bool Found = false;
            bool OK = true;
            Int32 CustomerID = 12;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.Name != "Twelve                             ")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();

            //create a boolean variable to store the result of the search
            bool Found = false;

            //create a boolean variable to record if data is ok
            bool OK = true;

            Int32 CustomerID = 12;

            //invoke the method
            Found = ACustomer.Find(CustomerID);

            //check customerid
            if (ACustomer.Email != "Twelve@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int CustomerID = 12;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the order date property
            if (ACustomer.Date != Convert.ToDateTime("12/12/2012"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhonenumberFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if data is ok
            Boolean OK = true;

            int CustomerID = 12;

            //invoke the method
            Found = ACustomer.Find(CustomerID);

            //check customerid
            if (ACustomer.Phonenumber != "00000000000")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NewsletterFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int CustomerID = 12;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the is paid property
            if (ACustomer.Newsletter != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 12;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the is paid property
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        /******************************ValidMthod****************************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance pf the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //involke the method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /***************************NameTests*******************************/

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Name = ""; // should trigger an error
            //invoke a method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Name = "a";//this should be ok
            //invoke method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Name = "aa";
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Name = "a";
            Name = Name.PadRight(34, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Name = "a";
            Name = Name.PadRight(35, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(17, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(36, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreNotEqual(Error, "");
        }


        /****************Email**********************/
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Email = ""; // should trigger an error
            //invoke a method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        /*  [TestMethod]
          public void EmailMin()
          {
              //create an instance of the class we want to create
              clsCustomers ACustomer = new clsCustomers();
              //string variable to store any error message
              String Error = "";
              //create some test data to pass the method
              string Email = "aa";//this should be ok
              //invoke method
              Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
              //test to see that the result is correct
              Assert.AreEqual(Error, "");
          }*/
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Email = "aa";//this should be ok
            //invoke method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Email = "a";
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(254, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(256, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMid()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(127, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(256, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Email = "a";
            Email = Email.PadRight(500, 'a');
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreNotEqual(Error, "");
        }

        /***************************Date**************************/
        [TestMethod]
        public void DateExtremeMin()
        {
            clsCustomers ACustomer = new clsCustomers();

            //string variable to to store error message
            String Error = "";

            //create a variable to store the test data
            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-200);

            string Date = TestDate.ToString();

            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinLessOne()
        {
            //create an instance of the class
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store error message
            String Error = "";
            //create a variable to store the data
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now.Date;
            //make date 16 years ago
            TestDate = TestDate.AddYears(11);
            //convert date variable to string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMin()
        {
            //create an instance of the class
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store error message
            String Error = "";
            //create a variable to store the data
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now.Date;
            //make date 16 years ago
            TestDate = TestDate.AddYears(-16);
            //convert date variable to string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }
        public void DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //minus 18 years
            TestDate = TestDate.AddYears(11);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber); ;
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateMax()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date.AddYears(-99);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(-101);
            //convert the date variable to a string variable       
            string Date = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateInvalidData()
        {
            clsCustomers ACustomer = new clsCustomers();

            //string variable to store the error message
            String Error = "";

            //set the Date to a non date value
            string Date = "this is not a date!";

            //invoke the method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /************************Phonenumber******************************/
        [TestMethod]
        public void PhonenumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Phonenumber = "077777777"; // should trigger an error
            //invoke a method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PhonenumberMin()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Phonenumber = "0777777777";//this should be ok
            //invoke method
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumberMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Phonenumber = "07777777777";
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumberMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Phonenumber = "07777777777";
           
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumberMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Phonenumber = "077777777777";
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhonenumberMid()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Phonenumber = "07777777777";
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumberMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Phonenumber = "0777777777777";
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumberExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Phonenumber = "077777777777777";
            Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
            Assert.AreNotEqual(Error, "");
        }



    }
}