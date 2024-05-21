using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstEvents
    {
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
            if (AnEvent.DateAdded != Convert.ToDateTime("23/12/2024"))
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
            if (AnEvent.Time != "10:00")
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
            if (AnEvent.Location != "Uthman's BackYard")
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
            if (AnEvent.Title != "Event Title")
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
            if (AnEvent.Description != "Event Description")
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
            bool found = false;

            // Create a boolean variable to record if the data is OK
            bool OK = true;

            // Create test data to assign to the property
            int EventsID = 1;

            // Assign a value to test the boolean
            found = AnEvent.Find(EventsID);

            // Check the Active property
            if (AnEvent.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
