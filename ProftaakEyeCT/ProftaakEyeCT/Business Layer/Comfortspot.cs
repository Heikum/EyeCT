using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Comfortspot: CampingSpots
    {
        private int price;
        public Comfortspot(int Room, string Location, bool Avalibillity) : base(Room, Location, Avalibillity)
        {

        }
    }
}
