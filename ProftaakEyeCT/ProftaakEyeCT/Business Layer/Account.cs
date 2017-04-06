using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public abstract class Account
    {


        public int id;
        public string username;
        public string password;
        public string emailadress;
        public int rights;

        public Account(int Id, string Username, string Password, string Emailadress, int Rights)
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
