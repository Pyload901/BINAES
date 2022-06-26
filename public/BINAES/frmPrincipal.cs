using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
namespace BINAES
{
    public partial class frmPrincipal : Form
    {
        // Variables globales
        public int id_usuario = 0;
        public string nombre_usuario = null;
        public string rol_usuario = null;


        public frmPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        // Mover Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void frmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelBarraTituloPrincpal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        // Formulario general
        public frmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            id_usuario = usuario.id;
            nombre_usuario = usuario.nombre;
            rol_usuario = usuario.rol;
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            //Conversion de colores Hexadecimales 
            System.Drawing.Color col1= System.Drawing.ColorTranslator.FromHtml("#52b7f5"); // #52b7f5 - #19384b
            System.Drawing.Color col2 = System.Drawing.ColorTranslator.FromHtml("#19384b");
           
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void búsquedaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            toolStripMenuItem.ShowDropDown();
        }
        private void btnCerrarPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestoreWinPrincipal_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizarPrincipal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
