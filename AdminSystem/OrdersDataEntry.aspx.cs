using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Any initialization code if needed
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();

        // Capture the input data
        string TicketID = txtTicketID.Text;
        string CustomerID = txtCustomerID.Text;
        string OrderDate = txtOrderDate.Text;
        string TotalAmount = txtTotalAmount.Text;
        string OrderStatus = chkOrderStatus.Checked ? "Active" : "Not Active";
        bool IsPaid = chkIsPaid.Checked;

        // Variable to store any error messages
        string Error = "";

        // Validate the data
        Error = AnOrder.Valid(TicketID, CustomerID, OrderDate, TotalAmount);

        // If there are no errors
        if (Error == "")
        {
            // Capture the data
            AnOrder.TicketID = TicketID;
            AnOrder.CustomerID = CustomerID;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalAmount = Convert.ToDecimal(TotalAmount);
            AnOrder.OrderStatus = OrderStatus;
            AnOrder.IsPaid = IsPaid;

            // Store the order in the session object
            Session["AnOrder"] = AnOrder;

            // Navigate to the view page
            Response.Redirect("OrdersViewer.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the clsOrders class
        clsOrders AnOrder = new clsOrders();
        // Create a variable to store the primary key
        Int32 OrderID;
        // Create a variable to store the result of the find operation
        Boolean Found = false;

        // Try to convert the primary key entered by the user
        try
        {
            OrderID = Convert.ToInt32(txtOrderID.Text);
            // Find the record
            Found = AnOrder.Find(OrderID);
            // If found
            if (Found == true)
            {
                // Display the values of the properties in the form
                txtTicketID.Text = AnOrder.TicketID;
                txtCustomerID.Text = AnOrder.CustomerID;
                chkOrderStatus.Checked = AnOrder.OrderStatus == "Active";
                txtOrderDate.Text = AnOrder.OrderDate.ToString("yyyy-MM-dd");
                chkIsPaid.Checked = AnOrder.IsPaid;
                txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            }
            else
            {
                lblError.Text = "Record not found.";
            }
        }
        catch (FormatException)
        {
            lblError.Text = "Please enter a valid numeric Order ID.";
        }
    }
}