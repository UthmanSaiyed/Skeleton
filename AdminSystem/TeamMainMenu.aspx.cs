﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        //redirect the user to the stocklist page
        Response.Redirect("StockList.aspx");
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        //redirect the user to the OrdersList page
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        //redirect the user to the StaffList page
        Response.Redirect("StaffList.aspx");
    }
}