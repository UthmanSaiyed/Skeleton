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
    }
}