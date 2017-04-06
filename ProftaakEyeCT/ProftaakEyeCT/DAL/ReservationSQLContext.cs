using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProftaakEyectEvents.DAL
{
    class ReservationSQLContext
    {
        public ReservationSQLContext()
        {
            Database.Initialize();
        }

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


        public Reservation GetByID(int Id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Reservation Where Id = id LIMIT 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Id", Id);
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

        public void InsertReservation(Reservation reservation)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Reservation (Id, Price, Personamount, Date, Location, Paymentstatus, Mainreservator, Otherreservator)" +
                    " VALUES (@id, @price, @personamount, @date, @location, @paymentstatus, @mainreservator, @otherreservator)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", reservation.id);
                    command.Parameters.AddWithValue("@price", reservation.price);
                    command.Parameters.AddWithValue("@personamount", reservation.personAmount);
                    command.Parameters.AddWithValue("@date", reservation.date);
                    command.Parameters.AddWithValue("@location", reservation.location);
                    command.Parameters.AddWithValue("@paymentstatus", reservation.paymentstatus);
                    command.Parameters.AddWithValue("@mainreservator", reservation.mainreservator);
                    command.Parameters.AddWithValue("@otherreservator", reservation.otherreservator);

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
            string query = "UPDATE Reservation SET Price = @price, Personamount = @personamount, Date = @date, Location = @location, Paymentstatus = @paymentstatus, Mainreservator = @mainreservator, Otherreservator = @otherreservator WHERE Id = @id";
            using (SqlConnection connection = Database.Connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", reservation.id);
                command.Parameters.AddWithValue("price", reservation.price);
                command.Parameters.AddWithValue("personamount", reservation.personAmount);
                command.Parameters.AddWithValue("date", reservation.date);
                command.Parameters.AddWithValue("location", reservation.location);
                command.Parameters.AddWithValue("paymentstatus", reservation.paymentstatus);
                command.Parameters.AddWithValue("mainreservator", reservation.mainreservator);
                command.Parameters.AddWithValue("otherreservator", reservation.otherreservator);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteReservation(Reservation reservation)
        {
            string query = "DELETE FROM Reservation WHERE Id = @id";
            using (SqlConnection connection = Database.Connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", reservation.id);
                command.ExecuteNonQuery();
            }
        }

        private Reservation CreateReservationFromReader(SqlDataReader reader)
        {
            return new Reservation(
                Convert.ToInt32(reader["Id"]),
                Convert.ToInt32(reader["Price"]),
                Convert.ToInt32(reader["Personamount"]),
                Convert.ToDateTime(reader["Date"]),
                Convert.ToString(reader["Location"]),
                Convert.ToString(reader["Paymentstatus"]),
                Convert.ToString(reader["Mainreservator"]),
                Convert.ToInt32(reader["Otherreservator"]));
        }
    }
}
