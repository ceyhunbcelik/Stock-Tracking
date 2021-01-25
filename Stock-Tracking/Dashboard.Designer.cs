
namespace Stock_Tracking
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tb_worker_like_name_surname = new System.Windows.Forms.TextBox();
            this.tb_worker_like_identification = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.datagrid_worker = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tb_supplier_like_person = new System.Windows.Forms.TextBox();
            this.tb_supplier_like_company = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.datagrid_supplier = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tb_product_like_brand = new System.Windows.Forms.TextBox();
            this.tb_product_like_code = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.datagrid_product = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_intake_like_identification = new System.Windows.Forms.TextBox();
            this.tb_intake_like_code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.datagrid_intake = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_supply_like_company = new System.Windows.Forms.TextBox();
            this.tb_supply_like_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.datagrid_supply = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_worker)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_supplier)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_product)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_intake)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_supply)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Black;
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.groupBox11);
            this.tabPage6.Controls.Add(this.groupBox12);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1003, 524);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "ÇALIŞANLAR LİSTESİ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(11, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 18);
            this.label14.TabIndex = 69;
            this.label14.Text = "ÇALIŞANLAR";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.tb_worker_like_name_surname);
            this.groupBox11.Controls.Add(this.tb_worker_like_identification);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(8, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(986, 58);
            this.groupBox11.TabIndex = 68;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "ARAMA";
            // 
            // tb_worker_like_name_surname
            // 
            this.tb_worker_like_name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_worker_like_name_surname.Location = new System.Drawing.Point(564, 19);
            this.tb_worker_like_name_surname.Name = "tb_worker_like_name_surname";
            this.tb_worker_like_name_surname.Size = new System.Drawing.Size(416, 24);
            this.tb_worker_like_name_surname.TabIndex = 2;
            this.tb_worker_like_name_surname.TextChanged += new System.EventHandler(this.tb_worker_like_name_surname_TextChanged);
            this.tb_worker_like_name_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_worker_like_name_surname_KeyPress);
            // 
            // tb_worker_like_identification
            // 
            this.tb_worker_like_identification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_worker_like_identification.Location = new System.Drawing.Point(48, 19);
            this.tb_worker_like_identification.Name = "tb_worker_like_identification";
            this.tb_worker_like_identification.Size = new System.Drawing.Size(398, 24);
            this.tb_worker_like_identification.TabIndex = 1;
            this.tb_worker_like_identification.TextChanged += new System.EventHandler(this.tb_worker_like_identification_TextChanged);
            this.tb_worker_like_identification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_worker_like_identification_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(452, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "AD SOYAD:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 20);
            this.label16.TabIndex = 64;
            this.label16.Text = "TC:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.datagrid_worker);
            this.groupBox12.ForeColor = System.Drawing.Color.Black;
            this.groupBox12.Location = new System.Drawing.Point(8, 101);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(986, 417);
            this.groupBox12.TabIndex = 67;
            this.groupBox12.TabStop = false;
            // 
            // datagrid_worker
            // 
            this.datagrid_worker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_worker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_worker.Location = new System.Drawing.Point(6, 19);
            this.datagrid_worker.Name = "datagrid_worker";
            this.datagrid_worker.Size = new System.Drawing.Size(974, 388);
            this.datagrid_worker.TabIndex = 56;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Black;
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1003, 524);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "TEDARİKÇİLER LİSTESİ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 18);
            this.label11.TabIndex = 69;
            this.label11.Text = "TEDARİKÇİLER";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tb_supplier_like_person);
            this.groupBox9.Controls.Add(this.tb_supplier_like_company);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(8, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(986, 58);
            this.groupBox9.TabIndex = 68;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "ARAMA";
            // 
            // tb_supplier_like_person
            // 
            this.tb_supplier_like_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_like_person.Location = new System.Drawing.Point(539, 19);
            this.tb_supplier_like_person.Name = "tb_supplier_like_person";
            this.tb_supplier_like_person.Size = new System.Drawing.Size(441, 24);
            this.tb_supplier_like_person.TabIndex = 2;
            this.tb_supplier_like_person.TextChanged += new System.EventHandler(this.tb_supplier_like_person_TextChanged);
            this.tb_supplier_like_person.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_supplier_like_person_KeyPress);
            // 
            // tb_supplier_like_company
            // 
            this.tb_supplier_like_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_like_company.Location = new System.Drawing.Point(90, 19);
            this.tb_supplier_like_company.Name = "tb_supplier_like_company";
            this.tb_supplier_like_company.Size = new System.Drawing.Size(356, 24);
            this.tb_supplier_like_company.TabIndex = 1;
            this.tb_supplier_like_company.TextChanged += new System.EventHandler(this.tb_supplier_like_company_TextChanged);
            this.tb_supplier_like_company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_supplier_like_company_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(452, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 66;
            this.label12.Text = "YETKİLİ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 64;
            this.label13.Text = "ŞİRKET:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.datagrid_supplier);
            this.groupBox10.ForeColor = System.Drawing.Color.Black;
            this.groupBox10.Location = new System.Drawing.Point(8, 101);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(986, 417);
            this.groupBox10.TabIndex = 67;
            this.groupBox10.TabStop = false;
            // 
            // datagrid_supplier
            // 
            this.datagrid_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_supplier.Location = new System.Drawing.Point(6, 19);
            this.datagrid_supplier.Name = "datagrid_supplier";
            this.datagrid_supplier.Size = new System.Drawing.Size(974, 388);
            this.datagrid_supplier.TabIndex = 56;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1003, 524);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ÜRÜNLER LİSTESİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 69;
            this.label8.Text = "STOKLAR";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tb_product_like_brand);
            this.groupBox7.Controls.Add(this.tb_product_like_code);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(8, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(986, 58);
            this.groupBox7.TabIndex = 68;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ARAMA";
            // 
            // tb_product_like_brand
            // 
            this.tb_product_like_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_product_like_brand.Location = new System.Drawing.Point(534, 19);
            this.tb_product_like_brand.Name = "tb_product_like_brand";
            this.tb_product_like_brand.Size = new System.Drawing.Size(446, 24);
            this.tb_product_like_brand.TabIndex = 2;
            this.tb_product_like_brand.TextChanged += new System.EventHandler(this.tb_product_like_brand_TextChanged);
            this.tb_product_like_brand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_product_like_brand_KeyPress);
            // 
            // tb_product_like_code
            // 
            this.tb_product_like_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_product_like_code.Location = new System.Drawing.Point(63, 19);
            this.tb_product_like_code.Name = "tb_product_like_code";
            this.tb_product_like_code.Size = new System.Drawing.Size(383, 24);
            this.tb_product_like_code.TabIndex = 1;
            this.tb_product_like_code.TextChanged += new System.EventHandler(this.tb_product_like_code_TextChanged);
            this.tb_product_like_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_product_like_code_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(452, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "MARKA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 64;
            this.label10.Text = "KOD:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.datagrid_product);
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(8, 101);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(986, 417);
            this.groupBox8.TabIndex = 67;
            this.groupBox8.TabStop = false;
            // 
            // datagrid_product
            // 
            this.datagrid_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_product.Location = new System.Drawing.Point(6, 19);
            this.datagrid_product.Name = "datagrid_product";
            this.datagrid_product.Size = new System.Drawing.Size(974, 388);
            this.datagrid_product.TabIndex = 56;
            this.datagrid_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_product_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1003, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ALIM LİSTESİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 69;
            this.label5.Text = "STOKLAR";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_intake_like_identification);
            this.groupBox5.Controls.Add(this.tb_intake_like_code);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(8, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(986, 58);
            this.groupBox5.TabIndex = 68;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ARAMA";
            // 
            // tb_intake_like_identification
            // 
            this.tb_intake_like_identification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_intake_like_identification.Location = new System.Drawing.Point(534, 19);
            this.tb_intake_like_identification.Name = "tb_intake_like_identification";
            this.tb_intake_like_identification.Size = new System.Drawing.Size(446, 24);
            this.tb_intake_like_identification.TabIndex = 2;
            this.tb_intake_like_identification.TextChanged += new System.EventHandler(this.tb_intake_like_identification_TextChanged);
            this.tb_intake_like_identification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_intake_like_identification_KeyPress);
            // 
            // tb_intake_like_code
            // 
            this.tb_intake_like_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_intake_like_code.Location = new System.Drawing.Point(63, 19);
            this.tb_intake_like_code.Name = "tb_intake_like_code";
            this.tb_intake_like_code.Size = new System.Drawing.Size(418, 24);
            this.tb_intake_like_code.TabIndex = 1;
            this.tb_intake_like_code.TextChanged += new System.EventHandler(this.tb_intake_like_code_TextChanged);
            this.tb_intake_like_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_intake_like_code_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(487, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "T.C:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "KOD:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.datagrid_intake);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(8, 101);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(986, 417);
            this.groupBox6.TabIndex = 67;
            this.groupBox6.TabStop = false;
            // 
            // datagrid_intake
            // 
            this.datagrid_intake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_intake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_intake.Location = new System.Drawing.Point(6, 19);
            this.datagrid_intake.Name = "datagrid_intake";
            this.datagrid_intake.Size = new System.Drawing.Size(974, 388);
            this.datagrid_intake.TabIndex = 56;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1003, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TEDARİK LİSTESİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "STOKLAR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_supply_like_company);
            this.groupBox3.Controls.Add(this.tb_supply_like_code);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(986, 58);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ARAMA";
            // 
            // tb_supply_like_company
            // 
            this.tb_supply_like_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supply_like_company.Location = new System.Drawing.Point(536, 19);
            this.tb_supply_like_company.Name = "tb_supply_like_company";
            this.tb_supply_like_company.Size = new System.Drawing.Size(444, 24);
            this.tb_supply_like_company.TabIndex = 2;
            this.tb_supply_like_company.TextChanged += new System.EventHandler(this.tb_supply_like_company_TextChanged);
            this.tb_supply_like_company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_supply_like_company_KeyPress);
            // 
            // tb_supply_like_code
            // 
            this.tb_supply_like_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supply_like_code.Location = new System.Drawing.Point(63, 19);
            this.tb_supply_like_code.Name = "tb_supply_like_code";
            this.tb_supply_like_code.Size = new System.Drawing.Size(383, 24);
            this.tb_supply_like_code.TabIndex = 1;
            this.tb_supply_like_code.TextChanged += new System.EventHandler(this.tb_supply_like_code_TextChanged);
            this.tb_supply_like_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_supply_like_code_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(452, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "ŞİRKET:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "KOD:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datagrid_supply);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(8, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(986, 417);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            // 
            // datagrid_supply
            // 
            this.datagrid_supply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_supply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_supply.Location = new System.Drawing.Point(6, 19);
            this.datagrid_supply.Name = "datagrid_supply";
            this.datagrid_supply.Size = new System.Drawing.Size(974, 388);
            this.datagrid_supply.TabIndex = 56;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1011, 548);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "GÖSTERGE PANELİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboards_Load);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_worker)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_supplier)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_product)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_intake)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_supply)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox tb_worker_like_name_surname;
        private System.Windows.Forms.TextBox tb_worker_like_identification;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DataGridView datagrid_worker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tb_supplier_like_person;
        private System.Windows.Forms.TextBox tb_supplier_like_company;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView datagrid_supplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tb_product_like_brand;
        private System.Windows.Forms.TextBox tb_product_like_code;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView datagrid_product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_intake_like_identification;
        private System.Windows.Forms.TextBox tb_intake_like_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView datagrid_intake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_supply_like_company;
        private System.Windows.Forms.TextBox tb_supply_like_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView datagrid_supply;
    }
}