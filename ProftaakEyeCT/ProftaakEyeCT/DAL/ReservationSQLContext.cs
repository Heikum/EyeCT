using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProftaakEyectEvents.DAL
{
    public class ReservationSQLContext: IReservationContext
    {
        private List<Reservation> reservations = new List<Reservation>();
        
        public List<Reservation> GetAll()
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Reservation ORDER BY Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(CreateReservationFromReader(reader));
                        }
                    }
                }
            }
            return reservations;
        }


        public Reservation GetByID(int eventid, int campingspotid)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Reservation Where EventID = @eventid AND CampingSpotsID = @campingspotsid";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("eventid", eventid);
                    command.Parameters.AddWithValue("campingspotsid", campingspotid);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CreateReservationFromReader(reader);
                        }
                    }
                }
            }
            return null;
        }
        public List<Reservation> GetByAccountID(int accountid)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT R.* FROM Reservation R LEFT JOIN AccountReservation on R.ID = AccountReservation.ReservationID Where AccountID = @accountid";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("accountid", accountid);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(CreateReservationFromReader(reader));
                        }
                    }
                }
            }
            return reservations;
        }

        public Reservation InsertReservation(Reservation reservation)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Reservation (ReservationDate, PaymentStatus, EventID, CampingSpotsID)" +
                    " VALUES (@reservationdate, @paymentstatus, @eventid, @campingspotsid)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@reservationdate", DateTime.Now);
                    command.Parameters.AddWithValue("@paymentstatus", reservation.Paymentstatus);
                    command.Parameters.AddWithValue("@eventid", reservation.Eventid);
                    command.Parameters.AddWithValue("@campingspotsid", reservation.Campingspotid);
                    


                    try
                    {
                        command.ExecuteNonQuery();
                      
                    }
                    catch (SqlException e)
                    {
                        // Unexpected error: rethrow to let the caller handle it
                        MessageBox.Show("Dit is al reeds ingevoerd" + e);
                        
                    }
                
                }

                return reservation;
            }
        }

        public bool InsertMaterialReservation(int reserveid, int materialid)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO MaterialReservation (ReservationID, MaterialID)" +
                    " VALUES (@reservationid, @materialid)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@reservationid", reserveid);
                    command.Parameters.AddWithValue("@materialid", materialid);
                    command.ExecuteNonQuery();
                }
                return true;
            }
        }
        

        public void InsertAccountReservation(Account account, int resid)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO AccountReservation VALUES (@reservationid, @accountid)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@reservationid", resid);
                    command.Parameters.AddWithValue("@accountid", account.Id);
                    



                    try
                    {
                        command.ExecuteNonQuery();
                        
                    }
                    catch (SqlException e)
                    {
                        // Unexpected error: rethrow to let the caller handle it
                        MessageBox.Show("Dit is al reeds ingevoerd" + e);
                    }

                }
               
            }
        }

        
        public void UpdateReservation(Reservation reservation)
        {
            string query = "UPDATE Reservation SET ReservationDate = @reservationdate, PaymentStatus = @paymentstatus, EventID = @eventid, CampingsSpotsID = @campingspotsid WHERE Id = @id";
            using (SqlConnection connection = Database.Connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", reservation.Id);
                command.Parameters.AddWithValue("reservationdate", reservation.Reservationdate);
                command.Parameters.AddWithValue("paymentstatus", reservation.Paymentstatus);
                command.Parameters.AddWithValue("eventid", reservation.Eventid);
                command.Parameters.AddWithValue("campingspotsid", reservation.Campingspotid);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteReservation(Reservation reservation)
        {
            string query = "DELETE FROM Reservation WHERE Id = @id";
            using (SqlConnection connection = Database.Connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", reservation.Id);
                command.ExecuteNonQuery();
            }
        }

        private Reservation CreateReservationFromReader(SqlDataReader reader)
        {
            return new Reservation(
                Convert.ToInt32(reader["ID"]),
                Convert.ToDateTime(reader["ReservationDate"]),
                Convert.ToBoolean(reader["PaymentStatus"]),
                Convert.ToInt32(reader["EventID"]),
                Convert.ToInt32(reader["CampingSpotsID"]));

        }
    }
}
