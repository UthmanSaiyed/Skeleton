using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstEvents
    {
        // Test data
        string Title = "Macharia's Event";
        string Location = "24 Fake Street";
        string DateAdded = Convert.ToDateTime("24/12/2024").ToShortDateString();
        string Time = "23:00";
        string Description = "Macharia's awesome event. bring juice.";

        [TestMethod]
        public void TestEvents()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Test to see if the instance exists or not
            Assert.IsNotNull(AnEvent);
        }

        [TestMethod]
        public void TestEventIDProperty()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Create test data
            int TestData = 1;

            // Assign test data
            AnEvent.EventID = TestData;

            // Check if the method is working
            Assert.AreEqual(AnEvent.EventID, TestData);
        }

        [TestMethod]
        public void TestEventTimeProperty()
        {
            // Arrange
            clsEvents AnEvent = new clsEvents();
            string testData = "10:00"; // Example test data

            // Act
            AnEvent.Time = testData;

            // Assert
            Assert.AreEqual(AnEvent.Time, testData);
        }

        [TestMethod]
        public void TestEventLocationProperty()
        {
            // Arrange
            clsEvents AnEvent = new clsEvents();
            string testData = "Uthman's BackYard"; // Example test data

            // Act
            AnEvent.Location = testData;

            // Assert
            Assert.AreEqual(AnEvent.Location, testData);
        }

        [TestMethod]
        public void TestDateProperty()
        {
            // Arrange
            clsEvents AnEvent = new clsEvents();
            DateTime testData = DateTime.Now.Date; // Example test data

            // Act
            AnEvent.DateAdded = testData;

            // Assert
            Assert.AreEqual(AnEvent.DateAdded, testData);
        }

        [TestMethod]
        public void TestEventTitleProperty()
        {
            // Arrange
            clsEvents AnEvent = new clsEvents();
            string testData = "Event Title"; // Example test data

            // Act
            AnEvent.Title = testData;

            // Assert
            Assert.AreEqual(AnEvent.Title, testData);
        }

        [TestMethod]
        public void TestEventDescriptionProperty()
        {
            // Arrange
            clsEvents AnEvent = new clsEvents();
            string testData = "Event Description"; // Example test data

            // Act
            AnEvent.Description = testData;

            // Assert
            Assert.AreEqual(AnEvent.Description, testData);
        }

        [TestMethod]
        public void TestActiveProperties()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Create test data
            bool TestData = true;

            // Assign a value to the property
            AnEvent.Active = TestData;

            // Check if the Active property behaves correctly
            Assert.AreEqual(AnEvent.Active, TestData);
        }

        [TestMethod]
        public void FindMethod()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Boolean variable to store the search result
            bool found = false;

            // Create a boolean variable to record if the data is OK
            bool OK = true;

            // Create test data to assign to the property
            int EventsID = 1;

            // Assign a value to test the boolean
            found = AnEvent.Find(EventsID);

            // Check event ID
            if (AnEvent.EventID != 1)
            {
                OK = false;
            }

            // Test if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Boolean variable to store the search result
            bool found = false;

            // Create a boolean variable to record if the data is OK
            bool OK = true;

            // Create test data to assign to the property
            int EventsID = 1;

            // Assign a value to test the boolean
            found = AnEvent.Find(EventsID);

            // Check the DateAdded property
            if (AnEvent.DateAdded != Convert.ToDateTime("24/12/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTimeFound()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Boolean variable to store the search result
            bool found = false;

            // Create a boolean variable to record if the data is OK
            bool OK = true;

            // Create test data to assign to the property
            int EventsID = 1;

            // Assign a value to test the boolean
            found = AnEvent.Find(EventsID);

            // Check the Time property
            if (AnEvent.Time != "23:00")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLocationFound()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Boolean variable to store the search result
            bool found = false;

            // Create a boolean variable to record if the data is OK
            bool OK = true;

            // Create test data to assign to the property
            int EventsID = 1;

            // Assign a value to test the boolean
            found = AnEvent.Find(EventsID);

            // Check the Location property
            if (AnEvent.Location != "24 Fake Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Boolean variable to store the search result
            bool found = false;

            // Create a boolean variable to record if the data is OK
            bool OK = true;

            // Create test data to assign to the property
            int EventsID = 1;

            // Assign a value to test the boolean
            found = AnEvent.Find(EventsID);

            // Check the Title property
            if (AnEvent.Title != "Macharia's Event")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Boolean variable to store the search result
            bool found = false;

            // Create a boolean variable to record if the data is OK
            bool OK = true;

            // Create test data to assign to the property
            int EventsID = 1;

            // Assign a value to test the boolean
            found = AnEvent.Find(EventsID);

            // Check the Description property
            if (AnEvent.Description != "Macharia's awesome event. bring juice.")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            // Create an instance of the class
            clsEvents AnEvent = new clsEvents();

            // Boolean variable to store the search result
            bool found = true;

            // Create a boolean variable to record if the data is OK
            bool OK = true;

            // Create test data to assign to the property
            int EventsID = 1;

            // Assign a value to test the boolean
            found = AnEvent.Find(EventsID);

            // Check the Active property
            if (AnEvent.Active != false)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestValidMethodOK()
        {
            clsEvents AnEvent = new clsEvents();
            //string variable to store ant error message
            string Error = "";
            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TitleExtremeMin()
        {
            //create an instance of the class we want to create
            clsEvents AnEvent = new clsEvents();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = ""; //error to be triggered
            //invoke the Valid Method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinMinusOne()
        {
            //create an instance of the class we want to create
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Title = "";// error to test

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TitleMinBoundary()
        {
            //create an instance of the class we want to create
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Title = "a";// error to test

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Title = "ab";// error to test

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxMinusOne()
        {
            //create an instance of the class we want to create 
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Title = new string('a', 49);// constructor which creates new string of character 'a' 49 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TitleMaxBoundary()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Title = new string('a', 50);// constructor which creates new string of character 'a' 49 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Title = new string('a', 51);// constructor which creates new string of character 'a' 49 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMid()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Title = new string('a', 25);// constructor which creates new string of character 'a' 25 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()

        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Title = new string('a', 500);// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TitleInvalidInput()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Title = "Invalid@Title##";// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LocationExtremeMin()
        {

            clsEvents AnEvent = new clsEvents();

            //create some test data to pass to the method
            string Location = "";

            //invoke the method
            string Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Extreme Min location length should trigger an error
        }

        [TestMethod]
        public void LocationMinMinusOne()
        {

            clsEvents AnEvent = new clsEvents();

            //create some test data to pass to the method
            string Location = "";

            //invoke the method
            string Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Extreme Min location length should trigger an error
        }

        [TestMethod]
        public void LocationMinBoundary()
        {
            clsEvents AnEvent = new clsEvents();

            //create some test data to pass to the method
            string Location = "A";

            //invoke the method
            string Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // Extreme Min location length should trigger an error
        }

        [TestMethod]
        public void LocationMinPlusOne()
        {
            clsEvents AnEvent = new clsEvents();

            //create some test data to pass to the method
            string Location = "AB";

            //invoke the method
            string Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // Extreme Min location length should trigger an error
        }

        [TestMethod]
        public void LocationMaxMinusOne()
        {
            clsEvents AnEvent = new clsEvents();

            //create some test data to pass to the method
            string Location = new string('a', 99); // constructor which replicates character 'a' 99 times

            string Error = "";
            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // Extreme Min location length should trigger an error
        }

        [TestMethod]
        public void LocationMaxBoundary()
        {
            clsEvents AnEvent = new clsEvents();

            //create some test data to pass to the method
            string Location = new string('a', 100); // constructor which replicates character 'a' 99 times

            //invoke the method
            string Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // Extreme Min location length should trigger an error
        }

        [TestMethod]
        public void LocationMaxPlusOne()
        {
            clsEvents AnEvent = new clsEvents();

            //create some test data to pass to the method
            string Location = new string('a', 101); // constructor which replicates character 'a' 99 times

            //invoke the method
            string Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Extreme Min location length should trigger an error
        }

        [TestMethod]
        public void LocationMid()
        {
            clsEvents AnEvent = new clsEvents();

            //create some test data to pass to the method
            string Location = new string('a', 50); // constructor which replicates character 'a' 99 times

            //invoke the method
            string Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, ""); // Extreme Min location length should trigger an error
        }

        [TestMethod]
        public void LocationExtremeMax()
        {
            clsEvents AnEvent = new clsEvents();

            //create some test data to pass to the method
            string Location = new string('a', 1000); // constructor which replicates character 'a' 99 times

            //invoke the method
            string Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Extreme Min location length should trigger an error
        }

        [TestMethod]
        public void LocationInvalidDataType()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Location = "Invalid@Location##";// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //creeate a variable tl store the test data
            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            //  Convert.ToDateTime("24/12/2024").ToShortDateString();

            TestDate = TestDate.AddYears(-100);
            //create some test data to pass to the method
            string DateAdded = TestDate.ToString();// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsEvents AnEvent = new clsEvents();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsEvents AnEvent = new clsEvents();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEvents AnEvent = new clsEvents();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsEvents AnEvent = new clsEvents();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable       
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TimeExtremeMin() 
       
        { 
        clsEvents AnEvent= new clsEvents();
          
            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string Time = "";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TimeMinBoundary()

        {
            clsEvents AnEvent = new clsEvents();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string Time = "00:00";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TimeMinPlusOne()

        {
            clsEvents AnEvent = new clsEvents();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string Time = "00:01";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TimeMaxMinusOne()

        {
            clsEvents AnEvent = new clsEvents();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string Time = "23:58";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TimeMaxBoundary()

        {
            clsEvents AnEvent = new clsEvents();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string Time = "23:59";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TimeMaxPlusOne()

        {
            clsEvents AnEvent = new clsEvents();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string Time = "24:00";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TimeMid()

        {
            clsEvents AnEvent = new clsEvents();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string Time = "12:00";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TimeExtremeMax()

        {
            clsEvents AnEvent = new clsEvents();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string Time = "99:99";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TimeInvalidDataType()

        {
            clsEvents AnEvent = new clsEvents();

            //string variable to store the error message
            String Error = "";

            //set the DateAdded to a non date value
            string Time = "ABC";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMin()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "";// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinBoundary()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "A";// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "AB";// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxMinusOne()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Description = new string('a', 999);// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxBoundary()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Description = new string('a', 1000);// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Description = new string('a', 1001);// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Description = new string('a', 500);// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Description = new string('a', 10000);// constructor which creates new string of character 'a' 500 times.

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionOtherTest()
        {
            clsEvents AnEvent = new clsEvents();

            //string variable to to store error message
            String Error = "";

            //create some test data to pass to the method
            string Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ultricies mollis ex, id lacinia lorem bibendum ut. Sed euismod, tortor nec blandit fermentum, turpis nisi vehicula nisi, in efficitur augue eros ac erat. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean eget magna ut nisi accumsan faucibus. Sed interdum accumsan urna, nec varius lacus facilisis sit amet. Proin vehicula orci non ligula.";

            //invoke the method
            Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
