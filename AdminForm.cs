
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
    public partial class AdminForm : Form
    {
        private string adminID;
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(string adminID) : this()
        {
            this.adminID = adminID;
            DataStore();
        }


        static AdminForm obj;
        public static AdminForm Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new AdminForm();
                }
                return obj;
            }
        }

        public Panel panelContainer
        {
            get { return admin_panel; }
            set { admin_panel = value; }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            obj = this;
        }

        private void hidePanel()
        {
            if (add_sub_panel.Visible)
                add_sub_panel.Visible = false;

            if (delete_sub_panel.Visible)
                delete_sub_panel.Visible = false;
        }

        private void showSubPanel(Panel subManu)
        {
            if (subManu.Visible)
            {
                subManu.Visible = false;
                return;
            }

            hidePanel();
            subManu.Visible = true;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            showSubPanel(add_sub_panel);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            showSubPanel(delete_sub_panel);
        }

        private void new_admin_btn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            New_Admin new_Admin = new New_Admin(this.adminID);
            new_Admin.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(new_Admin);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void profile_pictureBox_Click(object sender, EventArgs e)
        {


            if (!AdminForm.Instance.panelContainer.Controls.ContainsKey("Login"))
            {
                AdminForm.Instance.panelContainer.Controls.Clear();
                AdminProfile profile = new AdminProfile(this.adminID);
                profile.Dock = DockStyle.Fill;
                AdminForm.Instance.panelContainer.Controls.Add(profile);
            }
        }


        private void DataStore()
        {
            try
            {
                Database database = new Database();
                Equipment equipment = new Equipment();
                using (SqlConnection connection = new SqlConnection(database.connectionString))
                {
                    string query = @"SELECT * 
                                    FROM [Admin Information]
                                    WHERE ID = @id";

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id", adminID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                profile_pictureBox.Image = equipment.ByteArrayToImage((byte[])reader["Picture"]);

                            }


                        }
                    }

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void add_vessel_btn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            VesselAdd vesselAdd = new VesselAdd(this.adminID);
            vesselAdd.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(vesselAdd);
        }

        private void schedule_btn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Schedule schedule = new Schedule(this.adminID);
            schedule.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(schedule);
        }

        private void delete_admin_button_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Admin_info admin = new Admin_info(this.adminID);
            admin.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(admin);
        }

        private void captain_add_btn_Click(object sender, EventArgs e)
        {

        }
    }
}

