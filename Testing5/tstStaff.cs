using ClassLibrary; // Ensure this namespace is correct
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}

