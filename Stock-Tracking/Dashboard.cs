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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_product_insert_Click(object sender, EventArgs e)
        {
            product_table product = new product_table();

            product.code = tb_product_code.Text;
            product.brand = tb_product_brand.Text;
            product.model = tb_product_model.Text;
            product.description = tb_product_description.Text;

            db.product_table.Add(product);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedilmiştir");
        }
    }
}
