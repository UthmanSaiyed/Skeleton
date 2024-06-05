using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_Search : System.Web.UI.Page
{
    private StaffManager staffManager;

    protected void Page_Load(object sender, EventArgs e)
    {
        staffManager = new StaffManager();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string staffName = txtSearchName.Text.Trim();
        string departmentName = txtSearchDepartment.Text.Trim();
        bool? employmentStatus = null;

        if (!string.IsNullOrEmpty(ddlSearchEmploymentStatus.SelectedValue))
        {
            employmentStatus = Convert.ToBoolean(ddlSearchEmploymentStatus.SelectedValue);
        }

        gvStaff.DataSource = staffManager.FilterStaff(staffName, departmentName, employmentStatus);
        gvStaff.DataBind();
    }

    protected void gvStaff_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvStaff.EditIndex = e.NewEditIndex;
        btnSearch_Click(sender, e); // Rebind the data to refresh the GridView
    }

    protected void gvStaff_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = gvStaff.Rows[e.RowIndex];
        int staffId = Convert.ToInt32(gvStaff.DataKeys[e.RowIndex].Value);

        TextBox txtStaffName = row.Cells[1].Controls[0] as TextBox;
        TextBox txtAddress = row.Cells[2].Controls[0] as TextBox;
        TextBox txtDepartmentName = row.Cells[3].Controls[0] as TextBox;
        DropDownList ddlEmploymentStatus = row.Cells[4].FindControl("ddlEmploymentStatus") as DropDownList;
        TextBox txtSalary = row.Cells[5].Controls[0] as TextBox;
        TextBox txtDateOfEmployment = row.Cells[6].Controls[0] as TextBox;

        if (txtStaffName == null || txtAddress == null || txtDepartmentName == null || ddlEmploymentStatus == null || txtSalary == null || txtDateOfEmployment == null)
        {
            return;
        }

        string staffName = txtStaffName.Text;
        string address = txtAddress.Text;
        string departmentName = txtDepartmentName.Text;
        bool employmentStatus = Convert.ToBoolean(ddlEmploymentStatus.SelectedValue);
        int salary = Convert.ToInt32(txtSalary.Text);

        DateTime dateOfEmployment;
        if (!DateTime.TryParse(txtDateOfEmployment.Text, out dateOfEmployment))
        {
            dateOfEmployment = DateTime.MinValue;
        }

        Staff staff = new Staff
        {
            StaffID = staffId,
            StaffName = staffName,
            Address = address,
            DepartmentName = departmentName,
            EmploymentStatus = employmentStatus,
            Salary = salary,
            DateofEmployment = dateOfEmployment
        };

        staffManager.UpdateStaff(staff);
        gvStaff.EditIndex = -1;
        btnSearch_Click(sender, e); // Rebind the data to refresh the GridView
    }

    protected void gvStaff_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvStaff.EditIndex = -1;
        btnSearch_Click(sender, e); // Rebind the data to refresh the GridView
    }

    protected void gvStaff_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int staffId = Convert.ToInt32(gvStaff.DataKeys[e.RowIndex].Value);
        staffManager.DeleteStaff(staffId);
        btnSearch_Click(sender, e); // Rebind the data to refresh the GridView
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffViewer.aspx");
    }
}
