using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Student : Account
    {
        public Student(string Username, String Password, string Emailadress, bool Rights, Person person) : base(Username, Password, Emailadress, Rights, person)
        {

        }

        public void makeReservation()
        {

        }

        public override void showEvents()
        {

        }

        public void hireMaterial()
        {

        }
    }

}
