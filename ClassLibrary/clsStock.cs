namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public int TicketId { get; set; }
        public int EventId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Supplier { get; set; }
        public string TicketName { get; set; }
        public bool InStock { get; set; }
    }
}