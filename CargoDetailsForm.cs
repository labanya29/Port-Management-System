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
    public partial class CargoDetailsForm : UserControl
    {
        private string cargoID;
        public CargoDetailsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public CargoDetailsForm(string cargoID) : this()
        {
           this.cargoID = cargoID;
            DataLoad();
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
                                    [Cargo Information] 
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
                dataGridView1.DataSource = dataTable;

                // Refresh the DataGridView to display the data
                dataGridView1.Refresh();

                // Clear any selection in the DataGridView
                dataGridView1.ClearSelection();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Class name is Admin-info function name is LoadData and exception: " + ex.Message);
            }
        }
    }
}
