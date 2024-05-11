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
    public partial class CrewDetailsForm : UserControl
    {
        private string id;
        public CrewDetailsForm()
        {
            InitializeComponent();
        }
        public CrewDetailsForm(string id):this()
        {
            this.id = id;
        }
    }
}
