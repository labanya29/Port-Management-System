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
            }
        }
    }
}
