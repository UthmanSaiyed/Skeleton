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
            //create an instance of the class
            clsEvents AnEvent = new clsEvents();

            //test to see if the instance exist or not
            Assert.IsNotNull(AnEvent);
        }

        [TestMethod]
        public void TestEventIDProperty()
        {
            //creating an instance of the class
            clsEvents AnEvent = new clsEvents();

            //Creating Test Data 
            int TestData = 1;

            //Assigning test data
            AnEvent.EventID = TestData;

            // checking if the method is working
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
            // create an instance of the class
            clsEvents AnEvent = new clsEvents();

            //creating some test data to assign to the property
            bool TestData = true;

            //assign a value to test the boolean
            AnEvent.Active = TestData;

            //If the Active property behaves correctly, this assertion should pass
            Assert.AreEqual(AnEvent.Active, TestData);
        }
    }
}
