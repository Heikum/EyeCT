using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProftaakEyectEvents
{
    public class Material
    {
        //fields uit db
        private int id;
        private string name;
        private decimal price;
        private int stock;


        //fields niet uit db
        private bool reserved;
        private bool available;

        public Material(int id, string name, decimal price, int stock)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }

        
        public bool Reserved { get; set; }
        public bool Available { get; set; }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public bool reserve(Account account, string name, int ammountreserve)
        {
            //haal voor item met de naam die wordt meegegeven de hoeveelheid available op
            //set stock

            Stock = Stock - ammountreserve;

            if (Stock < 0)
            {
                //Messagebox moet nog een exception worden
                MessageBox.Show("Could not reserve " + name + ", there are " + Stock + " items avalable while you try to reserve " + ammountreserve);
                reserved = false;
            }
            else if (Stock == 0)
            {
                //set de bool avalable in de database naar false (alle items zijn dan gereserveerd)
                //set de amountavalable in de database naar de nieuwe hoeveelheid beschikbaar
                reserved = true;
            }
            else if (Stock > 0)
            {
                //set de amountavalable in de database naar de nieuwe hoeveelheid beschikbaar
                reserved = true;
            }
            return reserved;
        }

        public bool availabilty(string naam)
        {
            //haal voor item met de naam die wordt meegegeven de hoeveelheid available op
            //set stock

            if (Stock <= 0)
            {
                available = false;
            }
            else if (Stock > 0)
            {
                available = true;
            }
            return available;
        }

        public override string ToString()
        {
            return name + " " + price + " " + stock; 
        }
    }
}

