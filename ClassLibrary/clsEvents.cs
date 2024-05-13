using System;

namespace ClassLibrary
{
    public class clsEvents
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int EventID { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Method to set Time property
        public void SetTime(string time)
        {
            Time = time;
        }

        // Method to get Time property
        public string GetTime()
        {
            return Time;
        }

        // Method to set Location property
        public void SetLocation(string location)
        {
            Location = location;
        }

        // Method to get Location property
        public string GetLocation()
        {
            return Location;
        }

        // Method to set Title property
        public void SetTitle(string title)
        {
            Title = title;
        }

        // Method to get Title property
        public string GetTitle()
        {
            return Title;
        }

        // Method to set Description property
        public void SetDescription(string description)
        {
            Description = description;
        }

        // Method to get Description property
        public string GetDescription()
        {
            return Description;
        }
    }
}
