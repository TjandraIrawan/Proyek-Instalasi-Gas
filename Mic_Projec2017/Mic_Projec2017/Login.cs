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
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess;
using Dapper;
using System.Configuration;

namespace Mic_Projec2017
{
    public partial class Login : Form
    {
        private const string db = "MicProject";
        public Login()
        {
            InitializeComponent();
            GlobalVariable.UserId = txtUserName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[db].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@UserId", txtUserName.Text);
                p.Add("@Password", txtPassword.Text);

                var Hitung = connection.ExecuteScalar<int>("dbo.SpLogin_Get_USerID", p, commandType: CommandType.StoredProcedure);
                    if (Hitung == 1)
                    {
                        Menu_Utama obj = new Menu_Utama();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User Name dan Password salah !!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtUserName.Clear();
                        txtUserName.Focus();
                    }
            }
            //try
            //{

            //    Connection con = new Connection();
            //    SqlDataAdapter sda = new SqlDataAdapter("select * from login_user where UserId = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "' ", con.ActiveCon());
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);

            //    if (dt.Rows.Count == 1)
            //    {
            //        //UserId = txtUserName.Text;
            //        Menu_Utama obj = new Menu_Utama();
            //        obj.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("User Name dan Password salah !!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtPassword.Clear();
            //        txtUserName.Clear();
            //        txtUserName.Focus();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
