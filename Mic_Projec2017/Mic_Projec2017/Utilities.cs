﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mic_Projec2017
{
    public partial class Utilities : Form
    {
        public Utilities()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void Utilities_Load(object sender, EventArgs e)
        {
            //ViewGrid();
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    Tampil();
            //    Btn_Delete.Enabled = true;
            //    Btn_Update.Enabled = true;
            //}
            //else
            //{
            //    Btn_Delete.Enabled = false;
            //    Btn_Update.Enabled = false;
            //}
            //Btn_Save.Hide();
            //Btn_Cancel.Hide();
            //Txt_Inv_Nama.Focus();
        }

        private void Utilities_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_Utama.mdiobj.utilitiesToolStripMenuItem.Enabled = true;
        }
    }
}
