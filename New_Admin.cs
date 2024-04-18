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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Port_Management_System
{
    public partial class New_Admin : UserControl
    {
        private string adminID;
        private string id, name, email, phoneNumber, address, _gender = null, password;
        public New_Admin()
        {
            InitializeComponent();
        }


        public New_Admin(string adminID): this()
        {
            this.adminID = adminID;
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
            Database database = new Database();
            using (SqlConnection connection = new SqlConnection(database.connectionString))
            {
                connection.Open();

                string registrationQuery = @"INSERT INTO [Admin Information] (ID, Name,Picture, Email, [Phone Number], Gender, [Password], [Added By]) 
                                               VALUES (@ID, @Name,@Picture, @Email, @PhoneNumber, @Gender, @Password, @AddedBy)";
                Equipment equipment = new Equipment();



                
                using (SqlCommand command = new SqlCommand(registrationQuery, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ID", equipment.IdGenarator("Admin"));
                    command.Parameters.AddWithValue("@Name", name_tb.Text);
                    command.Parameters.AddWithValue("@Picture", equipment.ImageToByteArray(picture_box.Image));
                    command.Parameters.AddWithValue("@Email", email_tb.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", phone_number_tb.Text);
                    command.Parameters.AddWithValue("@Gender", _gender);
                    command.Parameters.AddWithValue("@Password", equipment.GenerateCustomPassword(5,true,true,true,false));
                    command.Parameters.AddWithValue("@AddedBy", adminID);
                    

                    command.ExecuteNonQuery();

                }
            }
        }
        private bool Check()
        {
            return !string.IsNullOrWhiteSpace(name_tb.Text) && !string.IsNullOrWhiteSpace(phone_number_tb.Text) && !string.IsNullOrWhiteSpace(email_tb.Text) && !string.IsNullOrWhiteSpace(address_tb.Text) && !string.IsNullOrWhiteSpace(_gender);
        }
        private void Gender()
        {
            if (MaleRB.Checked)
            {
                _gender = "Male";
            }
            else if (FemaleRB.Checked)
            {
                _gender = "Female";
            }
            else if (OthersRB.Checked)
            {
                _gender = "Others";
            }
        }
        private void New_Admin_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}