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
        private string name;
        private decimal price;
        private int stock;
        private int ammount;
        private bool reserved;
        private bool available;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Ammount { get; set; }
        public bool Reserved { get; set; }
        public bool Available { get; set; }

        public Material(string name, decimal price, int stock, int ammount)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.ammount = ammount;
        }

        public bool reserve(Account account, string name, int ammountreserve)
        {
            //haal voor item met de naam die wordt meegegeven de hoeveelheid available op
            //set stock

            stock = stock - ammountreserve;

            if (stock < 0)
            {
                //Messagebox moet nog een exception worden
                MessageBox.Show("Could not reserve " + name + ", there are " + stock + " items avalable while you try to reserve " + ammountreserve);
                reserved = false;
            }
            else if (stock == 0)
            {
                //set de bool avalable in de database naar false (alle items zijn dan gereserveerd)
                //set de amountavalable in de database naar de nieuwe hoeveelheid beschikbaar
                reserved = true;
            }
            else if (stock > 0)
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

            if (stock <= 0)
            {
                available = false;
            }
            else if (stock > 0)
            {
                available = true;
            }
            return available;
        }
    }
}

