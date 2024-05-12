using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Port_Management_System
{
    public partial class AdminProfile : UserControl
    {
        private string adminID;
        public AdminProfile()
        {
            InitializeComponent();
        }

        public AdminProfile(string adminID) : this()
        {
            this.adminID = adminID;
            DataStore();
        }

        private void DataStore()
        {
            try
            {
                Database database = new Database();
                Equipment equipment = new Equipment();
                using(SqlConnection connection = new SqlConnection(database.connectionString))
                {
                    string query = @"SELECT * 
                                    FROM [Admin Information]
                                    WHERE ID = @id";

                    connection.Open();

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id", adminID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                id_tb.Text = reader["ID"].ToString();
                                name_tb.Text = reader["Name"].ToString();
                                
                                phone_number_tb.Text = reader["Phone Number"].ToString();
                                email_tb.Text = reader["Email"].ToString();
                               // address_tb.Text = reader["Address"].ToString();

                                

                            }
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (!AdminForm.Instance.panelContainer.Controls.ContainsKey("Login"))
            {
                AdminForm.Instance.panelContainer.Controls.Clear();
                
            }
        }
    }
}
