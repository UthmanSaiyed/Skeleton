using System;
using System.Data;
using System.Web.UI;
using ClassLibrary;

public partial class _1_Find : System.Web.UI.Page
{
    private StaffManager staffManager;

    protected void Page_Load(object sender, EventArgs e)
    {
        staffManager = new StaffManager();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string staffName = txtSearchName.Text.Trim();
        DataTable dt = staffManager.FindStaffByName(staffName);

        if (dt.Rows.Count > 0)
        {
            gvStaff.DataSource = dt;
            gvStaff.DataBind();
        }
        else
        {
            gvStaff.DataSource = null;
            gvStaff.DataBind();
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffViewer.aspx");
    }
}
