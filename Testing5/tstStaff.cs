using ClassLibrary; // Ensure this namespace is correct
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        public object Name { get; private set; }
        public object Address { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void activepropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assgin to the property
            Boolean TestData = true;
            //assgin the data to the property
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }
        [TestMethod]
        public void DateaddedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            //assgin the data to the property
            AStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateAdded, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data tto assgin to the property
            Int32 TestData = 1;
            //assgin the data to the property
            AStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "John Doe";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void AddressPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "123 Main Street";
            //assign the data to the property
            AStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address, TestData);
        }

        [TestMethod]
        public void DepartmentNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "IT";
            //assign the data to the property
            AStaff.DepartmentName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DepartmentName, TestData);
        }

        [TestMethod]
        public void EmploymentStatusPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AStaff.EmploymentStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmploymentStatus, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 50000;
            //assign the data to the property
            AStaff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Salary, TestData);
        }

        [TestMethod]
        public void DateofEmploymentPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = new DateTime(2022, 1, 1);
            //assign the data to the property
            AStaff.DateofEmployment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateofEmployment, TestData);
        }
        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of class we want to create
            clsStaff AStaff = new clsStaff();
            //create boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 StaffId = 21;
            // Invoke the method
            Found = AStaff.Find(StaffId);
            // Check the StaffId property
            if (AStaff.StaffId != StaffId)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 StaffId = 21;
            // Invoke the method
            Found = AStaff.Find(StaffId);
            // Check the StaffName property
            if (AStaff.StaffName != "John Doe")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the address property
            if (AStaff.Address != "123 Main Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the department name property
            if (AStaff.DepartmentName != "IT")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmploymentStatusFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int StaffId = 1;
        }
        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the salary property
            if (AStaff.Salary != 30000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the date added property
            if (AStaff.DateAdded != Convert.ToDateTime("2022-01-01"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            bool Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the active property
            if (AStaff.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        /****************** Staff ID VALIDATION TESTS******************/
        [TestMethod]
        public void StaffIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffID = ""; //this should trigger an error
                                 //invoke the method
            Error = AnStaff.Valid(StaffID, Name, Address );
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffID = "1"; //this should be ok
                                  //invoke the method
            Error = AnStaff.Valid(StaffID, Name, Address);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffID = "2"; //this should be ok
                                  //invoke the method
            Error = AnStaff.Valid(StaffID, Name, Address);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffID = "999"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(StaffID, Name, Address);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffID = "1000"; //this should be ok
                                     //invoke the method
            Error = AnStaff.Valid(StaffID, Name, Address);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffID = "500"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(StaffID, Name, Address);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffID = "1001"; //this should fail
                                     //invoke the method
            Error = AnStaff.Valid(StaffID, Name, Address);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffID = "999999"; //this should fail
                                       //invoke the method
            Error = AnStaff.Valid(StaffID, Name, Address);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDInvalidFormat()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffID = "abc"; //this should fail
                                    //invoke the method
            Error = AnStaff.Valid(StaffID, Name, Address);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}

