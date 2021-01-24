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
        public int intakeID = 0;
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

            // INTAKE
            intakes();
            intake_products();
            intake_workers();
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
                            ADMIN_TC = item_worker.identification,
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
                                where item_supply.id == supplyID
                                select item_worker).FirstOrDefault();

            picture_supply_product.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_supply_product.ImageLocation = target_folder_product + query_product.image.ToString();

            picture_supply_supplier.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_supply_supplier.ImageLocation = target_folder_supplier + query_supplier.image.ToString();

            picture_supply_admin.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_supply_admin.ImageLocation = target_folder_worker + query_worker.image.ToString();

            cb_supply_product.Text = query_product.code.ToString();
            cb_supply_supplier.Text = query_supplier.company.ToString();
            tb_supply_amount.Text = selectedSupply.Cells[8].Value.ToString();
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
            if (supplyID == 0)
            {
                MessageBox.Show("Lütfen Tedarik Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (
                    cb_supply_product.Text.Trim().ToString().Length == 0 ||
                    cb_supply_supplier.Text.Trim().ToString().Length == 0 ||
                    tb_supply_amount.Text.Trim().ToString().Length == 0
                )
                {
                    MessageBox.Show("Lütfen Boş Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        if (Convert.ToInt32(tb_supply_amount.Text.Trim()) > 0)
                        {
                            var product_id = (from item in db.product_table
                                              where item.code == cb_supply_product.Text
                                              select item.id).FirstOrDefault();

                            var supplier_id = (from item in db.supplier_table
                                               where item.company == cb_supply_supplier.Text
                                               select item.id).FirstOrDefault();

                            var update = db.supply_table.Find(supplyID);

                            update.product_id = product_id;
                            update.supplier_id = supplier_id;
                            update.admin_id = AdminID;
                            update.amount = Convert.ToInt32(tb_supply_amount.Text.Trim().ToString());

                            db.SaveChanges();
                            MessageBox.Show("Tedarik Başarıyla Güncellenmiştir.");
                            supplies();
                            tb_supply_clear();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen 0 dan büyük değerler giriniz");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Lütfen geçerli değerler giriniz");
                    }

                }
            }
        }
        // Supply Delete Supply
        private void btn_supply_delete_Click(object sender, EventArgs e)
        {
            if (supplyID == 0)
            {
                MessageBox.Show("Lütfen Tedarik Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var delete = db.supply_table.Find(supplyID);

                db.supply_table.Remove(delete);

                db.SaveChanges();

                MessageBox.Show("Tedarik Başarıyla Silinmiştir.");
                supplies();
                tb_supply_clear();
            }
        }
        // Supply - Clear Button
        private void btn_supply_clear_Click(object sender, EventArgs e)
        {
            tb_supply_clear();
        }
        // Supply - Search Suppy by Code
        private void tb_supply_like_code_TextChanged(object sender, EventArgs e)
        {
            var query = from item_supply in db.supply_table
                        join item_product in db.product_table
                        on item_supply.product_id equals item_product.id
                        join item_supplier in db.supplier_table
                        on item_supply.supplier_id equals item_supplier.id
                        join item_worker in db.worker_table
                        on item_supply.admin_id equals item_worker.id
                        where item_product.code.Contains(tb_supply_like_code.Text)
                        select new
                        {
                            ID = item_supply.id,
                            KOD = item_product.code,
                            MARKA = item_product.brand,
                            MODEL = item_product.model,
                            ŞİRKET = item_supplier.company,
                            YETKİLİ = item_supplier.person,
                            ADMIN = item_worker.name_surname,
                            ADMIN_TC = item_worker.identification,
                            MİKTAR = item_supply.amount,
                            TARİH = item_supply.transaction_date
                        };

            datagrid_supply.DataSource = query.ToList();
        }
        // Supply - Search Supply by Company
        private void tb_supply_like_company_TextChanged(object sender, EventArgs e)
        {
            var query = from item_supply in db.supply_table
                        join item_product in db.product_table
                        on item_supply.product_id equals item_product.id
                        join item_supplier in db.supplier_table
                        on item_supply.supplier_id equals item_supplier.id
                        join item_worker in db.worker_table
                        on item_supply.admin_id equals item_worker.id
                        where item_supplier.company.Contains(tb_supply_like_company.Text)
                        select new
                        {
                            ID = item_supply.id,
                            KOD = item_product.code,
                            MARKA = item_product.brand,
                            MODEL = item_product.model,
                            ŞİRKET = item_supplier.company,
                            YETKİLİ = item_supplier.person,
                            ADMIN = item_worker.name_surname,
                            ADMIN_TC = item_worker.identification,
                            MİKTAR = item_supply.amount,
                            TARİH = item_supply.transaction_date
                        };

            datagrid_supply.DataSource = query.ToList();
        }

        // ------------------------------------------------------------------------------------

        // Intake - List All Intakes
        private void intakes()
        {
            var query = from item_intake in db.intake_table
                        join item_product in db.product_table
                        on item_intake.product_id equals item_product.id
                        join item_worker in db.worker_table
                        on item_intake.worker_id equals item_worker.id
                        join item_admin in db.worker_table
                        on item_intake.admin_id equals item_admin.id
                        select new
                        {
                            ID = item_intake.id,
                            KOD = item_product.code,
                            MARKA = item_product.brand,
                            MODEL = item_product.model,
                            ÇALIŞAN = item_worker.name_surname,
                            ÇALIŞAN_TC = item_worker.identification,
                            GÖREV = item_worker.rank,
                            ADMIN = item_admin.name_surname,
                            ADMIN_TC = item_admin.identification,
                            MİKTAR = item_intake.amount,
                            TARİH = item_intake.intake_date
                        };

            datagrid_intake.DataSource = query.ToList();
        }
        // Intake - Clear Inputs
        private void tb_intake_clear()
        {
            intakeID = 0;
            cb_intake_product.Text = "";
            cb_intake_worker.Text = "";
            tb_intake_amount.Text = "";

            picture_intake_product.ImageLocation = "";
            picture_intake_worker.ImageLocation = "";
            picture_intake_admin.ImageLocation = "";
        }
        // Intake - Fetch Selected Value in DataGrid
        private void datagrid_intake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int GridID = e.RowIndex;

                DataGridViewRow selectedIntake = datagrid_intake.Rows[GridID];

                intakeID = Convert.ToInt32(selectedIntake.Cells[0].Value.ToString());

                var query_product = (from item_product in db.product_table
                                     join item_intake in db.intake_table
                                     on item_product.id equals item_intake.product_id
                                     where item_intake.id == intakeID
                                     select item_product).FirstOrDefault();

                var query_worker = (from item_worker in db.worker_table
                                    join item_intake in db.intake_table
                                    on item_worker.id equals item_intake.worker_id
                                    where item_intake.id == intakeID
                                    select item_worker).FirstOrDefault();

                var query_admin = (from item_worker in db.worker_table
                                   join item_intake in db.intake_table
                                   on item_worker.id equals item_intake.admin_id
                                   where item_intake.id == intakeID
                                   select item_worker).FirstOrDefault();

                picture_intake_product.SizeMode = PictureBoxSizeMode.StretchImage;
                picture_intake_product.ImageLocation = target_folder_product + query_product.image.ToString();

                picture_intake_worker.SizeMode = PictureBoxSizeMode.StretchImage;
                picture_intake_worker.ImageLocation = target_folder_worker + query_worker.image.ToString();

                picture_intake_admin.SizeMode = PictureBoxSizeMode.StretchImage;
                picture_intake_admin.ImageLocation = target_folder_worker + query_admin.image.ToString();

                cb_intake_product.Text = selectedIntake.Cells[1].Value.ToString();
                cb_intake_worker.Text = selectedIntake.Cells[5].Value.ToString();
                tb_intake_amount.Text = selectedIntake.Cells[9].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Beklenmedik bir hata oluştu");
            }
        }
        // Intake - ComboBox Fetch Products Code
        private void intake_products()
        {
            var query = from item_product in db.product_table
                        select item_product.code;

            cb_intake_product.DataSource = query.ToList();
        }
        // Intake - ComboBox Fetch Worker Identification
        private void intake_workers()
        {
            var query = from item_worker in db.worker_table
                        select item_worker.identification;

            cb_intake_worker.DataSource = query.ToList();
        }
        // Intake - Save Intake
        private void btn_intake_insert_Click(object sender, EventArgs e)
        {
            if (
                cb_intake_product.Text.Trim().Length == 0 ||
                cb_intake_worker.Text.Trim().Length == 0 ||
                tb_intake_amount.Text.Trim().Length == 0
            )
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(tb_intake_amount.Text.Trim()) > 0)
                    {
                        // WORKER ID
                        var worker_id = (from item in db.worker_table
                                         where item.identification == cb_intake_worker.Text
                                         select item.id).FirstOrDefault();

                        // PRODUCT ID
                        var product_id = (from item in db.product_table
                                          where item.code == cb_intake_product.Text.ToString()
                                          select item.id).FirstOrDefault();
                        // PRODUCT SUPPLY AMOUNT
                        var product_supply = db.supply_table.Where(p => p.product_id == product_id).Sum(p => p.amount);

                        // PRODUCT INTAKE AMOUNT
                        var product_intake = db.intake_table.Where(p => p.product_id == product_id).Sum(p => p.amount);

                        int total_suply = Convert.ToInt32(product_supply);
                        int total_intake = Convert.ToInt32(product_intake);
                        int worker_intake = Convert.ToInt32(tb_intake_amount.Text.Trim());
                        int new_intake = total_intake + worker_intake;


                        if (product_supply >= new_intake) // NEW INTAKE
                        {
                            intake_table intake = new intake_table
                            {
                                product_id = product_id,
                                worker_id = worker_id,
                                admin_id = AdminID,
                                amount = Convert.ToInt32(tb_intake_amount.Text.ToString())
                            };

                            db.intake_table.Add(intake);
                            db.SaveChanges();

                            MessageBox.Show("Alım Başarıyla Kaydedilmiştir");
                            intakes();
                            tb_intake_clear();
                        }
                        else
                        {
                            MessageBox.Show("STOKTA YETERLİ MAL BULUNMAMAKTADIR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen 0 dan büyük değerler giriniz");
                    }

                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli değerler giriniz");
                }
            }
        }
        // Intake - Update Intake
        private void btn_intake_update_Click(object sender, EventArgs e)
        {
            if (intakeID == 0)
            {
                MessageBox.Show("Lütfen Alım Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(tb_intake_amount.Text.Trim()) > 0)
                    {
                        // PRODUCT ID
                        var product_id = (from item in db.product_table
                                          where item.code == cb_intake_product.Text
                                          select item.id).FirstOrDefault();

                        var query_intake = (from item in db.intake_table
                                            where item.id == intakeID
                                            select item.amount).FirstOrDefault();

                        int worker_intake_amount = Convert.ToInt32(query_intake.ToString());
                        int worker_intake_new = Convert.ToInt32(tb_intake_amount.Text);

                        // WORKER ID
                        var worker_id = (from item in db.worker_table
                                         where item.identification == cb_intake_worker.Text
                                         select item.id).FirstOrDefault();

                        if (worker_intake_amount >= worker_intake_new)
                        {
                            try
                            {
                                //MessageBox.Show("DAHA AZ MAL İSTİYOR");

                                var update = db.intake_table.Find(intakeID);

                                update.product_id = product_id;
                                update.worker_id = worker_id;
                                update.admin_id = AdminID;
                                update.amount = worker_intake_new;

                                db.SaveChanges();
                                MessageBox.Show("Alım Başarıyla Güncellenmiştir.");

                                intakes();
                                tb_intake_clear();
                            }
                            catch
                            {
                                MessageBox.Show("Beklenmedik Bir Hata Oluştu");
                            }
                        }
                        else
                        {
                            try
                            {
                                //MessageBox.Show("DAHA FAZLA MAL İSTİYOR");

                                // PRODUCT SUPPLY AMOUNT
                                var product_supply = db.supply_table.Where(p => p.product_id == product_id).Sum(p => p.amount);
                                int total_supply = Convert.ToInt32(product_supply);

                                // PRODUCT INTAKE AMOUNT
                                var product_intake = db.intake_table.Where(p => p.product_id == product_id).Sum(p => p.amount);
                                int total_intake = Convert.ToInt32(product_intake);

                                //MessageBox.Show("TOPLAM TEDARİK: " + total_supply.ToString());
                                //MessageBox.Show("TOPLAM ALIM: " + total_intake.ToString());
                                //MessageBox.Show("ÇALIŞAN ÖNCEKİ ALIMI: " + worker_intake_amount.ToString());
                                //MessageBox.Show("ÇALIŞANIN ŞİMDİ İSTEDİĞİ: " + worker_intake_new.ToString());

                                if(total_supply >= ((total_intake - worker_intake_amount) + worker_intake_new))
                                {
                                    var update = db.intake_table.Find(intakeID);

                                    update.product_id = product_id;
                                    update.worker_id = worker_id;
                                    update.admin_id = AdminID;
                                    update.amount = worker_intake_new;

                                    db.SaveChanges();
                                    MessageBox.Show("Alım Başarıyla Güncellenmiştir.");

                                    intakes();
                                    tb_intake_clear();
                                }
                                else
                                {
                                    MessageBox.Show("STOKTA YETERLİ MAL BULUNMAMAKTADIR");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Beklenmedik Bir Hata Oluştu");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen 0 dan büyük değerler giriniz");
                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli değerler giriniz");
                }
            }
        }
        // Intake - Delete Intake
        private void btn_intake_delete_Click(object sender, EventArgs e)
        {
            if(intakeID == 0)
            {
                MessageBox.Show("Lütfen Tedarik Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var delete = db.intake_table.Find(intakeID);

                db.intake_table.Remove(delete);

                db.SaveChanges();

                MessageBox.Show("Alım Başarıyla Silinmiştir.");
                intakes();
                tb_intake_clear();
            }
        }
        // Intake - Clear Button
        private void btn_intake_clear_Click(object sender, EventArgs e)
        {
            tb_intake_clear();
        }
        // Intake - Search Intake by Code
        private void tb_intake_like_code_TextChanged(object sender, EventArgs e)
        {
            var query = from item_intake in db.intake_table
                        join item_product in db.product_table
                        on item_intake.product_id equals item_product.id
                        join item_worker in db.worker_table
                        on item_intake.worker_id equals item_worker.id
                        join item_admin in db.worker_table
                        on item_intake.admin_id equals item_admin.id
                        where item_product.code.Contains(tb_intake_like_code.Text)
                        select new
                        {
                            ID = item_intake.id,
                            KOD = item_product.code,
                            MARKA = item_product.brand,
                            MODEL = item_product.model,
                            ÇALIŞAN = item_worker.name_surname,
                            ÇALIŞAN_TC = item_worker.identification,
                            GÖREV = item_worker.rank,
                            ADMIN = item_admin.name_surname,
                            ADMIN_TC = item_admin.identification,
                            MİKTAR = item_intake.amount,
                            TARİH = item_intake.intake_date
                        };

            datagrid_intake.DataSource = query.ToList();
        }
        // Intake - Search Intake by Identification
        private void tb_intake_like_identification_TextChanged(object sender, EventArgs e)
        {
            var query = from item_intake in db.intake_table
                        join item_product in db.product_table
                        on item_intake.product_id equals item_product.id
                        join item_worker in db.worker_table
                        on item_intake.worker_id equals item_worker.id
                        join item_admin in db.worker_table
                        on item_intake.admin_id equals item_admin.id
                        where item_worker.identification.Contains(tb_intake_like_identification.Text)
                        select new
                        {
                            ID = item_intake.id,
                            KOD = item_product.code,
                            MARKA = item_product.brand,
                            MODEL = item_product.model,
                            ÇALIŞAN = item_worker.name_surname,
                            ÇALIŞAN_TC = item_worker.identification,
                            GÖREV = item_worker.rank,
                            ADMIN = item_admin.name_surname,
                            ADMIN_TC = item_admin.identification,
                            MİKTAR = item_intake.amount,
                            TARİH = item_intake.intake_date
                        };

            datagrid_intake.DataSource = query.ToList();
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
