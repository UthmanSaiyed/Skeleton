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

            // Capture the Ticket ID directly from the TextBox and convert it to an integer
            AnOrder.TicketID = Convert.ToInt32(txtTicketID.Text);

            // Capture and directly convert the Customer ID to an integer
            AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);

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
            lblError.Text = "Please enter valid data: ";
        }
        catch (Exception ex)
        {
            lblError.Text = "An error occurred: " ;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the clsOrders class
        clsOrders AnOrder = new clsOrders();
        //create a variable to store the primary key
        Int32 OrderID;
        //create a variable to store the result of the find operation
        Boolean Found = false;

        //try to convert the primary key entered by the user
        try
        {
            OrderID = Convert.ToInt32(txtOrderID.Text);
            //find the record
            Found = AnOrder.Find(OrderID);
            //if found
            if (Found == true)
            {
                //display the values of the properties in the form
                txtTicketID.Text = AnOrder.TicketID.ToString();
                txtCustomerID.Text = AnOrder.CustomerID.ToString();
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