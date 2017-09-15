namespace Mic_Projec2017
{
    partial class InvMain
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
            this.Tab_InvMaster = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Inv_Id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Inv_Nama = new System.Windows.Forms.TextBox();
            this.Txt_Inv_Hrg_Jual = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Txt_Qty_Beli = new System.Windows.Forms.TextBox();
            this.Txt_Nilai_Beli = new System.Windows.Forms.TextBox();
            this.Txt_Qty_Jual = new System.Windows.Forms.TextBox();
            this.Txt_Qty_Masuk = new System.Windows.Forms.TextBox();
            this.Txt_Qty_Keluar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_Nilai_Awal = new System.Windows.Forms.TextBox();
            this.Txt_Cogs_Awal = new System.Windows.Forms.TextBox();
            this.Txt_Qty_Awal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Tgl_Awal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_Nilai_Akhir = new System.Windows.Forms.TextBox();
            this.Txt_Cogs_Akhir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Qty_Akhir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Tgl_Akhir = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab_Pembelian = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Tab_InvMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.Tab_InvMaster);
            this.tabControl1.Controls.Add(this.Tab_Pembelian);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 900);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_InvMaster
            // 
            this.Tab_InvMaster.Controls.Add(this.dataGridView1);
            this.Tab_InvMaster.Controls.Add(this.Btn_cancel);
            this.Tab_InvMaster.Controls.Add(this.Btn_Save);
            this.Tab_InvMaster.Controls.Add(this.Btn_Delete);
            this.Tab_InvMaster.Controls.Add(this.Btn_Update);
            this.Tab_InvMaster.Controls.Add(this.Btn_New);
            this.Tab_InvMaster.Controls.Add(this.tableLayoutPanel2);
            this.Tab_InvMaster.Controls.Add(this.tableLayoutPanel1);
            this.Tab_InvMaster.Controls.Add(this.label1);
            this.Tab_InvMaster.Location = new System.Drawing.Point(4, 32);
            this.Tab_InvMaster.Name = "Tab_InvMaster";
            this.Tab_InvMaster.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_InvMaster.Size = new System.Drawing.Size(1192, 864);
            this.Tab_InvMaster.TabIndex = 1;
            this.Tab_InvMaster.Text = "Master";
            this.Tab_InvMaster.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(8, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 254);
            this.dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Nama Barang";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Kode Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga Jual";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qty Awal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Hrg Pokok Awal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_cancel.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_cancel.Location = new System.Drawing.Point(929, 322);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(137, 53);
            this.Btn_cancel.TabIndex = 22;
            this.Btn_cancel.Text = "Cancel";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Save.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Save.Location = new System.Drawing.Point(929, 263);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(137, 53);
            this.Btn_Save.TabIndex = 21;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Delete.Location = new System.Drawing.Point(929, 175);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(137, 53);
            this.Btn_Delete.TabIndex = 25;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Update.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Update.Location = new System.Drawing.Point(929, 116);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(137, 53);
            this.Btn_Update.TabIndex = 24;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            // 
            // Btn_New
            // 
            this.Btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_New.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_New.Location = new System.Drawing.Point(929, 58);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(137, 53);
            this.Btn_New.TabIndex = 23;
            this.Btn_New.Text = "New";
            this.Btn_New.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06037F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.93964F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Txt_Inv_Id, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Txt_Inv_Nama, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Txt_Inv_Hrg_Jual, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(762, 95);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Barang";
            // 
            // Txt_Inv_Id
            // 
            this.Txt_Inv_Id.Enabled = false;
            this.Txt_Inv_Id.Location = new System.Drawing.Point(133, 3);
            this.Txt_Inv_Id.Name = "Txt_Inv_Id";
            this.Txt_Inv_Id.Size = new System.Drawing.Size(122, 26);
            this.Txt_Inv_Id.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Hrg Jual";
            // 
            // Txt_Inv_Nama
            // 
            this.Txt_Inv_Nama.Location = new System.Drawing.Point(133, 34);
            this.Txt_Inv_Nama.Name = "Txt_Inv_Nama";
            this.Txt_Inv_Nama.Size = new System.Drawing.Size(556, 26);
            this.Txt_Inv_Nama.TabIndex = 2;
            // 
            // Txt_Inv_Hrg_Jual
            // 
            this.Txt_Inv_Hrg_Jual.Location = new System.Drawing.Point(133, 65);
            this.Txt_Inv_Hrg_Jual.Name = "Txt_Inv_Hrg_Jual";
            this.Txt_Inv_Hrg_Jual.Size = new System.Drawing.Size(122, 26);
            this.Txt_Inv_Hrg_Jual.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.92913F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.69816F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30446F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.82839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.91405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.10448F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Qty_Beli, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Nilai_Beli, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Qty_Jual, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Qty_Masuk, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Qty_Keluar, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Nilai_Awal, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Cogs_Awal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Qty_Awal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Tgl_Awal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Nilai_Akhir, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Cogs_Akhir, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Qty_Akhir, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Tgl_Akhir, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 187);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 188);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Qty Keluar";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Qty Masuk";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Qty Jual";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Qty Beli";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(279, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Nilai Beli";
            // 
            // Txt_Qty_Beli
            // 
            this.Txt_Qty_Beli.Enabled = false;
            this.Txt_Qty_Beli.Location = new System.Drawing.Point(353, 34);
            this.Txt_Qty_Beli.Name = "Txt_Qty_Beli";
            this.Txt_Qty_Beli.Size = new System.Drawing.Size(89, 26);
            this.Txt_Qty_Beli.TabIndex = 8;
            // 
            // Txt_Nilai_Beli
            // 
            this.Txt_Nilai_Beli.Enabled = false;
            this.Txt_Nilai_Beli.Location = new System.Drawing.Point(353, 65);
            this.Txt_Nilai_Beli.Name = "Txt_Nilai_Beli";
            this.Txt_Nilai_Beli.Size = new System.Drawing.Size(89, 26);
            this.Txt_Nilai_Beli.TabIndex = 9;
            // 
            // Txt_Qty_Jual
            // 
            this.Txt_Qty_Jual.Enabled = false;
            this.Txt_Qty_Jual.Location = new System.Drawing.Point(353, 96);
            this.Txt_Qty_Jual.Name = "Txt_Qty_Jual";
            this.Txt_Qty_Jual.Size = new System.Drawing.Size(89, 26);
            this.Txt_Qty_Jual.TabIndex = 10;
            // 
            // Txt_Qty_Masuk
            // 
            this.Txt_Qty_Masuk.Enabled = false;
            this.Txt_Qty_Masuk.Location = new System.Drawing.Point(353, 127);
            this.Txt_Qty_Masuk.Name = "Txt_Qty_Masuk";
            this.Txt_Qty_Masuk.Size = new System.Drawing.Size(89, 26);
            this.Txt_Qty_Masuk.TabIndex = 11;
            // 
            // Txt_Qty_Keluar
            // 
            this.Txt_Qty_Keluar.Enabled = false;
            this.Txt_Qty_Keluar.Location = new System.Drawing.Point(353, 158);
            this.Txt_Qty_Keluar.Name = "Txt_Qty_Keluar";
            this.Txt_Qty_Keluar.Size = new System.Drawing.Size(89, 26);
            this.Txt_Qty_Keluar.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Nilai Awal";
            // 
            // Txt_Nilai_Awal
            // 
            this.Txt_Nilai_Awal.Location = new System.Drawing.Point(132, 127);
            this.Txt_Nilai_Awal.Name = "Txt_Nilai_Awal";
            this.Txt_Nilai_Awal.Size = new System.Drawing.Size(90, 26);
            this.Txt_Nilai_Awal.TabIndex = 7;
            // 
            // Txt_Cogs_Awal
            // 
            this.Txt_Cogs_Awal.Location = new System.Drawing.Point(132, 96);
            this.Txt_Cogs_Awal.Name = "Txt_Cogs_Awal";
            this.Txt_Cogs_Awal.Size = new System.Drawing.Size(90, 26);
            this.Txt_Cogs_Awal.TabIndex = 6;
            // 
            // Txt_Qty_Awal
            // 
            this.Txt_Qty_Awal.Location = new System.Drawing.Point(132, 65);
            this.Txt_Qty_Awal.Name = "Txt_Qty_Awal";
            this.Txt_Qty_Awal.Size = new System.Drawing.Size(90, 26);
            this.Txt_Qty_Awal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Qty Awal";
            // 
            // Txt_Tgl_Awal
            // 
            this.Txt_Tgl_Awal.Enabled = false;
            this.Txt_Tgl_Awal.Location = new System.Drawing.Point(132, 34);
            this.Txt_Tgl_Awal.Name = "Txt_Tgl_Awal";
            this.Txt_Tgl_Awal.Size = new System.Drawing.Size(90, 26);
            this.Txt_Tgl_Awal.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tanggal";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(510, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Nilai Akhir";
            // 
            // Txt_Nilai_Akhir
            // 
            this.Txt_Nilai_Akhir.Enabled = false;
            this.Txt_Nilai_Akhir.Location = new System.Drawing.Point(594, 127);
            this.Txt_Nilai_Akhir.Name = "Txt_Nilai_Akhir";
            this.Txt_Nilai_Akhir.Size = new System.Drawing.Size(122, 26);
            this.Txt_Nilai_Akhir.TabIndex = 16;
            // 
            // Txt_Cogs_Akhir
            // 
            this.Txt_Cogs_Akhir.Enabled = false;
            this.Txt_Cogs_Akhir.Location = new System.Drawing.Point(594, 96);
            this.Txt_Cogs_Akhir.Name = "Txt_Cogs_Akhir";
            this.Txt_Cogs_Akhir.Size = new System.Drawing.Size(122, 26);
            this.Txt_Cogs_Akhir.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(465, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Hrg Pokok Akhir";
            // 
            // Txt_Qty_Akhir
            // 
            this.Txt_Qty_Akhir.Enabled = false;
            this.Txt_Qty_Akhir.Location = new System.Drawing.Point(594, 65);
            this.Txt_Qty_Akhir.Name = "Txt_Qty_Akhir";
            this.Txt_Qty_Akhir.Size = new System.Drawing.Size(122, 26);
            this.Txt_Qty_Akhir.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Qty Akhir";
            // 
            // Txt_Tgl_Akhir
            // 
            this.Txt_Tgl_Akhir.Enabled = false;
            this.Txt_Tgl_Akhir.HideSelection = false;
            this.Txt_Tgl_Akhir.Location = new System.Drawing.Point(594, 34);
            this.Txt_Tgl_Akhir.Name = "Txt_Tgl_Akhir";
            this.Txt_Tgl_Akhir.Size = new System.Drawing.Size(122, 26);
            this.Txt_Tgl_Akhir.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(522, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tanggal";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hrg Pokok Awal";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Persediaan Barang";
            // 
            // Tab_Pembelian
            // 
            this.Tab_Pembelian.Location = new System.Drawing.Point(4, 32);
            this.Tab_Pembelian.Name = "Tab_Pembelian";
            this.Tab_Pembelian.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Pembelian.Size = new System.Drawing.Size(1192, 864);
            this.Tab_Pembelian.TabIndex = 0;
            this.Tab_Pembelian.Text = "Pembelian";
            this.Tab_Pembelian.UseVisualStyleBackColor = true;
            // 
            // InvMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "InvMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persediaan Barang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvMain_FormClosed);
            this.Load += new System.EventHandler(this.InvMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab_InvMaster.ResumeLayout(false);
            this.Tab_InvMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_InvMaster;
        private System.Windows.Forms.TabPage Tab_Pembelian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Txt_Inv_Id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Txt_Inv_Nama;
        private System.Windows.Forms.TextBox Txt_Inv_Hrg_Jual;
        private System.Windows.Forms.TextBox Txt_Tgl_Awal;
        private System.Windows.Forms.TextBox Txt_Qty_Awal;
        private System.Windows.Forms.TextBox Txt_Cogs_Awal;
        private System.Windows.Forms.TextBox Txt_Nilai_Awal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Txt_Qty_Beli;
        private System.Windows.Forms.TextBox Txt_Nilai_Beli;
        private System.Windows.Forms.TextBox Txt_Qty_Jual;
        private System.Windows.Forms.TextBox Txt_Qty_Masuk;
        private System.Windows.Forms.TextBox Txt_Qty_Keluar;
        private System.Windows.Forms.TextBox Txt_Qty_Akhir;
        private System.Windows.Forms.TextBox Txt_Cogs_Akhir;
        private System.Windows.Forms.TextBox Txt_Nilai_Akhir;
        private System.Windows.Forms.TextBox Txt_Tgl_Akhir;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}