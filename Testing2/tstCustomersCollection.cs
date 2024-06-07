using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomersCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //crate an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomersListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //n this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //Add an Item to the list 
            //create the item of the test data
            clsCustomers TestItem = new clsCustomers();
            //set the properties
            TestItem.Active = true;
            TestItem.Newsletter = true;
            TestItem.CustomerID = 1;
            TestItem.Name = "Twelve";
            TestItem.Email = "Twelve@gmail.com";
            TestItem.Date = DateTime.Now;
            TestItem.Phonenumber = "00000000000";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }




        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instnce of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign the new property
            clsCustomers TestCustomers = new clsCustomers();
            //set the propertes of the test object
            TestCustomers.Active = true;
            TestCustomers.Newsletter = true;
            TestCustomers.CustomerID = 1;
            TestCustomers.Name = "Twelve";
            TestCustomers.Email = "Twelve@gmail.com";
            TestCustomers.Date = DateTime.Now;
            TestCustomers.Phonenumber = "00000000000";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomers;
            //AllCustomers.ThisCustomer = TestCustomers;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomers);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create the instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //add an item of the test data 
            //create the item of the test data
            clsCustomers TestItem = new clsCustomers();
            //set the properties
            TestItem.Active = true;
            TestItem.Newsletter = true;
            TestItem.CustomerID = 1;
            TestItem.Name = "Twelve";
            TestItem.Email = "Twelve@gmail.com";
            TestItem.Date = DateTime.Now;
            TestItem.Phonenumber = "00000000000";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}

    
