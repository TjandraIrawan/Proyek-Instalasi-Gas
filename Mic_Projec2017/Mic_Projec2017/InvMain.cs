using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using System.Globalization;

namespace Mic_Projec2017
{
    public partial class InvMain : Form
    {
        int inv_Id = 0;
        private const string db = "MicProject";
        public InvMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void InvMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Utama.mdiobj.persediaanToolStripMenuItem.Enabled = true;
        }
        class InvModel
        {
            public int Inv_Id { get; set; }
            public string Inv_Nama { get; set; }
            public int Inv_Awal { get; set; }
            public int Inv_Cogs_Awal { get; set; }
            public int Inv_Hrg_Jual { get; set; }
            public int Inv_Cogs { get; set; }
            public int Inv_Min { get; set; }
            public DateTime Inv_Tgl_Awal { get; set; }
            public int Nilai_Awal { get; set; }
        }

        void ViewGrid()
        {
            var p = new DynamicParameters();
            p.Add("@SearchText", Txt_Search.Text);

            try
            {
                using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
                {
                    List<InvModel> list = connection.Query<InvModel>("sp_InvViewAllOrSearch", p, commandType: CommandType.StoredProcedure).ToList();
                    Inv_dataGridView.DataSource = list;
                    Inv_dataGridView.Columns[0].Frozen = true;
                    Inv_dataGridView.Columns[0].Visible = false;
                    Inv_dataGridView.Columns[1].HeaderText = "Nama Barang";
                    Inv_dataGridView.Columns[1].Width = 200;
                    Inv_dataGridView.Columns[1].Frozen = true;
                    Inv_dataGridView.Columns[2].HeaderText = "Qty Awal";
                    //Inv_dataGridView.Columns[2].Width = 300;
                    Inv_dataGridView.Columns[3].HeaderText = "Hrg Pokok Awal";
                    Inv_dataGridView.Columns[3].Width = 200;
                    Inv_dataGridView.Columns[4].HeaderText = "Hrg Jual";
                    Inv_dataGridView.Columns[5].Visible = false;
                    Inv_dataGridView.Columns[6].HeaderText = "Min Qty";
                    Inv_dataGridView.Columns[7].HeaderText = "Tgl Awal";
                    Inv_dataGridView.Columns[8].HeaderText = "Nilai Awal";
                    Inv_dataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Hapus()
        {
            Txt_Inv_Nama.Text = 
            Txt_Inv_Hrg_Jual.Text = 
            Txt_Inv_Min_Qty.Text = 
            Txt_Inv_Awal.Text = 
            Txt_Inv_Cogs_Awal.Text = "";
            lb_Tgl_Awal.Text =
                lb_Nilai_awal.Text =
                lb_Qty_Beli.Text =
                lb_Nilai_Beli.Text =
                lb_Qty_Jual.Text =
                lb_Qty_Masuk.Text =
                lb_Qty_Keluar.Text =
                lb_Tgl_Akhir.Text =
                lb_Qty_Akhir.Text =
                lb_Cogs.Text =
                lb_Nilai_Akhir.Text = "";
        }
        //string.Format("{0:n0}", double.Parse(Txt_Inv_Cogs_Awal.Text));
        private void InvMain_Load(object sender, EventArgs e)
        {
            ViewGrid();
            Hapus();
            Btn_Save.Text = "Save";
            Txt_Inv_Nama.Focus();
        }

        private void Txt_Qty_Awal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if (e.KeyChar == (char)13 || e.KeyChar == (char)9)
            {
                Txt_Inv_Awal.Text = string.Format("{0:n0}", double.Parse(Txt_Inv_Awal.Text));
                //var nilai_awal = double.Parse(Txt_Inv_Awal.Text) * double.Parse(Txt_Inv_Cogs_Awal.Text);
                var nilai_awal = Convert.ToInt32(Txt_Inv_Awal) * Convert.ToInt32(Txt_Inv_Cogs_Awal);
                lb_Nilai_awal.Text = nilai_awal.ToString();
                Txt_Inv_Cogs_Awal.Focus();                
            }            
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            ViewGrid();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (validateform())
            {
                try
                {
                    using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
                    {
                        var p = new DynamicParameters();
                        p.Add("@Inv_Id", inv_Id);
                        p.Add("@Inv_Nama", Txt_Inv_Nama.Text);
                        p.Add("@Inv_Awal", Txt_Inv_Awal.Text);
                        p.Add("@Inv_Cogs_Awal", Txt_Inv_Cogs_Awal.Text);
                        p.Add("@Inv_Hrg_Jual", int.Parse(Txt_Inv_Hrg_Jual.Text));
                        p.Add("@Inv_Min", int.Parse(Txt_Inv_Min_Qty.Text));

                        connection.Execute("dbo.sp_InvAddOrUpdate", p, commandType: CommandType.StoredProcedure);

                        if (Btn_Save.Text == "Save")
                        {
                            MessageBox.Show("Data Barang sudah di simpan", "Tambah Barang");
                        }
                        else
                        {
                            MessageBox.Show("Data Barang sudah di Update", "Update Barang");
                            Txt_Search.Enabled = true;
                            Btn_Save.Text = "Save";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Hapus();
                ViewGrid();
            }
        }

        private bool validateform()
        {
            bool output = true;
            int hrg_jual = 0, min_qty = 0, cogs_awal = 0;
            bool valid_Hrg_Jual = int.TryParse(Txt_Inv_Hrg_Jual.Text, out hrg_jual);
            bool valid_min_qty = int.TryParse(Txt_Inv_Min_Qty.Text, out min_qty);
            bool valid_cogs_awal = int.TryParse(Txt_Inv_Cogs_Awal.Text, out cogs_awal);

            if (Txt_Inv_Nama.Text == "")
            {
                output = false;
                MessageBox.Show("Nama Barang harus diisi", "Perhatian", MessageBoxButtons.OK);
                Txt_Inv_Nama.Focus();
            }
            else
            if (!valid_Hrg_Jual)
            {
                output = false;
                MessageBox.Show("Hrg Jual salah", "Perhatian", MessageBoxButtons.OK);
                Txt_Inv_Hrg_Jual.Focus();
            }
            else
                if(!valid_min_qty)
            {
                output = false;
                MessageBox.Show("Qty Minimum salah", "Perhatian", MessageBoxButtons.OK);
                Txt_Inv_Min_Qty.Focus();
            }
            else
                if(!valid_cogs_awal)
            {
                output = false;
                MessageBox.Show("Hrg Pokok Awal salah", "Perhatian", MessageBoxButtons.OK);
                Txt_Inv_Cogs_Awal.Focus();
            }

            try
            {
                using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@Inv_Id", inv_Id);
                    p.Add("@Inv_Nama", Txt_Inv_Nama.Text);

                    var Hitung = connection.ExecuteScalar<int>("dbo.SpInv_Cek_Nama", p, commandType: CommandType.StoredProcedure);
                    if (Hitung == 1)
                    {
                        output = false;
                        MessageBox.Show($"Nama Barang {Txt_Inv_Nama.Text} sudah ada", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Txt_Inv_Nama.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return output;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            inv_Id = 0;
            Hapus();
            Btn_Save.Text = "Save";
            Txt_Search.Enabled = true;
            Txt_Inv_Nama.Focus();
        }

        private void Txt_Inv_Hrg_Jual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if (e.KeyChar == (char)13)
            {
                Txt_Inv_Hrg_Jual.Text = string.Format("{0:n0}", double.Parse(Txt_Inv_Hrg_Jual.Text));

                Txt_Inv_Min_Qty.Focus();
            }
        }

        private void Txt_Inv_Hrg_Jual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                Txt_Inv_Hrg_Jual.Text = string.Format("{0:n0}", double.Parse(Txt_Inv_Hrg_Jual.Text));

                Txt_Inv_Min_Qty.Focus();
            }
        }

        private void Txt_Inv_Min_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Txt_Inv_Awal.Focus();
            }
        }

        private void Txt_Inv_Cogs_Awal_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void Txt_Inv_Nama_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Txt_Inv_Hrg_Jual.Focus();
            }
        }

        private void Txt_Inv_Min_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if (e.KeyChar == (char)13)
            {
                Txt_Inv_Min_Qty.Text = string.Format("{0:n0}", double.Parse(Txt_Inv_Min_Qty.Text));

                Txt_Inv_Awal.Focus();
            }
        }

