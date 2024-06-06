using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 EventID;
    protected void Page_Load(object sender, EventArgs e)
    {
        EventID = Convert.ToInt32(Session["EventID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the events collection class
        clsEventsCollection Events = new clsEventsCollection();
        //find the record to delete
        Events.ThisEvent.Find(EventID);
        //delete the record
        Events.Delete();
        //Redirect back to the main page
        Response.Redirect("EventsList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("EventsList.aspx");

    }
}