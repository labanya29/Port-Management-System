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
    public partial class VesselAdd : UserControl
    {

        private string adminID;
        public VesselAdd()
        {
            InitializeComponent();
        }

        public VesselAdd(string adminID) : this()
        {
            this.adminID = adminID;
        }
        private bool Register()
        {
            try
            {
                Database database = new Database();
                using (SqlConnection connection = new SqlConnection(database.connectionString))
                {
                    connection.Open();

                    string registrationQuery = @"INSERT INTO [Schedule] ([Vessel Name], [IMO NUMBER], [CARGO CAPACITY], [BOARDING TIME], [DEPARTURE TIME], FEE) 
                                               VALUES (@Vessel_Name,@IMO_number,@Cargo_Capacity,@Boarding_time,@Departure_time, @Fee)";





                    using (SqlCommand command = new SqlCommand(registrationQuery, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Vessel_Name", vessel_tb.Text);
                        command.Parameters.AddWithValue("@IMO_number", imo_tb.Text);
                        command.Parameters.AddWithValue("@Cargo_Capacity", cargo_capacity_tb.Text);
                        command.Parameters.AddWithValue("@Boarding_time", boarding_tb.Text);
                        command.Parameters.AddWithValue("@Departure_time", departure_tb.Text);
                        command.Parameters.AddWithValue("@Fee", fee_tb.Text);


                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Ërror");
                return false;
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            bool flag = Check();
            if (!flag)
            {
                MessageBox.Show("Fill the all required fields");
                return;
            }
            bool flag2 = Register();

            if(flag2)
            {
                MessageBox.Show("Register");
                
               if(AdminForm.Instance.panelContainer.Controls.ContainsKey("VesselAdd"))
                {
                    AdminForm.Instance.panelContainer.Controls.Clear();
                    VesselAdd vesselAdd = new VesselAdd(this.adminID);
                    vesselAdd.Dock = DockStyle.Fill;
                    AdminForm.Instance.panelContainer.Controls.Add(vesselAdd);
                    
                }
            }
        }

        private bool Check()
        {
            return !string.IsNullOrWhiteSpace(vessel_tb.Text) && !string.IsNullOrWhiteSpace(imo_tb.Text) && !string.IsNullOrWhiteSpace(cargo_capacity_tb.Text) && !string.IsNullOrWhiteSpace(boarding_tb.Text) && !string.IsNullOrWhiteSpace(departure_tb.Text)&& !string.IsNullOrWhiteSpace(fee_tb.Text);
        }
    }
    
}
