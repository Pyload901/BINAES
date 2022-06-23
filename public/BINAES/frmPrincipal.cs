using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
namespace BINAES
{
    public partial class frmPrincipal : Form
    {
        // Variables globales

        // Formulario general
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            //Conversion de colores Hexadecimales 
            System.Drawing.Color col1= System.Drawing.ColorTranslator.FromHtml("#238bba");
            System.Drawing.Color col2= System.Drawing.ColorTranslator.FromHtml("#239aba");
            System.Drawing.Color col3= System.Drawing.ColorTranslator.FromHtml("#237cba");

            /*DatagridViewComposer.BuildDataGridView_Editar(dgvEventosEV, EventoDAO.getType());*/
            tabAdmin.Select();
            this.Text = tabAdmin.SelectedTab.Text;

            //Cambios de color a ciertas partes
          
            tabBuscar.BackColor = Color.FromArgb(50, 149, 196);
            tabEventos.BackColor = col1;

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
            switch (tabAdmin.SelectedIndex)
            {
                case 4:
                    dgvEventosEV.DataSource = EventoDAO.Leer();
                    DataGridViewComposer.BuildDataGridView_Editar(dgvEventosEV);
                    DataGridViewComposer.BuildDataGridView_Eliminar(dgvEventosEV);
                    break;
                default:
                    break;

                case 8:
                    dgvVistaColeccionCO.DataSource = ColeccionDAO.Leer();
                    DataGridViewComposer.BuildDataGridView_Editar(dgvVistaColeccionCO);
                    DataGridViewComposer.BuildDataGridView_Eliminar(dgvVistaColeccionCO);
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
            string Titulo = txtBuscarEjemplarBU.Text;

            Ejemplar ejem = BusquedaDAO.FiltrarPorTituloExacto(Titulo);
        }
        private void btnBuscarEjemplarRE_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 0;
            txtBuscarEjemplarBU.Select();
        }

        // Formulario de prestamo
        
        // Formulario de reserva

        // Formulario de ejemplares

        // Formulario de eventos
        private void dgvEventosEV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderDgv = (DataGridView)sender;
            int id = DataGridViewComposer.getId(senderDgv, e);
            if (senderDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Editar")
            {
                Evento evento = EventoDAO.LeerUno(id);
                txtTituloEventoEV.Text = evento.titulo;
                dtpFechaInicioEV.Value = evento.fechaInicio;
                dtpFechaFinalizacionEV.Value = evento.fechaFin;
                nudNumeroAsistentesEV.Value = evento.numero_asistentes;
                btnDejarDeEditarEV.Enabled = true;
            }
            else if (senderDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Eliminar")
            {
                EventoDAO.Eliminar(Convert.ToInt32(senderDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag));
            }
        }

        private void btnSalirEdicionEjemplarAG_Click(object sender, EventArgs e)
        {
            txtTituloEventoEV.Clear();
            /*dtpFechaInicioEV;
            dtpFechaFinalizacionEV.Value = evento.fechaFin;
            nudNumeroAsistentesEV.Value = evento.numero_asistentes;*/
            btnDejarDeEditarEV.Enabled = false;
        }

        // Formulario de usuarios
        private void btnTomarFotoUS_Click(object sender, EventArgs e)
        {

            btnCancelarFotoUS.Enabled = true;
            if (Camara.Activada())
            {
                Bitmap foto = Camara.TomarFoto();
                DialogResult resultado = MessageBox.Show("¿Guardar foto?", "Has capturado la foto", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Camara.GuardarFoto(foto);
                    Camara.Cerrar(picFotoUS);
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
        }

        private void btnAgregarCO_Click(object sender, EventArgs e)
        {
            Coleccion cole = new Coleccion();
            cole.nombre = txtNombreCO.Text;
            cole.genero_coleccion = cmbGeneroColeccionCO.Text;
            cole.tipo_coleccion = cmbTipoColeccionCO.Text;

            ColeccionDAO.Insertar(cole);
        }
    }
}
