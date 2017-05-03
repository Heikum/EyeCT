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
using ProftaakEyeCT.Presentation_Layer;
using ProftaakEyeCT.DAL;

namespace ProftaakEyeCT.Presentation_Layer
{
    public partial class Reservation_group : Form
    {
        Menuform Menuform = (Menuform)Application.OpenForms["Menuform"];
        private AccountRepository accountrepo;
        private Account updateAccount;
        private ReservationRepository reservationrepo;
        private Reservation updateReservation;
        private MaterialRepository materialrepo;
        private Material insertmaterial;

        public Reservation_group()
        {
            InitializeComponent();
            accountrepo = new AccountRepository(new AccountSQLContext());
            reservationrepo = new ReservationRepository(new ReservationSQLContext());
            materialrepo = new MaterialRepository(new MaterialSQLContext());
            UpdateControls();
            
        }
        public void UpdateControls()
        {
            lbReservationPerson.Items.Clear();
            foreach (Account account in accountrepo.GetAllAccounts())
            {
                lbReservationPerson.Items.Add(account);
            }

            lbReservationMaterial.Items.Clear();
            foreach (Material material in materialrepo.GetMaterialByEvent(Menuform.EventID))
            {
                lbReservationMaterial.Items.Add(material);
            }
        }
        private void lbReservationPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAccount = (Account)lbReservationPerson.SelectedItem;
            
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            int resid = Menuform.ReservationID;
            updateAccount = (Account)lbReservationPerson.SelectedItem;
            reservationrepo.InsertAccountReservation(updateAccount, resid);
            foreach (Account account in lbReservationPerson.Items)
            {
                if(account == updateAccount)
                {
                    lbReservationPerson.Items.Remove(account);
                    break;
                    
                }
                
            }
        
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Menuform menuform = new Menuform();
            menuform.Show();
            this.Hide();

        }

        private void lbReservationMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            insertmaterial = lbReservationMaterial.SelectedItem as Material;
        }

        private void addmaterial_Click(object sender, EventArgs e)
        {
            insertmaterial = lbReservationMaterial.SelectedItem as Material;
            int resid = Menuform.ReservationID;
            residlabel.Text = resid.ToString();

            int materialid = insertmaterial.Id;
            materiallabel.Text = materialid.ToString();

            bool msgbox = reservationrepo.InsertMaterialReservation(resid, materialid);
            if (msgbox == true)
            {
                MessageBox.Show("Material Reserved.");
            }

        }
    }
}
