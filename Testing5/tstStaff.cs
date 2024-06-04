using ClassLibrary; // Ensure this namespace is correct
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
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
            clsStaff AStaff = new clsStaff()
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

    }

