using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Access
    {
        public int rfid { get; private set; }
        public bool accessstatus { get; private set; }

        public Access(int rfid, bool accessstatus)
        {
            this.rfid = rfid;
            this.accessstatus = accessstatus;
        }
        
    }
}
