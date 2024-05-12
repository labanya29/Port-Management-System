﻿using System;
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
    public partial class Add : UserControl
    {
        private string id, type, _gender;
        public Add()
        {
            InitializeComponent();
        }

        public Add(string id = "", string type = "") : this()
        {
            this.id = id;
            this.type = type;
        }
        private void AddCrew_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void choose_pic_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;

                    // Perform the necessary actions with the selected file here
                    // For example, you can display the file path in a TextBox:
                    // Load the image from the selected file
                    Image originalImage = Image.FromFile(selectedFile);

                    // Resize the image to fit the PictureBox size
                    Image resizedImage = new Bitmap(originalImage, new Size(130, 130));

                    // Display the resized image in the PictureBox
                    picture_box.Image = resizedImage;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Picture Error");
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Gender();
            bool flag = Check();
            if (!flag)
            {
                MessageBox.Show("Fill the all required fields");
                return;
            }
            try
            {
                Database database = new Database();
                using (SqlConnection connection = new SqlConnection(database.connectionString))
                {
                    connection.Open();

                    string registrationQuery = $@"INSERT INTO [{type} Information] (ID, Name,Picture, Email, [Phone Number], Gender, [Password]) 
                                               VALUES (@ID, @Name,@Picture, @Email, @PhoneNumber, @Gender, @Password)";
                    Equipment equipment = new Equipment();

                    using (SqlCommand command = new SqlCommand(registrationQuery, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@ID", equipment.IdGenarator(type));
                        command.Parameters.AddWithValue("@Name", name_tb.Text);
                        command.Parameters.AddWithValue("@Picture", equipment.ImageToByteArray(picture_box.Image));
                        command.Parameters.AddWithValue("@Email", email_tb.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", phone_number_tb.Text);
                        command.Parameters.AddWithValue("@Gender", _gender);
                        command.Parameters.AddWithValue("@Password", equipment.GenerateCustomPassword(5, true, true, true, false));
                        //  command.Parameters.AddWithValue("@AddedBy", adminID);


                        command.ExecuteNonQuery();

                    }
                    MessageBox.Show("Successfully resited");
                    this.Hide();
                    Add add = new Add(type: type);
                    add.Show();
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Class name is Add and function name is register and error is " + ex.Message);
            }
        }

        private bool Check()
        {
            return !string.IsNullOrWhiteSpace(name_tb.Text) && !string.IsNullOrWhiteSpace(phone_number_tb.Text) && !string.IsNullOrWhiteSpace(email_tb.Text) && !string.IsNullOrWhiteSpace(address_tb.Text) && !string.IsNullOrWhiteSpace(_gender);
        }

        private void Gender()
        {
            if (MaleRB.Checked)
                _gender = "Male";
            
            else if (FemaleRB.Checked)
                _gender = "Female";

            else if (OthersRB.Checked)
                _gender = "Others";
            
        }
    }
}
