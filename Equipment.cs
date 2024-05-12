using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port_Management_System
{
    internal class Equipment
    {
        private ImageFormat GetImageFormat(System.Drawing.Image image)
        {
            if (image.RawFormat.Equals(ImageFormat.Jpeg))
            {
                return ImageFormat.Jpeg;
            }
            else if (image.RawFormat.Equals(ImageFormat.Png))
            {
                return ImageFormat.Png;
            }
            else if (image.RawFormat.Equals(ImageFormat.Gif))
            {
                return ImageFormat.Gif;
            }
            else if (image.RawFormat.Equals(ImageFormat.Bmp))
            {
                return ImageFormat.Bmp;
            }
            else if (image.RawFormat.Equals(ImageFormat.Icon))
            {
                return ImageFormat.Icon;
            }
            else
            {
                // Handle other formats or return null if not recognized
                return null;
            }
        }
        public byte[] ImageToByteArray(System.Drawing.Image image)
        {
            if (image == null)
            {
                return null;
            }

            // Use a try-catch block to handle any potential GDI+ exceptions
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    ImageFormat imageFormat = GetImageFormat(image);
                    if (imageFormat != null)
                    {
                        image.Save(stream, imageFormat); // Save the image with the determined format
                    }
                    else
                    {
                        // If the image format is not recognized, save it as JPEG (or another default format)
                        image.Save(stream, ImageFormat.Jpeg);
                    }
                    return stream.ToArray();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions related to GDI+ here
                MessageBox.Show("Error in ImageToByteArray: " + ex.Message);
                return null;
            }
        }
        public string GenerateCustomPassword(int length, bool includeUpperCase, bool includeLowerCase, bool includeNumbers, bool includeSpecialCharacters)
        {
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string numberChars = "0123456789";
            const string specialChars = "@#$&*";

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            // Create a list of characters based on the specified criteria
            List<string> charCategories = new List<string>();

            if (includeUpperCase)
                charCategories.Add(uppercaseChars);
            if (includeLowerCase)
                charCategories.Add(lowercaseChars);
            if (includeNumbers)
                charCategories.Add(numberChars);
            if (includeSpecialCharacters)
                charCategories.Add(specialChars);

            // Generate the password
            for (int i = 0; i < length; i++)
            {
                // Choose a random character category
                int categoryIndex = random.Next(charCategories.Count);
                string charCategory = charCategories[categoryIndex];

                // Choose a random character from the selected category
                int charIndex = random.Next(charCategory.Length);
                char randomChar = charCategory[charIndex];

                // Append the random character to the password
                password.Append(randomChar);
            }

            return password.ToString();
        }

        private int SerialNo(string type)
        {
            string lastID = string.Empty;
            Database dataBase = new Database();
            lastID = dataBase.LastID(type);
            int returnValue = 0;


            if (lastID == null)
            {
                returnValue = -1;
            }

            else
            {
                if (lastID == string.Empty)
                {
                    returnValue = 0;
                }

                else if (!string.IsNullOrEmpty(lastID))
                {
                    int year = StringToInt(lastID.Substring(3, 2)), month = StringToInt(lastID.Substring(lastID.Length - 1, 1));
                    DateTime dateTime = DateTime.Now;
                    int yearNow = (dateTime.Year % 100);
                    int monthNow = ((dateTime.Month) / 5) + 1;


                    if (year != yearNow || month != monthNow)
                    {
                        // CustomMessageBox.Show("Year");
                        returnValue = 0;
                    }

                    else if (year == yearNow || month == monthNow)
                    {
                        if (type != "Customer")
                        {
                            string numberPart = lastID.Substring(5, 4);
                            // CustomMessageBox.Show(numberPart);
                            returnValue = StringToInt(numberPart);
                        }
                        else if (type == "Customer")
                        {
                            string numberPart = lastID.Substring(6, 10);
                            // CustomMessageBox.Show(numberPart);
                            returnValue = StringToInt(numberPart);
                        }

                    }
                }
            }
            // CustomMessageBox.Show(returnValue.ToString());
            return returnValue;
        }

        private int StringToInt(string value)
        {
            try
            {
                int result = Convert.ToInt32(value);
                // Conversion was successful, and 'result' now contains the integer value.
                // You can use the 'result' variable here as needed.
                return result;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalied Number Format");
                return -1;
            }
        }


        public string IdGenarator(string type)
        {
            DateTime date = DateTime.Now; // Example date, you can replace it with your desired date

            int year = date.Year;
            int month = (date.Month / 5) + 1;
            int day = date.Day;

            int serialNo = SerialNo(type) + 1;
            string id = string.Empty;
            if (type == "Admin")
                return "AD-" + (year % 100) + serialNo.ToString("D4") + "-" + month;
            

            else if(type == "Captain")
                    return "CA-" + (year % 100) + serialNo.ToString("D4") + "-" + month;

            else if (type == "Deck Officer")
                return "DK-" + (year % 100) + serialNo.ToString("D4") + "-" + month;

            else if (type == "Cargo Inspector")
                return "CI-" + (year % 100) + serialNo.ToString("D4") + "-" + month;
            else if (type == "Crew")
                return "CW-" + (year % 100) + serialNo.ToString("D4") + "-" + month;
            else if (type == "Cargo")
                return "CR-" + (year % 100) + serialNo.ToString("D4") + "-" + month;

            return string.Empty;
        }

        public System.Drawing.Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
    }
}
