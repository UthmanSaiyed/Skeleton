using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClassLibrary;

public partial class OrdersStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Create an instance of the orders class
            clsOrders AnOrder = new clsOrders();

            // Retrieve data grouped by order status from the database
            DataTable dt = AnOrder.StatisticsGroupedByOrderStatus();
            // Upload dt into GridView
            GridViewOrdersGroupedByStatus.DataSource = dt;
            GridViewOrdersGroupedByStatus.DataBind();
            // Change the header of the first column
            GridViewOrdersGroupedByStatus.HeaderRow.Cells[0].Text = " Total ";

            // Retrieve data grouped by order date from the database
            dt = AnOrder.StatisticsGroupedByOrderDate();
            // Upload dt into GridView
            GridViewOrdersGroupedByDate.DataSource = dt;
            GridViewOrdersGroupedByDate.DataBind();
            // Change the header of the first column
            GridViewOrdersGroupedByDate.HeaderRow.Cells[0].Text = " Total ";
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        // Redirect to the previous page
        Response.Redirect("OrdersList.aspx");
    }
}
