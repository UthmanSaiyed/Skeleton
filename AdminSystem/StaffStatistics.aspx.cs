using System;
using System.Data;
using System.Web.UI;
using ClassLibrary;

public partial class _1_Statistics : System.Web.UI.Page
{
    private StaffManager staffManager;

    protected void Page_Load(object sender, EventArgs e)
    {
        staffManager = new StaffManager();
        if (!IsPostBack)
        {
            LoadStatistics();
        }
    }

    private void LoadStatistics()
    {
        DataTable dt = staffManager.GetStaffStatistics();

        if (dt.Rows.Count > 0)
        {
            DataRow row = dt.Rows[0];
            lblTotalStaff.Text = "Total Staff: " + row["TotalStaff"].ToString();
            lblEmployedStaff.Text = "Employed Staff: " + row["EmployedStaff"].ToString();
            lblUnemployedStaff.Text = "Unemployed Staff: " + row["UnemployedStaff"].ToString();
            lblAverageSalary.Text = "Average Salary: " + row["AverageSalary"].ToString();
            lblMinimumSalary.Text = "Minimum Salary: " + row["MinimumSalary"].ToString();
            lblMaximumSalary.Text = "Maximum Salary: " + row["MaximumSalary"].ToString();
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffViewer.aspx");
    }
}
