using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProftaakEyectEvents;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProftaakEyeCT.DAL
{
    public class MaterialSQLContext : IMaterialContext
    {
        public bool DeleteMaterial(int id)
        {
            throw new NotImplementedException();
        }

        public List<Material> GetAll()
        {
            List<Material> materials = new List<Material>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Material ORDER BY ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            materials.Add(CreateMaterialFromReader(reader));
                        }
                    }
                }
            }
            return materials;
        }

        public Material InsertMaterial(Material material)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Material (Name,Price,Stock)" +
                    "VALUES (@name,@price,@stock)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", material.Name);
                    command.Parameters.AddWithValue("@price", material.Price);
                    command.Parameters.AddWithValue("@stock", material.Stock);
                    

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Error:" + e.Message);
                        return null;
                    }
                }
                return material;
            }
        }

        public bool UpdateMaterial(Material material)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE Material" +
                    " SET Name=@name, Price=@price, Stock=@stock" +
                    " WHERE ID=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", material.Id);
                    command.Parameters.AddWithValue("name", material.Name);
                    command.Parameters.AddWithValue("price", material.Price);
                    command.Parameters.AddWithValue("stock", material.Stock);
                    try
                    {
                        if (Convert.ToInt32(command.ExecuteNonQuery()) > 0)
                        {
                            return true;
                        }
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message);
                    }

                }
            }

            return false;
        }

        private Material CreateMaterialFromReader(SqlDataReader reader)
        {
            return new Material(
                Convert.ToInt32(reader["Id"]),
                Convert.ToString(reader["Name"]),
                Convert.ToDecimal(reader["Price"]),
                Convert.ToInt32(reader["Stock"]));
        }
    }
}
