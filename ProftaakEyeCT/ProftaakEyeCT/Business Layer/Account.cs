using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public abstract class Account
    {


        private string username;
        private string password;
        private string emailadress;
        private bool rights;

        public Account(string Username, string Password, string Emailadress, bool Rights, Person person)
        {

        }

        //Post post
        public void placePost()
        {

        }

        public abstract void showEvents();


        public void showReservation()
        {

        }
    }

}
