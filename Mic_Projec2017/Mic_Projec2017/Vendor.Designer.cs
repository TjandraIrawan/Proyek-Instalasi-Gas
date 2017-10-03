namespace Mic_Projec2017
{
    partial class Vendor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Mstr_Vendor = new System.Windows.Forms.TabPage();
            this.Tab_Pembelian = new System.Windows.Forms.TabPage();
            this.Tab_Laporan = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.Tab_Mstr_Vendor);
            this.tabControl1.Controls.Add(this.Tab_Pembelian);
            this.tabControl1.Controls.Add(this.Tab_Laporan);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 900);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_Mstr_Vendor
            // 
            this.Tab_Mstr_Vendor.Location = new System.Drawing.Point(4, 32);
            this.Tab_Mstr_Vendor.Name = "Tab_Mstr_Vendor";
            this.Tab_Mstr_Vendor.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Mstr_Vendor.Size = new System.Drawing.Size(1192, 864);
            this.Tab_Mstr_Vendor.TabIndex = 0;
            this.Tab_Mstr_Vendor.Text = "Master Vendor";
            this.Tab_Mstr_Vendor.UseVisualStyleBackColor = true;
            // 
            // Tab_Pembelian
            // 
            this.Tab_Pembelian.Location = new System.Drawing.Point(4, 32);
            this.Tab_Pembelian.Name = "Tab_Pembelian";
            this.Tab_Pembelian.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Pembelian.Size = new System.Drawing.Size(1192, 864);
            this.Tab_Pembelian.TabIndex = 1;
            this.Tab_Pembelian.Text = "Pembelian";
            this.Tab_Pembelian.UseVisualStyleBackColor = true;
            // 
            // Tab_Laporan
            // 
            this.Tab_Laporan.Location = new System.Drawing.Point(4, 32);
            this.Tab_Laporan.Name = "Tab_Laporan";
            this.Tab_Laporan.Size = new System.Drawing.Size(1192, 864);
            this.Tab_Laporan.TabIndex = 2;
            this.Tab_Laporan.Text = "Laporan";
            this.Tab_Laporan.UseVisualStyleBackColor = true;
            // 
            // Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Vendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vendor_FormClosed);
            this.Load += new System.EventHandler(this.Vendor_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Tab_Mstr_Vendor;
        private System.Windows.Forms.TabPage Tab_Pembelian;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_Laporan;
    }
}