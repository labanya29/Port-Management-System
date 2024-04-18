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
    public partial class Schedule : UserControl
    {
        private string adminID;
        public Schedule()
        {
            InitializeComponent();
        }

        public Schedule(string adminID) : this()
        {
            this.adminID = adminID;
            DataShow();
        }

        private void DataShow()
        {
            try
            {
                Database database = new Database();
                using(SqlConnection connection = new SqlConnection(database.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT *
                                    FROM Schedule
                                    ORDER BY DateTime DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Schedule_list list = new Schedule_list(this.adminID, reader["ID"].ToString(), reader["Vessel Name"].ToString(),
                                    reader["IMO NUMBER"].ToString(), reader["DEPARTURE TIME"].ToString());
                                
                                panel.Controls.Add(list);
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
