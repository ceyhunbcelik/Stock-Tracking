
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
            this.tb_admin_username = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_admin_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_admin_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_admin_username
            // 
            this.tb_admin_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_admin_username.Location = new System.Drawing.Point(137, 126);
            this.tb_admin_username.Name = "tb_admin_username";
            this.tb_admin_username.Size = new System.Drawing.Size(228, 24);
            this.tb_admin_username.TabIndex = 54;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(3, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 20);
            this.label22.TabIndex = 53;
            this.label22.Text = "KULLANICI ADI:";
            // 
            // tb_admin_password
            // 
            this.tb_admin_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_admin_password.Location = new System.Drawing.Point(137, 156);
            this.tb_admin_password.Name = "tb_admin_password";
            this.tb_admin_password.Size = new System.Drawing.Size(228, 24);
            this.tb_admin_password.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "ŞİFRE:";
            // 
            // btn_admin_login
            // 
            this.btn_admin_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin_login.Location = new System.Drawing.Point(137, 186);
            this.btn_admin_login.Name = "btn_admin_login";
            this.btn_admin_login.Size = new System.Drawing.Size(228, 27);
            this.btn_admin_login.TabIndex = 60;
            this.btn_admin_login.Text = "GİRİŞ YAP";
            this.btn_admin_login.UseVisualStyleBackColor = true;
            this.btn_admin_login.Click += new System.EventHandler(this.btn_admin_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 316);
            this.Controls.Add(this.btn_admin_login);
            this.Controls.Add(this.tb_admin_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_admin_username);
            this.Controls.Add(this.label22);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_admin_username;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_admin_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin_login;
    }
}