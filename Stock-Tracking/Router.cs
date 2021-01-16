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
    public partial class Router : Form
    {
        public int AdminID;
        public Router()
        {
            InitializeComponent();
        }

        private void btn_router_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard
            {
                AdminID = AdminID
            };

            this.Hide();
            dashboard.Show();
        }

        private void btn_router_transfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer
            {
                AdminID = AdminID
            };

            this.Hide();
            transfer.Show();
        }

        private void btn_router_record_Click(object sender, EventArgs e)
        {
            Record record = new Record
            {
                AdminID = AdminID
            };

            this.Hide();
            record.Show();
        }

        private void btn_router_admin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin
            {
                AdminID = AdminID
            };

            this.Hide();
            admin.Show();
        }

        private void Router_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
