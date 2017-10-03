using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace Mic_Projec2017
{
    public partial class CustMain : Form
    {
        int cust_Id = 0;
        private const string db = "MicProject";
        
        public CustMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void CustMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Utama.mdiobj.PelangganToolStripMenuItem.Enabled = true;
        }

        private void CustMain_Load(object sender, EventArgs e)
        {
            ViewGrid();
            Hapus();
            Btn_Save.Text="Save";
            Txt_CustomerNama.Focus();
        }

        void ViewGrid()
        {
            var p = new DynamicParameters();
            p.Add("@SearchText", Txt_Search.Text);

            try
            {
                using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
                {
                    List<CustomerModel> list = connection.Query<CustomerModel>("sp_CustomerViewAllOrSearch", p, commandType: CommandType.StoredProcedure).ToList();
                    Cust_dataGridView1.DataSource = list;
                    Cust_dataGridView1.Columns[0].Frozen = true;
                    Cust_dataGridView1.Columns[0].Visible = false;
                    Cust_dataGridView1.Columns[1].HeaderText = "Nama Pelanggan";
                    Cust_dataGridView1.Columns[1].Width=200;
                    Cust_dataGridView1.Columns[1].Frozen = true;
                    Cust_dataGridView1.Columns[2].HeaderText = "Alamat Pelanggan";
                    Cust_dataGridView1.Columns[2].Width = 300;
                    Cust_dataGridView1.Columns[3].HeaderText = "Kota";
                    Cust_dataGridView1.Columns[3].Width = 100;
                    Cust_dataGridView1.Columns[4].HeaderText = "Telepon";
                    Cust_dataGridView1.Columns[5].HeaderText = "Person in Charge";
                    Cust_dataGridView1.Columns[5].Width = 200;
                    Cust_dataGridView1.Columns[6].HeaderText = "Email";
                    Cust_dataGridView1.Columns[7].HeaderText = "Input By";
                    Cust_dataGridView1.Columns[8].HeaderText = "Tgl Input";
                    Cust_dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Hapus()
        {
            Txt_CustomerNama.Clear();
            Txt_CustomerAlamat.Clear();
            Txt_CustomerKota.Clear();
            Txt_CustomerPic.Clear();
            Txt_CustomerTlp.Clear();
            Txt_CustomerEmail.Clear();
            Txt_CustomerNama.Focus();
            Txt_CustomerInputBy.Text = GlobalVariable.UserId;
            Txt_CustomerInputTgl.Text = DateTime.Now.ToShortDateString();
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
                        p.Add("@Cust_Id", cust_Id);
                        p.Add("@CustomerNama", Txt_CustomerNama.Text);
                        p.Add("@CustomerAlamat", Txt_CustomerAlamat.Text);
                        p.Add("@CustomerKota", Txt_CustomerKota.Text);
                        p.Add("@CustomerTlp", Txt_CustomerTlp.Text);
                        p.Add("@CustomerPic", Txt_CustomerPic.Text);
                        p.Add("@CustomerEmail", Txt_CustomerEmail.Text);
                        p.Add("@CustomerInputBy", Txt_CustomerInputBy.Text);
                        p.Add("@CustomerInputTgl", Convert.ToDateTime(Txt_CustomerInputTgl.Text));

                        connection.Execute("dbo.sp_CustomerAddOrUpdate", p, commandType: CommandType.StoredProcedure);

                        if(Btn_Save.Text == "Save")
                        {
                            MessageBox.Show("Data Pelanggan sudah di simpan", "Tambah Pelanggan");
                        }
                        else
                        {
                            MessageBox.Show("Data Pelanggan sudah di Update", "Update Pelanggan");
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
            if (Txt_CustomerNama.Text == "")
            {
                output = false;
                MessageBox.Show("Nama Pelanggan harus diisi", "Perhatian", MessageBoxButtons.OK);
                Txt_CustomerNama.Focus();
            }
            else
            if (Txt_CustomerTlp.Text == "" && Txt_CustomerEmail.Text == "")
            {
                output = false;
                MessageBox.Show("No. Telepon/Email harus diisi", "Perhatian", MessageBoxButtons.OK);
                Txt_CustomerTlp.Focus();
            }
            try
            {
                using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@Cust_Id", cust_Id);
                    p.Add("@CustomerNama", Txt_CustomerNama.Text);

                    var Hitung = connection.ExecuteScalar<int>("dbo.SpCust_Cek_Nama", p, commandType: CommandType.StoredProcedure);
                    if (Hitung == 1)
                    {
                        output = false;
                        MessageBox.Show($"Nama Pelanggan {Txt_CustomerNama.Text} sudah ada", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        Txt_CustomerNama.Focus();
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
            cust_Id = 0;
            Hapus();
            Btn_Save.Text="Save";
            Txt_Search.Enabled = true;
            Txt_CustomerNama.Focus();
        }
        
        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            ViewGrid();
        }

        private void Txt_CustomerNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Txt_CustomerAlamat.Focus();
            }
        }

        private void Txt_CustomerAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Txt_CustomerKota.Focus();
            }
        }

        private void Txt_CustomerKota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Txt_CustomerPic.Focus();
            }
        }

        private void Txt_CustomerPic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Txt_CustomerTlp.Focus();
            }
        }

        private void Txt_CustomerTlp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Txt_CustomerEmail.Focus();
            }
        }

        private void Txt_CustomerEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Txt_CustomerNama.Focus();
            }
        }

        private void Cust_dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(Cust_dataGridView1.CurrentRow.Index != -1)
            {
                cust_Id =Convert.ToInt32(Cust_dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Txt_CustomerNama.Text = Cust_dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Txt_CustomerAlamat.Text = Cust_dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Txt_CustomerKota.Text = Cust_dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Txt_CustomerTlp.Text = Cust_dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Txt_CustomerPic.Text = Cust_dataGridView1.CurrentRow.Cells[5].Value.ToString();                
                Txt_CustomerEmail.Text = Cust_dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Txt_CustomerInputBy.Text = Cust_dataGridView1.CurrentRow.Cells[7].Value.ToString();
                Txt_CustomerInputTgl.Text = Convert.ToDateTime(Cust_dataGridView1.CurrentRow.Cells[8].Value).ToString();
                //Txt_CustomerInputTgl.Text = DateTime.Now.ToShortDateString();
                Txt_Search.Enabled = false;
                Btn_Save.Text = "Update";
            }
        }
    }
}
