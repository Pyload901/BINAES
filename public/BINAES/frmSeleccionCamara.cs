using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
namespace BINAES
{
    public partial class frmSeleccionCamara : Form
    {
        public frmSeleccionCamara()
        {
            InitializeComponent();
        }

        private void frmSeleccionCamara_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cmbCamara.DisplayMember = "Name";
            cmbCamara.DataSource = dispositivos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Camara = dispositivos[cmbCamara.SelectedIndex].MonikerString;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
