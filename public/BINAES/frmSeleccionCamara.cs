using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            // Quitar Bordes
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Modificaciones al frmPrincipal

        //Mover Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmSeleccionCamara_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelPrincipalCamara_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCerrarSelecCam_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarSelecCam_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
