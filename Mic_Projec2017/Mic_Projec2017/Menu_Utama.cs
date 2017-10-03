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
        public static Menu_Utama mdiobj;

        public Menu_Utama()
        {
            InitializeComponent();

        }
        
        private void Menu_Utama_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void proyekToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void PelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PelangganToolStripMenuItem.Enabled = false;
            CustMain obj = new CustMain
            {
                MdiParent = this
            };
            obj.Show();
            mdiobj = this;
        }

        private void PersediaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            persediaanToolStripMenuItem.Enabled = false;
            
            InvMain obj = new InvMain
            {
                MdiParent = this
            };
            obj.Show();
            
            mdiobj = this;
            
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vendorToolStripMenuItem1.Enabled = false;

            Vendor obj = new Vendor
            {
                MdiParent = this
            };
            obj.Show();

            mdiobj = this;
        }

        private void sumberDayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sumberDayaToolStripMenuItem.Enabled = false;

            SumberDaya obj = new SumberDaya
            {
                MdiParent = this
            };
            obj.Show();

            mdiobj = this;
        }

        private void pekerjaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pekerjaanToolStripMenuItem.Enabled = false;

            Pekerjaan obj = new Pekerjaan
            {
                MdiParent = this
            };
            obj.Show();

            mdiobj = this;
        }

        private void marketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marketingToolStripMenuItem.Enabled = false;

            Marketing obj = new Marketing
            {
                MdiParent = this
            };
            obj.Show();

            mdiobj = this;
        }

        private void utilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilitiesToolStripMenuItem.Enabled = false;

            Utilities obj = new Utilities
            {
                MdiParent = this
            };
            obj.Show();

            mdiobj = this;
        }

        private void userIDRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userIDRoleToolStripMenuItem.Enabled = false;

            UserIdRole obj = new UserIdRole
            {
                MdiParent = this
            };
            obj.Show();

            mdiobj = this;
        }

        private void Menu_Utama_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah ingin keluar dari Aplikasi ini ?", "Pertanyaan", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
