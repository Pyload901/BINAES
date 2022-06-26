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
        public int idUsuario = 0;
        public string nombreUsuario = null;
        public string rolUsuario = null;

        Dictionary<FiltroEnumerate, string> filtros = new Dictionary<FiltroEnumerate, string>();

        // Formulario general
        public frmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            idUsuario = usuario.id;
            nombreUsuario = usuario.nombre;
            rolUsuario = usuario.rol;
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            //Conversion de colores Hexadecimales 
            System.Drawing.Color col1= System.Drawing.ColorTranslator.FromHtml("#238bba");
            System.Drawing.Color col2= System.Drawing.ColorTranslator.FromHtml("#19384b"); //Buen Color
            System.Drawing.Color col3= System.Drawing.ColorTranslator.FromHtml("#237cba");

            /*DatagridViewComposer.BuildDataGridView_Editar(dgvEventosEV, EventoDAO.getType());*/
            tabAdmin.Select();
            this.Text = tabAdmin.SelectedTab.Text;

            //Cambios de color a ciertas partes
          
            //tabBuscar.BackColor = Color.FromArgb(50, 149, 196);
            //tabEventos.BackColor = col1;


            // Renderizar imagen de btnBuscarEjemplar
            btnBuscarEjemplarBU.Image = (Image)new Bitmap(global::BINAES.Properties.Resources.lupa, new Size(btnBuscarEjemplarBU.Size.Height, btnBuscarEjemplarBU.Size.Height));
            sspNombre.Text += nombreUsuario;
            sspRol.Text += rolUsuario;

            filtros.Add(FiltroEnumerate.Titulo, "Titulo");
            filtros.Add(FiltroEnumerate.Autor, "Autor");
            filtros.Add(FiltroEnumerate.PalabrasClave, "Palabras clave");
            cmbFiltrarEjemplarBU.DisplayMember = "Value";
            cmbFiltrarEjemplarBU.ValueMember = "Key";
            cmbFiltrarEjemplarBU.DataSource = filtros.ToList();
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
            switch (tabAdmin.SelectedIndex)
            {
                case 4:
                    cmbAreaEventoEV.ValueMember = "id";
                    cmbAreaEventoEV.DisplayMember = "nombre";
                    cmbAreaEventoEV.DataSource = AreaDAO.Leer();
                    dgvEventosEV.DataSource = EventoDAO.Leer();
                    DataGridViewComposer.Compose(dgvEventosEV);
                    /*DataGridViewComposer.BuildDataGridView_Editar(dgvEventosEV);
                    DataGridViewComposer.BuildDataGridView_Eliminar(dgvEventosEV);*/
                    break;
                case 5:
                    dgvUsuariosUS.DataSource = UsuarioDAO.Leer();
                    DataGridViewComposer.Compose(dgvUsuariosUS);
                   
                    

                    break;

                case 8:
                    /*dgvVistaColeccionCO.DataSource = ColeccionDAO.Leer();
                    DataGridViewComposer.BuildDataGridView_Editar(dgvVistaColeccionCO);
                    DataGridViewComposer.BuildDataGridView_Eliminar(dgvVistaColeccionCO);*/
                    break;
                default:
                    break;
            }
        }

        // Formulario de busqueda
        private void txtBuscarEjemplarBU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarEjemplarBU.PerformClick();
            }
        }
        private void btnBuscarEjemplarBU_Click(object sender, EventArgs e)
        {
            FiltroEnumerate filtroFormato;
            if ((chkDigitalBU.Checked && chkFísicoBU.Checked) || (!chkDigitalBU.Checked && !chkFísicoBU.Checked))
                filtroFormato = FiltroEnumerate.DigitalFisico;
            else if (chkFísicoBU.Checked)
                filtroFormato = FiltroEnumerate.Fisico;
            else
                filtroFormato = FiltroEnumerate.Digital;

            FiltroEnumerate filtroBusqueda = (chkBusquedaExactaBU.Checked ? FiltroEnumerate.Exacta : FiltroEnumerate.Parcial);

            List<Ejemplar> list = EjemplarDAO.Leer(txtBuscarEjemplarBU.Text, (FiltroEnumerate)cmbFiltrarEjemplarBU.SelectedValue, filtroBusqueda, filtroFormato);

            dgvEjemplaresBU.DataSource =  list;
            DataGridViewComposer.Compose(dgvEjemplaresBU);
        }
        private void btnBuscarEjemplarRE_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 0;
            txtBuscarEjemplarBU.Select();
        }

        private void cmbFiltrarEjemplarBU_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        // Formulario de prestamo

        // Formulario de reserva
        private void btnQrRE_Click(object sender, EventArgs e)
        {
            using (frmEscanerQR ventana = new frmEscanerQR())
            {
                DialogResult resultado = ventana.ShowDialog();
            }
        }

        // Formulario de ejemplares
        private void picEjemplarAG_Click(object sender, EventArgs e)
        {
            Utils.SeleccionarImagen(picEjemplarAG);
        }

        // Formulario coleccion
        private void dgvVistaColeccionCO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAgregarCO_Click(object sender, EventArgs e)
        {
            Coleccion cole = new Coleccion();
            cole.nombre = txtNombreCO.Text;
            cole.id_genero = Convert.ToInt32(cmbGeneroColeccionCO.ValueMember);
            cole.id_coleccion = Convert.ToInt32(cmbTipoColeccionCO.ValueMember);

            ColeccionDAO.Insertar(cole);
        }

        // Formulario de eventos
        private void dgvEventosEV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                btnEditarEventoEV.Tag = dgv.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtTituloEventoEV.Text = dgv.Rows[e.RowIndex].Cells["titulo"].Value.ToString();
                try
                {
                    picImagenEV.Image = Image.FromFile(Properties.Resources.RutaImagenesEventos + "/" + dgv.Rows[e.RowIndex].Cells["imagen"].Value.ToString());
                }
                catch (Exception ex2)
                {
                    picImagenEV.Image = Properties.Resources._default;
                }
                dtpFechaInicioEV.Text = dgv.Rows[e.RowIndex].Cells["fechaInicio"].Value.ToString();
                dtpFechaFinalizacionEV.Text = dgv.Rows[e.RowIndex].Cells["fechaFin"].Value.ToString();
                cmbAreaEventoEV.SelectedValue = dgv.Rows[e.RowIndex].Cells["id_area"].Value;
                rtbObjetivoEventoEV.Clear();
                List<ObjetivoEvento> objetivos = ObjetivoEventoDAO.Leer(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["id"].Value));
                foreach (ObjetivoEvento obj in objetivos)
                {
                    rtbObjetivoEventoEV.AppendText(obj.objetivo + Environment.NewLine);
                }
                nudNumeroAsistentesEV.Value = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["numero_asistentes"].Value);
                btnDejarDeEditarEV.Enabled = true;
                btnEliminarEventoEV.Enabled = true;
                btnAgregarEventoEV.Enabled = false;

            }
            catch (Exception ex1)
            {

            }
        }
        private void btnDejarDeEditarEV_Click(object sender, EventArgs e)
        {
            txtTituloEventoEV.Clear();
            picImagenEV.Image = Properties.Resources._default;
            dtpFechaInicioEV.ResetText();
            dtpFechaFinalizacionEV.ResetText();
            rtbObjetivoEventoEV.Clear();
            nudNumeroAsistentesEV.Value = 0;
            btnAgregarEventoEV.Enabled = true;
            btnDejarDeEditarEV.Enabled = false;
            btnEliminarEventoEV.Enabled = false;
        }
        private void dgvEventosEV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            /* if (Utils.VerificarOpcion(dgv, e) == OpcionesEnumerate.Editar)
             {
                 Evento evento = EventoDAO.LeerUno(id);
                 txtTituloEventoEV.Text = evento.titulo;
                 dtpFechaInicioEV.Value = evento.fechaInicio;
                 dtpFechaFinalizacionEV.Value = evento.fechaFin;
                 nudNumeroAsistentesEV.Value = evento.numero_asistentes;
                 btnDejarDeEditarEV.Enabled = true;
             }
             else if (Utils.VerificarOpcion(dgv, e) == OpcionesEnumerate.Eliminar)
             {
                 EventoDAO.Eliminar(id);
             }*/
        }

        private void btnSalirEdicionEjemplarAG_Click(object sender, EventArgs e)
        {
            txtTituloEventoEV.Clear();
            /*dtpFechaInicioEV;
            dtpFechaFinalizacionEV.Value = evento.fechaFin;
            nudNumeroAsistentesEV.Value = evento.numero_asistentes;*/
            btnDejarDeEditarEV.Enabled = false;
        }

        private void picImagenEV_Click(object sender, EventArgs e)
        {
            Utils.SeleccionarImagen(picImagenEV);
        }
        private void btnAgregarEV_Click(object sender, EventArgs e)
        {
            
        }
        private void btnEditarEventoEV_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(btnEditarEventoEV.Tag);
            List<string> objetivos = rtbObjetivoEventoEV.Text.Trim().Split('\n').ToList();
            objetivos.RemoveAll(str => str == "");
            int objetivosEnBaseDeDatos = ObjetivoEventoDAO.ContarElementosPorIdEvento(id);
            int objetivos_nuevos = objetivos.Count - objetivosEnBaseDeDatos;
            List<string> objetivosActualizar = objetivos.GetRange(0, objetivosEnBaseDeDatos);
            List<string> objetivosNuevos = objetivos.GetRange(objetivosEnBaseDeDatos, objetivos.Count);
            
        }

