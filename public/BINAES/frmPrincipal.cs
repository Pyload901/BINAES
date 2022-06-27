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
            private void frmPrincipal_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            private void panelPrincipal_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

        // Botones cerrar/maximizar/minimizar

        private void btnCerrarPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxPrincipal_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinPrincipal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            /*DatagridViewComposer.BuildDataGridView_Editar(dgvEventosEV, EventoDAO.getType());*/
            tabAdmin.Select();
            this.Text = tabAdmin.SelectedTab.Text;

            System.Drawing.Color col1 = System.Drawing.ColorTranslator.FromHtml("#214962"); // #52b7f5 - #19384b
            System.Drawing.Color col2 = System.Drawing.ColorTranslator.FromHtml("#214962");

            //Cambios de color a todos los tab y sus componentes

            //tab eventos
            tabEventos.BackColor = col1;
            //tab buscar
            tabBuscar.BackColor = col1;
            txtBuscarEjemplarBU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //tab agregar
            tabAgregar.BackColor = col1;
     
            //tab prestamo
            tabPrestamo.BackColor = col1;
            //tab reserva
            tabReserva.BackColor = col1;
          
            //tab usuario
            tabUsuarios.BackColor = col1;
            //tab Coleccion
            tabColeccion.BackColor = col1;
            //Tab Acerca 
            TabAcerca.BackColor = col1;



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
                case 1:
                    dgvPrestamosPR.DataSource = PrestamoDAO.Leer();
                    DataGridViewComposer.Compose(dgvPrestamosPR);
                    break;
                case 2:
                    dgvReservasRE.DataSource = ReservaDAO.Leer();
                    DataGridViewComposer.Compose(dgvReservasRE);
                    break;
                case 3:
                    cmbIdiomaEjemplarAG.ValueMember = "id";
                    cmbIdiomaEjemplarAG.DisplayMember = "idioma";
                    cmbIdiomaEjemplarAG.DataSource = IdiomaDAO.Leer();

                    cmbFormatoEjemplarAG.ValueMember = "id";
                    cmbFormatoEjemplarAG.DisplayMember = "formato";
                    cmbFormatoEjemplarAG.DataSource = FormatoDAO.Leer();

                    cmbColeccionEjemplarAG.ValueMember = "id";
                    cmbColeccionEjemplarAG.DisplayMember = "nombre";
                    cmbColeccionEjemplarAG.DataSource = ColeccionDAO.Leer();

                    cmbEditorialEjemplarAG.ValueMember = "id";
                    cmbEditorialEjemplarAG.DisplayMember = "editorial";
                    cmbEditorialEjemplarAG.DataSource = EditorialDAO.Leer();

                    dgvEjemplaresAG.DataSource = EjemplarDAO.Leer();
                    DataGridViewComposer.Compose(dgvEjemplaresAG);

                    break;
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

                   
                    cmbOcupacionUS.ValueMember = "id";
                    cmbOcupacionUS.DisplayMember = "ocupacion";
                    cmbOcupacionUS.DataSource = OcupacionDAO.Leer();

                    cmbRolUS.ValueMember = "id";
                    cmbRolUS.DisplayMember = "nombre";
                    cmbRolUS.DataSource = RolDAO.Leer();
                   

                    break;

                case 6:
                    cmbTipoColeccionCO.ValueMember = "id";
                    cmbTipoColeccionCO.DisplayMember = "tipo";
                    cmbTipoColeccionCO.DataSource = TipoColeccionDAO.Leer();

                    cmbGeneroColeccionCO.ValueMember = "id";
                    cmbGeneroColeccionCO.DisplayMember = "genero";
                    cmbGeneroColeccionCO.DataSource = GeneroDAO.Leer();

                    dgvColeccionesCO.DataSource = ColeccionDAO.Leer();
                    DataGridViewComposer.Compose(dgvColeccionesCO);

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

            List<Ejemplar> list = EjemplarDAO.LeerFiltrado(txtBuscarEjemplarBU.Text, (FiltroEnumerate)cmbFiltrarEjemplarBU.SelectedValue, filtroBusqueda, filtroFormato);

            dgvEjemplaresBU.DataSource =  list;
            DataGridViewComposer.Compose(dgvEjemplaresBU);
        }
        private void btnBuscarEjemplarRE_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 0;
            txtBuscarEjemplarBU.Select();
            MessageBox.Show("Doble click al ejemplar que quiere reservar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbFiltrarEjemplarBU_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        // Formulario de prestamo
        private void btnBuscarPR_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 0;
            txtBuscarEjemplarBU.Select();
            MessageBox.Show("Doble click al ejemplar que quiere prestar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQrPR_Click(object sender, EventArgs e)
        {
            using (frmEscanerQR ventana = new frmEscanerQR())
            {
                DialogResult resultado = ventana.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    nudIdUsuarioRE.Value = ventana.codigo;
                }
            }
        }

        private void btnPrestarPR_Click(object sender, EventArgs e)
        {
            if (nudIdEjemplarPR.Value > 0 && nudIdUsuarioPR.Value > 0)
            {
                Prestamo prestamo = new Prestamo();
                prestamo.fechaPrestamo = DateTime.Now;
                prestamo.fechaDevolucion = prestamo.fechaPrestamo.AddDays(15);
                prestamo.id_ejemplar = Convert.ToInt32(nudIdEjemplarPR.Value);
                prestamo.id_usuario = Convert.ToInt32(nudIdUsuarioPR.Value);
                if (!PrestamoDAO.Crear(prestamo))
                    MessageBox.Show("No se pudo realizar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataGridViewComposer.LimpiarDataGridView(dgvPrestamosPR);
                    dgvPrestamosPR.DataSource = PrestamoDAO.Leer();
                    DataGridViewComposer.Compose(dgvPrestamosPR);
                }
            }
        }

        // Formulario de reserva
        private void btnQrRE_Click(object sender, EventArgs e)
        {
            using (frmEscanerQR ventana = new frmEscanerQR())
            {
                DialogResult resultado = ventana.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    nudIdUsuarioRE.Value = ventana.codigo;
                }
            }
        }

        private void btnReservarRE_Click(object sender, EventArgs e)
        {
            if (nudIdEjemplarRE.Value > 0 && nudIdUsuarioRE.Value > 0)
                if (!ReservaDAO.Create(Convert.ToInt32(nudIdEjemplarRE.Value), Convert.ToInt32(nudIdUsuarioRE.Value)))
                    MessageBox.Show("No se pudo realizar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataGridViewComposer.LimpiarDataGridView(dgvReservasRE);
                    dgvReservasRE.DataSource = ReservaDAO.Leer();
                    DataGridViewComposer.Compose(dgvReservasRE);
                }

            else
                MessageBox.Show("No se ha ingresado usuario o ejemplar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Formulario de ejemplares
        private void picEjemplarAG_Click(object sender, EventArgs e)
        {
            Utils.SeleccionarImagen(picEjemplarAG);
        }

        private void btnAgregarEjemplarAG_Click(object sender, EventArgs e)
        {
            if (txtNombreEjemplarAG.Text != "" && txtAutorEjemplarAG.Text != "" && dtpFechaPublicacionEjemplarAG.Text != "" && picEjemplarAG.Image != Properties.Resources._default)
            {
                string imagen = Utils.GuardarImagen(Properties.Resources.RutaImagenesEjemplares, picEjemplarAG.Image);
                Ejemplar ejemplar = new Ejemplar();
                ejemplar.nombre = txtNombreEjemplarAG.Text;
                ejemplar.imagen = imagen;
                ejemplar.fecha_publicacion = Convert.ToDateTime(dtpFechaPublicacionEjemplarAG.Value).Date;
                ejemplar.disponibilidad = chkDisponibilidadEjemplarAG.Checked;
                ejemplar.id_editorial = Convert.ToInt32(cmbEditorialEjemplarAG.SelectedValue);
                ejemplar.id_coleccion = Convert.ToInt32(cmbColeccionEjemplarAG.SelectedValue);
                ejemplar.id_idioma = Convert.ToInt32(cmbIdiomaEjemplarAG.SelectedValue);
                ejemplar.id_formato = Convert.ToInt32(cmbFormatoEjemplarAG.SelectedValue);
                ejemplar.autor = txtAutorEjemplarAG.Text;
                int id_ejemplar = EjemplarDAO.Crear(ejemplar);
                if (id_ejemplar > 0)
                {
                    using (frmMultivaluadosEjemplar ventana = new frmMultivaluadosEjemplar())
                    {
                        ventana.ShowDialog();
                        if (ventana.ISBN != "")
                        {
                            Etiqueta etiqueta = new Etiqueta();
                            etiqueta.etiqueta = ventana.ISBN;
                            etiqueta.id_nombre_etiqueta = 1;
                            etiqueta.id_ejemplar = id_ejemplar;
                            EtiquetaDAO.Crear(etiqueta);
                        }
                        if (ventana.ISSN != "")
                        {
                            Etiqueta etiqueta = new Etiqueta();
                            etiqueta.etiqueta = ventana.ISSN;
                            etiqueta.id_nombre_etiqueta = 2;
                            etiqueta.id_ejemplar = id_ejemplar;
                            EtiquetaDAO.Crear(etiqueta);
                        }
                        if (ventana.DOI != "")
                        {
                            Etiqueta etiqueta = new Etiqueta();
                            etiqueta.etiqueta = ventana.DOI;
                            etiqueta.id_nombre_etiqueta = 3;
                            etiqueta.id_ejemplar = id_ejemplar;
                            EtiquetaDAO.Crear(etiqueta);
                        }
                        if (ventana.PalabrasClave != "")
                        {
                            List<string> listaPalabrasClave = ventana.PalabrasClave.Trim().Replace(", ", ",").Split(',').ToList();
                            foreach (string palabra in listaPalabrasClave)
                            {
                                PalabraClave palabraClave = new PalabraClave();
                                palabraClave.palabra = palabra;
                                palabraClave.id_ejemplar = id_ejemplar;
                                PalabraClaveDAO.Crear(palabraClave);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido crear el ejemplar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Formulario coleccion

        private void btnAgregarCO_Click_1(object sender, EventArgs e)
        {
            Coleccion col = new Coleccion();
            col.nombre = txtNombreColeccionCO.Text;
            col.id_tipo_coleccion = Convert.ToInt32(cmbTipoColeccionCO.SelectedValue);
            col.id_genero = Convert.ToInt32(cmbGeneroColeccionCO.SelectedValue);

       
            if (ColeccionDAO.Crear(col))
            {
                MessageBox.Show("Registro coleccion agregada con éxito!");
                DataGridViewComposer.LimpiarDataGridView(dgvColeccionesCO);
                dgvColeccionesCO.DataSource = ColeccionDAO.Leer();
                DataGridViewComposer.Compose(dgvColeccionesCO);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar la coleccion!");
            }
        }
        private void dgvVistaColeccionCO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAgregarCO_Click(object sender, EventArgs e)
        {
            Coleccion cole = new Coleccion();
            cole.nombre = txtNombreCO.Text;
            cole.id_genero = Convert.ToInt32(cmbGeneroColeccionCO.ValueMember);
            cole.id = Convert.ToInt32(cmbTipoColeccionCO.ValueMember);

            ColeccionDAO.Crear(cole);
        }

        private void btnEliminarCO_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(btnEliminarCO.Tag);

            if (ColeccionDAO.Eliminar(id))
            {
                MessageBox.Show("Eliminada con éxito!");
                DataGridViewComposer.LimpiarDataGridView(dgvColeccionesCO);
                dgvColeccionesCO.DataSource = ColeccionDAO.Leer();
                DataGridViewComposer.Compose(dgvColeccionesCO);
            }
            else
                MessageBox.Show("Ha ocurrido un error!");

        }

        private void dgvColeccionesCO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            btnEliminarCO.Tag = dgv.Rows[e.RowIndex].Cells["id"].Value.ToString();
            btnDejarDeEditarCO.Enabled = true;

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
                    picImagenEV.Image = Image.FromFile(Properties.Resources.RutaImagenesEventos + dgv.Rows[e.RowIndex].Cells["imagen"].Value.ToString());
                    picImagenEV.Tag = Properties.Resources.RutaImagenesEventos + dgv.Rows[e.RowIndex].Cells["imagen"].Value.ToString();
                }
                catch (Exception ex2)
                {
                    picImagenEV.Image = Properties.Resources._default;
                }
                dtpFechaInicioEV.Text = dgv.Rows[e.RowIndex].Cells["fechaInicio"].Value.ToString();
                dtpFechaFinalizacionEV.Text = dgv.Rows[e.RowIndex].Cells["fechaFin"].Value.ToString();
                cmbAreaEventoEV.SelectedValue = dgv.Rows[e.RowIndex].Cells["id_area"].Value;
                rtbObjetivoEventoEV.Clear();
                rtbObjetivoEventoEV.Text = dgv.Rows[e.RowIndex].Cells["objetivos"].Value.ToString();
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

        private void btnSalirEdicionEjemplarAG_Click(object sender, EventArgs e)
        {
            txtTituloEventoEV.Clear();
            btnDejarDeEditarEV.Enabled = false;
        }

        private void picImagenEV_Click(object sender, EventArgs e)
        {
            Utils.SeleccionarImagen(picImagenEV);
        }
        private void btnAgregarEV_Click(object sender, EventArgs e)
        {
            if (txtTituloEventoEV.Text != "" && dtpFechaInicioEV.Text != "" && dtpFechaFinalizacionEV.Text != "" && rtbObjetivoEventoEV.Text != "" && nudNumeroAsistentesEV.Value != 0 && picImagenEV.Image != Properties.Resources._default)
            {
                if (nudNumeroAsistentesEV.Value > 358 && cmbAreaEventoEV.Text.Contains("Auditórium"))
                {
                    MessageBox.Show("No hay espacio para más de 358 personas en el Auditórium", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nudNumeroAsistentesEV.Value > 200 && cmbAreaEventoEV.Text.Contains("Sala de proyección"))
                {
                    MessageBox.Show("No hay espacio para más de 200 personas en la Sala de proyección", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    Evento evento = new Evento();
                    evento.titulo = txtTituloEventoEV.Text;
                    evento.fechaInicio = Convert.ToDateTime(dtpFechaInicioEV.Text);
                    evento.fechaFin = Convert.ToDateTime(dtpFechaFinalizacionEV.Text);
                    evento.id_area = Convert.ToInt32(cmbAreaEventoEV.SelectedValue);
                    evento.id_area = Convert.ToInt32(cmbAreaEventoEV.SelectedValue);
                    evento.numero_asistentes = Convert.ToInt32(nudNumeroAsistentesEV.Value);
                    evento.objetivos = rtbObjetivoEventoEV.Text;
                    Utils.EliminarImagen(picImagenEV.Tag.ToString());
                    evento.imagen = Utils.GuardarImagen(Properties.Resources.RutaImagenesEventos, picImagenEV.Image);
                    if (EventoDAO.Crear(evento))
                    {
                        DataGridViewComposer.LimpiarDataGridView(dgvEventosEV);
                        dgvEventosEV.DataSource = EventoDAO.Leer();
                        DataGridViewComposer.Compose(dgvEventosEV);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*objetivos.Take(ObjetivoEventoDAO.ContarElementosPorIdEvento());*/

            //Falta implementar Bussines Object para Create
        }

        // Update
        private void btnActualizarEventoEV_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            if (txtTituloEventoEV.Text != "" && dtpFechaInicioEV.Text != "" && dtpFechaFinalizacionEV.Text != "" && rtbObjetivoEventoEV.Text != "" && nudNumeroAsistentesEV.Value != 0 && picImagenEV.Image != Properties.Resources._default)
            {
                evento.titulo = txtTituloEventoEV.Text;
                evento.fechaInicio = dtpFechaInicioEV.Value;
                evento.fechaFin = dtpFechaFinalizacionEV.Value;
                evento.objetivos = rtbObjetivoEventoEV.Text;
                evento.id_area = Convert.ToInt32(cmbAreaEventoEV.SelectedValue);

                evento.imagen = Utils.GuardarImagen(Properties.Resources.RutaImagenesEventos, picImagenEV.Image);
                evento.numero_asistentes = Convert.ToInt32(nudNumeroAsistentesEV.Value);
                // Agregar id_area
                if (nudNumeroAsistentesEV.Value > 358 && cmbAreaEventoEV.Text.Contains("Auditórium"))
                {
                    MessageBox.Show("No hay espacio para más de 358 personas en el Auditórium", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nudNumeroAsistentesEV.Value > 200 && cmbAreaEventoEV.Text.Contains("Sala de proyección"))
                {
                    MessageBox.Show("No hay espacio para más de 200 personas en la Sala de proyección", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (EventoDAO.Editar(evento))
                    MessageBox.Show("Actualizada con éxito!");
                else
                    MessageBox.Show("Ha ocurrido un error!");
            }
            else
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //Delete
        private void btnEliminarEventoEV_Click(object sender, EventArgs e)
        {
            Coleccion coleccion = new Coleccion();
            coleccion.id = Convert.ToInt32(btnEliminarCO.Tag);
            int id = coleccion.id;

            if (EventoDAO.Eliminar(id))
            {
                MessageBox.Show("Eliminada con éxito!");
                DataGridViewComposer.LimpiarDataGridView(dgvEventosEV);
                dgvEventosEV.DataSource = EventoDAO.Leer();
                DataGridViewComposer.Compose(dgvEventosEV);
            }
            else
                MessageBox.Show("Ha ocurrido un error!");

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
            if (txtNombreUS.Text != "" && txtTelefonoUS.Text != "" && txtEmailUS.Text != "" && txtInstitucionUS.Text != "" && txtDireccionUS.Text != "" && picFotoUS.Image != Properties.Resources._default)
            {
                user.nombre = txtNombreUS.Text;
                user.telefono = txtTelefonoUS.Text;
                user.email = txtEmailUS.Text;
                user.institucion = txtInstitucionUS.Text;
                user.direccion = txtDireccionUS.Text;
                Utils.GuardarImagen(Properties.Resources.RutaImagenesUsuarios, picFotoUS.Image);
                if (UsuarioDAO.Crear(user))
                {
                    MessageBox.Show("Registro agregado con éxito!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
            else
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Read
        private void dgvUsuariosUS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                txtNombreUS.Text = dgv.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                btnActualizarUS.Tag = dgv.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtTelefonoUS.Text = dgv.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                txtEmailUS.Text = dgv.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtInstitucionUS.Text = dgv.Rows[e.RowIndex].Cells["institucion"].Value.ToString();
                txtDireccionUS.Text = dgv.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                try
                {
                    picFotoUS.Image = Image.FromFile(Properties.Resources.RutaImagenesEventos + dgv.Rows[e.RowIndex].Cells["imagen"].Value.ToString());
                    picFotoUS.Image.Tag = Properties.Resources.RutaImagenesEventos + dgv.Rows[e.RowIndex].Cells["imagen"].Value.ToString();
                }
                catch (Exception ex2)
                {
                    picFotoUS.Image = Properties.Resources._default;
                }
            }
            catch (Exception ex1)
            {

            }
        }

        // Update
        private void btnActualizarUS_Click(object sender, EventArgs e)
        {
            if (txtNombreUS.Text != "" && txtTelefonoUS.Text != "" && txtEmailUS.Text != "" && txtInstitucionUS.Text != "" && txtDireccionUS.Text != "" && picFotoUS.Image != Properties.Resources._default)
            {
                Usuario user = new Usuario();

                user.nombre = txtNombreUS.Text;
                user.telefono = txtTelefonoUS.Text;
                user.email = txtEmailUS.Text;
                user.institucion = txtInstitucionUS.Text;
                user.direccion = txtDireccionUS.Text;
                Utils.EliminarImagen(picFotoUS.Tag.ToString());
                user.fotografia = Utils.GuardarImagen(Properties.Resources.RutaImagenesUsuarios, picFotoUS.Image);

                if (UsuarioDAO.Editar(user))
                    MessageBox.Show("Actualizada con éxito!");
                else
                    MessageBox.Show("Ha ocurrido un error!");
            }
            else
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }   

 // ---------------------------------------------------------------------------------------------------


        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnBuscarCO_Click(object sender, EventArgs e)
        {
            dgvColeccionesCO.DataSource = null;
            dgvColeccionesCO.DataSource = ColeccionDAO.Leer();
        }

        private void dgvEjemplaresBU_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Utils.getDataGridViewCellId(sender as DataGridView, e);
            if (EjemplarDAO.VerificarDisponibilidad(id))
            {
                tabAdmin.SelectedIndex = 1;
                nudIdEjemplarPR.Value = id;
            }
            else
            {
                tabAdmin.SelectedIndex = 2;
                nudIdEjemplarRE.Value = id;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBusquedaPPrincipal_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 0;
        }

        private void btnPrestamosPPrincipal_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 1;
        }

        private void btnReservasPPrincipal_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 2;
        }

        private void btnAddEjemplarPPrincipal_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 3;
        }

        private void btnAddEventoPPrincipal_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 4;
        }

        private void btnAddUsuarioPPrincipal_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 5;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 6;
        }

        private void btnIntroPPrincipal_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 7;
        }


        private void btnDejarDeEditarCO_Click(object sender, EventArgs e)
        {
            txtNombreColeccionCO.Clear();

            btnAgregarCO.Enabled = true;
            btnEliminarCO.Enabled = false;
            btnBuscarCO.Enabled = false;

        }
        private void dgvEjemplaresAG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (picEjemplarAG.Image != null)
                    picEjemplarAG.Image.Dispose();
                DataGridView dgv = (DataGridView)sender;
                int idEjemplar = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["id"].Value);
                btnEditarEjemplarAG.Tag = idEjemplar;
                Ejemplar ejemplar = EjemplarDAO.LeerPorId(idEjemplar);
                txtNombreEjemplarAG.Text = ejemplar.nombre;
                txtAutorEjemplarAG.Text = ejemplar.autor;
                cmbColeccionEjemplarAG.SelectedValue = ejemplar.id_coleccion;
                cmbFormatoEjemplarAG.SelectedValue = ejemplar.id_formato;
                cmbEditorialEjemplarAG.SelectedValue = ejemplar.id_editorial;
                cmbIdiomaEjemplarAG.SelectedValue = ejemplar.id_idioma;
                dtpFechaPublicacionEjemplarAG.Text = ejemplar.fecha_publicacion.ToString();
                chkDisponibilidadEjemplarAG.Checked = ejemplar.disponibilidad;
                picEjemplarAG.Image = Image.FromFile(Properties.Resources.RutaImagenesEjemplares + ejemplar.imagen);
            }
            catch(Exception ex)
            {
            }
        }



























































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































        private void btnEditarEjemplarAG_Click(object sender, EventArgs e)
        {
            if (txtNombreEjemplarAG.Text != "" && txtAutorEjemplarAG.Text != "" && dtpFechaPublicacionEjemplarAG.Text != "" && picEjemplarAG.Image != Properties.Resources._default)
            {
                string imagen = Utils.GuardarImagen(Properties.Resources.RutaImagenesEjemplares, picEjemplarAG.Image);
                Ejemplar ejemplar = new Ejemplar();
                ejemplar.id = Convert.ToInt32(btnEditarEjemplarAG.Tag);
                ejemplar.nombre = txtNombreEjemplarAG.Text;
                ejemplar.imagen = imagen;
                ejemplar.fecha_publicacion = Convert.ToDateTime(dtpFechaPublicacionEjemplarAG.Value).Date;
                ejemplar.disponibilidad = chkDisponibilidadEjemplarAG.Checked;
                ejemplar.id_editorial = Convert.ToInt32(cmbEditorialEjemplarAG.SelectedValue);
                ejemplar.id_coleccion = Convert.ToInt32(cmbColeccionEjemplarAG.SelectedValue);
                ejemplar.id_idioma = Convert.ToInt32(cmbIdiomaEjemplarAG.SelectedValue);
                ejemplar.id_formato = Convert.ToInt32(cmbFormatoEjemplarAG.SelectedValue);
                ejemplar.autor = txtAutorEjemplarAG.Text;
                if (EjemplarDAO.Actualizar(ejemplar))
                {

                    using (frmMultivaluadosEjemplar ventana = new frmMultivaluadosEjemplar(ejemplar.id))
                    {
                        ventana.ShowDialog();
                        if (ventana.ISBN != "")
                        {
                            Etiqueta etiqueta = new Etiqueta();
                            etiqueta.id = ventana.id_ISBN;
                            etiqueta.etiqueta = ventana.ISBN;
                            EtiquetaDAO.Actualizar(etiqueta);
                        }
                        if (ventana.ISSN != "")
                        {
                            Etiqueta etiqueta = new Etiqueta();
                            etiqueta.id = ventana.id_ISSN;
                            etiqueta.etiqueta = ventana.ISSN;
                            EtiquetaDAO.Actualizar(etiqueta);
                        }
                        if (ventana.DOI != "")
                        {
                            Etiqueta etiqueta = new Etiqueta();
                            etiqueta.id = ventana.id_DOI;
                            etiqueta.etiqueta = ventana.DOI;
                            EtiquetaDAO.Actualizar(etiqueta);
                        }
                        if (ventana.PalabrasClave != "")
                        {
                            PalabraClaveDAO.Eliminar(ejemplar.id);
                            List<string> listaPalabrasClave = ventana.PalabrasClave.Trim().Replace(", ", ",").Split(',').ToList();
                            foreach (string palabra in listaPalabrasClave)
                            {
                                PalabraClave palabraClave = new PalabraClave();
                                palabraClave.palabra = palabra;
                                palabraClave.id_ejemplar = ejemplar.id;
                                PalabraClaveDAO.Crear(palabraClave);
                            }
                        }
                    }
                }
                DataGridViewComposer.LimpiarDataGridView(dgvEjemplaresAG);
                dgvEjemplaresAG.DataSource = EjemplarDAO.Leer();
                DataGridViewComposer.Compose(dgvEjemplaresAG);

            }
        }
    }
}
     
    