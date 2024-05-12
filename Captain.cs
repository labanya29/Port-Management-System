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
    public partial class CaptainForm : Form
    {
        public CaptainForm()
        {
            InitializeComponent();
        }
        static CaptainForm obj;
        public static CaptainForm Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new CaptainForm();
                }
                return obj;
            }
        }

        public Panel panelContainer
        {
            get { return captain_panel; }
            set { captain_panel = value; }
        }
        private void captain_from_Load(object sender, EventArgs e)
        {
            obj = this;
        }

        private void add_crew_btn_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.ContainsKey("AddCrew"))
            {
                panelContainer.Controls.Clear();
                 Add add_crew= new Add();
                add_crew.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(add_crew);
            }
        }

        private void CargoDetailsBtn_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.ContainsKey("CargoDetailsForm"))
            {
                panelContainer.Controls.Clear();
                CargoDetailsForm cargoDetailsForm = new CargoDetailsForm();
                cargoDetailsForm.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(cargoDetailsForm);
            }
        }

        private void CrewDetailsBtn_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.ContainsKey("CargoDetailsForm"))
            {
                panelContainer.Controls.Clear();
                CrewDetailsForm crewDetailsForm = new CrewDetailsForm();
                crewDetailsForm.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(crewDetailsForm);
            }
        }
    }
}
