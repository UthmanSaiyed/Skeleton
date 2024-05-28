using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock clsstock = new clsStock();

        //retrieve data from the database
        DataTable dT = clsstock.StatisticsGroupedBySupplier();

        //upload dT into GridView
        GridViewStGroupBySupplier.DataSource = dT;
        GridViewStGroupBySupplier.DataBind();

        //change the header of the first column
        GridViewStGroupBySupplier.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        dT = clsstock.StatisticsGroupedByPrice();

        //upload dT into GridView
        GridViewStGroupByPrice.DataSource = dT;
        GridViewStGroupByPrice.DataBind();

        //change the header of the first column
        GridViewStGroupByPrice.HeaderRow.Cells[0].Text = " Total ";
    }
}