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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomers
        clsCustomers ACustomer = new clsCustomers();

        //capture the CustomerID
        ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                 
        //capture firstname
        ACustomer.Firstname = txtFirstname.Text;

        //capture lastname
        ACustomer.Lastname = txtLastname.Text;

        //capture email
        ACustomer.Email = txtEmail.Text;

        //capture birthdate
        ACustomer.BirthDate = Convert.ToDateTime(txtBirthDate.Text);

        //capture phonenumber
        ACustomer.Phonenumber = txtPhonenumber.Text;

        //capture newsletter
        ACustomer.Newsletter = cbActive.Checked;

        //capture active
        ACustomer.Active = cbActive.Checked;

        //store the customer in the session object
        Session["ACustomer"] = ACustomer;

        //navigate to the view page
        Response.Redirect("CustomersViewer.aspx");
    }
}