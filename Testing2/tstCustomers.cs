using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomers
    {
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
        public void BirthDateProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("2007-02-03");
            //assign the data to the property
            ACustomer.BirthDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.BirthDate, TestData);
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
            Int32 CustomerID = 4;

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
            Int32 CustomerID = 1;

            //invoke the method
            Found = ACustomer.Find(CustomerID);

            //check customerid
            if (ACustomer.CustomerID != 4) 
            { 
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();

            //create a boolean variable to store the result of the search
            bool Found = false;

            //create a boolean variable to record if data is ok
            bool OK = true;

            //create some test data to use with the method
            int CustomerID = 4;

            //invoke the method
            Found = ACustomer.Find(CustomerID);

            //check customerid
            if (ACustomer.Name != "Javk")
            {
                OK = false;
            }
            //test to see that the result is correct
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

            Int32 CustomerID = 4;

            //invoke the method
            Found = ACustomer.Find(CustomerID);

            //check customerid
            if (ACustomer.Email != "paulopsa@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBirthDateFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int CustomerID = 4;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the order date property
            if (ACustomer.BirthDate != Convert.ToDateTime("21/07/1990"))
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

            int CustomerID = 4;

            //invoke the method
            Found = ACustomer.Find(CustomerID);

            //check customerid
            if (ACustomer.Phonenumber != "07796895049")
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
            int CustomerID = 4;
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
            int CustomerID = 4;
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
    }
}