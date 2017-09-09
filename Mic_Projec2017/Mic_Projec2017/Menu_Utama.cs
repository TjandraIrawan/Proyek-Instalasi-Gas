using System;
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
    public partial class Menu_Utama : Form
    {
        public Menu_Utama()
        {
            InitializeComponent();
        }
        
        private void Menu_Utama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void proyekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProMain obj = new ProMain();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
