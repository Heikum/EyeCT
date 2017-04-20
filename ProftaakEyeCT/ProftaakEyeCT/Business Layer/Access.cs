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
        /*public void addRFID(Account account, int rfid)
        {
            //voer in de access tabel een nieuwe rij in met: autoincrement ID, rfid (zelfde als account ID), Account (foreign key?), AccessStatus (automatisch false)

        }
        public void removeRFID(Account account)
        {
            //remove uit de accesstabel de rij met het rfid dat het zelfde is als het account ID
        }
        public bool gainAccess(Account account) //naar binnen
        {
            //haal uit de database voor dat account het RFID ID
            //haal uit de database de AccessStatus
            //set de accessstatus
            if (accessstatus == true) //en dit persoon dus al binnen is
            {
                status = false;
            }
            else
            {
                status = true;
            }
            //set de AccessStatus in de database naar true 
            return status;
        }
        public bool gainExit(Account account) //naar buiten
        {
            //haal uit de database voor dat account het RFID ID
            //haal uit de database de AccessStatus
            //set de accessstatus
            if (accessstatus == true) //en dit persoon dus al binnen is
            {
                status = true;
            }
            else
            {
                status = false; //(als dit persoon dus al buiten is)
            }
            //set de AccessStatus in de database naar false
            return status;
        }
        public bool checkAccess(Account account)
        {
            //haal uit de database voor dat account het RFID ID
            //haal uit de database de AccessStatus
            //set de accessstatus
            return accessstatus;
        }*/
    }
}
