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
    //variable to store the primary key with page level scope
    Int32 TicketId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Stock to be processed
        TicketId = Convert.ToInt32(Session["TicketId"] ?? "-1");
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (TicketId != -1)
            {
                //display the current data of the record
                DisplayStock();
            }
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the eventid
        string SKU = txtSKU.Text;
        //capture the quantity
        string Quantity = txtQuantity.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the supplier
        string Supplier = txtSupplier.Text;  
        //capture the ticketname
        string TicketName = txtTicketName.Text;
        //capture InStock checkbox
        bool InStock = chkInStock.Checked;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(SKU, Quantity, Price, Supplier, TicketName);
        if (Error == "")
        {
            //captures the ticketid
            AStock.TicketId = Convert.ToInt32(TicketId); 
            //capture the eventid
            AStock.SKU = SKU;
            //capture the quantity
            AStock.Quantity = Convert.ToInt32(Quantity);
            //capture the price
            AStock.Price = Convert.ToDecimal(Price);
            //capture the supplier
            AStock.Supplier = Supplier;
            //capture the ticketname
            AStock.TicketName = TicketName;
            //capture inStock
            AStock.InStock = chkInStock.Checked;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();    

            //if this a new record of the stock collection
            if (TicketId == -1)
            {
                //set thisStock property
                StockList.ThisStock = AStock;
                //adds the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(TicketId);
                //set the thisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }
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
                txtSKU.Text = AStock.SKU.ToString();
                txtQuantity.Text = AStock.Quantity.ToString();
                txtPrice.Text = AStock.Price.ToString();
                txtSupplier.Text = AStock.Supplier;
                txtTicketName.Text = AStock.TicketName;
                chkInStock.Checked = AStock.InStock;
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
    void DisplayStock()
    {
        //create an instance of the stock
        clsStockCollection Stock = new clsStockCollection();
        //find the record to update
        Stock.ThisStock.Find(TicketId);
        //display the data for the record
        txtTicketId.Text = Stock.ThisStock.TicketId.ToString();
        txtSKU.Text = Stock.ThisStock.SKU.ToString();
        txtQuantity.Text = Stock.ThisStock.Quantity.ToString();
        txtPrice.Text = Stock.ThisStock.Price.ToString();
        txtSupplier.Text = Stock.ThisStock.Supplier;
        txtTicketName.Text = Stock.ThisStock.TicketName;
        chkInStock.Checked = Stock.ThisStock.InStock;
    }

    protected void btnReturnMM_Click(object sender, EventArgs e)
    {
        //redirect to the team main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the stock list page
        Response.Redirect("StockList.aspx");
    }
}