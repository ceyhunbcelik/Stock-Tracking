﻿
namespace Stock_Tracking
{
    partial class Record
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_product_like_model = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_product_like_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_product_delete = new System.Windows.Forms.Button();
            this.btn_product_update = new System.Windows.Forms.Button();
            this.btn_product_insert = new System.Windows.Forms.Button();
            this.tb_product_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_product_model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_product_brand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_product_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_product = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_supplier_like_person = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_supplier_like_company = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.datagrid_supplier = new System.Windows.Forms.DataGridView();
            this.btn_supplier_delete = new System.Windows.Forms.Button();
            this.btn_supplier_update = new System.Windows.Forms.Button();
            this.btn_supplier_insert = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_supplier_phone_2 = new System.Windows.Forms.MaskedTextBox();
            this.tb_supplier_phone_1 = new System.Windows.Forms.MaskedTextBox();
            this.tb_supplier_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_supplier_rank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_supplier_person = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_supplier_company = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tb_worker_identification = new System.Windows.Forms.MaskedTextBox();
            this.tb_worker_like_name_surname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_worker_like_identification = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.datagrid_worker = new System.Windows.Forms.DataGridView();
            this.btn_worker_delete = new System.Windows.Forms.Button();
            this.btn_worker_update = new System.Windows.Forms.Button();
            this.btn_worker_insert = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_worker_phone = new System.Windows.Forms.MaskedTextBox();
            this.tb_worker_address = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_worker_rank = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_worker_name_surname = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_product)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_supplier)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_worker)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_product_like_model);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tb_product_like_code);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btn_product_delete);
            this.tabPage2.Controls.Add(this.btn_product_update);
            this.tabPage2.Controls.Add(this.btn_product_insert);
            this.tabPage2.Controls.Add(this.tb_product_description);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_product_model);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_product_brand);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_product_code);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.datagrid_product);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ÜRÜNLER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_product_like_model
            // 
            this.tb_product_like_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_product_like_model.Location = new System.Drawing.Point(497, 8);
            this.tb_product_like_model.Name = "tb_product_like_model";
            this.tb_product_like_model.Size = new System.Drawing.Size(232, 24);
            this.tb_product_like_model.TabIndex = 16;
            this.tb_product_like_model.TextChanged += new System.EventHandler(this.tb_product_like_model_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(358, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "MODELE GÖRE:";
            // 
            // tb_product_like_code
            // 
            this.tb_product_like_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_product_like_code.Location = new System.Drawing.Point(124, 8);
            this.tb_product_like_code.Name = "tb_product_like_code";
            this.tb_product_like_code.Size = new System.Drawing.Size(228, 24);
            this.tb_product_like_code.TabIndex = 14;
            this.tb_product_like_code.TextChanged += new System.EventHandler(this.tb_product_like_code_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "KODA GÖRE:";
            // 
            // btn_product_delete
            // 
            this.btn_product_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_product_delete.Location = new System.Drawing.Point(735, 424);
            this.btn_product_delete.Name = "btn_product_delete";
            this.btn_product_delete.Size = new System.Drawing.Size(228, 27);
            this.btn_product_delete.TabIndex = 11;
            this.btn_product_delete.Text = "SİL";
            this.btn_product_delete.UseVisualStyleBackColor = true;
            this.btn_product_delete.Click += new System.EventHandler(this.btn_product_delete_Click);
            // 
            // btn_product_update
            // 
            this.btn_product_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_product_update.Location = new System.Drawing.Point(735, 391);
            this.btn_product_update.Name = "btn_product_update";
            this.btn_product_update.Size = new System.Drawing.Size(228, 27);
            this.btn_product_update.TabIndex = 10;
            this.btn_product_update.Text = "GÜNCELLE";
            this.btn_product_update.UseVisualStyleBackColor = true;
            this.btn_product_update.Click += new System.EventHandler(this.btn_product_update_Click);
            // 
            // btn_product_insert
            // 
            this.btn_product_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_product_insert.Location = new System.Drawing.Point(735, 358);
            this.btn_product_insert.Name = "btn_product_insert";
            this.btn_product_insert.Size = new System.Drawing.Size(228, 27);
            this.btn_product_insert.TabIndex = 9;
            this.btn_product_insert.Text = "EKLE";
            this.btn_product_insert.UseVisualStyleBackColor = true;
            this.btn_product_insert.Click += new System.EventHandler(this.btn_product_insert_Click);
            // 
            // tb_product_description
            // 
            this.tb_product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_product_description.Location = new System.Drawing.Point(735, 176);
            this.tb_product_description.Multiline = true;
            this.tb_product_description.Name = "tb_product_description";
            this.tb_product_description.Size = new System.Drawing.Size(228, 176);
            this.tb_product_description.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(735, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "AÇIKLAMA";
            // 
            // tb_product_model
            // 
            this.tb_product_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_product_model.Location = new System.Drawing.Point(735, 126);
            this.tb_product_model.Name = "tb_product_model";
            this.tb_product_model.Size = new System.Drawing.Size(228, 24);
            this.tb_product_model.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(735, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "MODEL";
            // 
            // tb_product_brand
            // 
            this.tb_product_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_product_brand.Location = new System.Drawing.Point(735, 76);
            this.tb_product_brand.Name = "tb_product_brand";
            this.tb_product_brand.Size = new System.Drawing.Size(228, 24);
            this.tb_product_brand.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(735, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "MARKA";
            // 
            // tb_product_code
            // 
            this.tb_product_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_product_code.Location = new System.Drawing.Point(735, 26);
            this.tb_product_code.Name = "tb_product_code";
            this.tb_product_code.Size = new System.Drawing.Size(228, 24);
            this.tb_product_code.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(735, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "KOD";
            // 
            // datagrid_product
            // 
            this.datagrid_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_product.Location = new System.Drawing.Point(0, 38);
            this.datagrid_product.Name = "datagrid_product";
            this.datagrid_product.Size = new System.Drawing.Size(729, 413);
            this.datagrid_product.TabIndex = 0;
            this.datagrid_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_product_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_supplier_like_person);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tb_supplier_like_company);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.datagrid_supplier);
            this.tabPage3.Controls.Add(this.btn_supplier_delete);
            this.tabPage3.Controls.Add(this.btn_supplier_update);
            this.tabPage3.Controls.Add(this.btn_supplier_insert);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tb_supplier_phone_2);
            this.tabPage3.Controls.Add(this.tb_supplier_phone_1);
            this.tabPage3.Controls.Add(this.tb_supplier_address);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tb_supplier_rank);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tb_supplier_person);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.tb_supplier_company);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(972, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TEDARİKÇİLER";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_supplier_like_person
            // 
            this.tb_supplier_like_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_like_person.Location = new System.Drawing.Point(511, 8);
            this.tb_supplier_like_person.Name = "tb_supplier_like_person";
            this.tb_supplier_like_person.Size = new System.Drawing.Size(218, 24);
            this.tb_supplier_like_person.TabIndex = 28;
            this.tb_supplier_like_person.TextChanged += new System.EventHandler(this.tb_supplier_like_person_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(358, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "YETKİLİYE GÖRE:";
            // 
            // tb_supplier_like_company
            // 
            this.tb_supplier_like_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_like_company.Location = new System.Drawing.Point(148, 8);
            this.tb_supplier_like_company.Name = "tb_supplier_like_company";
            this.tb_supplier_like_company.Size = new System.Drawing.Size(204, 24);
            this.tb_supplier_like_company.TabIndex = 26;
            this.tb_supplier_like_company.TextChanged += new System.EventHandler(this.tb_supplier_like_company_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(8, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "ŞİRKETE GÖRE:";
            // 
            // datagrid_supplier
            // 
            this.datagrid_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_supplier.Location = new System.Drawing.Point(0, 38);
            this.datagrid_supplier.Name = "datagrid_supplier";
            this.datagrid_supplier.Size = new System.Drawing.Size(729, 413);
            this.datagrid_supplier.TabIndex = 24;
            this.datagrid_supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_supplier_CellClick);
            // 
            // btn_supplier_delete
            // 
            this.btn_supplier_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_supplier_delete.Location = new System.Drawing.Point(735, 424);
            this.btn_supplier_delete.Name = "btn_supplier_delete";
            this.btn_supplier_delete.Size = new System.Drawing.Size(228, 27);
            this.btn_supplier_delete.TabIndex = 23;
            this.btn_supplier_delete.Text = "SİL";
            this.btn_supplier_delete.UseVisualStyleBackColor = true;
            this.btn_supplier_delete.Click += new System.EventHandler(this.btn_supplier_delete_Click);
            // 
            // btn_supplier_update
            // 
            this.btn_supplier_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_supplier_update.Location = new System.Drawing.Point(735, 391);
            this.btn_supplier_update.Name = "btn_supplier_update";
            this.btn_supplier_update.Size = new System.Drawing.Size(228, 27);
            this.btn_supplier_update.TabIndex = 22;
            this.btn_supplier_update.Text = "GÜNCELLE";
            this.btn_supplier_update.UseVisualStyleBackColor = true;
            this.btn_supplier_update.Click += new System.EventHandler(this.btn_supplier_update_Click);
            // 
            // btn_supplier_insert
            // 
            this.btn_supplier_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_supplier_insert.Location = new System.Drawing.Point(735, 358);
            this.btn_supplier_insert.Name = "btn_supplier_insert";
            this.btn_supplier_insert.Size = new System.Drawing.Size(228, 27);
            this.btn_supplier_insert.TabIndex = 21;
            this.btn_supplier_insert.Text = "EKLE";
            this.btn_supplier_insert.UseVisualStyleBackColor = true;
            this.btn_supplier_insert.Click += new System.EventHandler(this.btn_supplier_insert_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(735, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Telefon(2)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(735, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Telefon(1)";
            // 
            // tb_supplier_phone_2
            // 
            this.tb_supplier_phone_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_phone_2.Location = new System.Drawing.Point(735, 226);
            this.tb_supplier_phone_2.Mask = "(999) 000-0000";
            this.tb_supplier_phone_2.Name = "tb_supplier_phone_2";
            this.tb_supplier_phone_2.Size = new System.Drawing.Size(228, 24);
            this.tb_supplier_phone_2.TabIndex = 18;
            // 
            // tb_supplier_phone_1
            // 
            this.tb_supplier_phone_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_phone_1.Location = new System.Drawing.Point(735, 176);
            this.tb_supplier_phone_1.Mask = "(999) 000-0000";
            this.tb_supplier_phone_1.Name = "tb_supplier_phone_1";
            this.tb_supplier_phone_1.Size = new System.Drawing.Size(228, 24);
            this.tb_supplier_phone_1.TabIndex = 17;
            // 
            // tb_supplier_address
            // 
            this.tb_supplier_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_address.Location = new System.Drawing.Point(735, 276);
            this.tb_supplier_address.Multiline = true;
            this.tb_supplier_address.Name = "tb_supplier_address";
            this.tb_supplier_address.Size = new System.Drawing.Size(228, 76);
            this.tb_supplier_address.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(735, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "ADRES";
            // 
            // tb_supplier_rank
            // 
            this.tb_supplier_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_rank.Location = new System.Drawing.Point(735, 126);
            this.tb_supplier_rank.Name = "tb_supplier_rank";
            this.tb_supplier_rank.Size = new System.Drawing.Size(228, 24);
            this.tb_supplier_rank.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(735, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "ÜNVAN";
            // 
            // tb_supplier_person
            // 
            this.tb_supplier_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_person.Location = new System.Drawing.Point(735, 76);
            this.tb_supplier_person.Name = "tb_supplier_person";
            this.tb_supplier_person.Size = new System.Drawing.Size(228, 24);
            this.tb_supplier_person.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(735, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "YETKİLİ";
            // 
            // tb_supplier_company
            // 
            this.tb_supplier_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier_company.Location = new System.Drawing.Point(735, 26);
            this.tb_supplier_company.Name = "tb_supplier_company";
            this.tb_supplier_company.Size = new System.Drawing.Size(228, 24);
            this.tb_supplier_company.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(735, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "ŞİRKET";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tb_worker_identification);
            this.tabPage4.Controls.Add(this.tb_worker_like_name_surname);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.tb_worker_like_identification);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.datagrid_worker);
            this.tabPage4.Controls.Add(this.btn_worker_delete);
            this.tabPage4.Controls.Add(this.btn_worker_update);
            this.tabPage4.Controls.Add(this.btn_worker_insert);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.tb_worker_phone);
            this.tabPage4.Controls.Add(this.tb_worker_address);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.tb_worker_rank);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.tb_worker_name_surname);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(972, 458);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ÇALIŞANLAR";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tb_worker_identification
            // 
            this.tb_worker_identification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_worker_identification.Location = new System.Drawing.Point(735, 26);
            this.tb_worker_identification.Mask = "00000000000";
            this.tb_worker_identification.Name = "tb_worker_identification";
            this.tb_worker_identification.Size = new System.Drawing.Size(228, 24);
            this.tb_worker_identification.TabIndex = 49;
            // 
            // tb_worker_like_name_surname
            // 
            this.tb_worker_like_name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_worker_like_name_surname.Location = new System.Drawing.Point(490, 8);
            this.tb_worker_like_name_surname.Name = "tb_worker_like_name_surname";
            this.tb_worker_like_name_surname.Size = new System.Drawing.Size(239, 24);
            this.tb_worker_like_name_surname.TabIndex = 48;
            this.tb_worker_like_name_surname.TextChanged += new System.EventHandler(this.tb_worker_like_name_surname_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(339, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "ÇALIŞANA GÖRE:";
            // 
            // tb_worker_like_identification
            // 
            this.tb_worker_like_identification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_worker_like_identification.Location = new System.Drawing.Point(129, 8);
            this.tb_worker_like_identification.Name = "tb_worker_like_identification";
            this.tb_worker_like_identification.Size = new System.Drawing.Size(204, 24);
            this.tb_worker_like_identification.TabIndex = 46;
            this.tb_worker_like_identification.TextChanged += new System.EventHandler(this.tb_worker_like_identification_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(8, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "T.C YE GÖRE:";
            // 
            // datagrid_worker
            // 
            this.datagrid_worker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_worker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_worker.Location = new System.Drawing.Point(0, 38);
            this.datagrid_worker.Name = "datagrid_worker";
            this.datagrid_worker.Size = new System.Drawing.Size(729, 413);
            this.datagrid_worker.TabIndex = 44;
            this.datagrid_worker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_worker_CellClick);
            // 
            // btn_worker_delete
            // 
            this.btn_worker_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_worker_delete.Location = new System.Drawing.Point(735, 424);
            this.btn_worker_delete.Name = "btn_worker_delete";
            this.btn_worker_delete.Size = new System.Drawing.Size(228, 27);
            this.btn_worker_delete.TabIndex = 43;
            this.btn_worker_delete.Text = "SİL";
            this.btn_worker_delete.UseVisualStyleBackColor = true;
            this.btn_worker_delete.Click += new System.EventHandler(this.btn_worker_delete_Click);
            // 
            // btn_worker_update
            // 
            this.btn_worker_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_worker_update.Location = new System.Drawing.Point(735, 391);
            this.btn_worker_update.Name = "btn_worker_update";
            this.btn_worker_update.Size = new System.Drawing.Size(228, 27);
            this.btn_worker_update.TabIndex = 42;
            this.btn_worker_update.Text = "GÜNCELLE";
            this.btn_worker_update.UseVisualStyleBackColor = true;
            this.btn_worker_update.Click += new System.EventHandler(this.btn_worker_update_Click);
            // 
            // btn_worker_insert
            // 
            this.btn_worker_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_worker_insert.Location = new System.Drawing.Point(735, 358);
            this.btn_worker_insert.Name = "btn_worker_insert";
            this.btn_worker_insert.Size = new System.Drawing.Size(228, 27);
            this.btn_worker_insert.TabIndex = 41;
            this.btn_worker_insert.Text = "EKLE";
            this.btn_worker_insert.UseVisualStyleBackColor = true;
            this.btn_worker_insert.Click += new System.EventHandler(this.btn_worker_insert_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(735, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 20);
            this.label18.TabIndex = 39;
            this.label18.Text = "Telefon";
            // 
            // tb_worker_phone
            // 
            this.tb_worker_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_worker_phone.Location = new System.Drawing.Point(735, 176);
            this.tb_worker_phone.Mask = "(999) 000-0000";
            this.tb_worker_phone.Name = "tb_worker_phone";
            this.tb_worker_phone.Size = new System.Drawing.Size(228, 24);
            this.tb_worker_phone.TabIndex = 37;
            // 
            // tb_worker_address
            // 
            this.tb_worker_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_worker_address.Location = new System.Drawing.Point(735, 226);
            this.tb_worker_address.Multiline = true;
            this.tb_worker_address.Name = "tb_worker_address";
            this.tb_worker_address.Size = new System.Drawing.Size(228, 126);
            this.tb_worker_address.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(735, 203);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "ADRES";
            // 
            // tb_worker_rank
            // 
            this.tb_worker_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_worker_rank.Location = new System.Drawing.Point(735, 126);
            this.tb_worker_rank.Name = "tb_worker_rank";
            this.tb_worker_rank.Size = new System.Drawing.Size(228, 24);
            this.tb_worker_rank.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(735, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 20);
            this.label20.TabIndex = 33;
            this.label20.Text = "ÜNVAN";
            // 
            // tb_worker_name_surname
            // 
            this.tb_worker_name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_worker_name_surname.Location = new System.Drawing.Point(735, 76);
            this.tb_worker_name_surname.Name = "tb_worker_name_surname";
            this.tb_worker_name_surname.Size = new System.Drawing.Size(228, 24);
            this.tb_worker_name_surname.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(735, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 20);
            this.label21.TabIndex = 31;
            this.label21.Text = "AD SOYAD";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(735, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 20);
            this.label22.TabIndex = 29;
            this.label22.Text = "T.C KİMLİK";
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "Record";
            this.Text = "KAYIT PANELİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Record_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_product)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_supplier)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_worker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView datagrid_product;
        private System.Windows.Forms.TextBox tb_product_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_product_model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_product_brand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_product_like_model;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_product_like_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_product_delete;
        private System.Windows.Forms.Button btn_product_update;
        private System.Windows.Forms.Button btn_product_insert;
        private System.Windows.Forms.TextBox tb_product_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_supplier_delete;
        private System.Windows.Forms.Button btn_supplier_update;
        private System.Windows.Forms.Button btn_supplier_insert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox tb_supplier_phone_2;
        private System.Windows.Forms.MaskedTextBox tb_supplier_phone_1;
        private System.Windows.Forms.TextBox tb_supplier_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_supplier_rank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_supplier_person;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_supplier_company;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_supplier_like_person;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_supplier_like_company;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView datagrid_supplier;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tb_worker_like_name_surname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_worker_like_identification;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView datagrid_worker;
        private System.Windows.Forms.Button btn_worker_delete;
        private System.Windows.Forms.Button btn_worker_update;
        private System.Windows.Forms.Button btn_worker_insert;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox tb_worker_phone;
        private System.Windows.Forms.TextBox tb_worker_address;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_worker_rank;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_worker_name_surname;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox tb_worker_identification;
    }
}
