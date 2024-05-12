using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port_Management_System
{
    internal class Database
    {
        public string connectionString = "Data Source=DESKTOP-82FJLT4\\SQLEXPRESS;Initial Catalog=\"Port Management System\";Integrated Security=True";

        public string LastID(string type)
        {
            string lastID = string.Empty;
            Database database = new Database();
            try
            {
                using (SqlConnection connection = new SqlConnection(database.connectionString))
                {
                    string query = $@"SELECT 
                                    TOP 1 [ID] 
                                FROM 
                                    [{type} Information] 
                                ORDER BY 
                                    [Added_DateTime] DESC";

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            lastID = reader["ID"].ToString();
                        }
                    }
                }
                // CustomMessageBox.Show(lastID);
                return lastID;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Class name is Database, function name is GetLastID, exception: {ex.Message}");
                // Returning an empty string or any other appropriate value instead of null
                return null;
            }
        }
    }


   
}
