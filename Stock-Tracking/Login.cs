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
    public partial class Login : Form
    {
        DB_Factory_Stock db = new DB_Factory_Stock();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            var query = (from item in db.admin_table
                         where
                            item.username == tb_admin_username.Text &
                            item.password == tb_admin_password.Text
                         select item).FirstOrDefault();

            if(query != null)
            {
                Router router = new Router
                {
                    AdminID = query.id
                };

                this.Hide();
                router.Show();
            }
            else
            {
                MessageBox.Show("Başarısız!");
            }
        }
    }
}
