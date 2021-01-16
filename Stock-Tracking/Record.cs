﻿using System;
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
    public partial class Record : Form
    {
        DB_Factory_Stock db = new DB_Factory_Stock();

        public int AdminID;

        public int productID;
        public int supplierID;
        public int workerID;

        public Record()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            products();
            suppliers();
            workers();
        }

        // Product Starts Here
        private void products()
        {
            var query = from item in db.product_table
                        select new
                        {
                            ID = item.id,
                            Kod = item.code,
                            Marka = item.brand,
                            Model = item.model,
                        };
            datagrid_product.DataSource = query.ToList();
        }

        private void tb_product_clear()
        {
            tb_product_code.Text = "";
            tb_product_brand.Text = "";
            tb_product_model.Text = "";
            tb_product_description.Text = "";
        }

        private void datagrid_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int GridID = e.RowIndex;

            DataGridViewRow selectedProduct = datagrid_product.Rows[GridID];

            productID = Convert.ToInt32(selectedProduct.Cells[0].Value.ToString());
            tb_product_code.Text = selectedProduct.Cells[1].Value.ToString();
            tb_product_brand.Text = selectedProduct.Cells[2].Value.ToString();
            tb_product_model.Text = selectedProduct.Cells[3].Value.ToString();

            var query = (from item in db.product_table
                         where item.id == productID
                         select item).FirstOrDefault();

            tb_product_description.Text = query.description.ToString();
        }

        private void btn_product_insert_Click(object sender, EventArgs e)
        {
            product_table product = new product_table
            {
                code = tb_product_code.Text,
                brand = tb_product_brand.Text,
                model = tb_product_model.Text,
                description = tb_product_description.Text
            };

            db.product_table.Add(product);
            db.SaveChanges();

            stock_table stock = new stock_table
            {
                product_id = product.id,
                amount = 0
            };

            db.stock_table.Add(stock);
            db.SaveChanges();

            MessageBox.Show("Ürün Başarıyla Kaydedilmiştir");
            products();
            tb_product_clear();
        }

        private void btn_product_update_Click(object sender, EventArgs e)
        {
            var update = db.product_table.Find(productID);

            update.code = tb_product_code.Text;
            update.brand = tb_product_brand.Text;
            update.model = tb_product_model.Text;
            update.description = tb_product_description.Text;

            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellenmiştir.");
            products();
            tb_product_clear();
        }

        private void btn_product_delete_Click(object sender, EventArgs e)
        {
            var delete = db.product_table.Find(productID);

            db.product_table.Remove(delete);

            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silinmiştir.");
            products();
            tb_product_clear();
        }

        private void tb_product_like_code_TextChanged(object sender, EventArgs e)
        {
            var query = from item in db.product_table
                        where item.code.Contains(tb_product_like_code.Text)
                        select new
                        {
                            ID = item.id,
                            Kod = item.code,
                            Marka = item.brand,
                            Model = item.model
                        };

            datagrid_product.DataSource = query.ToList();
        }

        private void tb_product_like_model_TextChanged(object sender, EventArgs e)
        {
            var query = from item in db.product_table
                        where item.model.Contains(tb_product_like_model.Text)
                        select new
                        {
                            ID = item.id,
                            Kod = item.code,
                            Marka = item.brand,
                            Model = item.model
                        };

            datagrid_product.DataSource = query.ToList();
        }
        // Product Ends Here

        // Supplier Start Here
        private void suppliers()
        {
            var query = from item in db.supplier_table
                        select new
                        {
                            ID = item.id,
                            Şirket = item.company,
                            Yetkili = item.person,
                            Yetkili_Görevi = item.rank,
                            Telefon1 = item.phone_1,
                            Telefon2 = item.phone_2
                        };

            datagrid_supplier.DataSource = query.ToList();
        }

        private void tb_supplier_clear()
        {
            tb_supplier_company.Text = "";
            tb_supplier_person.Text = "";
            tb_supplier_rank.Text = "";
            tb_supplier_phone_1.Text = "";
            tb_supplier_phone_2.Text = "";
            tb_supplier_address.Text = "";
        }

        private void datagrid_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int GridID = e.RowIndex;

            DataGridViewRow selectedSupplier = datagrid_supplier.Rows[GridID];

            supplierID = Convert.ToInt32(selectedSupplier.Cells[0].Value.ToString());
            tb_supplier_company.Text = selectedSupplier.Cells[1].Value.ToString();
            tb_supplier_person.Text = selectedSupplier.Cells[2].Value.ToString();
            tb_supplier_rank.Text = selectedSupplier.Cells[3].Value.ToString();
            tb_supplier_phone_1.Text = selectedSupplier.Cells[4].Value.ToString();
            tb_supplier_phone_2.Text = selectedSupplier.Cells[5].Value.ToString();

            var query = (from item in db.supplier_table
                         where item.id == supplierID
                         select item).FirstOrDefault();

            tb_supplier_address.Text = query.address.ToString();
        }

        private void btn_supplier_insert_Click(object sender, EventArgs e)
        {
            supplier_table supplier = new supplier_table
            {
                company = tb_supplier_company.Text,
                person = tb_supplier_person.Text,
                rank = tb_supplier_rank.Text,
                phone_1 = tb_supplier_phone_1.Text,
                phone_2 = tb_supplier_phone_2.Text,
                address = tb_supplier_address.Text
            };

            db.supplier_table.Add(supplier);
            db.SaveChanges();
            MessageBox.Show("Tedarikçi Başarıyla Kaydedilmiştir.");
            suppliers();
            tb_supplier_clear();
        }

        private void btn_supplier_update_Click(object sender, EventArgs e)
        {
            var update = db.supplier_table.Find(supplierID);

            update.company = tb_supplier_company.Text;
            update.person = tb_supplier_person.Text;
            update.rank = tb_supplier_rank.Text;
            update.phone_1 = tb_supplier_phone_1.Text;
            update.phone_2 = tb_supplier_phone_2.Text;
            update.address = tb_supplier_address.Text;

            db.SaveChanges();
            MessageBox.Show("Tedarikçi Başarıyla Güncellenmiştir.");
            suppliers();
            tb_supplier_clear();
        }

        private void btn_supplier_delete_Click(object sender, EventArgs e)
        {
            var delete = db.supplier_table.Find(supplierID);
            
            db.supplier_table.Remove(delete);

            db.SaveChanges();
            MessageBox.Show("Tedarikçi Başarıyla Silinmiştir.");
            suppliers();
            tb_supplier_clear();
        }

        private void tb_supplier_like_company_TextChanged(object sender, EventArgs e)
        {
            var query = from item in db.supplier_table
                        where item.company.Contains(tb_supplier_like_company.Text)
                        select new
                        {
                            ID = item.id,
                            Şirket = item.company,
                            Yetkili = item.person,
                            Yetkili_Görevi = item.rank,
                            Telefon1 = item.phone_1,
                            Telefon2 = item.phone_2
                        };

            datagrid_supplier.DataSource = query.ToList();
        }

        private void tb_supplier_like_person_TextChanged(object sender, EventArgs e)
        {
            var query = from item in db.supplier_table
                        where item.person.Contains(tb_supplier_like_person.Text)
                        select new
                        {
                            ID = item.id,
                            Şirket = item.company,
                            Yetkili = item.person,
                            Yetkili_Görevi = item.rank,
                            Telefon1 = item.phone_1,
                            Telefon2 = item.phone_2
                        };

            datagrid_supplier.DataSource = query.ToList();
        }
        // Supplier Ends Here

        // Worker Starts Here
        private void workers()
        {
            var query = from item in db.worker_table
                        select new
                        {
                            ID = item.id,
                            TC = item.identification,
                            AD_SOYAD = item.name_surname,
                            GÖREVİ = item.rank,
                            TELEFON = item.phone
                        };

            datagrid_worker.DataSource = query.ToList();
        }

        private void tb_worker_clear()
        {
            tb_worker_identification.Text = "";
            tb_worker_name_surname.Text = "";
            tb_worker_rank.Text = "";
            tb_worker_phone.Text = "";
            tb_worker_address.Text = "";
        }

        private void datagrid_worker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int GridID = e.RowIndex;

            DataGridViewRow selectedWorker = datagrid_worker.Rows[GridID];

            workerID = Convert.ToInt32(selectedWorker.Cells[0].Value.ToString());
            tb_worker_identification.Text = selectedWorker.Cells[1].Value.ToString();
            tb_worker_name_surname.Text = selectedWorker.Cells[2].Value.ToString();
            tb_worker_rank.Text = selectedWorker.Cells[3].Value.ToString();
            tb_worker_phone.Text = selectedWorker.Cells[4].Value.ToString();

            var query = (from item in db.worker_table
                         where item.id == workerID
                         select item).FirstOrDefault();

            tb_worker_address.Text = query.address.ToString();
        }

        private void btn_worker_insert_Click(object sender, EventArgs e)
        {
            worker_table worker = new worker_table
            {
                identification = tb_worker_identification.Text,
                name_surname = tb_worker_name_surname.Text,
                rank = tb_worker_rank.Text,
                phone = tb_worker_phone.Text,
                address = tb_worker_address.Text
            };

            db.worker_table.Add(worker);
            db.SaveChanges();
            MessageBox.Show("Çalışan Başarıyla Kaydedilmiştir.");
            workers();
            tb_worker_clear();
        }

        private void btn_worker_update_Click(object sender, EventArgs e)
        {
            var update = db.worker_table.Find(workerID);

            update.identification = tb_worker_identification.Text;
            update.name_surname = tb_worker_name_surname.Text;
            update.rank = tb_worker_rank.Text;
            update.phone = tb_worker_phone.Text;
            update.address = tb_worker_address.Text;

            db.SaveChanges();
            MessageBox.Show("Çalışan Başarıyla Güncellenmiştir.");
            workers();
            tb_worker_clear();
        }

        private void btn_worker_delete_Click(object sender, EventArgs e)
        {
            var delete = db.worker_table.Find(workerID);

            db.worker_table.Remove(delete);

            db.SaveChanges();
            MessageBox.Show("Çalışan Başarıyla Silinmiştir.");
            workers();
            tb_worker_clear();
        }

        private void tb_worker_like_identification_TextChanged(object sender, EventArgs e)
        {
            var query = from item in db.worker_table
                        where item.identification.Contains(tb_worker_like_identification.Text)
                        select new
                        {
                            ID = item.id,
                            TC = item.identification,
                            AD_SOYAD = item.name_surname,
                            GÖREVİ = item.rank,
                            TELEFON = item.phone
                        };

            datagrid_worker.DataSource = query.ToList();
        }

        private void tb_worker_like_name_surname_TextChanged(object sender, EventArgs e)
        {
            var query = from item in db.worker_table
                        where item.name_surname.Contains(tb_worker_like_name_surname.Text)
                        select new
                        {
                            ID = item.id,
                            TC = item.identification,
                            AD_SOYAD = item.name_surname,
                            GÖREVİ = item.rank,
                            TELEFON = item.phone
                        };

            datagrid_worker.DataSource = query.ToList();
        }

        private void Record_FormClosing(object sender, FormClosingEventArgs e)
        {
            Router router = new Router
            {
                AdminID = AdminID
            };

            this.Hide();
            router.Show();
        }
        // Worker Ends Here
    }
}