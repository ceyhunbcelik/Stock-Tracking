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
    public partial class Transfer : Form
    {
        public int AdminID;
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfers_Load(object sender, EventArgs e)
        {
            //label1.Text = AdminID.ToString();
        }
        // Supply - Save Supply
        private void btn_supply_insert_Click(object sender, EventArgs e)
        {

        }
        // Close Form and Redirect to Router
        private void Transfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Router router = new Router
            {
                AdminID = AdminID
            };

            this.Hide();
            router.Show();
        }
    }
}
