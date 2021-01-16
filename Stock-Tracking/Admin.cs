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
    public partial class Admin : Form
    {
        DB_Factory_Stock db = new DB_Factory_Stock();

        public int AdminID;

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            admins();
            cb_admin_identification_list();
        }

        private void admins()
        {
            var query = from item_admin in db.admin_table
                        join item_worker in db.worker_table
                        on item_admin.worker_id equals item_worker.id
                        select new
                        {
                            KULLANICI_ADI = item_admin.username,
                            ŞİFRE = item_admin.password,
                            AD_SOYAD = item_worker.name_surname,
                            TC = item_worker.identification
                        };

            datagrid_admin.DataSource = query.ToList();
        }

        private void cb_admin_identification_list()
        {

            var query = from item_worker in db.worker_table
                        where !(from item_admin in db.admin_table
                                select item_admin.worker_id).Contains(item_worker.id)
                        select item_worker.identification;

            cb_admin_identification.DataSource = query.ToList();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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
