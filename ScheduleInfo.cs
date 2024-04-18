using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port_Management_System
{
    public partial class ScheduleInfo : UserControl
    {
        private string adminID, schduleID;
        public ScheduleInfo()
        {
            InitializeComponent();
        }

        public ScheduleInfo(string adminID, string scheduleID) : this() 
        {
            this.adminID = adminID;
            this.schduleID = scheduleID;
            DataStore();
        }


        private void DataStore()
        {
            try
            {
                Database database = new Database();
                using (SqlConnection connection = new SqlConnection(database.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Schedule WHERE ID = @id";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id", schduleID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                vessel_tb.Text = reader["Vessel Name"].ToString();
                                imo_tb.Text = reader["IMO NUMBER"].ToString();
                                cargo_capacity_tb.Text = reader["CARGO CAPACITY"].ToString();
                                boarding_tb.Text = reader["BOARDING TIME"].ToString();
                                departure_tb.Text = reader["DEPARTURE TIME"].ToString();
                                fee_tb.Text = reader["FEE"].ToString();
                            }
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
