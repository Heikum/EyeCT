﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Admin : Account
    {
        public Admin(int Id, string Username, string Password, string Emailadress, int Rights) : base(Id, Username, Password, Emailadress, Rights)
        {

        }

        public override void showEvents()
        {

        }

        public void removeEvent()
        {

        }

    }
    }
