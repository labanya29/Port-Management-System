using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port_Management_System
{
    public partial class Schedule_list : UserControl
    {
        private string adminID;
        public string nextButton { get; set; }
        public string vasselName { get; set; }
        public string imoNumber { get; set; }
        public string departureTime { get; set; }   
        public Schedule_list()
        {
            InitializeComponent();
            
        }

        public Schedule_list(string adminID) : this()
        {
            this.adminID = adminID;
            
        }

        public Schedule_list(string adminID, string nextButton, string vasselName, string imoNumber, string departureTime) : this(adminID)
        {
            this.nextButton = nextButton;
            this.vasselName = vasselName;
            this.imoNumber = imoNumber;
            this.departureTime = departureTime;
            DataStore();
        }

        private void DataStore()
        {
            next_button.Tag = nextButton;
            vassel_name.Text = "Vassel Name: "+vasselName;
            imo_number.Text = "IMO Number: " + imoNumber;    
            departure_time.Text = "Departure TIme: " + departureTime;    
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (!AdminForm.Instance.panelContainer.Controls.ContainsKey("ScheduleInfo"))
            {
                AdminForm.Instance.panelContainer.Controls.Clear();
                ScheduleInfo scheduleInfo = new ScheduleInfo(this.adminID, next_button.Tag.ToString());
                scheduleInfo.Dock = DockStyle.Fill;
                AdminForm.Instance.panelContainer.Controls.Add(scheduleInfo);
            }
            
                

                
        }
    }
}
