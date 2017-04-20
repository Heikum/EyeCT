using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class CampingSpot
    {
        private readonly int id;
        private bool availability;
        private int room;
        private string category;
        private int price;

        public int Id => id;

        public bool Availability { get { return availability; } set { availability = value; } }
        public int Room { get { return room; } set { room = value; } }
        public string Category { get { return category; } set { category = value; } }
        public int Price { get { return price; } set { price = value; } }

        public CampingSpot(int id, bool availability, int room, string category, int price)
        {
            this.id = id;
            this.availability = availability;
            this.room = room;
            this.category = category;
            this.price = price;
        }
        public CampingSpot(bool availability, int room, string category, int price)
            :this(0,availability,room,category,price)
        {

        }
        public override string ToString()
        {
            return id + " || " + room + " || " + category + " || " + price;
        }
    }
}