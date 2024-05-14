using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomers
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

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
        public void FirstnameProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "Peter";
            //assign the data to the property
            ACustomer.Firstname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Firstname, TestData);
        }

        [TestMethod]
        public void LastnameProperty()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "Mopo";
            //assign the data to the property
            ACustomer.Lastname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Lastname, TestData);
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
            ACustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
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
    }
}