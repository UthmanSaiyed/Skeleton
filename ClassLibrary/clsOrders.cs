using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public int OrderID { get; set; }
        public int TicketID { get; set; }
        public int CustomerID { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPaid { get; set; }
        public decimal TotalAmount { get; set; }
    }
}