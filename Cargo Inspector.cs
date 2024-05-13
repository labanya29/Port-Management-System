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
    public partial class Cargo_Inspector : Form
    {
        static Cargo_Inspector obj;
        public Cargo_Inspector()
        {
            InitializeComponent();
        }

        public static Cargo_Inspector Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new Cargo_Inspector();
                }
                return obj;
            }
        }

        public Panel panelContainer
        {
            get { return CargoInspectorPanel; }
            set { CargoInspectorPanel = value; }
        }

        private void Cargo_Inspector_Load(object sender, EventArgs e)
        {
            obj = this;
        }

        private void AddCargo_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            AddCargo addCargo = new AddCargo();
            addCargo.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(addCargo);
        }

        private void CiLogOutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void CargoDetails_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            CargoDetailsForm cargoDetailsForm = new CargoDetailsForm();
            cargoDetailsForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(cargoDetailsForm);
        }
    }
}
