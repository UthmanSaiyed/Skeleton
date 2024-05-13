﻿using System;
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
        {
            // Create a new instance of clsStock
            clsStock AStock = new clsStock();
            //capture the ticket id
            AStock.TicketId = Convert.ToInt32(txtTicketId.Text);
            //store the stock in the session object
            Session["AStock"] = AStock;
            // Navigate to the Stock viewer page
            Response.Redirect("StockViewer.aspx");
          

        }
    }
}