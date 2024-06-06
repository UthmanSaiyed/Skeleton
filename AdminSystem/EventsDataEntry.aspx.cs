using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{ 
    Int32 EventID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Event to be processed
        EventID = Convert.ToInt32(Session["EventID"]);
        if (IsPostBack == false)
        {
            if (EventID != -1)
            {
                DisplayEvent();
            }
        }
    }
    void DisplayEvent()
    {
        //create an instance of the address book
        clsEventsCollection Events = new clsEventsCollection();

        //find the record to update
        Events.ThisEvent.Find(EventID);

        //display the data for the record
        txtTitle.Text = Events.ThisEvent.EventID.ToString();
        txtLocation.Text = Events.ThisEvent.Location.ToString();
        txtDate.Text = Events.ThisEvent.DateAdded.ToString();
        txtTime.Text = Events.ThisEvent.Time.ToString();
        txtDescription.Text = Events.ThisEvent.Description.ToString();
        chkActive.Checked = Events.ThisEvent.Active;
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


        //capture the title
        string Title = txtTitle.Text;

        //capture the event location
        string Location = txtLocation.Text;

        //capture the event date
        string DateAdded = Convert.ToString(txtDate.Text);

        //capture the event time
        string Time = Convert.ToString(txtTime.Text);

        //capture the event description
        string Description = txtDescription.Text;

        //capture the event active check box
        AnEvent.Active = chkActive.Checked;

        //variable to store error message
        string Error = "";

        //validate the data
        Error = AnEvent.Valid(Title, Location, DateAdded, Time, Description);
        if (Error == "")
        {

            //capture the event ID
            AnEvent.EventID = EventID;

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

            //create a new instance
            clsEventsCollection EventsList = new clsEventsCollection();
            if (EventID == -1)
            {//set the ThisEvent property
                EventsList.ThisEvent = AnEvent;

                //add the new record
                EventsList.Add();
            }
            else
            {
                //find the record to update
                EventsList.ThisEvent.Find(EventID);
                //set the ThisEvent property
                EventsList.ThisEvent = AnEvent;
                //update the record
                EventsList.Update();
            }
            //navigate to the view page
            Response.Redirect("EventsList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsEvents AnEvent = new clsEvents();
        Int32 EventID;
        bool Found = false;
        EventID = Convert.ToInt32(txtEventsID.Text);
        Found = AnEvent.Find(EventID);
        if (Found == true)
        {
            txtTitle.Text = AnEvent.Title;
            txtLocation.Text = AnEvent.Location;
            txtDate.Text = AnEvent.DateAdded.ToShortDateString();
            txtTime.Text = AnEvent.Time;
            txtDescription.Text = AnEvent.Description;
            chkActive.Checked = AnEvent.Active;
        }
    }
}