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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private int Admin(string id, string password)
        {
            try
            {
                Database database = new Database();
                using (SqlConnection connection = new SqlConnection(database.connectionString))
                {
                    string query = @"SELECT 
                                    1 
                                FROM 
                                    [Admin Information] 
                                WHERE 
                                    [ID] = @id 
                                    AND
                                    [Password] = @password";



                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@password", password);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                return 1;
                            else { return 0; }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error");
                return -1;
            }
        } 
       


        private void login_button_Click(object sender, EventArgs e)
        {
            string id = id_tbx.Text;

            if(string.IsNullOrWhiteSpace(id)) 
            {
                MessageBox.Show("Dill the id", "Ërror");
                return; 
            }
            
            if (id.Substring(0, 2) == "AD")
            {
                int flag = Admin(id, password_tb.Text);
                if (flag == 0) 
                {
                    MessageBox.Show("Invalid ID or Password");
                    return;
                }
                AdminForm adminForm = new AdminForm(id);
                this.Hide();
                adminForm.Show();


            }
           else if (id.Substring(0, 2) == "DC")
            {
                int flag = Admin(id, password_tb.Text);
                if (flag == 0)
                {
                    MessageBox.Show("Invalid ID or Password");
                    return;
                }
                Deck_officer deck_Officer = new Deck_officer(id);
                this.Hide();
                deck_Officer.Show();


            }

        }
       

    }
 }

