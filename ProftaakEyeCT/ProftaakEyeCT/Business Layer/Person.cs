using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Person
    {
        private int id;
        private string name;
        private string phonenumber;
        private string street;
        private int number;
        private string zipcode;
        private string city;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Phonenumber { get { return phonenumber; } set { phonenumber = value; } }
        public string Street { get { return street; } set { street = value; } }
        public int Number { get { return number; } set { number = value; } }
        public string Zipcode { get {return zipcode; } set {zipcode = value; } }
        public string City { get { return city; } set { city = value; } }

        public Person(int id, string name, string zipcode, string city, string street, int number, string phonenumber)
        {
            this.id = id;
            this.name = name;
            this.zipcode = zipcode;
            this.city = city;
            this.street = street;
            this.number = number;
            this.phonenumber = phonenumber;

        }

        public Person(string name, string zipcode, string city, string street, int number, string phonenumber)
            : this(-1, name, zipcode, city, street, number, phonenumber)
        {

        }

        public override string ToString()
        {
            return name + " " + zipcode +  " " + city +  " " + street + " " + number + " " + Phonenumber;
        }
    }
}

