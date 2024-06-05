using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstEventsCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //Create am instance of the class
            clsEventsCollection AllEvents = new clsEventsCollection();
            //test to check if the class exists
            Assert.IsNotNull(AllEvents);
        }

        [TestMethod]
        public void ThisEventPropertyOk()
        {
            //Create am instance of the class
            clsEventsCollection AllEvents = new clsEventsCollection();

            //create some test data to assign to the property
            clsEvents TestEvent = new clsEvents();

            //set the properties of the test object
            TestEvent.EventID = 1;
            TestEvent.Title = "Macharia's Event";
            TestEvent.Location = "24 Fake Street";
            TestEvent.DateAdded = DateTime.Now;
            TestEvent.Time = "23:00";
            TestEvent.Description = "Macharia's awesome event. bring juice.";
            TestEvent.Active = true;

            AllEvents.ThisEvent = TestEvent;
            //test to check if the class exists
            Assert.AreEqual(AllEvents.ThisEvent, TestEvent);
        }

        [TestMethod]
        public void EventsListOk()
        {
            //create an instance of the class we want to create
            clsEventsCollection AllEvents= new clsEventsCollection();

            //create some test data (List Of Objects)
            List<clsEvents> TestList = new List<clsEvents>();
            //Add an Item to the List
            //Create the item of test data
            clsEvents TestItem = new clsEvents();
            //set the properties
            TestItem.EventID = 1;
            TestItem.Title = "Macharia's Event";
            TestItem.Location = "24 Fake Street";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Time = "23:00";
            TestItem.Description = "Macharia's awesome event. bring juice.";
            TestItem.Active = true;

            //add the test items to the test list
            TestList.Add(TestItem);

            //assign the data to the property
           AllEvents.EventList = TestList;

            Assert.AreEqual(AllEvents.EventList, TestList);
        }


        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsEventsCollection AllEvents = new clsEventsCollection();

            //create some test data (List Of Objects)
            List<clsEvents> TestList = new List<clsEvents>();
            //Add an Item to the List
            //Create the item of test data
            clsEvents TestItem = new clsEvents();
            //set the properties
            TestItem.EventID = 1;
            TestItem.Title = "Macharia's Event";
            TestItem.Location = "24 Fake Street";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Time = "23:00";
            TestItem.Description = "Macharia's awesome event. bring juice.";
            TestItem.Active = true;

            //add the test items to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllEvents.EventList = TestList;

            Assert.AreEqual(AllEvents.EventList.Count, TestList.Count);
        }

    }
}
