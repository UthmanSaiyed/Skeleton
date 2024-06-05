using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        // create an instance of the Orders collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        // set the data source to the list of orders in the collection
        lstOrdersList.DataSource = Orders.OrdersList;
        // set the name of the primary key
        lstOrdersList.DataValueField = "OrderID";
        // set the data field to display
        lstOrdersList.DataTextField = "PromoCode";
        // bind the data to the list
        lstOrdersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be edited
        Int32 OrderID;
        // If a record has been selected from the list
        if (lstOrdersList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            // Store the data in the session object
            Session["OrderID"] = OrderID;
            // Redirect to the edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else // If no record has been selected
        {
            // Display an error message
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be deleted
        Int32 OrderID;
        // If a record has been selected from the list
        if (lstOrdersList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to delete
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            // Store the data in the session object
            Session["OrderID"] = OrderID;
            // Redirect to the delete page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else // If no record has been selected
        {
            // Display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the orders collection
        clsOrdersCollection AnOrder = new clsOrdersCollection();
        //retrieve the value of the promo code from the text box
        AnOrder.ReportByPromoCode(txtFilter.Text);
        //set the data source to the filtered list of orders in the collection
        lstOrdersList.DataSource = AnOrder.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderID";
        //set the data field to display
        lstOrdersList.DataTextField = "PromoCode";
        //bind the data to the list
        lstOrdersList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the orders collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        //clear any filter applied
        Orders.ReportByPromoCode("");
        //clear the filter text box
        txtFilter.Text = "";
        //set the data source to the full list of orders in the collection
        lstOrdersList.DataSource = Orders.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderID";
        //set the data field to display
        lstOrdersList.DataTextField = "PromoCode";
        //bind the data to the list
        lstOrdersList.DataBind();
    }

    protected void btnStatisticsPage_Click(object sender, EventArgs e)
    {
        // Redirect to the statistics page
        Response.Redirect("OrdersStatistics.aspx");
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}

