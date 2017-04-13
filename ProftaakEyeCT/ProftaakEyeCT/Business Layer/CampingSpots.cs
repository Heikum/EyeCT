using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class CampingSpot
    {
        private int room { get; set; }
        private string location { get; set; }
        private bool avalibillity { get; set; }
        private int price { get; set; }

        public CampingSpot(int room, string location, bool avalibillity)
        {
            this.room = room;
            this.location = location;
            this.avalibillity = avalibillity;
        }
        public bool Avalibillity(int ID)
        {
            //get avalibillity from database for the given ID
            //set avalibillity
            return avalibillity;
        }
        public int getRoom(int ID)
        {
            //get room from database for the given ID
            //set room
            return room;
        }
        public int getPrice(int ID)
        {
            //get price from database for the given ID
            //set price
            return room;
        }
    }
}