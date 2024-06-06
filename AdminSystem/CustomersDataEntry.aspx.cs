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

        string CustomerID = txtCustomerID.Text;
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string Date = txtDate.Text;
        string Phonenumber = txtPhonenumber.Text;
        string Newsletter = cbActive.Text;
        string Active = cbActive.Text;
        string Error = "";
        Error = ACustomer.Valid(Name, Email, Date, Phonenumber);
        if (Error == "")
        {
            ACustomer.Name = Name;
            ACustomer.Email = Email;
            ACustomer.Date = Convert.ToDateTime(Date);
            ACustomer.Phonenumber = Phonenumber;
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomersViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

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
            txtDate.Text = ACustomer.Date.ToString();
            txtPhonenumber.Text = ACustomer.Phonenumber;
            cbNewsletter.Checked = ACustomer.Newsletter;
            cbActive.Checked = ACustomer.Active;
        }
    }
}