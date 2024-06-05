using System;
using System.Web.UI;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnAddStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffAdd.aspx");
    }

    protected void btnListStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    protected void btnFindStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffFind.aspx");
    }

    protected void btnFilterStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffFilter.aspx");
    }

    protected void btnStatistics_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffStatistics.aspx");
    }
}
