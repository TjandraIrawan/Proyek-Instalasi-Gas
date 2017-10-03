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

namespace Mic_Projec2017
{
    public partial class ProMain : Form
    {
        public ProMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void Txt_Pro_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            {
                Txt_CustomerId.Clear();
                Txt_CustomerNama.Clear();
                Txt_CustomerAlamat.Clear();
                Txt_CustomerKota.Clear();
                Txt_CustomerPic.Clear();
                Txt_CustomerTlp.Clear();
                Txt_CustomerEmail.Clear();
                Txt_CustomerNama.Focus();
                Txt_CustomerInputBy.Text = GlobalVariable.UserId;
                Txt_CustomerInputTgl.Text = DateTime.Now.ToShortDateString();

                Btn_Save.Show();
                Btn_cancel.Show();
                Btn_Update.Enabled = false;
                Btn_Delete.Enabled = false;
                Txt_Search.Enabled = false;
            }
        }
        void ViewGrid()
        {
            try
            {
                Connection con = new Connection();
                SqlDataAdapter sda = new SqlDataAdapter("select * from customerinfo ORDER by CustomerNama", con.ActiveCon());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[1].Value = item["CustomerId"].ToString();
                    dataGridView1.Rows[n].Cells[0].Value = item["CustomerNama"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["CustomerAlamat"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["CustomerKota"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["CustomerPic"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item["CustomerTlp"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item["CustomerEmail"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item["CustomerInputBy"].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item["CustomerInputTgl"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian");

            }
        }
        void Tampil()
        {
            Txt_CustomerId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Txt_CustomerNama.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Txt_CustomerAlamat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Txt_CustomerKota.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Txt_CustomerPic.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Txt_CustomerTlp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Txt_CustomerEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Txt_CustomerInputBy.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Txt_CustomerInputTgl.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void ProMain_Load(object sender, EventArgs e)
        {
            ViewGrid();
            if (dataGridView1.Rows.Count > 0)
            {
                Tampil();
                Btn_Delete.Enabled = true;
                Btn_Update.Enabled = true;
            }
            else
            {
                Btn_Delete.Enabled = false;
                Btn_Update.Enabled = false;
            }
            Btn_Save.Hide();
            Btn_cancel.Hide();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_CustomerNama.Text == "")
            {
                MessageBox.Show("Nama Pelanggan harus diisi", "Perhatian", MessageBoxButtons.OK);
                Txt_CustomerNama.Focus();
            }
            try
            {
                Connection con = new Connection();
                SqlDataAdapter sda_cek = new SqlDataAdapter("select * from CustomerInfo where CustomerId = '" + Txt_CustomerId.Text + "'", con.ActiveCon());
                SqlCommand command_cek = new SqlCommand();
                DataTable dt_cek = new DataTable();
                sda_cek.Fill(dt_cek);
                if (dt_cek.Rows.Count > 1)
                {
                    MessageBox.Show("Nama Pelanggan : " + Txt_CustomerId.Text + " sudah ada", "Perhatian", MessageBoxButtons.OK);
                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Tambah_Pro_Id", con.ActiveCon());
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //SqlCommand command = new SqlCommand
                    //{
                    //    CommandType = CommandType.StoredProcedure
                    //};
                    //MySqlCommand command = new MySqlCommand();
                    //command.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Txt_CustomerId.Text = dt.Rows[0][0].ToString();
                    AddNewRecord();
                    ViewGrid();

                    Btn_Save.Hide();
                    Btn_cancel.Hide();
                    Btn_Update.Enabled = true;
                    Btn_Delete.Enabled = true;
                    Txt_Search.Enabled = true ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian");

            }
        }
        void AddNewRecord()
        {
            try
            {
                Connection con = new Connection();
                Txt_CustomerInputTgl.CustomFormat = "yyyy-MM-dd";
                string insertquery = @"INSERT INTO[dbo].[customerinfo]
           ([CustomerId]
           ,[CustomerNama]
           ,[CustomerAlamat]
           ,[CustomerKota]
           ,[CustomerTlp]
           ,[CustomerPic]
           ,[CustomerEmail]
           ,[CustomerInputBy]
           ,[CustomerInputTgl])
     VALUES
           ('" + Txt_CustomerId.Text + "', '" + Txt_CustomerNama.Text + "', '" + Txt_CustomerAlamat.Text + "', '" + Txt_CustomerKota.Text + "', '" + Txt_CustomerPic.Text + "','" + Txt_CustomerTlp.Text + "', '" + Txt_CustomerEmail.Text + "', '" + Txt_CustomerInputBy.Text + "','" + Txt_CustomerInputTgl.Text + "')";           
                //string insertquery = @"insert into customerinfo(CustomerId, CustomerNama, CustomerAlamat, CustomerKota, CustomerPic, CustomerTlp, CustomerEmail, CustomerInputBy, CustomerInputTgl) 
                //value ('" + Txt_CustomerId.Text + "','" + Txt_CustomerNama.Text + "','" + Txt_CustomerAlamat.Text + "','" + Txt_CustomerKota.Text + "', '" + Txt_CustomerPic.Text + "','" + Txt_CustomerTlp.Text + "', '" + Txt_CustomerEmail.Text + "', '" + Txt_CustomerInputBy.Text + "','" + Txt_CustomerInputTgl.Text + "')";
                Txt_CustomerInputTgl.CustomFormat = "dd-MM-yyyy";
                SqlCommand command = new SqlCommand(insertquery, con.ActiveCon());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian");
            }
        }
        void UpdateRecord()
        {
            try
            {
                Connection con = new Connection();
                SqlDataAdapter sda_cek = new SqlDataAdapter("select * from CustomerInfo where CustomerId != '" + Txt_CustomerId.Text + "' and CustomerNama = '" + Txt_CustomerNama.Text + "'", con.ActiveCon());
                SqlCommand command_cek = new SqlCommand();
                DataTable dt_cek = new DataTable();
                sda_cek.Fill(dt_cek);
                if (dt_cek.Rows.Count == 1)
                {
                    MessageBox.Show("Nama Pelanggan : " + Txt_CustomerNama.Text + " sudah ada", "Perhatian", MessageBoxButtons.OK);
                }
                else
                {
                    Txt_CustomerInputTgl.CustomFormat = "yyyy-MM-dd";
                    string insertquery = @"UPDATE [dbo].[customerinfo] 
SET [CustomerNama] = '" + Txt_CustomerNama.Text + "' ,[CustomerAlamat] = '" + Txt_CustomerAlamat.Text + "',[CustomerKota] = '" + Txt_CustomerKota.Text + "',[CustomerTlp] = '" + Txt_CustomerTlp.Text + "',[CustomerPic] = '" + Txt_CustomerPic.Text + "',[CustomerEmail] = '" + Txt_CustomerEmail.Text + "' WHERE CustomerId = '" + Txt_CustomerId.Text + "' ";
                    //string insertquery = @"update customerinfo set CustomerNama = '" + Txt_CustomerNama.Text + "', " +
                    //"CustomerAlamat = '" + Txt_CustomerAlamat.Text + "'," +
                    //"CustomerKota = '" + Txt_CustomerKota.Text + "'," +
                    //"CustomerTlp = '" + Txt_CustomerTlp.Text + "'," +
                    //"CustomerPic = '" + Txt_CustomerPic.Text + "'," +
                    //"CustomerEmail = '" + Txt_CustomerEmail.Text + "' where CustomerId = '" + Txt_CustomerId.Text + "' ";
                    Txt_CustomerInputTgl.CustomFormat = "dd-MM-yyyy";
                    SqlCommand command = new SqlCommand(insertquery, con.ActiveCon());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data sudah di UPDATE");

                    ViewGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian");
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Tampil();
            Btn_Save.Hide();
            Btn_cancel.Hide();
            Btn_Update.Enabled = true;
            Btn_Delete.Enabled = true;
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Txt_CustomerNama.Text == "")
            {
                MessageBox.Show("Nama Pelanggan harus diisi", "Perhatian", MessageBoxButtons.OK);
                Txt_CustomerNama.Focus();
            }
            else
            {
                UpdateRecord();
                Tampil();
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Tampil();
                Btn_Delete.Enabled = true;
                Btn_Update.Enabled = true;
            }
            else
            {
                Btn_Delete.Enabled = false;
                Btn_Update.Enabled = false;
            }
            Btn_Save.Hide();
            Btn_cancel.Hide();            
            Txt_Search.Enabled = true ;
            Txt_CustomerNama.Focus();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            Tampil();
        }

        void DeleteRecord()
        {
            DialogResult dialogResult = MessageBox.Show("Apakah data Pelanggan : " + Txt_CustomerNama.Text + " dihapus?", "Pertanyaan", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Connection con = new Connection();
                    string insertquery = "delete from customerinfo where CustomerId = '" + Txt_CustomerId.Text + "'";

                    SqlCommand command = new SqlCommand(insertquery, con.ActiveCon());
                    command.ExecuteNonQuery();
                    ViewGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Perhatian");

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection con = new Connection();
                SqlDataAdapter sda = new SqlDataAdapter("select * from customerinfo where CustomerNama like '%" + Txt_Search.Text + "%' ORDER by CustomerNama", con.ActiveCon());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[1].Value = item["CustomerId"].ToString();
                    dataGridView1.Rows[n].Cells[0].Value = item["CustomerNama"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["CustomerAlamat"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["CustomerKota"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["CustomerPic"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item["CustomerTlp"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item["CustomerEmail"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item["CustomerInputBy"].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item["CustomerInputTgl"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian");
            }
        }

        private void ProMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Utama.mdiobj.PelangganToolStripMenuItem.Enabled = true;
        }
    }
}
