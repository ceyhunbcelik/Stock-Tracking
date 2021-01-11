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
    public partial class Dashboards : Form
    {
        DB_Factory_Stock db = new DB_Factory_Stock();
        public Dashboards()
        {
            InitializeComponent();
        }

        private void Dashboards_Load(object sender, EventArgs e)
        {
            stocks();
            supply();
            intake();
        }

        // Stock Starts Here
        private void stocks()
        {
            var query = from item_stock in db.stock_table
                        join item_product in db.product_table
                        on item_stock.product_id equals item_product.id
                        select new
                        {
                            KOD = item_product.code,
                            MİKTAR = item_stock.amount
                            //ÜRÜN_ID = item_stock.product_id
                        };

            datagrid_stock.DataSource = query.ToList();
        }
        // Stock Ends Here

        // Supply Starts Here
        private void supply()
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
                            ŞİRKET = item_supplier.company,
                            MİKTAR = item_supply.amount,
                            FİYAT = item_supply.price + "₺",
                            ADMIN = item_worker.name_surname,
                            TARİH = item_supply.transaction_date
                            //TEDARİK_ID = item_supply.id
                        };

            datagrid_supply.DataSource = query.ToList();
        }
        // Supply Ends Here

        // Intake Starts Here
        private void intake()
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
                            ÇALIŞAN = item_worker.name_surname,
                            ADMIN = item_admin.name_surname,
                            MİKTAR = item_intake.amount,
                            TARİH = item_intake.intake_date
                        };

            datagrid_intake.DataSource = query.ToList();
        }
        // Intake Ends Here
    }
}
