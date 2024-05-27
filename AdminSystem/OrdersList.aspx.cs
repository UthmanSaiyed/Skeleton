﻿using System;
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
        lstOrdersList.DataTextField = "TicketID";
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
}