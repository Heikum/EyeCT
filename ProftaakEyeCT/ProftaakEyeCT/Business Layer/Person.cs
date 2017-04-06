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
        private int phonenumber;
        private string street;
        private int number;
        private string zipcode;
        private string city;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Phonenumber { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }

        public Person(int id, string name, string zipcode, string city, string street, int number, int phonenumber)
        {
            this.id = id;
            this.name = name;
            this.zipcode = zipcode;
            this.city = city;
            this.street = street;
            this.number = number;
            this.phonenumber = phonenumber;
            
        }

        public Person(string name, string zipcode, string city, string street, int number, int phonenumber)
            :this(-1,name,zipcode,city,street,number,phonenumber)
        {

        }

        public override string ToString()
        {
            return name + zipcode + city + street + number + phonenumber;
        }
    }
}
