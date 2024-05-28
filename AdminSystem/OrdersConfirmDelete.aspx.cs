using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Variable to store the primary key value of the record to be deleted
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the order to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // Redirect back to the main page
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create a new instance of the orders collection class
        clsOrdersCollection Orders = new clsOrdersCollection();
        // Find the record to delete
        Orders.ThisOrder.Find(OrderID);
        // Delete the record
        Orders.Delete();
        // Redirect back to the main page
        Response.Redirect("OrdersList.aspx");
    }
}
