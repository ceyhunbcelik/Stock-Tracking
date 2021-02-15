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
            supplies();
            intakes();
            products();
            suppliers();
            workers();
        }

        // Supply - List All Supply
        private void supplies()
        {
            try
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
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Supply - Search Supply by Code
        private void tb_supply_like_code_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Supply - Search Supply by Company 
        private void tb_supply_like_company_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------------------------------------------------------------

        // Intake - List All Intake
        private void intakes()
        {
            try
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
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Intake - Search Intake by Code
        private void tb_intake_like_code_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Intake - Search Intake by Identification
        private void tb_intake_like_identification_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------------------------------------------------------------

        // Product - List All Product
        private void products()
        {
            try
            {
                var query = from item in db.product_table
                            select new
                            {
                                ID = item.id,
                                KOD = item.code,
                                MARKA = item.brand,
                                MODEL = item.model
                            };

                datagrid_product.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Product - Show Stock by MessageBox
        private void datagrid_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int GridID = e.RowIndex;

                DataGridViewRow selectedProduct = datagrid_product.Rows[GridID];

                int productID = Convert.ToInt32(selectedProduct.Cells[0].Value.ToString());

                // PRODUCT SUPPLY AMOUNT
                var product_supply = db.supply_table.Where(p => p.product_id == productID).Sum(p => p.amount);
                int total_supply = Convert.ToInt32(product_supply);

                // PRODUCT INTAKE AMOUNT
                var product_intake = db.intake_table.Where(p => p.product_id == productID).Sum(p => p.amount);
                int total_intake = Convert.ToInt32(product_intake);

                int result = total_supply - total_intake;

                MessageBox.Show("STOK: " + result, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Teknik bir hata oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Product - Search Product by Code
        private void tb_product_like_code_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from item in db.product_table
                            where item.code.Contains(tb_product_like_code.Text)
                            select new
                            {
                                ID = item.id,
                                KOD = item.code,
                                MARKA = item.brand,
                                MODEL = item.model
                            };

                datagrid_product.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Product - Search Product by Brand
        private void tb_product_like_brand_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from item in db.product_table
                            where item.brand.Contains(tb_product_like_brand.Text)
                            select new
                            {
                                ID = item.id,
                                KOD = item.code,
                                MARKA = item.brand,
                                MODEL = item.model
                            };

                datagrid_product.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------------------------------------------------------------

        // Supplier - List All Suppliers
        private void suppliers()
        {
            try
            {
                var query = from item in db.supplier_table
                            select new
                            {
                                ŞİRKET = item.company,
                                YETKİLİ = item.person,
                                YETKİLİ_GÖREVİ = item.rank,
                                TELEFON1 = item.phone_1,
                                TELEFON2 = item.phone_2
                            };

                datagrid_supplier.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Supplier - Search Supplier by Company
        private void tb_supplier_like_company_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from item in db.supplier_table
                            where item.company.Contains(tb_supplier_like_company.Text)
                            select new
                            {
                                ŞİRKET = item.company,
                                YETKİLİ = item.person,
                                YETKİLİ_GÖREVİ = item.rank,
                                TELEFON1 = item.phone_1,
                                TELEFON2 = item.phone_2
                            };

                datagrid_supplier.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Supplier - Search Supplier by Person
        private void tb_supplier_like_person_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from item in db.supplier_table
                            where item.person.Contains(tb_supplier_like_person.Text)
                            select new
                            {
                                ŞİRKET = item.company,
                                YETKİLİ = item.person,
                                YETKİLİ_GÖREVİ = item.rank,
                                TELEFON1 = item.phone_1,
                                TELEFON2 = item.phone_2
                            };

                datagrid_supplier.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------------------------------------------------------------

        // Worker - List All Worker
        private void workers()
        {
            try
            {
                var query = from item in db.worker_table
                            select new
                            {
                                TC = item.identification,
                                AD_SOYAD = item.name_surname,
                                GÖREVİ = item.rank,
                                TELEFON = item.phone
                            };

                datagrid_worker.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Worker - Search Worker by Identification
        private void tb_worker_like_identification_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from item in db.worker_table
                            where item.identification.Contains(tb_worker_like_identification.Text)
                            select new
                            {
                                TC = item.identification,
                                AD_SOYAD = item.name_surname,
                                GÖREVİ = item.rank,
                                TELEFON = item.phone
                            };

                datagrid_worker.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Worker - Search Worker by Name Surname
        private void tb_worker_like_name_surname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from item in db.worker_table
                            where item.name_surname.Contains(tb_worker_like_name_surname.Text)
                            select new
                            {
                                TC = item.identification,
                                AD_SOYAD = item.name_surname,
                                GÖREVİ = item.rank,
                                TELEFON = item.phone
                            };

                datagrid_worker.DataSource = query.ToList();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanılamadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------------------------------------------------------------


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Router router = new Router
            {
                AdminID = AdminID
            };

            this.Hide();
            router.Show();
        }
        // KeyPress - SUPPLY LIKE CODE
        private void tb_supply_like_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        // KeyPress - SUPPLY LIKE COMPANY
        private void tb_supply_like_company_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        // KeyPress - INTAKE LIKE CODE
        private void tb_intake_like_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        // KeyPress - INTAKE LIKE IDENTIFICATION
        private void tb_intake_like_identification_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        // KeyPress - PRODUCT LIKE CODE
        private void tb_product_like_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        // KeyPress - PRODUCT LIKE BRAND
        private void tb_product_like_brand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        // KeyPress - SUPPLIER LIKE COMPANY
        private void tb_supplier_like_company_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        // KeyPress - SUPPLIER LIKE PERSON
        private void tb_supplier_like_person_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        // KeyPress - WORKER LIKE IDENTIFICATION
        private void tb_worker_like_identification_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        // KeyPress - WORKER LIKE NAME SURNAME
        private void tb_worker_like_name_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
