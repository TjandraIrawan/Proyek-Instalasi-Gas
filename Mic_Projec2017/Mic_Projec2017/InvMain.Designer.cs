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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Inv_dataGridView = new System.Windows.Forms.DataGridView();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Inv_Nama = new System.Windows.Forms.TextBox();
            this.Txt_Inv_Hrg_Jual = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Txt_Inv_Min_Qty = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_Inv_Cogs_Awal = new System.Windows.Forms.TextBox();
            this.Txt_Inv_Awal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab_Pengeluaran = new System.Windows.Forms.TabPage();
            this.Tab_Pengembalian = new System.Windows.Forms.TabPage();
            this.Tab_Mutasi_Msk = new System.Windows.Forms.TabPage();
            this.Tab_Mutasi_Klr = new System.Windows.Forms.TabPage();
            this.Tab_Laporan = new System.Windows.Forms.TabPage();
            this.lb_Tgl_Awal = new System.Windows.Forms.Label();
            this.lb_Qty_Beli = new System.Windows.Forms.Label();
            this.lb_Nilai_Beli = new System.Windows.Forms.Label();
            this.lb_Qty_Jual = new System.Windows.Forms.Label();
            this.lb_Qty_Masuk = new System.Windows.Forms.Label();
            this.lb_Qty_Keluar = new System.Windows.Forms.Label();
            this.lb_Tgl_Akhir = new System.Windows.Forms.Label();
            this.lb_Qty_Akhir = new System.Windows.Forms.Label();
            this.lb_Cogs = new System.Windows.Forms.Label();
            this.lb_Nilai_Akhir = new System.Windows.Forms.Label();
            this.lb_Nilai_awal = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Tab_InvMaster.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_dataGridView)).BeginInit();
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
            this.tabControl1.Controls.Add(this.Tab_Pengeluaran);
            this.tabControl1.Controls.Add(this.Tab_Pengembalian);
            this.tabControl1.Controls.Add(this.Tab_Mutasi_Msk);
            this.tabControl1.Controls.Add(this.Tab_Mutasi_Klr);
            this.tabControl1.Controls.Add(this.Tab_Laporan);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 900);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_InvMaster
            // 
            this.Tab_InvMaster.Controls.Add(this.groupBox1);
            this.Tab_InvMaster.Controls.Add(this.Inv_dataGridView);
            this.Tab_InvMaster.Controls.Add(this.Btn_Cancel);
            this.Tab_InvMaster.Controls.Add(this.Btn_Save);
            this.Tab_InvMaster.Controls.Add(this.tableLayoutPanel2);
            this.Tab_InvMaster.Controls.Add(this.tableLayoutPanel1);
            this.Tab_InvMaster.Controls.Add(this.label1);
            this.Tab_InvMaster.Location = new System.Drawing.Point(4, 32);
            this.Tab_InvMaster.Name = "Tab_InvMaster";
            this.Tab_InvMaster.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_InvMaster.Size = new System.Drawing.Size(1192, 864);
            this.Tab_InvMaster.TabIndex = 1;
            this.Tab_InvMaster.Text = "Master Persediaan";
            this.Tab_InvMaster.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Txt_Search);
            this.groupBox1.Location = new System.Drawing.Point(8, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 68);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Nama Barang";
            // 
            // Txt_Search
            // 
            this.Txt_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Search.Location = new System.Drawing.Point(6, 25);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(458, 30);
            this.Txt_Search.TabIndex = 26;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Inv_dataGridView
            // 
            this.Inv_dataGridView.AllowUserToAddRows = false;
            this.Inv_dataGridView.AllowUserToDeleteRows = false;
            this.Inv_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inv_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Inv_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inv_dataGridView.Location = new System.Drawing.Point(8, 433);
            this.Inv_dataGridView.Name = "Inv_dataGridView";
            this.Inv_dataGridView.ReadOnly = true;
            this.Inv_dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Inv_dataGridView.RowTemplate.Height = 28;
            this.Inv_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Inv_dataGridView.Size = new System.Drawing.Size(1154, 215);
            this.Inv_dataGridView.TabIndex = 27;
            this.Inv_dataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Inv_dataGridView_MouseDoubleClick);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel.Location = new System.Drawing.Point(1025, 206);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(137, 53);
            this.Btn_Cancel.TabIndex = 21;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Save.BackColor = System.Drawing.Color.Blue;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Location = new System.Drawing.Point(1025, 147);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(137, 53);
            this.Btn_Save.TabIndex = 20;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.44127F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.55873F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Txt_Inv_Nama, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Txt_Inv_Hrg_Jual, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Txt_Inv_Min_Qty, 1, 2);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(911, 104);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Barang";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "Hrg Jual";
            // 
            // Txt_Inv_Nama
            // 
            this.Txt_Inv_Nama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Inv_Nama.Location = new System.Drawing.Point(170, 3);
            this.Txt_Inv_Nama.MaxLength = 50;
            this.Txt_Inv_Nama.Name = "Txt_Inv_Nama";
            this.Txt_Inv_Nama.Size = new System.Drawing.Size(727, 28);
            this.Txt_Inv_Nama.TabIndex = 4;
            this.Txt_Inv_Nama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Inv_Nama_KeyPress_1);
            // 
            // Txt_Inv_Hrg_Jual
            // 
            this.Txt_Inv_Hrg_Jual.Location = new System.Drawing.Point(170, 37);
            this.Txt_Inv_Hrg_Jual.MaxLength = 7;
            this.Txt_Inv_Hrg_Jual.Name = "Txt_Inv_Hrg_Jual";
            this.Txt_Inv_Hrg_Jual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Inv_Hrg_Jual.Size = new System.Drawing.Size(123, 28);
            this.Txt_Inv_Hrg_Jual.TabIndex = 5;
            this.Txt_Inv_Hrg_Jual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Inv_Hrg_Jual_KeyDown);
            this.Txt_Inv_Hrg_Jual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Inv_Hrg_Jual_KeyPress);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(51, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 22);
            this.label19.TabIndex = 1;
            this.label19.Text = "Minimum Qty";
            // 
            // Txt_Inv_Min_Qty
            // 
            this.Txt_Inv_Min_Qty.Location = new System.Drawing.Point(170, 71);
            this.Txt_Inv_Min_Qty.MaxLength = 5;
            this.Txt_Inv_Min_Qty.Name = "Txt_Inv_Min_Qty";
            this.Txt_Inv_Min_Qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Inv_Min_Qty.Size = new System.Drawing.Size(123, 28);
            this.Txt_Inv_Min_Qty.TabIndex = 6;
            this.Txt_Inv_Min_Qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Inv_Min_Qty_KeyDown);
            this.Txt_Inv_Min_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Inv_Min_Qty_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.46154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.37362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.17582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.15384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.34066F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4945F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Inv_Cogs_Awal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Inv_Awal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Tgl_Awal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Nilai_awal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Qty_Beli, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Nilai_Beli, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Qty_Jual, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Qty_Masuk, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Qty_Keluar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Tgl_Akhir, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Qty_Akhir, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cogs, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Nilai_Akhir, 5, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 162);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 185);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Qty Keluar";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Qty Masuk";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Qty Jual";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Qty Beli";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(363, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "Nilai Beli";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "Nilai Awal";
            // 
            // Txt_Inv_Cogs_Awal
            // 
            this.Txt_Inv_Cogs_Awal.Location = new System.Drawing.Point(171, 77);
            this.Txt_Inv_Cogs_Awal.MaxLength = 7;
            this.Txt_Inv_Cogs_Awal.Name = "Txt_Inv_Cogs_Awal";
            this.Txt_Inv_Cogs_Awal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Inv_Cogs_Awal.Size = new System.Drawing.Size(122, 28);
            this.Txt_Inv_Cogs_Awal.TabIndex = 9;
            this.Txt_Inv_Cogs_Awal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Inv_Cogs_Awal_KeyDown);
            // 
            // Txt_Inv_Awal
            // 
            this.Txt_Inv_Awal.Location = new System.Drawing.Point(171, 40);
            this.Txt_Inv_Awal.MaxLength = 7;
            this.Txt_Inv_Awal.Name = "Txt_Inv_Awal";
            this.Txt_Inv_Awal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Inv_Awal.Size = new System.Drawing.Size(122, 28);
            this.Txt_Inv_Awal.TabIndex = 8;
            this.Txt_Inv_Awal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Qty_Awal_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Qty Awal";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tanggal";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(675, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "Nilai Akhir";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(626, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "Hrg Pokok Akhir";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(682, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Qty Akhir";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(690, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 22);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tanggal";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hrg Pokok Awal";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Persediaan Barang";
            // 
            // Tab_Pengeluaran
            // 
            this.Tab_Pengeluaran.Location = new System.Drawing.Point(4, 32);
            this.Tab_Pengeluaran.Name = "Tab_Pengeluaran";
            this.Tab_Pengeluaran.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Pengeluaran.Size = new System.Drawing.Size(1192, 864);
            this.Tab_Pengeluaran.TabIndex = 0;
            this.Tab_Pengeluaran.Text = "Pengeluaran Brg (BPB)";
            this.Tab_Pengeluaran.UseVisualStyleBackColor = true;
            // 
            // Tab_Pengembalian
            // 
            this.Tab_Pengembalian.Location = new System.Drawing.Point(4, 32);
            this.Tab_Pengembalian.Name = "Tab_Pengembalian";
            this.Tab_Pengembalian.Size = new System.Drawing.Size(1192, 864);
            this.Tab_Pengembalian.TabIndex = 2;
            this.Tab_Pengembalian.Text = "Pengembalian Material";
            this.Tab_Pengembalian.UseVisualStyleBackColor = true;
            // 
            // Tab_Mutasi_Msk
            // 
            this.Tab_Mutasi_Msk.Location = new System.Drawing.Point(4, 32);
            this.Tab_Mutasi_Msk.Name = "Tab_Mutasi_Msk";
            this.Tab_Mutasi_Msk.Size = new System.Drawing.Size(1192, 864);
            this.Tab_Mutasi_Msk.TabIndex = 3;
            this.Tab_Mutasi_Msk.Text = "Mutasi Masuk";
            this.Tab_Mutasi_Msk.UseVisualStyleBackColor = true;
            // 
            // Tab_Mutasi_Klr
            // 
            this.Tab_Mutasi_Klr.Location = new System.Drawing.Point(4, 32);
            this.Tab_Mutasi_Klr.Name = "Tab_Mutasi_Klr";
            this.Tab_Mutasi_Klr.Size = new System.Drawing.Size(1192, 864);
            this.Tab_Mutasi_Klr.TabIndex = 4;
            this.Tab_Mutasi_Klr.Text = "Mutasi Keluar";
            this.Tab_Mutasi_Klr.UseVisualStyleBackColor = true;
            // 
            // Tab_Laporan
            // 
            this.Tab_Laporan.Location = new System.Drawing.Point(4, 32);
            this.Tab_Laporan.Name = "Tab_Laporan";
            this.Tab_Laporan.Size = new System.Drawing.Size(1192, 864);
            this.Tab_Laporan.TabIndex = 5;
            this.Tab_Laporan.Text = "Laporan";
            this.Tab_Laporan.UseVisualStyleBackColor = true;
            // 
            // lb_Tgl_Awal
            // 
            this.lb_Tgl_Awal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Tgl_Awal.AutoSize = true;
            this.lb_Tgl_Awal.Location = new System.Drawing.Point(171, 7);
            this.lb_Tgl_Awal.Name = "lb_Tgl_Awal";
            this.lb_Tgl_Awal.Size = new System.Drawing.Size(143, 22);
            this.lb_Tgl_Awal.TabIndex = 1;
            this.lb_Tgl_Awal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Qty_Beli
            // 
            this.lb_Qty_Beli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Qty_Beli.AutoSize = true;
            this.lb_Qty_Beli.Location = new System.Drawing.Point(449, 7);
            this.lb_Qty_Beli.Name = "lb_Qty_Beli";
            this.lb_Qty_Beli.Size = new System.Drawing.Size(0, 22);
            this.lb_Qty_Beli.TabIndex = 1;
            this.lb_Qty_Beli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Nilai_Beli
            // 
            this.lb_Nilai_Beli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Nilai_Beli.AutoSize = true;
            this.lb_Nilai_Beli.Location = new System.Drawing.Point(449, 44);
            this.lb_Nilai_Beli.Name = "lb_Nilai_Beli";
            this.lb_Nilai_Beli.Size = new System.Drawing.Size(0, 22);
            this.lb_Nilai_Beli.TabIndex = 1;
            this.lb_Nilai_Beli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Qty_Jual
            // 
            this.lb_Qty_Jual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Qty_Jual.AutoSize = true;
            this.lb_Qty_Jual.Location = new System.Drawing.Point(449, 81);
            this.lb_Qty_Jual.Name = "lb_Qty_Jual";
            this.lb_Qty_Jual.Size = new System.Drawing.Size(0, 22);
            this.lb_Qty_Jual.TabIndex = 1;
            this.lb_Qty_Jual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Qty_Masuk
            // 
            this.lb_Qty_Masuk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Qty_Masuk.AutoSize = true;
            this.lb_Qty_Masuk.Location = new System.Drawing.Point(449, 118);
            this.lb_Qty_Masuk.Name = "lb_Qty_Masuk";
            this.lb_Qty_Masuk.Size = new System.Drawing.Size(0, 22);
            this.lb_Qty_Masuk.TabIndex = 1;
            this.lb_Qty_Masuk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Qty_Keluar
            // 
            this.lb_Qty_Keluar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Qty_Keluar.AutoSize = true;
            this.lb_Qty_Keluar.Location = new System.Drawing.Point(449, 155);
            this.lb_Qty_Keluar.Name = "lb_Qty_Keluar";
            this.lb_Qty_Keluar.Size = new System.Drawing.Size(0, 22);
            this.lb_Qty_Keluar.TabIndex = 1;
            this.lb_Qty_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Tgl_Akhir
            // 
            this.lb_Tgl_Akhir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Tgl_Akhir.AutoSize = true;
            this.lb_Tgl_Akhir.Location = new System.Drawing.Point(772, 7);
            this.lb_Tgl_Akhir.Name = "lb_Tgl_Akhir";
            this.lb_Tgl_Akhir.Size = new System.Drawing.Size(0, 22);
            this.lb_Tgl_Akhir.TabIndex = 1;
            this.lb_Tgl_Akhir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Qty_Akhir
            // 
            this.lb_Qty_Akhir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Qty_Akhir.AutoSize = true;
            this.lb_Qty_Akhir.Location = new System.Drawing.Point(772, 44);
            this.lb_Qty_Akhir.Name = "lb_Qty_Akhir";
            this.lb_Qty_Akhir.Size = new System.Drawing.Size(0, 22);
            this.lb_Qty_Akhir.TabIndex = 1;
            this.lb_Qty_Akhir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Cogs
            // 
            this.lb_Cogs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Cogs.AutoSize = true;
            this.lb_Cogs.Location = new System.Drawing.Point(772, 81);
            this.lb_Cogs.Name = "lb_Cogs";
            this.lb_Cogs.Size = new System.Drawing.Size(0, 22);
            this.lb_Cogs.TabIndex = 1;
            this.lb_Cogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Nilai_Akhir
            // 
            this.lb_Nilai_Akhir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Nilai_Akhir.AutoSize = true;
            this.lb_Nilai_Akhir.Location = new System.Drawing.Point(772, 118);
            this.lb_Nilai_Akhir.Name = "lb_Nilai_Akhir";
            this.lb_Nilai_Akhir.Size = new System.Drawing.Size(0, 22);
            this.lb_Nilai_Akhir.TabIndex = 1;
            this.lb_Nilai_Akhir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Nilai_awal
            // 
            this.lb_Nilai_awal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Nilai_awal.AutoSize = true;
            this.lb_Nilai_awal.Location = new System.Drawing.Point(171, 118);
            this.lb_Nilai_awal.Name = "lb_Nilai_awal";
            this.lb_Nilai_awal.Size = new System.Drawing.Size(0, 22);
            this.lb_Nilai_awal.TabIndex = 1;
            this.lb_Nilai_awal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_dataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_InvMaster;
        private System.Windows.Forms.TabPage Tab_Pengeluaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Txt_Inv_Nama;
        private System.Windows.Forms.TextBox Txt_Inv_Hrg_Jual;
        private System.Windows.Forms.TextBox Txt_Inv_Awal;
        private System.Windows.Forms.TextBox Txt_Inv_Cogs_Awal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.DataGridView Inv_dataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Txt_Inv_Min_Qty;
        private System.Windows.Forms.TabPage Tab_Pengembalian;
        private System.Windows.Forms.TabPage Tab_Mutasi_Msk;
        private System.Windows.Forms.TabPage Tab_Mutasi_Klr;
        private System.Windows.Forms.TabPage Tab_Laporan;
        private System.Windows.Forms.Label lb_Tgl_Awal;
        private System.Windows.Forms.Label lb_Nilai_awal;
        private System.Windows.Forms.Label lb_Qty_Beli;
        private System.Windows.Forms.Label lb_Nilai_Beli;
        private System.Windows.Forms.Label lb_Qty_Jual;
        private System.Windows.Forms.Label lb_Qty_Masuk;
        private System.Windows.Forms.Label lb_Qty_Keluar;
        private System.Windows.Forms.Label lb_Tgl_Akhir;
        private System.Windows.Forms.Label lb_Qty_Akhir;
        private System.Windows.Forms.Label lb_Cogs;
        private System.Windows.Forms.Label lb_Nilai_Akhir;
    }
}