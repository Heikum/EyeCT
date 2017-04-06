using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Budgetspot: CampingSpots
    {
        private int price;
        public Budgetspot(int Room, string Location, bool Avalibillity): base(Room, Location, Avalibillity)
        {

        }
    }
}
