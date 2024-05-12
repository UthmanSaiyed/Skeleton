using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();

        // Capture the Ticket ID directly from the TextBox and convert it to an integer
        AnOrder.TicketID = Convert.ToInt32(txtTicketID.Text);

        // Capture and directly convert the Customer ID to an integer
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);

        // Capture the Order Status directly from a TextBox
        AnOrder.OrderStatus = txtOrderStatus.Text;

        // Capture and directly convert the Order Date to DateTime
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

        // Capture the Is Paid status directly from a TextBox assumed to have 'true' or 'false'
        AnOrder.IsPaid = Convert.ToBoolean(txtIsPaid.Text);

        // Capture and directly convert the Total Amount to decimal
        AnOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);

        // Store the order in the session object
        Session["AnOrder"] = AnOrder;

        // Navigate to the view page
        Response.Redirect("OrdersViewer.aspx");
    }
}