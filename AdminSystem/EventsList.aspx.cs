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
        //if this is the first time the page is being displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayEvents();
        }
    }
    void DisplayEvents()
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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 EventId;
        //if a record has been selected from the list
        if (lstEventsList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            EventId = Convert.ToInt32(lstEventsList.SelectedValue);
            //store the data in the session object
            Session["EventID"] = EventId;
            //redirect to the edit page
            Response.Redirect("EventsDataEntry.aspx");
        }
        else  //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 EventId;
        //if a record has been selected from the list
        if (lstEventsList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            EventId = Convert.ToInt32(lstEventsList.SelectedValue);
            //store the data in the session object
            Session["EventID"] = EventId;
            //redirect to the edit page
            Response.Redirect("EventsConfirmDelete.aspx");
        }

        else  //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnFilterApply_Click(object sender, EventArgs e)
    {
        clsEventsCollection events = new clsEventsCollection();
        events.ReportByLocation(txtFilter.Text);
        lstEventsList.DataSource = events.EventList;
        lstEventsList.DataValueField = "EventID";
        lstEventsList.DataTextField = "Location";
        lstEventsList.DataBind();
    }

    protected void btnFilterClr_Click(object sender, EventArgs e)
    {
        clsEventsCollection events = new clsEventsCollection();
        txtFilter.Text = "";
        events.ReportByLocation(txtFilter.Text);
        lstEventsList.DataSource = events.EventList;
        lstEventsList.DataValueField = "EventID";
        lstEventsList.DataTextField = "Location";
        lstEventsList.DataBind();
    }

    protected void btnStatistics_Click(object sender, EventArgs e)
    {

    }

    protected void btnReturnMM_Click(object sender, EventArgs e)
    {

    }
}
