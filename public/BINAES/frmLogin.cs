﻿using System;
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
    public partial class frmLogin : Form
    {
  
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text != "" && txtContraseniaLogin.Text != "")
            {
                Usuario usuario = new Usuario();
                usuario.nombre = txtUsuarioLogin.Text;
                usuario.contrasenia = txtContraseniaLogin.Text;
                if (UsuarioDAO.Login(usuario))
                {
                    MessageBox.Show("Entra");
                } else
                    MessageBox.Show("No entra");

            }
            else
            {
                MessageBox.Show("No se han completado los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtContraseniaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnInicioSesion.PerformClick();
        }
    }
}
