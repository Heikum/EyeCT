using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProftaakEyectEvents.DAL;
using ProftaakEyectEvents.Prensentation_Layer;
using ProftaakEyectEvents;
using ProftaakEyeCT.Presentation_Layer;
using ProftaakEyeCT.DAL;

namespace ProftaakEyeCT
{
    public partial class Menuform : Form
    {
        Loginform mainloginform = (Loginform)Application.OpenForms["Loginform"];
        public int ReservationID;
        public int EventID;
        private PersonRepository personrepo;
        private Person updatePerson;
        private AccountRepository accountrepo;
        private Account updateAccount;
        private MediaRepository mediarepo;
        private Media updateMedia;
        private MaterialRepository materialrepo;
        private Material updateMaterial;
        private CampingSpot updateCampingspot;
        private CampingspotRepository campingspotrepo;
        private EventRepository eventrepo;
        private Event updateEvent;
        private AccessRepository accessrepo;
        private Access updateAccess;
        private ReservationRepository reservationrepo;
        private Reservation updateReservation;
        
        public Menuform()
        {
            
            InitializeComponent();
            personrepo = new PersonRepository(new PersonSQLContext());
            //mediarepo = new MediaRepository(new MediaSQLContext());
            accountrepo = new AccountRepository(new AccountSQLContext());
            materialrepo = new MaterialRepository(new MaterialSQLContext());
            campingspotrepo = new CampingspotRepository(new CampingspotSQLContext());
            eventrepo = new EventRepository(new EventSQLContext());
            accessrepo = new AccessRepository(new AccessSQLContext());
            reservationrepo = new ReservationRepository(new ReservationSQLContext());
            UpdateControls();
            bool rights = AccountRights();
            if (rights == false)
            {
                tcCamping.TabPages.Remove(tpAccess);
                tcCamping.TabPages.Remove(tpAccountDetails);
                tcCamping.TabPages.Remove(tpEvent);
                tcCamping.TabPages.Remove(tpMaterials);
                btnReportPage.Visible = false;
            }
        }

        //code voor person
        private void UpdateControls()
        {
            
            lbAllAccounts.Items.Clear();
            foreach (Account account in accountrepo.GetAllAccounts())
            {
                lbAllAccounts.Items.Add(account);
            }

            // It is only possible to edit and delete students when one is selected
            bool userSelected = lbAllAccounts.SelectedItem != null;

            lbAllMaterials.Items.Clear();
            foreach (Material material in materialrepo.GetAll())
            {
                lbAllMaterials.Items.Add(material);
            }
            lbReservationCampingspot.Items.Clear();
            
            lbReservationEvents.Items.Clear();
            foreach (Event events in eventrepo.GetAllEvents())
            {
                lbReservationEvents.Items.Add(events);
            }
            lbOnSite.Items.Clear();
            foreach (Account account in accessrepo.GetAllInside())
            {
                lbOnSite.Items.Add(account);
            }
            lbAccesAllUsers.Items.Clear();
            foreach (Account account in accountrepo.GetAllAccounts())
            {
                lbAccesAllUsers.Items.Add(account);
            }
            lbOutside.Items.Clear();
            foreach (Account account in accessrepo.GetAllOutside())
            {
                lbOutside.Items.Add(account);
            }
            cbEvents.Items.Clear();
            foreach (var item in eventrepo.GetAllEvents())
            {
                cbEvents.Items.Add(item.name);
            }
            lbAllEvents.Items.Clear();
            foreach (var item in eventrepo.GetAllEvents())
            {
                lbAllEvents.Items.Add(item);
            }
            lbReservations.Items.Clear();
            foreach (Reservation reservatie in reservationrepo.GetByAccountID(mainloginform.accountid))
            {
                lbReservations.Items.Add(reservatie);
            }

        }

        private bool AccountRights()
        {
            Account acc = accountrepo.GetAccountRights(mainloginform.tbUsername.Text);
            if (acc.Rights == true)
            {
                return true; 
            }
            return false; 
        }



