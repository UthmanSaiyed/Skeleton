using System;
using System.Activities.Statements;
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
        // Create a new instance of clsStock
        clsStock AStock = new clsStock();

       
        if (!string.IsNullOrEmpty(txtTicketId.Text))
        {
            AStock.TicketId = Convert.ToInt32(txtTicketId.Text);
        }
        else
        {
            // Handles if ticket id is not provided
            AStock.TicketId = 0; 
        }

        if (!string.IsNullOrEmpty(txtEventId.Text))
        {
            AStock.EventId = Convert.ToInt32(txtEventId.Text);
        }
        else
        {
            AStock.EventId = 0; 
        }


        if (!string.IsNullOrEmpty(txtQuantity.Text))
        {
            AStock.Quantity = Convert.ToInt32(txtQuantity.Text);
        }
        else
        {
            AStock.Quantity = 0; 
        }

        if (!string.IsNullOrEmpty(txtPrice.Text))
        {
            AStock.Price = Convert.ToDecimal(txtPrice.Text);
        }
        else
        {
            AStock.Price = 0.00m; 
        }
        Error = AStock.Valid(EventId, Quantity, Price, Supplier, TicketName);
        if(Error == "")
        {
            //capture the Eventid
            AStock.EventId = EventId;
            //capture the Quantity
            AStock.Quantity = Quantity;
            //capture the Eventid
            AStock.Price = Price;
            //capture the Eventid
            AStock.Supplier = Supplier;
            //capture the Eventid
            AStock.TicketName = TicketName;
            Session["AStock"] = AStock;

            // Redirect to viewer page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display error
            lblError.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e) 
    {
        //creae an instance of the address class
        clsStock AStock = new clsStock();
        //create a variable to store the primary key
        Int32 TicketId;
        //create a variable to store the result of the find operation
        Boolean Found = false;

        try
        {
            //get the primary key enteed by the user
            TicketId = Convert.ToInt32(txtTicketId.Text);
            //find the record
            Found = AStock.Find(TicketId);
            //if found
            if (Found == true)
            {
                //display the values of the properties in the form
                txtTicketId.Text = AStock.TicketId.ToString();
                txtEventId.Text = AStock.EventId.ToString();
                txtQuantity.Text = AStock.Quantity.ToString();
                txtPrice.Text = AStock.Price.ToString();
                txtSupplier.Text = AStock.Supplier;
                txtTicketName.Text = AStock.TicketName;
            }
            else
            {
                //display an error message
                lblError.Text = "Record not found.";
            }
        }
        catch (FormatException)
        {
            //display an error message
            lblError.Text = "Please enter a valid numeric Ticket ID.";
        }
    }

}