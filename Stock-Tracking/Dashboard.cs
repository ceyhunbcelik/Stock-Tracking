using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Tracking
{
    public partial class Dashboard : Form
    {
        DB_Factory_Stock db = new DB_Factory_Stock();

        public int AdminID;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboards_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Router router = new Router
            {
                AdminID = AdminID
            };

            this.Hide();
            router.Show();
        }
        // Intake Ends Here
    }
}