        private void Inv_dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Inv_dataGridView.CurrentRow.Index != -1)
            {
                inv_Id = Convert.ToInt32(Inv_dataGridView.CurrentRow.Cells[0].Value.ToString());
                Txt_Inv_Nama.Text = Inv_dataGridView.CurrentRow.Cells[1].Value.ToString();
                Txt_Inv_Awal.Text = Inv_dataGridView.CurrentRow.Cells[2].Value.ToString();
                Txt_Inv_Cogs_Awal.Text = Inv_dataGridView.CurrentRow.Cells[3].Value.ToString();
                Txt_Inv_Hrg_Jual.Text = string.Format("0:N0",Inv_dataGridView.CurrentRow.Cells[4].Value);
                Txt_Inv_Min_Qty.Text = Inv_dataGridView.CurrentRow.Cells[6].Value.ToString();
                lb_Tgl_Awal.Text = Inv_dataGridView.CurrentRow.Cells[7].Value.ToString();
                lb_Nilai_awal.Text = Inv_dataGridView.CurrentRow.Cells[8].Value.ToString();
                lb_Qty_Beli.Text =
                lb_Nilai_Beli.Text =
                lb_Qty_Jual.Text =
                lb_Qty_Masuk.Text =
                lb_Qty_Keluar.Text =
                lb_Tgl_Akhir.Text =
                lb_Qty_Akhir.Text =
                lb_Cogs.Text =
                lb_Nilai_Akhir.Text = "";
                Txt_Search.Enabled = false;
                Btn_Save.Text = "Update";
            }
        }
    }
}
