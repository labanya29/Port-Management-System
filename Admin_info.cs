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
    public partial class Admin_info : UserControl
    {
        private string adminID;
        public Admin_info()
        {
            InitializeComponent();
        }

        public Admin_info(string adminID) : this()
        {
            this.adminID = adminID;
            DataLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataLoad()
        {
            try
            {
                DataTable dataTable;
                Database dataBase = new Database();

                using (SqlConnection connection = new SqlConnection(dataBase.connectionString))
                {
                    string query = @"SELECT 
                                       ID,
                                       Name,
                                       [Phone Number], 
                                       [Email], 
                                       Password
                                FROM 
                                    [Admin Information] 
                                ORDER BY
                                      Added_DateTime DESC";

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        // You don't need to create a new DataTable instance here
                        dataTable = dataSet.Tables[0];
                    }

                    connection.Close();
                }

                //  data_grid_view.AutoGenerateColumns = false;
                data_grid_view.DataSource = dataTable;

                // Refresh the DataGridView to display the data
                data_grid_view.Refresh();

                // Clear any selection in the DataGridView
                data_grid_view.ClearSelection();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Class name is Admin-info function name is LoadData and exception: " + ex.Message);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Database dataBase = new Database();
                string query = $"DELETE FROM [Admin Information] WHERE [ID] = '{id_tb.Text}'";
                DataOperation(query, dataBase.connectionString);
            }

            DataLoad();
        }



        private void DataOperation(string query, string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"{id_tb.Text} account successfully registered", "VOVO");
                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Class name is Quiz and function name is DataOperation and exception: " + ex.Message);
            }

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Database dataBase = new Database();
            string query = $@"SELECT 
                                    ID, 
                                    Name,
                                    [Phone Number], 
                                    [Email], 
                                    Password 
                             FROM 
                                [Admin Information] 
                            WHERE 
                                [ID] = '{id_tb.Text}'";
            DataOperation(query, dataBase.connectionString);
        }

        private void id_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }


}