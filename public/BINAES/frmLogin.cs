using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES
{
    public partial class frmLogin : Form
    {
        //Lados del Form

        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);

        }

        //Mover Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Minimizar/mover barra de tareas
        private void tableLayoutPanel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtContraseniaLogin_KeyDown(object sender, KeyEventArgs e)
        {
        if (e.KeyCode == Keys.Enter)
                btnIniciarSesionLogin.PerformClick();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Color
            System.Drawing.Color col1 = System.Drawing.ColorTranslator.FromHtml("#52b7f5"); // 1.#c8e7fa   2.#19384b 3.#52b7f5
            tableLayoutPanel5.BackColor = col1;
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarLogin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnIniciarSesionLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text != "" && txtContraseniaLogin.Text != "")
            {
                Usuario usuario = new Usuario();
                usuario.nombre = txtUsuarioLogin.Text;
                usuario.contrasenia = txtContraseniaLogin.Text;
                usuario = UsuarioDAO.Login(usuario);
                if (usuario != null)
                {
                    this.Hide();
                    new frmPrincipal(usuario).Show();
                }
                else
                    MessageBox.Show("Usuario o contraseña inválidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("No se han completado los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
