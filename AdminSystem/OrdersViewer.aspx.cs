using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Check if the session contains the order object and retrieve it
        if (Session["AnOrder"] != null)
        {
            // Cast the session object back to clsOrders type
            clsOrders AnOrder = (clsOrders)Session["AnOrder"];

            // Display the Ticket ID for this entry
            Response.Write("Promo Code: " + AnOrder.PromoCode + "<br/>");

            // Display the Customer ID
            Response.Write("Order Feedback: " + AnOrder.OrderFeedback + "<br/>");

            // Display the Order Status
            Response.Write("Order Status: " + AnOrder.OrderStatus + "<br/>");

            // Display the Order Date
            Response.Write("Order Date: " + AnOrder.OrderDate.ToString("dd/MM/yyyy") + "<br/>");

            // Display the Is Paid status
            Response.Write("Order Paid: " + (AnOrder.IsPaid ? "Yes" : "No") + "<br/>");

            // Display the Total Amount
            Response.Write("Total Amount: £" + AnOrder.TotalAmount.ToString("N2") + "<br/>");
        }
        else
        {
            // If the session does not contain the order, display a message
            Response.Write("No order information available.");
        }
    }
}