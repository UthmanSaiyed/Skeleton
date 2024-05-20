using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        try
        {
            // Create a new instance of clsOrders
            clsOrders AnOrder = new clsOrders();

            // Capture the Ticket ID directly from the TextBox as string
            AnOrder.TicketID = txtTicketID.Text;

            // Capture the Customer ID directly from the TextBox as string
            AnOrder.CustomerID = txtCustomerID.Text;

            // Capture the Order Status from the CheckBox
            AnOrder.OrderStatus = chkOrderStatus.Checked ? "Active" : "Not Active";

            // Capture and directly convert the Order Date to DateTime
            AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

            // Capture the Is Paid status from the DropDownList
            AnOrder.IsPaid = ddlIsPaid.SelectedValue == "true";

            // Capture and directly convert the Total Amount to decimal
            AnOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);

            // Store the order in the session object
            Session["AnOrder"] = AnOrder;

            // Navigate to the view page
            Response.Redirect("OrdersViewer.aspx");
        }
        catch (FormatException ex)
        {
            lblError.Text = "Please enter valid data: " + ex.Message;
        }
        catch (Exception ex)
        {
            lblError.Text = "An error occurred: " + ex.Message;
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
                ddlIsPaid.SelectedValue = AnOrder.IsPaid ? "true" : "false";
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