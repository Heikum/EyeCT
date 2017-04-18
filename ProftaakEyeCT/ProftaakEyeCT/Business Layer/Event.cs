using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Event
    {
        public int id;
        public string description;
        public string name;
        public string location;
        public DateTime eventstartdate;
        public DateTime eventenddate;



        public Event(int id, string Description, string Name, string Location, DateTime EventStartDate, DateTime EventEndDate)
        {
            this.id = id;
            this.description = Description;
            this.name = Name;
            this.location = Location;
            this.eventstartdate = EventStartDate.Date;
            this.eventenddate = EventEndDate.Date;

        }

        public Event(string Description, string Name, string Location, DateTime EventStartDate, DateTime EventEndDate)
        {
            this.description = Description;
            this.name = Name;
            this.location = Location;
            this.eventstartdate = EventStartDate.Date;
            this.eventenddate = EventEndDate.Date;

        }

        public void addMaterial()
        {

        }

        public void checkMaterialAvailabilty(Material Material)
        {

        }

        public void removeMaterial(Material Material)
        {

        }

        public void eventMaterial(Material Material, int Ammount)
        {

        }

        public override string ToString()
        {
            return name + " | " + "Location: " + location + " | " + "Start Date: " + eventstartdate.ToString("dd/MM/yyyy") + " | " + "End Date: " + eventenddate.ToString("dd/MM/yyyy");
        }

    }
}
