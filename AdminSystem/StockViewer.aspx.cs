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
        // Check if the session contains the Stock object and retrieve it
        
            // Cast the session object back to clstype
            clsStock AStock = new clsStock();
            //get the data from the session object
            AStock = (clsStock)Session["AStock"];
            // Display the Ticket ID for this entry
            Response.Write("Ticket ID: " + AStock.TicketId + "<br/>");

            //get the data from the session object
            AStock = (clsStock)Session["AStock"];
            // Display the Event ID
            Response.Write("Event ID: " + AStock.EventId + "<br/>");

            //get the data from the session object
            AStock = (clsStock)Session["AStock"];
            // Display the Quantity
            Response.Write("Quantity: " + AStock.Quantity + "<br/>");

            //get the data from the session object
            AStock = (clsStock)Session["AStock"];
            // Display the price
            Response.Write("Price: " + AStock.Price + "<br/>");

            //get the data from the session object
            AStock = (clsStock)Session["AStock"];
            // Display the supplier
            Response.Write("Supplier: " + AStock.Supplier + "<br/>");

            //get the data from the session object
            AStock = (clsStock)Session["AStock"];
            // Display the Ticket Name
            Response.Write("Ticket Name: " + AStock.TicketName + "<br/>");

            //get the data from the session object
            AStock = (clsStock)Session["AStock"];
            // Display what is in Stock
            Response.Write("InStock: " + AStock.InStock + "<br/>");
        }
  
    }
}