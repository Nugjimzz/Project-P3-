// File: ParfumController.cs
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TokoParfum.Model;

namespace TokoParfum.Controller
{
    public class ParfumController
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public List<ParfumModel> GetAllParfum()
        {
            List<ParfumModel> parfums = new List<ParfumModel>();
            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM parfum";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    parfums.Add(new ParfumModel
                    {
                        Id = reader.GetInt32("id"),
                        Nama = reader.GetString("nama"),
                        Harga = reader.GetDecimal("harga"),
                        Stok = reader.GetInt32("stok")
                    });
                }
            }
            return parfums;
        }

        public void AddParfum(ParfumModel parfum)
        {
            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO parfum (nama, harga, stok) VALUES (@nama, @harga, @stok)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", parfum.Nama);
                cmd.Parameters.AddWithValue("@harga", parfum.Harga);
                cmd.Parameters.AddWithValue("@stok", parfum.Stok);
                cmd.ExecuteNonQuery();
            }
        }

        // Implement Update dan Delete sesuai kebutuhan
    }
}