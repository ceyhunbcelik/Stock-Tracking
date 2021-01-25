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

        public string target_folder_worker = Environment.CurrentDirectory + @"\img\worker\";

        public int AdminID;
        public int adminID;

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            admins();
            cb_admin_identification_list();
            tb_admin_clear();
        }
        // Admin - List All Values
        private void admins()
        {
            try
            {
                var query = from item_admin in db.admin_table
                            join item_worker in db.worker_table
                            on item_admin.worker_id equals item_worker.id
                            select new
                            {
                                ID = item_admin.id,
                                KULLANICI_ADI = item_admin.username,
                                ŞİFRE = item_admin.password,
                                AD_SOYAD = item_worker.name_surname,
                                TC = item_worker.identification,
                                GÖREV = item_worker.rank
                            };

                datagrid_admin.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Admin - Clear Inputs
        private void tb_admin_clear()
        {
            adminID = 0;
            tb_admin_username.Text = "";
            tb_admin_password.Text = "";
            cb_admin_identification.Text = "";
            picture_admin.ImageLocation = "";
        }
        // Admin - Fetch Workers ID without Admin
        private void cb_admin_identification_list()
        {
            try
            {
                var query = from item_worker in db.worker_table
                            where !(from item_admin in db.admin_table
                                    select item_admin.worker_id).Contains(item_worker.id)
                            select item_worker.identification;

                cb_admin_identification.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Admin - Show Picture of Worker by Selected ID
        private void cb_admin_identification_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = (from item_worker in db.worker_table
                             where item_worker.identification == cb_admin_identification.Text
                             select item_worker.image).FirstOrDefault();

                picture_admin.SizeMode = PictureBoxSizeMode.StretchImage;
                picture_admin.ImageLocation = target_folder_worker + query.ToString();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Admin - Fetch Selected Value in DataGrid
        private void datagrid_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int GridID = e.RowIndex;

                DataGridViewRow selectedAdmin = datagrid_admin.Rows[GridID];

                adminID = Convert.ToInt32(selectedAdmin.Cells[0].Value.ToString());
                tb_admin_username.Text = selectedAdmin.Cells[1].Value.ToString();
                tb_admin_password.Text = selectedAdmin.Cells[2].Value.ToString();
                cb_admin_identification.Text = selectedAdmin.Cells[4].Value.ToString();

                var query = (from item in db.worker_table
                             where item.identification == cb_admin_identification.Text
                             select item).FirstOrDefault();

                picture_admin.SizeMode = PictureBoxSizeMode.StretchImage;
                picture_admin.ImageLocation = target_folder_worker + query.image.ToString();
            }
            catch
            {
                MessageBox.Show("Teknik bir hata oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Admin - Save Admin
        private void btn_admin_insert_Click(object sender, EventArgs e)
        {
            if (
                tb_admin_username.Text.Trim().Length == 0 ||
                tb_admin_password.Text.Trim().Length == 0 ||
                cb_admin_identification.Text.Trim().Length == 0
            )
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var query = (from item in db.worker_table
                                 where item.identification == cb_admin_identification.Text
                                 select item).FirstOrDefault();


                    admin_table admin = new admin_table
                    {
                        username = tb_admin_username.Text,
                        password = tb_admin_password.Text,
                        worker_id = query.id
                    };

                    db.admin_table.Add(admin);
                    db.SaveChanges();

                    MessageBox.Show("Admin Başarıyla Kaydedilmiştir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    admins();
                    cb_admin_identification_list();
                    tb_admin_clear();
                }
                catch
                {
                    MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Admin - Update Admin
        private void btn_admin_update_Click(object sender, EventArgs e)
        {
            if (adminID == 0)
            {
                MessageBox.Show("Lütfen Admini Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (
                tb_admin_username.Text.Trim().Length == 0 ||
                tb_admin_password.Text.Trim().Length == 0 ||
                cb_admin_identification.Text.Trim().Length == 0
                )
                {
                    MessageBox.Show("Lütfen Boş Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        var query = (from item in db.worker_table
                                     where item.identification == cb_admin_identification.Text
                                     select item).FirstOrDefault();

                        var update = db.admin_table.Find(adminID);

                        update.username = tb_admin_username.Text;
                        update.password = tb_admin_password.Text;
                        update.worker_id = query.id;

                        db.SaveChanges();
                        MessageBox.Show("Admin Başarıyla Güncellenmiştir.");
                        AdminID = query.id;

                        admins();
                        cb_admin_identification_list();
                        tb_admin_clear();
                    }
                    catch
                    {
                        MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Admin - Delete Adminn
        private void btn_admin_delete_Click(object sender, EventArgs e)
        {
            if (adminID == 0)
            {
                MessageBox.Show("Lütfen Admini Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var delete = db.admin_table.Find(adminID);

                    if (delete.worker_id == AdminID)
                    {
                        // Shut Down
                        db.admin_table.Remove(delete);
                        db.SaveChanges();

                        MessageBox.Show("Kaydınız Silinmiştir!");
                        Application.Exit();
                    }
                    else
                    {
                        db.admin_table.Remove(delete);
                        db.SaveChanges();

                        MessageBox.Show("Admin Başarıyla Silinmiştir.");

                        admins();
                        cb_admin_identification_list();
                        tb_admin_clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Admin - Clearn Button
        private void btn_admin_clear_Click(object sender, EventArgs e)
        {
            tb_admin_clear();
        }
        // Admin - Search Admin by Identification
        private void tb_admin_like_identification_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from item_admin in db.admin_table
                            join item_worker in db.worker_table
                            on item_admin.worker_id equals item_worker.id
                            where item_worker.identification.Contains(tb_admin_like_identification.Text)
                            select new
                            {
                                ID = item_admin.id,
                                KULLANICI_ADI = item_admin.username,
                                ŞİFRE = item_admin.password,
                                AD_SOYAD = item_worker.name_surname,
                                TC = item_worker.identification,
                                GÖREV = item_worker.rank
                            };

                datagrid_admin.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Close Form and Redirect to Router
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Router router = new Router
            {
                AdminID = AdminID
            };

            this.Hide();
            router.Show();
        }
        // KeyPress - ADMIN LIKE IDENTIFICATION
        private void tb_admin_like_identification_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
