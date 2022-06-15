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
                tabMisionVision.SelectedIndex = Convert.ToInt32(e.ClickedItem.Tag);
            }
        }

        private void búsquedaToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tabMisionVision.SelectedIndex = Convert.ToInt32(e.ClickedItem.Tag);

        }
        private void tabAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyValue)
                {
                    case 'F':
                        tabMisionVision.SelectedIndex = 0;
                        break;
                    case 'N':
                        tabMisionVision.SelectedIndex = 3;
                        break;
                }
            }
        }

        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = tabMisionVision.SelectedTab.Text;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tabMisionVision.Select();
        }

        private void tabBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tabEventos_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void tabBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
