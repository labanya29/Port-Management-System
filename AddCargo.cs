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
    public partial class AddCargo : UserControl
    {
        public AddCargo()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            return !string.IsNullOrWhiteSpace(CargoNoTb.Text) && !string.IsNullOrWhiteSpace(TypeOfCargoTb.Text) && !string.IsNullOrWhiteSpace(CargoQuantityTb.Text) && !string.IsNullOrWhiteSpace(DestinationTb.Text);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            bool flag = Check();
            if (!flag)
            {
                MessageBox.Show("Fill the all required fields");
                return;
            }
            Database database = new Database();
            using (SqlConnection connection = new SqlConnection(database.connectionString))
            {
                connection.Open();

                string registrationQuery = $@"INSERT INTO [Cargo Information] (ID,[Cargo No],[Type of Cargo],Quantity,Destination) 
                                               VALUES (@ID,@Cargo_No,@Type_of_Cargo,@Quantity,@Destination )";
                Equipment equipment = new Equipment();

                using (SqlCommand command = new SqlCommand(registrationQuery, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ID", equipment.IdGenarator("Cargo"));
                    command.Parameters.AddWithValue("@Cargo_No", CargoNoTb.Text);
                    command.Parameters.AddWithValue("@Type_of_Cargo", TypeOfCargoTb.Text);
                    command.Parameters.AddWithValue("@Quantity", CargoQuantityTb.Text);
                    command.Parameters.AddWithValue("@Destination",DestinationTb.Text);
                  
                    //  command.Parameters.AddWithValue("@AddedBy", adminID);


                    command.ExecuteNonQuery();

                }

                connection.Close();
                this.Hide();
                Cargo_Inspector.Instance.panelContainer.Controls.Clear();
                AddCargo addCargo = new AddCargo();
                addCargo.Dock = DockStyle.Fill;
                Cargo_Inspector.Instance.panelContainer.Controls.Add(addCargo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cargo_Inspector cargo_Inspector = new Cargo_Inspector();
            this.Hide();
            cargo_Inspector.Show();
        }
    }
}
