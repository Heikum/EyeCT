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
        public DateTime date;

        public Event(int id, string Description, string Name, string Location, DateTime Date)
        {
            this.id = id;
            this.description = Description;
            this.name = Name;
            this.location = Location;
            this.date = Date;

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


        //geen createEvent method, omdat Event al een constructor heeft waar een Event wordt aangemaakt.
    }
}
