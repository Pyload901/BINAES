using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void búsquedaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            toolStripMenuItem.ShowDropDown();
        }

        private void mspMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag.ToString() != "")
            {
                tabAdmin.SelectedIndex = Convert.ToInt32(e.ClickedItem.Tag);
            }
        }

        private void búsquedaToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tabAdmin.SelectedIndex = Convert.ToInt32(e.ClickedItem.Tag);

        }
        private void tabAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyValue)
                {
                    case 'F':
                        tabAdmin.SelectedIndex = 0;
                        break;
                    case 'N':
                        tabAdmin.SelectedIndex = 3;
                        break;
                }
            }
        }

        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = tabAdmin.SelectedTab.Text;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tabAdmin.Select();
            this.Text = tabAdmin.SelectedTab.Text;
        }

        private void tlpBusquedaEjemplaresBE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbFiltroBE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
