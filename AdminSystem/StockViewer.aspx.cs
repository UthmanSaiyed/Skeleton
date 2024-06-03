using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AStock"] != null)
        {
            clsStock AStock = (clsStock)Session["AStock"];

            Response.Write("Ticket ID: " + AStock.TicketId + "<br/>");
            Response.Write("SKU: " + AStock.SKU + "<br/>");
            Response.Write("Quantity: " + AStock.Quantity + "<br/>");
            Response.Write("Price: " + AStock.Price + "<br/>");
            Response.Write("Supplier: " + AStock.Supplier + "<br/>");
            Response.Write("Ticket Name: " + AStock.TicketName + "<br/>");
            Response.Write("InStock: " + AStock.InStock + "<br/>");
        }
        else
        {
            Response.Write("Stock information not found in session.");
        }
    }

}