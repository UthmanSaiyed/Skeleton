using System;
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

        AStock.Supplier = txtSupplier.Text;
        AStock.TicketName = txtTicketName.Text;


        Session["AStock"] = AStock;

        // Redirect to viewer page
        Response.Redirect("StockViewer.aspx");
    }

}