using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (!IsPostBack) 
        {
            //update the list box
            DisplayStocks();
        }
    }
    void DisplayStocks()
    {
        //create an instance of the Stock Collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to the list of stock in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "TicketId";
        //set the data field to display
        lstStockList.DataTextField = "TicketName";
        //bind the data to the list
        lstStockList.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["TicketId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 TicketId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            TicketId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["TicketId"] = TicketId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted 
        Int32 TicketId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            TicketId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["TicketId"] = TicketId;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnFilterApply_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object 
        clsStockCollection AStock = new clsStockCollection();
        //retrieve the value of supplier from the presentation layer
        AStock.ReportBySupplier(txtFilter.Text);
        //set the data source to the list of stock in the collection
        lstStockList.DataSource = AStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "TicketId";
        //set the name of the field to display
        lstStockList.DataTextField = "Supplier";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnFilterClr_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection AStock = new clsStockCollection();
        //set an empty string
        AStock.ReportBySupplier("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of stock in the collection
        lstStockList.DataSource = AStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "TicketId";
        //set the name of the field to display
        lstStockList.DataTextField = "Supplier";
        //bind the data to the display
        lstStockList.DataBind();
    }

    protected void btnStatistics_Click(object sender, EventArgs e)
    {
        //redirect to the edit page
        Response.Redirect("StockStatistics.aspx");
    }
}