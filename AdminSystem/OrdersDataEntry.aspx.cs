using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // Variable to store the primary key with page-level scope
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            // If this is not a new record
            if (OrderID != -1)
            {
                // Display the current data for the record
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        // Create an instance of the Orders collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        // Find the record to update
        Orders.ThisOrder.Find(OrderID);
        // Display the data for the record
        txtOrderID.Text = Orders.ThisOrder.OrderID.ToString();
        txtTicketID.Text = Orders.ThisOrder.TicketID;
        txtCustomerID.Text = Orders.ThisOrder.CustomerID;
        txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString("yyyy-MM-dd");
        txtTotalAmount.Text = Orders.ThisOrder.TotalAmount.ToString();
        chkOrderStatus.Checked = Orders.ThisOrder.OrderStatus == "Active";
        chkIsPaid.Checked = Orders.ThisOrder.IsPaid;
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
            // Capture the order ID
            AnOrder.OrderID = OrderID; // DON'T MISS THIS BIT !!!!!

            // Capture the data
            AnOrder.TicketID = TicketID;
            AnOrder.CustomerID = CustomerID;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalAmount = Convert.ToDecimal(TotalAmount);
            AnOrder.OrderStatus = OrderStatus;
            AnOrder.IsPaid = IsPaid;

            // Create an instance of the orders collection
            clsOrdersCollection OrdersList = new clsOrdersCollection();

            // If this is a new record i.e. OrderID = -1 then add the data
            if (OrderID == -1)
            {
                // Set the ThisOrder property
                OrdersList.ThisOrder = AnOrder;
                // Add the new record
                OrdersList.Add();
            }
            // Otherwise, it must be an update
            else
            {
                // Find the record to update
                OrdersList.ThisOrder.Find(OrderID);
                // Set the ThisOrder property
                OrdersList.ThisOrder = AnOrder;
                // Update the record
                OrdersList.Update();
            }
            // Redirect back to the list page
            Response.Redirect("OrdersList.aspx");
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