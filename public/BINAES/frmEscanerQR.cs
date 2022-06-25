using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;
namespace BINAES
{
    public partial class frmEscanerQR : Form
    {
        public int codigo;
        public frmEscanerQR()
        {
            InitializeComponent();
        }

        private void frmEscanerQR_Load(object sender, EventArgs e)
        {
            Camara.Abrir(picEscanerQR);
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            if (Camara.Activada())
            {
                using (Bitmap qr = Camara.TomarFoto(picEscanerQR))
                {
                    BarcodeResult resultado = BarcodeReader.ReadASingleBarcode(qr, BarcodeEncoding.QRCode | BarcodeEncoding.Code128, BarcodeReader.BarcodeRotationCorrection.High, BarcodeReader.BarcodeImageCorrection.MediumCleanPixels);
                    if (resultado != null)
                    {
                        try
                        {
                            codigo = Convert.ToInt32(resultado.Text);
                            Console.WriteLine(resultado.Text);
                            Camara.Cerrar(picEscanerQR);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("El QR que se escaneó es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Camara.Cerrar(picEscanerQR);
                            Camara.Abrir(picEscanerQR);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún código QR, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        /*Camara.Cerrar(picEscanerQR);*/
                        Camara.Cerrar(picEscanerQR);
                        Camara.Abrir(picEscanerQR);
                    }
                }
                /*Camara.Parar();*/
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Camara.Activada())
                Camara.Cerrar(picEscanerQR);
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmEscanerQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Camara.Activada())
            {
                Camara.Cerrar(picEscanerQR);
            }
        }
    }
}
