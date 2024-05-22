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
                 
        //capture Name
        ACustomer.Name = txtName.Text;

     

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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomers ACustomer = new clsCustomers();
        //create variable to store primary key
        Int32 CustomerID;
        //create variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = ACustomer.CustomerID.ToString();
            txtName.Text = ACustomer.Name;
            txtEmail.Text = ACustomer.Email;
            txtBirthDate.Text = ACustomer.BirthDate.ToString();
            txtPhonenumber.Text = ACustomer.Phonenumber;
            cbNewsletter.Checked = ACustomer.Newsletter;
            cbActive.Checked = ACustomer.Active;
        }
    }
}