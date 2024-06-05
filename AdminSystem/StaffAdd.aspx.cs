using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_Add : System.Web.UI.Page
{
    private StaffManager staffManager;

    protected void Page_Load(object sender, EventArgs e)
    {
        staffManager = new StaffManager();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        DateTime dateOfEmployment;
        bool isDateValid = DateTime.TryParse(txtDateofEmployment.Text, out dateOfEmployment);

        Staff staff = new Staff
        {
            StaffName = txtStaffName.Text,
            Address = txtAddress.Text,
            DepartmentName = txtDepartmentName.Text,
            EmploymentStatus = chkEmploymentStatus.Checked,
            Salary = int.Parse(txtSalary.Text),
            DateofEmployment = isDateValid ? dateOfEmployment : (DateTime?)null
        };

        staffManager.AddStaff(staff);
        Response.Redirect("StaffList.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}
