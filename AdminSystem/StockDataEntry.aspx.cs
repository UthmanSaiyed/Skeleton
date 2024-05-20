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
        //capture the eventid
        string EventId = txtEventId.Text;
        //capture the quantity
        string Quantity = txtQuantity.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the supplier
        string Supplier = txtPrice.Text;  
        //capture the ticketname
        string TicketName = txtTicketName.Text; 
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(EventId,Quantity, Price, Supplier, TicketName);
        if (Error == "")
        {
            //capture the eventid
            AStock.EventId = Convert.ToInt32(EventId);
            //capture the quantity
            AStock.Quantity = Convert.ToInt32(Quantity);
            //capture the price
            AStock.Price = Convert.ToDecimal(Price);
            //capture the supplier
            AStock.Supplier = Supplier;
            //capture the ticketname
            AStock.TicketName = TicketName;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();    
            //set the ThisStock property
            StockList.ThisStock = AStock;
            //add the new record
            StockList.Add();
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
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