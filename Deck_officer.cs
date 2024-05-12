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
    public partial class Deck_officer : Form
    {
        private string id;
        public Deck_officer()
        {
            InitializeComponent();
        }
        public Deck_officer(string id):this()
        {
            this.id = id;  
        }
        static Deck_officer obj;
        public static Deck_officer Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new Deck_officer();
                }
                return obj;
            }
        }

        public Panel panelContainer
        {
            get { return AddCrewPanel; }
            set { AddCrewPanel = value; }
        }
        

        private void add_crew_btn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Add new_Admin = new Add(type: "Crew");
            new_Admin.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(new_Admin);
        }

       

        private void Deck_officer_Load(object sender, EventArgs e)
        {
            obj = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Deck_officer.Instance.panelContainer.Controls.ContainsKey("AddCrew"))
            {
                Deck_officer.Instance.panelContainer.Controls.Clear();
                CrewDetailsForm crewdetails = new CrewDetailsForm(this.id);
                crewdetails.Dock = DockStyle.Fill;
                Deck_officer.Instance.panelContainer.Controls.Add(crewdetails);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panelContainer.Controls.Clear();
            Schedule schedule = new Schedule();
            schedule.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(schedule);
        }
    }
}
