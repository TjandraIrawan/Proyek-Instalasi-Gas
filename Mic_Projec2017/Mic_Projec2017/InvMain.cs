using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mic_Projec2017
{
    public partial class InvMain : Form
    {
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

        void ViewGrid()
        {
            try
            {
                Connection con = new Connection();
                MySqlDataAdapter sda = new MySqlDataAdapter("select *, inv_awal*Inv_Cogs_Awal as Nilai_awal from inventry ORDER by Inv_Nama", con.ActiveCon());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[1].Value = item["Inv_Id"].ToString();
                    dataGridView1.Rows[n].Cells[0].Value = item["Inv_Nama"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["Inv_Hrg_Jual"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["Inv_Awal"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["Inv_Cogs_Awal"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item["Inv_Cogs"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item["Nilai_Awal"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perhatian");

            }
        }
        void Tampil()
        {
                Txt_Inv_Id.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Txt_Inv_Nama.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txt_Inv_Hrg_Jual.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Txt_Qty_Awal.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Txt_Cogs_Awal.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Txt_Cogs_Akhir.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Txt_Nilai_Awal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void InvMain_Load(object sender, EventArgs e)
        {
            ViewGrid();
            Tampil();
            Btn_Save.Hide();
            Btn_cancel.Hide();
        }
    }
}
