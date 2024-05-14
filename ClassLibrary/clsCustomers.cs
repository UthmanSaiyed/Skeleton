using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        public int CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public bool Newsletter { get; set; }
        public bool Active { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
    }
}