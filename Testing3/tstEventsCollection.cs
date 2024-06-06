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
        /*        [TestMethod]
                public void  AddMethodOK()
                {
                    clsEventsCollection AllEvents = new clsEventsCollection();
                    clsEvents TestItem = new clsEvents();
                    Int32 PrimaryKey = 0;
                    //set the properties
                    TestItem.EventID = 1;
                    TestItem.Title = "Macharia's Event";
                    TestItem.Location = "24 Fake Street";
                    TestItem.DateAdded = DateTime.Now;
                    TestItem.Time = "23:00";
                    TestItem.Description = "Macharia's awesome event. bring juice.";
                    TestItem.Active = true;
                    //set this event to the test data
                    AllEvents.ThisEvent = TestItem;
                    //add the record
                    PrimaryKey = AllEvents.Add();
                    //set the primary key of the test data
                    TestItem.EventID = PrimaryKey;
                    //find the record
                    AllEvents.ThisEvent.Find(PrimaryKey);
                    //test to see that the two values are the same
                    Assert.AreEqual(AllEvents.ThisEvent, TestItem);

                }
        */

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsEventsCollection AllEvents = new clsEventsCollection();
            //create the item for the test data
            clsEvents TestItem = new clsEvents();
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.EventID = 1;
            TestItem.Title = "Macharia's Event";
            TestItem.Location = "24 Fake Street";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Time = "23:00";
            TestItem.Description = "Macharia's awesome event. bring juice.";
            TestItem.Active = true;
            //set this event to the test data
            AllEvents.ThisEvent = TestItem;
            //add the record
            PrimaryKey = AllEvents.Add();
            //set the primary key of the test data
            TestItem.EventID = PrimaryKey;

            //replication of mofifying the test
            TestItem.Title = "ChangedToParth";
            TestItem.Location = "24 Real Street";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Time = "00:01";
            TestItem.Description = "Parth's takeover event. bring protien shakes.";
            TestItem.Active = false;
            //set the record based on the newly manipulated data
            AllEvents.ThisEvent = TestItem;
            //update the record
            AllEvents.Update();
            //find the record
            AllEvents.ThisEvent.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllEvents.ThisEvent, TestItem);

        }
    }
}
