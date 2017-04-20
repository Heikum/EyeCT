using ProftaakEyectEvents;
using ProftaakEyectEvents.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProftaakEyeCT.Presentation_Layer
{
    public partial class Reservation_group : Form
    {
        Menuform Menuform = (Menuform)Application.OpenForms["Menuform"];
        private AccountRepository accountrepo;
        private Account updateAccount;
        private ReservationRepository reservationrepo;
        private Reservation updateReservation;
        public Reservation_group()
        {
            InitializeComponent();
            accountrepo = new AccountRepository(new AccountSQLContext());
            reservationrepo = new ReservationRepository(new ReservationSQLContext());
            UpdateControls();
            
        }
        public void UpdateControls()
        {
            lbReservationPerson.Items.Clear();
            foreach (Account account in accountrepo.GetAllAccounts())
            {
                lbReservationPerson.Items.Add(account);
            }
        }
        private void lbReservationPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAccount = (Account)lbReservationPerson.SelectedItem;
            txtReservationName.Text = updateAccount.Username;
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            int resid = Menuform.ReservationID;
            updateAccount = (Account)lbReservationPerson.SelectedItem;
            reservationrepo.InsertAccountReservation(updateAccount, resid);


        
        }
    }
}