        private void UpdatePerson()
        {

            updatePerson.Name = txtPersonName.Text;
            updatePerson.Zipcode = txtPersonZipcode.Text;
            updatePerson.City = txtPersonCity.Text;
            updatePerson.Street = txtPersonStreet.Text;
            updatePerson.Number = (int)nudPersonHousenumber.Value;
            updatePerson.Phonenumber = txtPersonPhonenumber.Text;

            if (personrepo.Update(updatePerson))
            {
                UpdateControls();
                txtPersonName.Text = "";
                txtPersonZipcode.Text = "";
                txtPersonCity.Text = "";
                txtPersonStreet.Text = "";
                nudPersonHousenumber.Value = 0;
                txtPersonPhonenumber.Text = "";
                updatePerson = null;
            }
            else
            {
                MessageBox.Show("Updating person failed. Check if the email address is valid.");
            }
        }
        private void UpdateAccount()
        {

            updateAccount.Username = txtAccountUsername.Text;
            updateAccount.Password = txtAccountPassword.Text;
            updateAccount.Emailadress = txtAccountEmail.Text;

            if (accountrepo.UpdateAccount(updateAccount))
            {
                txtAccountUsername.Text = "";
                txtAccountPassword.Text = "";
                txtAccountEmail.Text = "";
                updateAccount = null;
            }
            else
            {
                MessageBox.Show("Updating account failed. Check if the email address is valid.");
            }
        }
        private void Menuform_Load(object sender, EventArgs e)
        {
            string LoggedInUser = mainloginform.LoggedInUser;
            txtReservationAccountName.Text = LoggedInUser;
            updateAccount = accountrepo.GetAccountByUsername(LoggedInUser);
            txtCurrenctUsername.Text = updateAccount.Username;
            txtCurrentPassword.Text = updateAccount.Password;
            txtCurrentEmail.Text = updateAccount.Emailadress;
            updatePerson = personrepo.GetById(updateAccount.Personid);
            txtCurrentName.Text = updatePerson.Name;
            txtCurrentZipcode.Text = updatePerson.Zipcode;
            txtCurrentCity.Text = updatePerson.City;
            txtCurrentStreet.Text = updatePerson.Street;
            txtCurrentPhonenumber.Text = updatePerson.Phonenumber;
            nudCurrentHousenumber.Value = updatePerson.Number;
            //lbReservations.DataSource = reservationrepo.GetByAccountID(updateAccount.Id);
            //GetEvents();
            
        }

        private void GetEvents()
        {
            lbReservations.DataSource = reservationrepo.GetByAccountID(updateAccount.Id);
            
            
        }



        private void lbAllPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPersonEdit.Enabled = lbAllAccounts.SelectedItem != null;
            btnPersonRemove.Enabled = lbAllAccounts.SelectedItem != null;
            btnPersonUpdate.Enabled = lbAllAccounts.SelectedItem != null;

        }




        private void btnAccountConfirm_Click(object sender, EventArgs e)
        {

            UpdateControls();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            InsertMaterial();
        }

        private void InsertMaterial()
        {
            materialrepo.Insert(new Material(txtMaterialName.Text, Convert.ToDecimal(updownpriceitem.Value), Convert.ToInt32(nudMaterialStock.Value)));
            UpdateControls();

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registerform register = new Registerform();
            register.Show();
        }

        private void btnMedia_Click_1(object sender, EventArgs e)
        {
            MediaPlatform mediaPlatform = new MediaPlatform();

            mediaPlatform.Show();
        }

        private void tpReserve_Click(object sender, EventArgs e)
        {

        }

        private void lbReservationCampingspot_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCampingspot = (CampingSpot)lbReservationCampingspot.SelectedItem;
            
