using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create a new instance of clsEvent
        clsEvents AnEvent = new clsEvents();

       // get the data from the session object
       AnEvent = (clsEvents)Session["AnEvent"];

        //display the Event ID for this entry
        Response.Write("EventID: " + (AnEvent.EventID)+ "<br>");

        //display the Event Title for this entry
        Response.Write("Title: " + (AnEvent.Title) + "<br/>");

        //display the Event Location for this entry
        Response.Write("Locaton: " + (AnEvent.Location) + "<br/>");

        //display the Event Date for this entry
        Response.Write("Date: " + AnEvent.DateAdded.ToShortDateString() + "<br/>");

        //display the Event time for this entry
        Response.Write("Time: " + (AnEvent.Time) + "<br>");

        //display the Event Description for this entry
        Response.Write("Description: " + (AnEvent.Description) + "<br>");

        //display the Event Active checkBox for this entry
        Response.Write(AnEvent.Active);


    }
}
