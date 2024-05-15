using System;
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
        //create a new instance of clsCustomers
        clsCustomers ACustomer = new clsCustomers();

        //get data from session object
        ACustomer = (clsCustomers)Session["ACustomer"];

        //display customerId
        Response.Write(ACustomer.CustomerID);
    }
}