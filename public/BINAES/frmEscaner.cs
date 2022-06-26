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
    public partial class frmEscaner : Form
    {
        public frmEscaner()
        {
            InitializeComponent();
        }

        private void frmEscaner_Load(object sender, EventArgs e)
        {
            if (!Camara.Activada())
            {
                Camara.Abrir(picQrEscaner);
            }
        }

        private void frmEscaner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Camara.Cerrar(picQrEscaner);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Bitmap qr = Camara.TomarFoto(picQrEscaner);
            
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
