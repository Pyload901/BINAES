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
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tabAdmin.Select();
            this.Text = tabAdmin.SelectedTab.Text;

            // Renderizar imagen de btnBuscarEjemplar
            btnBuscarEjemplarBU.Image = (Image)new Bitmap(global::BINAES.Properties.Resources.lupa, new Size(btnBuscarEjemplarBU.Size.Height, btnBuscarEjemplarBU.Size.Height));
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
        private void txtBuscarEjemplarBU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarEjemplarBU.PerformClick();
            }
        }
        private void btnBuscarEjemplarBU_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Buscar");
        }
        private void btnBuscarEjemplarRE_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 0;
            txtBuscarEjemplarBU.Select();
        }
        private void btnTomarFotoUS_Click(object sender, EventArgs e)
        {

            if (Camara.Activada())
            {
                btnCancelarFotoUS.Enabled = true;
                Bitmap foto = Camara.TomarFoto(picFotoUS);
                DialogResult resultado = MessageBox.Show("¿Guardar foto?", "Has capturado la foto", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                    Camara.GuardarFoto(foto);
                else
                    Camara.Abrir(picFotoUS);
            }
            else
            {
                Camara.Abrir(picFotoUS);
            }
        }
        private void btnCancelarFotoUS_Click(object sender, EventArgs e)
        {
            Camara.Cerrar(picFotoUS);
            if (!Camara.Activada())
            {
                btnCancelarFotoUS.Enabled = false;
            }
        }
    }
}
