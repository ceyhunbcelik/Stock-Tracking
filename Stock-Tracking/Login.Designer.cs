
namespace Stock_Tracking
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tb_admin_username = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_admin_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_admin_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_admin_username
            // 
            this.tb_admin_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_admin_username.Location = new System.Drawing.Point(12, 174);
            this.tb_admin_username.Name = "tb_admin_username";
            this.tb_admin_username.Size = new System.Drawing.Size(228, 24);
            this.tb_admin_username.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(9, 154);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 17);
            this.label22.TabIndex = 53;
            this.label22.Text = "KULLANICI ADI";
            // 
            // tb_admin_password
            // 
            this.tb_admin_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_admin_password.Location = new System.Drawing.Point(12, 221);
            this.tb_admin_password.Name = "tb_admin_password";
            this.tb_admin_password.PasswordChar = '*';
            this.tb_admin_password.Size = new System.Drawing.Size(228, 24);
            this.tb_admin_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "ŞİFRE";
            // 
            // btn_admin_login
            // 
            this.btn_admin_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_admin_login.BackgroundImage")));
            this.btn_admin_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_admin_login.FlatAppearance.BorderSize = 0;
            this.btn_admin_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin_login.Location = new System.Drawing.Point(88, 251);
            this.btn_admin_login.Name = "btn_admin_login";
            this.btn_admin_login.Size = new System.Drawing.Size(75, 75);
            this.btn_admin_login.TabIndex = 3;
            this.btn_admin_login.UseVisualStyleBackColor = true;
            this.btn_admin_login.Click += new System.EventHandler(this.btn_admin_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(253, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_admin_login);
            this.Controls.Add(this.tb_admin_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_admin_username);
            this.Controls.Add(this.label22);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ PANELİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_admin_username;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_admin_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}