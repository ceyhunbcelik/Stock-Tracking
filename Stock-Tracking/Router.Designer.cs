
namespace Stock_Tracking
{
    partial class Router
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
            this.btn_router_admin = new System.Windows.Forms.Button();
            this.btn_router_dashboard = new System.Windows.Forms.Button();
            this.btn_router_record = new System.Windows.Forms.Button();
            this.btn_router_transfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_router_admin
            // 
            this.btn_router_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_router_admin.Location = new System.Drawing.Point(158, 74);
            this.btn_router_admin.Name = "btn_router_admin";
            this.btn_router_admin.Size = new System.Drawing.Size(140, 56);
            this.btn_router_admin.TabIndex = 5;
            this.btn_router_admin.Text = "ADMİN";
            this.btn_router_admin.UseVisualStyleBackColor = true;
            this.btn_router_admin.Click += new System.EventHandler(this.btn_router_admin_Click);
            // 
            // btn_router_dashboard
            // 
            this.btn_router_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_router_dashboard.Location = new System.Drawing.Point(12, 12);
            this.btn_router_dashboard.Name = "btn_router_dashboard";
            this.btn_router_dashboard.Size = new System.Drawing.Size(140, 56);
            this.btn_router_dashboard.TabIndex = 4;
            this.btn_router_dashboard.Text = "LİSTE";
            this.btn_router_dashboard.UseVisualStyleBackColor = true;
            this.btn_router_dashboard.Click += new System.EventHandler(this.btn_router_dashboard_Click);
            // 
            // btn_router_record
            // 
            this.btn_router_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_router_record.Location = new System.Drawing.Point(12, 74);
            this.btn_router_record.Name = "btn_router_record";
            this.btn_router_record.Size = new System.Drawing.Size(140, 56);
            this.btn_router_record.TabIndex = 3;
            this.btn_router_record.Text = "KAYIT";
            this.btn_router_record.UseVisualStyleBackColor = true;
            this.btn_router_record.Click += new System.EventHandler(this.btn_router_record_Click);
            // 
            // btn_router_transfer
            // 
            this.btn_router_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_router_transfer.Location = new System.Drawing.Point(158, 12);
            this.btn_router_transfer.Name = "btn_router_transfer";
            this.btn_router_transfer.Size = new System.Drawing.Size(140, 56);
            this.btn_router_transfer.TabIndex = 6;
            this.btn_router_transfer.Text = "TRANSFER";
            this.btn_router_transfer.UseVisualStyleBackColor = true;
            this.btn_router_transfer.Click += new System.EventHandler(this.btn_router_transfer_Click);
            // 
            // Router
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 144);
            this.Controls.Add(this.btn_router_transfer);
            this.Controls.Add(this.btn_router_admin);
            this.Controls.Add(this.btn_router_dashboard);
            this.Controls.Add(this.btn_router_record);
            this.Name = "Router";
            this.Text = "Router";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Router_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_router_admin;
        private System.Windows.Forms.Button btn_router_dashboard;
        private System.Windows.Forms.Button btn_router_record;
        private System.Windows.Forms.Button btn_router_transfer;
    }
}