            nudReservationCampingspot.Value = campingspotrepo.GetCampingspotById(updateCampingspot.Id);
        }

        private void lbReservationEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateEvent = (Event)lbReservationEvents.SelectedItem;
            txtReservationEvent.Text = updateEvent.name;
            lbReservationCampingspot.Items.Clear();
            foreach (CampingSpot campingspot in campingspotrepo.GetAllAvailable(updateEvent))
            {
                lbReservationCampingspot.Items.Add(campingspot);
            }

        }

        private void btnCheckStat_Click(object sender, EventArgs e)
        {
            updateEvent = eventrepo.GetByName((string)cbEvents.SelectedItem);
            

            if (accessrepo.GetStatus(tbAccUsername.Text) && accessrepo.CheckStatusForEvent(updateEvent.name,tbAccUsername.Text) && DatumCheck(eventrepo.getStart(Convert.ToString(cbEvents.SelectedItem)), eventrepo.getEnd(Convert.ToString(cbEvents.SelectedItem))))
            {
                btnCheck.BackColor = Color.Green;
            }
            else
            {
                btnCheck.BackColor = Color.Red;
                MessageBox.Show("De gebruiker heeft geen Access of het event is al afgelopen.");
            }
        }

        private bool DatumCheck(DateTime Begin, DateTime End)
        {
            if (Begin < DateTime.Now && End > DateTime.Now)
            {
                return true;
            }
            return false;
        }



        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            updateEvent = (Event)lbReservationEvents.SelectedItem;
            
            if (updateEvent != null && nudReservationCampingspot.Value != 0)
            {
                reservationrepo.InsertReservation(new Reservation(DateTime.Now, false, updateEvent.id, (int)nudReservationCampingspot.Value));
                campingspotrepo.UpdateCampingspot(updateEvent.id, (int)nudReservationCampingspot.Value, false);
                updateReservation = reservationrepo.GetById(updateEvent.id, (int)nudReservationCampingspot.Value);
                updateAccount = accountrepo.GetAccountByUsername(mainloginform.LoggedInUser);
                reservationrepo.InsertAccountReservation(updateAccount, updateReservation.Id);
                accessrepo.ReservationUpdate(reservationrepo.GetID(), Convert.ToInt32(accountrepo.GetAccountIDByUsername(txtReservationAccountName.Text)));
                UpdateControls();

                ReservationID = updateReservation.Id;
                EventID = updateReservation.Eventid;
                Reservation_group rg = new Reservation_group();
                rg.Show();
            }
        }

        private void btnPersonEdit_Click_1(object sender, EventArgs e)
        {
            updateAccount = (Account)lbAllAccounts.SelectedItem;
            updatePerson = personrepo.GetById(updateAccount.Personid);
            txtAccountUsername.Text = updateAccount.Username;
            txtAccountPassword.Text = updateAccount.Password;
            txtAccountEmail.Text = updateAccount.Emailadress;
            txtPersonName.Text = updatePerson.Name;
            txtPersonZipcode.Text = updatePerson.Zipcode;
            txtPersonCity.Text = updatePerson.City;
            txtPersonStreet.Text = updatePerson.Street;
            nudPersonHousenumber.Value = updatePerson.Number;
            txtPersonPhonenumber.Text = updatePerson.Phonenumber;
        }

        private void btnPersonUpdate_Click_1(object sender, EventArgs e)
        {
            updatePerson = personrepo.GetById(updateAccount.Personid);
            updateAccount = (Account)lbAllAccounts.SelectedItem;
            UpdatePerson();
            UpdateAccount();
            UpdateControls();
        }

        private void btnPersonRemove_Click_1(object sender, EventArgs e)
        {
            accountrepo.DeleteAccount(((Account)lbAllAccounts.SelectedItem).Id);
            UpdateControls();
        }



        private void pbCampingFoto_MouseClick(object sender, MouseEventArgs e)
        {
            CampingMapForm formie = new CampingMapForm();
            formie.Show(); 
        }

        private void EventPlatormShow_Click(object sender, EventArgs e)
        {
            EventPlatform eventplatform = new EventPlatform();
            eventplatform.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void btnSelGoOutside_Click(object sender, EventArgs e)
        {
            try
            {
                Account A = (Account)lbOnSite.SelectedItem;
                accessrepo.UpdateInside(A, false);
                UpdateControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets misgegaan" + ex.Message);
            }
        }

        private void btnSelGoOnSite_Click(object sender, EventArgs e)
        {
            try
            {
                Account A = (Account)lbOutside.SelectedItem;
                accessrepo.UpdateInside(A, true);
                UpdateControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets misgegaan" + ex.Message);
            }
        }

        private void btnReportPage_Click(object sender, EventArgs e)
        {
            Reportform reportform = new Reportform();
            reportform.Show();
        }

        private void lbReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateReservation = (Reservation)lbReservations.SelectedItem;
            updateEvent = eventrepo.GetById(updateReservation.Eventid);
            txtCurrentPlaceReservation.Text = updateEvent.location;
            nudCampingspot.Value = updateReservation.Campingspotid;
            dtpCurrentDateReservation.Value = updateReservation.Reservationdate;
            txtEventNaam.Text = updateEvent.name;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            updateReservation = (Reservation)lbReservations.SelectedItem;
            campingspotrepo.UpdateCampingspot(updateReservation.Eventid, updateReservation.Campingspotid, true);
            reservationrepo.DeleteReservation(updateReservation);
            lbReservations.Items.Clear();
            GetEvents();
            MessageBox.Show("Reservation Deleted!");
            UpdateControls();
        }

        private void lbOnSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Account A = (Account)lbOnSite.SelectedItem;
                string EventByUser = accessrepo.EventReservationAccess(Convert.ToInt32(accountrepo.GetAccountIDByUsername(A.Username)));
                string TelnrUser = accountrepo.GetTelNr(A.Username);
                lblEventUser.Text = EventByUser;
                lblTelNr.Text = TelnrUser;
            }
            catch (Exception)
            {
                MessageBox.Show("Er ging iets mis");
            }
            
        }

        private void btreturnitems_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation local = lbReservations.SelectedItem as Reservation;
                //label22.Text = local.id.ToString();
                bool msg = materialrepo.DeleteMaterialReservation(local.Id);
                if (msg == true)
                {
                    MessageBox.Show("Items returned.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Failed to return items." + exception);
            }
        }


        private void btnAddMaterial_Click_1(object sender, EventArgs e)
        {
            Material item = new Material(1, txtMaterialName.Text, updownpriceitem.Value, Convert.ToInt32(nudMaterialStock.Value));
            materialrepo.Insert(item);
            MessageBox.Show("Material Added!"); 
        }

        private void lbAllEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateEvent = (Event)lbAllEvents.SelectedItem;
            txtEventName.Text = updateEvent.name;
        }

        private void lbAllMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMaterial = (Material)lbAllMaterials.SelectedItem;
            txtMaterialName.Text = updateMaterial.Name;
            updownpriceitem.Value = updateMaterial.Price;
            nudMaterialStock.Value = updateMaterial.Stock;
            

        }

        private void btnAddToEvent_Click(object sender, EventArgs e)
        {
            updateEvent = (Event)lbAllEvents.SelectedItem;
            updateMaterial = (Material)lbAllMaterials.SelectedItem;
            int ammount = (int)nudMaterialStock.Value;
            if (updateEvent != null && updateMaterial != null && ammount != null)
            {
                materialrepo.InsertMaterialEvent(updateEvent, updateMaterial, ammount);
            }
            else
            {
                MessageBox.Show("Please fill all fields in");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            Application.Restart();
            
        }

        private void btnUpdatePersonDetails_Click(object sender, EventArgs e)
        {
            updatePerson = personrepo.GetById(updateAccount.Personid);
            updateAccount = accountrepo.GetAccountByUsername(mainloginform.LoggedInUser);
            UpdatePerson();
            UpdateAccount();
            UpdateControls();
        }
    }
}