// ---------------------------------------------------------------------------------------------------

        // Formulario de usuarios

        // Implementación para la captura de fotos
        private void btnTomarFotoUS_Click(object sender, EventArgs e)
        {
            btnCancelarFotoUS.Enabled = true;
            if (Camara.Activada())
            {
                Bitmap foto = Camara.TomarFoto(picFotoUS);
                DialogResult resultado = MessageBox.Show("¿Guardar foto?", "Has capturado la foto", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Camara.GuardarFoto(foto);
                    Camara.Cerrar(picFotoUS);
                    picFotoUS.Image = foto;
                    btnCancelarFotoUS.Enabled = false;
                }
                else
                    Camara.Abrir(picFotoUS);
                foto.Dispose();

            }
            else
                Camara.Abrir(picFotoUS);

        }
        private void btnCancelarFotoUS_Click(object sender, EventArgs e)
        {
            Camara.Cerrar(picFotoUS);
            if (!Camara.Activada())
            {
                btnCancelarFotoUS.Enabled = false;
            }
            picFotoUS.Image = global::BINAES.Properties.Resources._default;
        }

        private void picFotoUS_Click(object sender, EventArgs e)
        {
            Utils.SeleccionarImagen(picFotoUS);
        }

        //CRUDE

        // Create
        private void btnAgregarUS_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.nombre = txtNombreUS.Text;
            user.telefono = txtTelefonoUS.Text;
            user.email = txtEmailUS.Text;
            user.institucion = txtInstitucionUS.Text;
            user.direccion = txtDireccionUS.Text;

            if (UsuarioDAO.Crear(user))
            {
                MessageBox.Show("Registro agregado con éxito!");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }

        // Read
        private void dgvUsuariosUS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                txtNombreUS.Text = dgv.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtTelefonoUS.Text = dgv.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                txtEmailUS.Text = dgv.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtInstitucionUS.Text = dgv.Rows[e.RowIndex].Cells["institucion"].Value.ToString();
                txtDireccionUS.Text = dgv.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                
            }
            catch (Exception ex1)
            {

            }
        }

        // Update
        private void btnActualizarUS_Click(object sender, EventArgs e)
        {

            Usuario user = new Usuario();

            user.nombre = txtNombreUS.Text;
            user.telefono = txtTelefonoUS.Text;
            user.email = txtEmailUS.Text;
            user.institucion = txtInstitucionUS.Text;
            user.direccion = txtDireccionUS.Text;

            if (UsuarioDAO.Update(user))
                MessageBox.Show("Actualizada con éxito!");
            else
                MessageBox.Show("Ha ocurrido un error!");
            
        }   

 // ---------------------------------------------------------------------------------------------------


        private void btnAgregarEjemplarAG_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }
        public void btnAgregarUS_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscarCO_Click(object sender, EventArgs e)
        {
            dgvColeccionesCO.DataSource = null;
            dgvColeccionesCO.DataSource = ColeccionDAO.Buscar();
        }

        
    }
}
        }
    }
}
        }
    }
}
        }
    }
}
        }
    }
}
        }
    }
}
        }
    }
}
        }
    }
}
