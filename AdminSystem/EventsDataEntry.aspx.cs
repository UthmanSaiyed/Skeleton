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

    protected void txtDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // create a new instance of clsEvent
        clsEvents AnEvent = new clsEvents();

        //capture the event ID
        AnEvent.EventID = Convert.ToInt32(txtEventsID.Text);

        //capture the event title
        AnEvent.Title = txtTitle.Text;
        
        //capture the event location
        AnEvent.Location = txtLocation.Text;

        //capture the event date
        AnEvent.DateAdded = Convert.ToDateTime(txtDate.Text);

        //capture the event time
        AnEvent.Time = Convert.ToString(txtTime.Text);

        //capture the event description
        AnEvent.Description = txtDescription.Text;

        //capture the event active check box
        AnEvent.Active = chkActive.Checked;

        //store the address in the session object
        Session["AnEvent"] = AnEvent;

        //navigate to the view page
        Response.Redirect("EventsViewer.aspx");
    }
}