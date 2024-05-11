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
            if (!CaptainForm.Instance.panelContainer.Controls.ContainsKey("AddCrew"))
            {
                CaptainForm.Instance.panelContainer.Controls.Clear();
                 AddCrew add_crew= new AddCrew();
                add_crew.Dock = DockStyle.Fill;
                CaptainForm.Instance.panelContainer.Controls.Add(add_crew);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
