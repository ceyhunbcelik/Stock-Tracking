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

        private void textbox_clear()
        {
            tb_admin_username.Text = "";
            tb_admin_password.Text = "";
        }

        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            if(tb_admin_username.Text.Trim().Length == 0 && tb_admin_password.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox_clear();
            } 
            else
            {
                try
                {
                    var query = (from item in db.admin_table
                                 where
                                    item.username == tb_admin_username.Text &
                                    item.password == tb_admin_password.Text
                                 select item).FirstOrDefault();

                    if (query != null)
                    {

                        Router router = new Router
                        {
                            AdminID = (int)query.worker_id
                        };

                        this.Hide();
                        router.Show();
                    }
                    else
                    {
                        MessageBox.Show("Böyle Bir Kullanıcı Bulunmamaktadır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textbox_clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
