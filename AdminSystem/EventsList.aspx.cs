using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of the Events Collection
        clsEventsCollection Events = new clsEventsCollection();

        //set the data source to the list of Events in the collection
        lstEventsList.DataSource = Events.EventList;

        //set the name of the primary key
        lstEventsList.DataValueField = "EventID";

        //set the data field to display
        lstEventsList.DataTextField = "Location";

        //bind the data to the list
        lstEventsList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["EventID"] = -1;
        //redirct to the data entry page
        Response.Redirect("EventsDataEntry.aspx");
    }
}