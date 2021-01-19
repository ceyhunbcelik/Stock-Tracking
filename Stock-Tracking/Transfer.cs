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
        DB_Factory_Stock db = new DB_Factory_Stock();

        public int AdminID;

        public string target_folder_product = @"C:\Users\90541\Desktop\Stock-Tracking\Stock-Tracking\bin\img\product\";
        public string target_folder_supplier = @"C:\Users\90541\Desktop\Stock-Tracking\Stock-Tracking\bin\img\supplier\";
        public string target_folder_worker = @"C:\Users\90541\Desktop\Stock-Tracking\Stock-Tracking\bin\img\worker\";
        public string file_name, file_source;

        public int supplyID = 0;
        public int intakeID;
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfers_Load(object sender, EventArgs e)
        {
            // SUPPLY
            supplies();
            supply_products();
            supply_supplier();
        }
        // Supply - List All Supplies
        private void supplies()
        {
            var query = from item_supply in db.supply_table
                        join item_product in db.product_table
                        on item_supply.product_id equals item_product.id
                        join item_supplier in db.supplier_table
                        on item_supply.supplier_id equals item_supplier.id
                        join item_worker in db.worker_table
                        on item_supply.admin_id equals item_worker.id
                        select new
                        {
                            ID = item_supply.id,
                            KOD = item_product.code,
                            MARKA = item_product.brand,
                            MODEL = item_product.model,
                            ŞİRKET = item_supplier.company,
                            YETKİLİ = item_supplier.person,
                            ADMIN = item_worker.name_surname,
                            MİKTAR = item_supply.amount,
                            TARİH = item_supply.transaction_date
                        };

            datagrid_supply.DataSource = query.ToList();
        }
        // Supply - Clear Inputs
        private void tb_supply_clear()
        {
            supplyID = 0;
            cb_supply_product.Text = "";
            cb_supply_supplier.Text = "";
            tb_supply_amount.Text = "";

            picture_supply_product.ImageLocation = "";
            picture_supply_supplier.ImageLocation = "";
            picture_supply_admin.ImageLocation = "";
        }
        // Supply - Fetch Selected Value in DataGrid
        private void datagrid_supply_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int GridID = e.RowIndex;

            DataGridViewRow selectedSupply = datagrid_supply.Rows[GridID];

            supplyID = Convert.ToInt32(selectedSupply.Cells[0].Value.ToString());

            var query_product = (from item_product in db.product_table
                                 join item_supply in db.supply_table
                                 on item_product.id equals item_supply.product_id
                                 where item_supply.id == supplyID
                                 select item_product).FirstOrDefault();

            var query_supplier = (from item_supplier in db.supplier_table
                                  join item_supply in db.supply_table
                                  on item_supplier.id equals item_supply.supplier_id
                                  where item_supply.id == supplyID
                                  select item_supplier).FirstOrDefault();

            var query_worker = (from item_worker in db.worker_table
                                join item_supply in db.supply_table
                                on item_worker.id equals item_supply.admin_id
                                select item_worker).FirstOrDefault();

            picture_supply_product.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_supply_product.ImageLocation = target_folder_product + query_product.image.ToString();

            picture_supply_supplier.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_supply_supplier.ImageLocation = target_folder_supplier + query_supplier.image.ToString();

            picture_supply_admin.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_supply_admin.ImageLocation = target_folder_worker + query_worker.image.ToString();

            cb_supply_product.Text = query_product.code.ToString();
            cb_supply_supplier.Text = query_supplier.company.ToString();
            tb_supply_amount.Text = selectedSupply.Cells[7].Value.ToString();
        }
        // Supply - ComboBox Fetch Products Code 
        private void supply_products()
        {
            var query = from item_product in db.product_table
                        select item_product.code;

            cb_supply_product.DataSource = query.ToList();
        }
        // Supply - ComboBox Fetch Supplier Company
        private void supply_supplier()
        {
            var query = from item_supplier in db.supplier_table
                        select item_supplier.company;

            cb_supply_supplier.DataSource = query.ToList();
        }
        // Supply - Save Supply
        private void btn_supply_insert_Click(object sender, EventArgs e)
        {
            if (
                cb_supply_product.Text.Trim().Length == 0 ||
                cb_supply_supplier.Text.Trim().Length == 0 ||
                tb_supply_amount.Text.Trim().Length == 0
            )
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {   // UPDATED!
                if (int.TryParse(tb_supply_amount.Text, out int testValue) && Convert.ToInt32(tb_supply_amount.Text) > 0)
                {
                    var product_id = (from item_product in db.product_table
                                      where item_product.code == cb_supply_product.Text
                                      select item_product.id).FirstOrDefault();

                    var supplier_id = (from item_supplier in db.supplier_table
                                       where item_supplier.company == cb_supply_supplier.Text
                                       select item_supplier.id).FirstOrDefault();

                    // SUPPLY
                    supply_table supply = new supply_table
                    {
                        product_id = product_id,
                        supplier_id = supplier_id,
                        admin_id = AdminID,
                        amount = Convert.ToInt32(tb_supply_amount.Text)
                    };

                    db.supply_table.Add(supply);
                    db.SaveChanges();

                    MessageBox.Show("Tedarik Başarıyla Kaydedilmiştir");
                    supplies();
                    tb_supply_clear();

                }
                else
                {
                    MessageBox.Show("Lütfen 0 dan büyük bir miktar giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        // Supply - Update Supply
        private void btn_supply_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (supplyID == 0)
                {
                    MessageBox.Show("Lütfen Tedariki Seçiniz", "UYARI");
                }
                else
                {
                    try
                    {
                        if (
                                                cb_supply_product.Text.Trim().Length == 0 ||
                                                cb_supply_supplier.Text.Trim().Length == 0 ||
                                                tb_supply_amount.Text.Trim().Length == 0
                                            )
                        {
                            MessageBox.Show("Lütfen Değerleri Doğru Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var product_id = (from item in db.product_table
                                              where item.code == cb_supply_product.Text.ToString()
                                              select item.id).FirstOrDefault();

                            MessageBox.Show("PRODUCT ID: " + product_id);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bir hata oluştu");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu");
            }

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
