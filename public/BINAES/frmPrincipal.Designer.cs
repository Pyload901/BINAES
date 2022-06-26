using System.ComponentModel;
using System.Windows.Forms;

namespace BINAES
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.búsquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarUS = new System.Windows.Forms.Button();
            this.tabEventos = new System.Windows.Forms.TabPage();
            this.tblEventos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEventosEV = new System.Windows.Forms.DataGridView();
            this.lblTituloEventoEV = new System.Windows.Forms.Label();
            this.txtTituloEventoEV = new System.Windows.Forms.TextBox();
            this.lblFechaInicioEventoEV = new System.Windows.Forms.Label();
            this.dtpFechaInicioEV = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinalizacionEventoEV = new System.Windows.Forms.Label();
            this.dtpFechaFinalizacionEV = new System.Windows.Forms.DateTimePicker();
            this.lblObjetivosEventoEV = new System.Windows.Forms.Label();
            this.rtbObjetivoEventoEV = new System.Windows.Forms.RichTextBox();
            this.lblAreaEventoEV = new System.Windows.Forms.Label();
            this.cmbAreaEventoEV = new System.Windows.Forms.ComboBox();
            this.lblNumeroAsistentesEV = new System.Windows.Forms.Label();
            this.nudNumeroAsistentesEV = new System.Windows.Forms.NumericUpDown();
            this.btnDejarDeEditarEV = new System.Windows.Forms.Button();
            this.picImagenEV = new System.Windows.Forms.PictureBox();
            this.lblImagenEV = new System.Windows.Forms.Label();
            this.btnEliminarEventoEV = new System.Windows.Forms.Button();
            this.btnAgregarEventoEV = new System.Windows.Forms.Button();
            this.btnEditarEventoEV = new System.Windows.Forms.Button();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.tblEjemplares = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalirEdicionEjemplarAG = new System.Windows.Forms.Button();
            this.btnAgregarEjemplarAG = new System.Windows.Forms.Button();
            this.txtEditorialEjemplarAG = new System.Windows.Forms.TextBox();
            this.lblImagenEjemplarEJ = new System.Windows.Forms.Label();
            this.lblNombreEjemplarEJ = new System.Windows.Forms.Label();
            this.lblAutorEjemplarEJ = new System.Windows.Forms.Label();
            this.lblFechaPublicacionEjemplarEJ = new System.Windows.Forms.Label();
            this.lblIdiomaEjemplarEJ = new System.Windows.Forms.Label();
            this.lblEditorialEjemplarEJ = new System.Windows.Forms.Label();
            this.lblEtiquetasEjemplarEJ = new System.Windows.Forms.Label();
            this.lblFormatoEjemplarEJ = new System.Windows.Forms.Label();
            this.lblTipoColeccionEjemplarEJ = new System.Windows.Forms.Label();
            this.lblCodigoEjemplarEJ = new System.Windows.Forms.Label();
            this.txtCodigoEjemplarAG = new System.Windows.Forms.TextBox();
            this.cmbIdiomaEjemplarAG = new System.Windows.Forms.ComboBox();
            this.btnEtiquetasEjemplarAG = new System.Windows.Forms.Button();
            this.txtNombreEjemplarAG = new System.Windows.Forms.TextBox();
            this.txtAutorEjemplarAG = new System.Windows.Forms.TextBox();
            this.cmbTipoColeccionEjemplarAG = new System.Windows.Forms.ComboBox();
            this.cmbFormatoEjemplarAG = new System.Windows.Forms.ComboBox();
            this.dgvEjemplaresAG = new System.Windows.Forms.DataGridView();
            this.dtpFechaPublicacionEjemplarAG = new System.Windows.Forms.DateTimePicker();
            this.picEjemplarAG = new System.Windows.Forms.PictureBox();
            this.tabReserva = new System.Windows.Forms.TabPage();
            this.tblReserva = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReservasRE = new System.Windows.Forms.DataGridView();
            this.lblEjemplarRE = new System.Windows.Forms.Label();
            this.btnBuscarEjemplarRE = new System.Windows.Forms.Button();
            this.btnReservarRE = new System.Windows.Forms.Button();
            this.lblUsuarioRE = new System.Windows.Forms.Label();
            this.btnQrRE = new System.Windows.Forms.Button();
            this.nudIdUsuarioRE = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPrestamo = new System.Windows.Forms.TabPage();
            this.tblPrestamo = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEjemplarPR = new System.Windows.Forms.Label();
            this.btnCompletarPR = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblUsuarioPR = new System.Windows.Forms.Label();
            this.btnBuscarPR = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tblBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEjemplaresBU = new System.Windows.Forms.DataGridView();
            this.txtBuscarEjemplarBU = new System.Windows.Forms.TextBox();
            this.btnBuscarEjemplarBU = new System.Windows.Forms.Button();
            this.chkBusquedaExactaBU = new System.Windows.Forms.CheckBox();
            this.lblFiltroBU = new System.Windows.Forms.Label();
            this.cmbFiltrarEjemplarBU = new System.Windows.Forms.ComboBox();
            this.chkFísicoBU = new System.Windows.Forms.CheckBox();
            this.chkDigitalBU = new System.Windows.Forms.CheckBox();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.tblUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.lblFotoUsuarioUS = new System.Windows.Forms.Label();
            this.btnDejarDeEditarUS = new System.Windows.Forms.Button();
            this.dgvUsuariosUS = new System.Windows.Forms.DataGridView();
            this.lblNombreUsuarioUS = new System.Windows.Forms.Label();
            this.txtNombreUS = new System.Windows.Forms.TextBox();
            this.lblInstitucionUsuarioUS = new System.Windows.Forms.Label();
            this.txtInstitucionUS = new System.Windows.Forms.TextBox();
            this.cmbOcupacionUS = new System.Windows.Forms.ComboBox();
            this.lblOcupacionUsuarioUS = new System.Windows.Forms.Label();
            this.lblContraseniaUsuarioUS = new System.Windows.Forms.Label();
            this.txtContraseñaUS = new System.Windows.Forms.TextBox();
            this.lblDireccionUsuarioUS = new System.Windows.Forms.Label();
            this.txtDireccionUS = new System.Windows.Forms.TextBox();
            this.txtEmailUS = new System.Windows.Forms.TextBox();
            this.lblEmailUsuarioUS = new System.Windows.Forms.Label();
            this.txtTelefonoUS = new System.Windows.Forms.TextBox();
            this.lblTelefonoUsuarioUS = new System.Windows.Forms.Label();
            this.lblRolUsuarioUS = new System.Windows.Forms.Label();
            this.cmbRolUS = new System.Windows.Forms.ComboBox();
            this.picFotoUS = new System.Windows.Forms.PictureBox();
            this.btnTomarFotoUS = new System.Windows.Forms.Button();
            this.btnCancelarFotoUS = new System.Windows.Forms.Button();
            this.btnActualizarUS = new System.Windows.Forms.Button();
            this.tabMisionVision = new System.Windows.Forms.TabPage();
            this.tblMisionVision = new System.Windows.Forms.TableLayoutPanel();
            this.lblMision = new System.Windows.Forms.Label();
            this.lblVision = new System.Windows.Forms.Label();
            this.lblInfoMision = new System.Windows.Forms.Label();
            this.lblInfoVision = new System.Windows.Forms.Label();
            this.tabIntroduccion = new System.Windows.Forms.TabPage();
            this.tblQuienesSomos = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuienesSomosTXT = new System.Windows.Forms.Label();
            this.lblQuienesSomosTXT2 = new System.Windows.Forms.Label();
            this.lblQuienesSomos = new System.Windows.Forms.Label();
            this.tabColeccion = new System.Windows.Forms.TabPage();
            this.tblColeccion = new System.Windows.Forms.TableLayoutPanel();
            this.lblGeneroColeccionCO = new System.Windows.Forms.Label();
            this.lblTipoColeccionCO = new System.Windows.Forms.Label();
            this.lblNombreColeccionCO = new System.Windows.Forms.Label();
            this.dgvColeccionesCO = new System.Windows.Forms.DataGridView();
            this.cmbTipoColeccionCO = new System.Windows.Forms.ComboBox();
            this.cmbGeneroColeccionCO = new System.Windows.Forms.ComboBox();
            this.txtNombreColeccionCO = new System.Windows.Forms.TextBox();
            this.btnDejarDeEditarCO = new System.Windows.Forms.Button();
            this.btnBuscarCO = new System.Windows.Forms.Button();
            this.btnAgregarCO = new System.Windows.Forms.Button();
            this.tlpColeccionCO = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dgvVistaColeccionCO = new System.Windows.Forms.DataGridView();
            this.txtNombreCO = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sspStatus = new System.Windows.Forms.StatusStrip();
            this.sspNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.sspRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.mspMenu.SuspendLayout();
            this.tabEventos.SuspendLayout();
            this.tblEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroAsistentesEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenEV)).BeginInit();
            this.tabAgregar.SuspendLayout();
            this.tblEjemplares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresAG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEjemplarAG)).BeginInit();
            this.tabReserva.SuspendLayout();
            this.tblReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdUsuarioRE)).BeginInit();
            this.tabPrestamo.SuspendLayout();
            this.tblPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabBuscar.SuspendLayout();
            this.tblBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresBU)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            this.tblUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUS)).BeginInit();
            this.tabMisionVision.SuspendLayout();
            this.tblMisionVision.SuspendLayout();
            this.tabIntroduccion.SuspendLayout();
            this.tblQuienesSomos.SuspendLayout();
            this.tabColeccion.SuspendLayout();
            this.tblColeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColeccionesCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaColeccionCO)).BeginInit();
            this.sspStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMenu
            // 
            this.mspMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.búsquedaToolStripMenuItem,
            this.administradorDeEventosToolStripMenuItem,
            this.administradorDeUsuariosToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mspMenu.Size = new System.Drawing.Size(1258, 24);
            this.mspMenu.TabIndex = 1;
            this.mspMenu.Text = "menuStrip1";
            this.mspMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mspMenu_ItemClicked);
            // 
            // búsquedaToolStripMenuItem
            // 
            this.búsquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.búscarToolStripMenuItem,
            this.prestarToolStripMenuItem,
            this.devolucionesToolStripMenuItem,
            this.añadirToolStripMenuItem});
            this.búsquedaToolStripMenuItem.Name = "búsquedaToolStripMenuItem";
            this.búsquedaToolStripMenuItem.Size = new System.Drawing.Size(216, 20);
            this.búsquedaToolStripMenuItem.Tag = "";
            this.búsquedaToolStripMenuItem.Text = "Administrador de ejemplares";
            this.búsquedaToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.búsquedaToolStripMenuItem_DropDownItemClicked);
            this.búsquedaToolStripMenuItem.MouseHover += new System.EventHandler(this.búsquedaToolStripMenuItem_MouseHover);
            // 
            // búscarToolStripMenuItem
            // 
            this.búscarToolStripMenuItem.Name = "búscarToolStripMenuItem";
            this.búscarToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.búscarToolStripMenuItem.Tag = "0";
            this.búscarToolStripMenuItem.Text = "Buscar [Ctrl + F]";
            // 
            // prestarToolStripMenuItem
            // 
            this.prestarToolStripMenuItem.Name = "prestarToolStripMenuItem";
            this.prestarToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.prestarToolStripMenuItem.Tag = "1";
            this.prestarToolStripMenuItem.Text = "Préstamos";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.devolucionesToolStripMenuItem.Tag = "2";
            this.devolucionesToolStripMenuItem.Text = "Reservas";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.añadirToolStripMenuItem.Tag = "3";
            this.añadirToolStripMenuItem.Text = "Agregar [Ctrl + N]";
            // 
            // administradorDeEventosToolStripMenuItem
            // 
            this.administradorDeEventosToolStripMenuItem.Name = "administradorDeEventosToolStripMenuItem";
            this.administradorDeEventosToolStripMenuItem.Size = new System.Drawing.Size(194, 20);
            this.administradorDeEventosToolStripMenuItem.Tag = "4";
            this.administradorDeEventosToolStripMenuItem.Text = "Administrador de eventos";
            // 
            // administradorDeUsuariosToolStripMenuItem
            // 
            this.administradorDeUsuariosToolStripMenuItem.Name = "administradorDeUsuariosToolStripMenuItem";
            this.administradorDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(197, 20);
            this.administradorDeUsuariosToolStripMenuItem.Tag = "5";
            this.administradorDeUsuariosToolStripMenuItem.Text = "Administrador de usuarios";
            // 
            // btnAgregarUS
            // 
            this.btnAgregarUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarUS.Location = new System.Drawing.Point(315, 555);
            this.btnAgregarUS.Name = "btnAgregarUS";
            this.btnAgregarUS.Size = new System.Drawing.Size(150, 43);
            this.btnAgregarUS.TabIndex = 27;
            this.btnAgregarUS.Text = "Agregar";
            this.btnAgregarUS.UseVisualStyleBackColor = true;
            this.btnAgregarUS.Click += new System.EventHandler(this.btnAgregarUS_Click);
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.tblEventos);
            this.tabEventos.Location = new System.Drawing.Point(4, 40);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(1250, 594);
            this.tabEventos.TabIndex = 4;
            this.tabEventos.Text = "Eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // tblEventos
            // 
            this.tblEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEventos.ColumnCount = 5;
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblEventos.Controls.Add(this.dgvEventosEV, 4, 0);
            this.tblEventos.Controls.Add(this.lblTituloEventoEV, 0, 0);
            this.tblEventos.Controls.Add(this.txtTituloEventoEV, 0, 1);
            this.tblEventos.Controls.Add(this.lblFechaInicioEventoEV, 0, 2);
            this.tblEventos.Controls.Add(this.dtpFechaInicioEV, 0, 3);
            this.tblEventos.Controls.Add(this.lblFechaFinalizacionEventoEV, 0, 4);
            this.tblEventos.Controls.Add(this.dtpFechaFinalizacionEV, 0, 5);
            this.tblEventos.Controls.Add(this.lblObjetivosEventoEV, 0, 6);
            this.tblEventos.Controls.Add(this.rtbObjetivoEventoEV, 0, 7);
            this.tblEventos.Controls.Add(this.lblAreaEventoEV, 0, 8);
            this.tblEventos.Controls.Add(this.cmbAreaEventoEV, 0, 9);
            this.tblEventos.Controls.Add(this.lblNumeroAsistentesEV, 0, 10);
            this.tblEventos.Controls.Add(this.nudNumeroAsistentesEV, 0, 11);
            this.tblEventos.Controls.Add(this.btnDejarDeEditarEV, 0, 12);
            this.tblEventos.Controls.Add(this.picImagenEV, 2, 1);
            this.tblEventos.Controls.Add(this.lblImagenEV, 2, 0);
            this.tblEventos.Controls.Add(this.btnEliminarEventoEV, 1, 12);
            this.tblEventos.Controls.Add(this.btnAgregarEventoEV, 3, 12);
            this.tblEventos.Controls.Add(this.btnEditarEventoEV, 2, 12);
            this.tblEventos.Location = new System.Drawing.Point(0, 0);
            this.tblEventos.Name = "tblEventos";
            this.tblEventos.RowCount = 13;
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEventos.Size = new System.Drawing.Size(1250, 601);
            this.tblEventos.TabIndex = 0;
            // 
            // dgvEventosEV
            // 
            this.dgvEventosEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEventosEV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventosEV.Location = new System.Drawing.Point(627, 3);
            this.dgvEventosEV.Name = "dgvEventosEV";
            this.dgvEventosEV.RowHeadersWidth = 51;
            this.tblEventos.SetRowSpan(this.dgvEventosEV, 13);
            this.dgvEventosEV.Size = new System.Drawing.Size(620, 595);
            this.dgvEventosEV.TabIndex = 26;
            this.dgvEventosEV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventosEV_CellClick);
            this.dgvEventosEV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventosEV_CellContentClick);
            // 
            // lblTituloEventoEV
            // 
            this.lblTituloEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloEventoEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblTituloEventoEV, 2);
            this.lblTituloEventoEV.Location = new System.Drawing.Point(3, 18);
            this.lblTituloEventoEV.Name = "lblTituloEventoEV";
            this.lblTituloEventoEV.Size = new System.Drawing.Size(306, 28);
            this.lblTituloEventoEV.TabIndex = 3;
            this.lblTituloEventoEV.Text = "Titulo del evento";
            this.lblTituloEventoEV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTituloEventoEV
            // 
            this.txtTituloEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEventos.SetColumnSpan(this.txtTituloEventoEV, 2);
            this.txtTituloEventoEV.Location = new System.Drawing.Point(3, 49);
            this.txtTituloEventoEV.Name = "txtTituloEventoEV";
            this.txtTituloEventoEV.Size = new System.Drawing.Size(306, 34);
            this.txtTituloEventoEV.TabIndex = 4;
            // 
            // lblFechaInicioEventoEV
            // 
            this.lblFechaInicioEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInicioEventoEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblFechaInicioEventoEV, 2);
            this.lblFechaInicioEventoEV.Location = new System.Drawing.Point(3, 110);
            this.lblFechaInicioEventoEV.Name = "lblFechaInicioEventoEV";
            this.lblFechaInicioEventoEV.Size = new System.Drawing.Size(306, 28);
            this.lblFechaInicioEventoEV.TabIndex = 5;
            this.lblFechaInicioEventoEV.Text = "Fecha de inicio";
            this.lblFechaInicioEventoEV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaInicioEV
            // 
            this.tblEventos.SetColumnSpan(this.dtpFechaInicioEV, 2);
            this.dtpFechaInicioEV.Location = new System.Drawing.Point(3, 141);
            this.dtpFechaInicioEV.Name = "dtpFechaInicioEV";
            this.dtpFechaInicioEV.Size = new System.Drawing.Size(306, 34);
            this.dtpFechaInicioEV.TabIndex = 17;
            // 
            // lblFechaFinalizacionEventoEV
            // 
            this.lblFechaFinalizacionEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFinalizacionEventoEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblFechaFinalizacionEventoEV, 2);
            this.lblFechaFinalizacionEventoEV.Location = new System.Drawing.Point(3, 202);
            this.lblFechaFinalizacionEventoEV.Name = "lblFechaFinalizacionEventoEV";
            this.lblFechaFinalizacionEventoEV.Size = new System.Drawing.Size(306, 28);
            this.lblFechaFinalizacionEventoEV.TabIndex = 18;
            this.lblFechaFinalizacionEventoEV.Text = "Fecha de finalización";
            this.lblFechaFinalizacionEventoEV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaFinalizacionEV
            // 
            this.tblEventos.SetColumnSpan(this.dtpFechaFinalizacionEV, 2);
            this.dtpFechaFinalizacionEV.Location = new System.Drawing.Point(3, 233);
            this.dtpFechaFinalizacionEV.Name = "dtpFechaFinalizacionEV";
            this.dtpFechaFinalizacionEV.Size = new System.Drawing.Size(306, 34);
            this.dtpFechaFinalizacionEV.TabIndex = 19;
            // 
            // lblObjetivosEventoEV
            // 
            this.lblObjetivosEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObjetivosEventoEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblObjetivosEventoEV, 2);
            this.lblObjetivosEventoEV.Location = new System.Drawing.Point(3, 294);
            this.lblObjetivosEventoEV.Name = "lblObjetivosEventoEV";
            this.lblObjetivosEventoEV.Size = new System.Drawing.Size(306, 28);
            this.lblObjetivosEventoEV.TabIndex = 13;
            this.lblObjetivosEventoEV.Text = "Objetivos del evento";
            this.lblObjetivosEventoEV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbObjetivoEventoEV
            // 
            this.rtbObjetivoEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEventos.SetColumnSpan(this.rtbObjetivoEventoEV, 2);
            this.rtbObjetivoEventoEV.Location = new System.Drawing.Point(3, 325);
            this.rtbObjetivoEventoEV.Name = "rtbObjetivoEventoEV";
            this.rtbObjetivoEventoEV.Size = new System.Drawing.Size(306, 40);
            this.rtbObjetivoEventoEV.TabIndex = 23;
            this.rtbObjetivoEventoEV.Text = "";
            // 
            // lblAreaEventoEV
            // 
            this.lblAreaEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAreaEventoEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblAreaEventoEV, 2);
            this.lblAreaEventoEV.Location = new System.Drawing.Point(3, 386);
            this.lblAreaEventoEV.Name = "lblAreaEventoEV";
            this.lblAreaEventoEV.Size = new System.Drawing.Size(306, 28);
            this.lblAreaEventoEV.TabIndex = 20;
            this.lblAreaEventoEV.Text = "Área del evento";
            this.lblAreaEventoEV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAreaEventoEV
            // 
            this.cmbAreaEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEventos.SetColumnSpan(this.cmbAreaEventoEV, 2);
            this.cmbAreaEventoEV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaEventoEV.FormattingEnabled = true;
            this.cmbAreaEventoEV.Location = new System.Drawing.Point(3, 417);
            this.cmbAreaEventoEV.Name = "cmbAreaEventoEV";
            this.cmbAreaEventoEV.Size = new System.Drawing.Size(306, 36);
            this.cmbAreaEventoEV.TabIndex = 14;
            // 
            // lblNumeroAsistentesEV
            // 
            this.lblNumeroAsistentesEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroAsistentesEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblNumeroAsistentesEV, 2);
            this.lblNumeroAsistentesEV.Location = new System.Drawing.Point(3, 478);
            this.lblNumeroAsistentesEV.Name = "lblNumeroAsistentesEV";
            this.lblNumeroAsistentesEV.Size = new System.Drawing.Size(306, 28);
            this.lblNumeroAsistentesEV.TabIndex = 21;
            this.lblNumeroAsistentesEV.Text = "Número de asistentes";
            this.lblNumeroAsistentesEV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudNumeroAsistentesEV
            // 
            this.nudNumeroAsistentesEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEventos.SetColumnSpan(this.nudNumeroAsistentesEV, 2);
            this.nudNumeroAsistentesEV.Location = new System.Drawing.Point(3, 509);
            this.nudNumeroAsistentesEV.Name = "nudNumeroAsistentesEV";
            this.nudNumeroAsistentesEV.Size = new System.Drawing.Size(306, 34);
            this.nudNumeroAsistentesEV.TabIndex = 16;
            // 
            // btnDejarDeEditarEV
            // 
            this.btnDejarDeEditarEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDejarDeEditarEV.Enabled = false;
            this.btnDejarDeEditarEV.Location = new System.Drawing.Point(3, 555);
            this.btnDejarDeEditarEV.Name = "btnDejarDeEditarEV";
            this.btnDejarDeEditarEV.Size = new System.Drawing.Size(150, 43);
            this.btnDejarDeEditarEV.TabIndex = 24;
            this.btnDejarDeEditarEV.Text = "Dejar de editar";
            this.btnDejarDeEditarEV.UseVisualStyleBackColor = true;
            this.btnDejarDeEditarEV.Click += new System.EventHandler(this.btnDejarDeEditarEV_Click);
            // 
            // picImagenEV
            // 
            this.picImagenEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEventos.SetColumnSpan(this.picImagenEV, 2);
            this.picImagenEV.Image = global::BINAES.Properties.Resources._default;
            this.picImagenEV.Location = new System.Drawing.Point(315, 49);
            this.picImagenEV.Name = "picImagenEV";
            this.tblEventos.SetRowSpan(this.picImagenEV, 11);
            this.picImagenEV.Size = new System.Drawing.Size(306, 500);
            this.picImagenEV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagenEV.TabIndex = 28;
            this.picImagenEV.TabStop = false;
            this.picImagenEV.Click += new System.EventHandler(this.picImagenEV_Click);
            // 
            // lblImagenEV
            // 
            this.lblImagenEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagenEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblImagenEV, 2);
            this.lblImagenEV.Location = new System.Drawing.Point(315, 18);
            this.lblImagenEV.Name = "lblImagenEV";
            this.lblImagenEV.Size = new System.Drawing.Size(306, 28);
            this.lblImagenEV.TabIndex = 27;
            this.lblImagenEV.Text = "Imagen";
            // 
            // btnEliminarEventoEV
            // 
            this.btnEliminarEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEventoEV.Enabled = false;
            this.btnEliminarEventoEV.Location = new System.Drawing.Point(159, 555);
            this.btnEliminarEventoEV.Name = "btnEliminarEventoEV";
            this.btnEliminarEventoEV.Size = new System.Drawing.Size(150, 43);
            this.btnEliminarEventoEV.TabIndex = 29;
            this.btnEliminarEventoEV.Text = "Eliminar";
            this.btnEliminarEventoEV.UseVisualStyleBackColor = true;
            this.btnEliminarEventoEV.Click += new System.EventHandler(this.btnEliminarEventoEV_Click);
            // 
            // btnAgregarEventoEV
            // 
            this.btnAgregarEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEventoEV.Location = new System.Drawing.Point(471, 555);
            this.btnAgregarEventoEV.Name = "btnAgregarEventoEV";
            this.btnAgregarEventoEV.Size = new System.Drawing.Size(150, 43);
            this.btnAgregarEventoEV.TabIndex = 22;
            this.btnAgregarEventoEV.Tag = "1";
            this.btnAgregarEventoEV.Text = "Agregar";
            this.btnAgregarEventoEV.UseVisualStyleBackColor = true;
            this.btnAgregarEventoEV.Click += new System.EventHandler(this.btnAgregarEV_Click);
            // 
            // btnEditarEventoEV
            // 
            this.btnEditarEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarEventoEV.Location = new System.Drawing.Point(315, 555);
            this.btnEditarEventoEV.Name = "btnEditarEventoEV";
            this.btnEditarEventoEV.Size = new System.Drawing.Size(150, 43);
            this.btnEditarEventoEV.TabIndex = 30;
            this.btnEditarEventoEV.Text = "Actualizar";
            this.btnEditarEventoEV.UseVisualStyleBackColor = true;
            this.btnEditarEventoEV.Click += new System.EventHandler(this.btnActualizarEventoEV_Click);
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.tblEjemplares);
            this.tabAgregar.Location = new System.Drawing.Point(4, 40);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Size = new System.Drawing.Size(1250, 594);
            this.tabAgregar.TabIndex = 3;
            this.tabAgregar.Text = "Agregar ejemplar";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // tblEjemplares
            // 
            this.tblEjemplares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEjemplares.ColumnCount = 3;
            this.tblEjemplares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblEjemplares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblEjemplares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblEjemplares.Controls.Add(this.btnSalirEdicionEjemplarAG, 0, 12);
            this.tblEjemplares.Controls.Add(this.btnAgregarEjemplarAG, 0, 12);
            this.tblEjemplares.Controls.Add(this.txtEditorialEjemplarAG, 1, 1);
            this.tblEjemplares.Controls.Add(this.lblImagenEjemplarEJ, 1, 6);
            this.tblEjemplares.Controls.Add(this.lblNombreEjemplarEJ, 0, 2);
            this.tblEjemplares.Controls.Add(this.lblAutorEjemplarEJ, 0, 4);
            this.tblEjemplares.Controls.Add(this.lblFechaPublicacionEjemplarEJ, 1, 2);
            this.tblEjemplares.Controls.Add(this.lblIdiomaEjemplarEJ, 0, 6);
            this.tblEjemplares.Controls.Add(this.lblEditorialEjemplarEJ, 1, 0);
            this.tblEjemplares.Controls.Add(this.lblEtiquetasEjemplarEJ, 0, 10);
            this.tblEjemplares.Controls.Add(this.lblFormatoEjemplarEJ, 0, 8);
            this.tblEjemplares.Controls.Add(this.lblTipoColeccionEjemplarEJ, 1, 4);
            this.tblEjemplares.Controls.Add(this.lblCodigoEjemplarEJ, 0, 0);
            this.tblEjemplares.Controls.Add(this.txtCodigoEjemplarAG, 0, 1);
            this.tblEjemplares.Controls.Add(this.cmbIdiomaEjemplarAG, 0, 7);
            this.tblEjemplares.Controls.Add(this.btnEtiquetasEjemplarAG, 0, 11);
            this.tblEjemplares.Controls.Add(this.txtNombreEjemplarAG, 0, 3);
            this.tblEjemplares.Controls.Add(this.txtAutorEjemplarAG, 0, 5);
            this.tblEjemplares.Controls.Add(this.cmbTipoColeccionEjemplarAG, 1, 5);
            this.tblEjemplares.Controls.Add(this.cmbFormatoEjemplarAG, 0, 9);
            this.tblEjemplares.Controls.Add(this.dgvEjemplaresAG, 2, 0);
            this.tblEjemplares.Controls.Add(this.dtpFechaPublicacionEjemplarAG, 1, 3);
            this.tblEjemplares.Controls.Add(this.picEjemplarAG, 1, 7);
            this.tblEjemplares.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblEjemplares.Location = new System.Drawing.Point(0, 0);
            this.tblEjemplares.Name = "tblEjemplares";
            this.tblEjemplares.RowCount = 13;
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblEjemplares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEjemplares.Size = new System.Drawing.Size(1250, 601);
            this.tblEjemplares.TabIndex = 11;
            // 
            // btnSalirEdicionEjemplarAG
            // 
            this.btnSalirEdicionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirEdicionEjemplarAG.Enabled = false;
            this.btnSalirEdicionEjemplarAG.Location = new System.Drawing.Point(3, 555);
            this.btnSalirEdicionEjemplarAG.Name = "btnSalirEdicionEjemplarAG";
            this.btnSalirEdicionEjemplarAG.Size = new System.Drawing.Size(244, 43);
            this.btnSalirEdicionEjemplarAG.TabIndex = 28;
            this.btnSalirEdicionEjemplarAG.Text = "Dejar de editar";
            this.btnSalirEdicionEjemplarAG.UseVisualStyleBackColor = true;
            this.btnSalirEdicionEjemplarAG.Click += new System.EventHandler(this.btnSalirEdicionEjemplarAG_Click);
            // 
            // btnAgregarEjemplarAG
            // 
            this.btnAgregarEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEjemplarAG.Location = new System.Drawing.Point(253, 555);
            this.btnAgregarEjemplarAG.Name = "btnAgregarEjemplarAG";
            this.btnAgregarEjemplarAG.Size = new System.Drawing.Size(244, 43);
            this.btnAgregarEjemplarAG.TabIndex = 27;
            this.btnAgregarEjemplarAG.Text = "Agregar";
            this.btnAgregarEjemplarAG.UseVisualStyleBackColor = true;
            this.btnAgregarEjemplarAG.Click += new System.EventHandler(this.btnAgregarEjemplarAG_Click);
            // 
            // txtEditorialEjemplarAG
            // 
            this.txtEditorialEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditorialEjemplarAG.Location = new System.Drawing.Point(253, 49);
            this.txtEditorialEjemplarAG.Name = "txtEditorialEjemplarAG";
            this.txtEditorialEjemplarAG.Size = new System.Drawing.Size(244, 34);
            this.txtEditorialEjemplarAG.TabIndex = 22;
            // 
            // lblImagenEjemplarEJ
            // 
            this.lblImagenEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImagenEjemplarEJ.AutoSize = true;
            this.lblImagenEjemplarEJ.Location = new System.Drawing.Point(253, 294);
            this.lblImagenEjemplarEJ.Name = "lblImagenEjemplarEJ";
            this.lblImagenEjemplarEJ.Size = new System.Drawing.Size(77, 28);
            this.lblImagenEjemplarEJ.TabIndex = 9;
            this.lblImagenEjemplarEJ.Text = "Imagen";
            // 
            // lblNombreEjemplarEJ
            // 
            this.lblNombreEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreEjemplarEJ.AutoSize = true;
            this.lblNombreEjemplarEJ.Location = new System.Drawing.Point(3, 110);
            this.lblNombreEjemplarEJ.Name = "lblNombreEjemplarEJ";
            this.lblNombreEjemplarEJ.Size = new System.Drawing.Size(85, 28);
            this.lblNombreEjemplarEJ.TabIndex = 2;
            this.lblNombreEjemplarEJ.Text = "Nombre";
            // 
            // lblAutorEjemplarEJ
            // 
            this.lblAutorEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAutorEjemplarEJ.AutoSize = true;
            this.lblAutorEjemplarEJ.Location = new System.Drawing.Point(3, 202);
            this.lblAutorEjemplarEJ.Name = "lblAutorEjemplarEJ";
            this.lblAutorEjemplarEJ.Size = new System.Drawing.Size(62, 28);
            this.lblAutorEjemplarEJ.TabIndex = 3;
            this.lblAutorEjemplarEJ.Text = "Autor";
            // 
            // lblFechaPublicacionEjemplarEJ
            // 
            this.lblFechaPublicacionEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaPublicacionEjemplarEJ.AutoSize = true;
            this.lblFechaPublicacionEjemplarEJ.Location = new System.Drawing.Point(253, 110);
            this.lblFechaPublicacionEjemplarEJ.Name = "lblFechaPublicacionEjemplarEJ";
            this.lblFechaPublicacionEjemplarEJ.Size = new System.Drawing.Size(195, 28);
            this.lblFechaPublicacionEjemplarEJ.TabIndex = 7;
            this.lblFechaPublicacionEjemplarEJ.Text = "Fecha de publicación";
            // 
            // lblIdiomaEjemplarEJ
            // 
            this.lblIdiomaEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdiomaEjemplarEJ.AutoSize = true;
            this.lblIdiomaEjemplarEJ.Location = new System.Drawing.Point(3, 294);
            this.lblIdiomaEjemplarEJ.Name = "lblIdiomaEjemplarEJ";
            this.lblIdiomaEjemplarEJ.Size = new System.Drawing.Size(73, 28);
            this.lblIdiomaEjemplarEJ.TabIndex = 4;
            this.lblIdiomaEjemplarEJ.Text = "Idioma";
            // 
            // lblEditorialEjemplarEJ
            // 
            this.lblEditorialEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEditorialEjemplarEJ.AutoSize = true;
            this.lblEditorialEjemplarEJ.Location = new System.Drawing.Point(253, 18);
            this.lblEditorialEjemplarEJ.Name = "lblEditorialEjemplarEJ";
            this.lblEditorialEjemplarEJ.Size = new System.Drawing.Size(85, 28);
            this.lblEditorialEjemplarEJ.TabIndex = 1;
            this.lblEditorialEjemplarEJ.Text = "Editorial";
            // 
            // lblEtiquetasEjemplarEJ
            // 
            this.lblEtiquetasEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEtiquetasEjemplarEJ.AutoSize = true;
            this.lblEtiquetasEjemplarEJ.Location = new System.Drawing.Point(3, 478);
            this.lblEtiquetasEjemplarEJ.Name = "lblEtiquetasEjemplarEJ";
            this.lblEtiquetasEjemplarEJ.Size = new System.Drawing.Size(92, 28);
            this.lblEtiquetasEjemplarEJ.TabIndex = 6;
            this.lblEtiquetasEjemplarEJ.Text = "Etiquetas";
            // 
            // lblFormatoEjemplarEJ
            // 
            this.lblFormatoEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormatoEjemplarEJ.AutoSize = true;
            this.lblFormatoEjemplarEJ.Location = new System.Drawing.Point(3, 386);
            this.lblFormatoEjemplarEJ.Name = "lblFormatoEjemplarEJ";
            this.lblFormatoEjemplarEJ.Size = new System.Drawing.Size(87, 28);
            this.lblFormatoEjemplarEJ.TabIndex = 5;
            this.lblFormatoEjemplarEJ.Text = "Formato";
            // 
            // lblTipoColeccionEjemplarEJ
            // 
            this.lblTipoColeccionEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipoColeccionEjemplarEJ.AutoSize = true;
            this.lblTipoColeccionEjemplarEJ.Location = new System.Drawing.Point(253, 202);
            this.lblTipoColeccionEjemplarEJ.Name = "lblTipoColeccionEjemplarEJ";
            this.lblTipoColeccionEjemplarEJ.Size = new System.Drawing.Size(165, 28);
            this.lblTipoColeccionEjemplarEJ.TabIndex = 8;
            this.lblTipoColeccionEjemplarEJ.Text = "Tipo de colección";
            // 
            // lblCodigoEjemplarEJ
            // 
            this.lblCodigoEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigoEjemplarEJ.AutoSize = true;
            this.lblCodigoEjemplarEJ.Location = new System.Drawing.Point(3, 18);
            this.lblCodigoEjemplarEJ.Name = "lblCodigoEjemplarEJ";
            this.lblCodigoEjemplarEJ.Size = new System.Drawing.Size(158, 28);
            this.lblCodigoEjemplarEJ.TabIndex = 0;
            this.lblCodigoEjemplarEJ.Text = "Código ejemplar";
            // 
            // txtCodigoEjemplarAG
            // 
            this.txtCodigoEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoEjemplarAG.Location = new System.Drawing.Point(3, 49);
            this.txtCodigoEjemplarAG.Name = "txtCodigoEjemplarAG";
            this.txtCodigoEjemplarAG.Size = new System.Drawing.Size(244, 34);
            this.txtCodigoEjemplarAG.TabIndex = 10;
            // 
            // cmbIdiomaEjemplarAG
            // 
            this.cmbIdiomaEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdiomaEjemplarAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdiomaEjemplarAG.FormattingEnabled = true;
            this.cmbIdiomaEjemplarAG.Location = new System.Drawing.Point(3, 325);
            this.cmbIdiomaEjemplarAG.Name = "cmbIdiomaEjemplarAG";
            this.cmbIdiomaEjemplarAG.Size = new System.Drawing.Size(244, 36);
            this.cmbIdiomaEjemplarAG.TabIndex = 13;
            // 
            // btnEtiquetasEjemplarAG
            // 
            this.btnEtiquetasEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEtiquetasEjemplarAG.Location = new System.Drawing.Point(3, 509);
            this.btnEtiquetasEjemplarAG.Name = "btnEtiquetasEjemplarAG";
            this.btnEtiquetasEjemplarAG.Size = new System.Drawing.Size(244, 40);
            this.btnEtiquetasEjemplarAG.TabIndex = 15;
            this.btnEtiquetasEjemplarAG.Text = "Seleccionar";
            this.btnEtiquetasEjemplarAG.UseVisualStyleBackColor = true;
            // 
            // txtNombreEjemplarAG
            // 
            this.txtNombreEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreEjemplarAG.Location = new System.Drawing.Point(3, 141);
            this.txtNombreEjemplarAG.Name = "txtNombreEjemplarAG";
            this.txtNombreEjemplarAG.Size = new System.Drawing.Size(244, 34);
            this.txtNombreEjemplarAG.TabIndex = 23;
            // 
            // txtAutorEjemplarAG
            // 
            this.txtAutorEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutorEjemplarAG.Location = new System.Drawing.Point(3, 233);
            this.txtAutorEjemplarAG.Name = "txtAutorEjemplarAG";
            this.txtAutorEjemplarAG.Size = new System.Drawing.Size(244, 34);
            this.txtAutorEjemplarAG.TabIndex = 24;
            // 
            // cmbTipoColeccionEjemplarAG
            // 
            this.cmbTipoColeccionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoColeccionEjemplarAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoColeccionEjemplarAG.FormattingEnabled = true;
            this.cmbTipoColeccionEjemplarAG.Location = new System.Drawing.Point(253, 233);
            this.cmbTipoColeccionEjemplarAG.Name = "cmbTipoColeccionEjemplarAG";
            this.cmbTipoColeccionEjemplarAG.Size = new System.Drawing.Size(244, 36);
            this.cmbTipoColeccionEjemplarAG.TabIndex = 25;
            // 
            // cmbFormatoEjemplarAG
            // 
            this.cmbFormatoEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormatoEjemplarAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormatoEjemplarAG.FormattingEnabled = true;
            this.cmbFormatoEjemplarAG.Location = new System.Drawing.Point(3, 417);
            this.cmbFormatoEjemplarAG.Name = "cmbFormatoEjemplarAG";
            this.cmbFormatoEjemplarAG.Size = new System.Drawing.Size(244, 36);
            this.cmbFormatoEjemplarAG.TabIndex = 26;
            // 
            // dgvEjemplaresAG
            // 
            this.dgvEjemplaresAG.AllowUserToAddRows = false;
            this.dgvEjemplaresAG.AllowUserToDeleteRows = false;
            this.dgvEjemplaresAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplaresAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEjemplaresAG.Location = new System.Drawing.Point(503, 3);
            this.dgvEjemplaresAG.Name = "dgvEjemplaresAG";
            this.dgvEjemplaresAG.ReadOnly = true;
            this.dgvEjemplaresAG.RowHeadersWidth = 51;
            this.tblEjemplares.SetRowSpan(this.dgvEjemplaresAG, 13);
            this.dgvEjemplaresAG.Size = new System.Drawing.Size(744, 595);
            this.dgvEjemplaresAG.TabIndex = 29;
            // 
            // dtpFechaPublicacionEjemplarAG
            // 
            this.dtpFechaPublicacionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPublicacionEjemplarAG.Location = new System.Drawing.Point(253, 141);
            this.dtpFechaPublicacionEjemplarAG.Name = "dtpFechaPublicacionEjemplarAG";
            this.dtpFechaPublicacionEjemplarAG.Size = new System.Drawing.Size(244, 34);
            this.dtpFechaPublicacionEjemplarAG.TabIndex = 30;
            // 
            // picEjemplarAG
            // 
            this.picEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picEjemplarAG.Image = global::BINAES.Properties.Resources._default;
            this.picEjemplarAG.Location = new System.Drawing.Point(253, 325);
            this.picEjemplarAG.Name = "picEjemplarAG";
            this.tblEjemplares.SetRowSpan(this.picEjemplarAG, 5);
            this.picEjemplarAG.Size = new System.Drawing.Size(244, 224);
            this.picEjemplarAG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEjemplarAG.TabIndex = 31;
            this.picEjemplarAG.TabStop = false;
            this.picEjemplarAG.Click += new System.EventHandler(this.picEjemplarAG_Click);
            // 
            // tabReserva
            // 
            this.tabReserva.Controls.Add(this.tblReserva);
            this.tabReserva.Location = new System.Drawing.Point(4, 40);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabReserva.Size = new System.Drawing.Size(1250, 594);
            this.tabReserva.TabIndex = 2;
            this.tabReserva.Text = "Reservas de ejemplares";
            this.tabReserva.UseVisualStyleBackColor = true;
            // 
            // tblReserva
            // 
            this.tblReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblReserva.ColumnCount = 6;
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblReserva.Controls.Add(this.dgvReservasRE, 4, 1);
            this.tblReserva.Controls.Add(this.lblEjemplarRE, 1, 1);
            this.tblReserva.Controls.Add(this.btnBuscarEjemplarRE, 1, 2);
            this.tblReserva.Controls.Add(this.btnReservarRE, 1, 6);
            this.tblReserva.Controls.Add(this.lblUsuarioRE, 1, 3);
            this.tblReserva.Controls.Add(this.btnQrRE, 1, 4);
            this.tblReserva.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblReserva.Location = new System.Drawing.Point(0, 0);
            this.tblReserva.Name = "tblReserva";
            this.tblReserva.RowCount = 8;
            this.tblReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.002F));
            this.tblReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblReserva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.002F));
            this.tblReserva.Size = new System.Drawing.Size(1250, 601);
            this.tblReserva.TabIndex = 12;
            // 
            // dgvReservasRE
            // 
            this.dgvReservasRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservasRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasRE.Location = new System.Drawing.Point(440, 63);
            this.dgvReservasRE.Name = "dgvReservasRE";
            this.dgvReservasRE.RowHeadersWidth = 51;
            this.tblReserva.SetRowSpan(this.dgvReservasRE, 6);
            this.dgvReservasRE.Size = new System.Drawing.Size(681, 474);
            this.dgvReservasRE.TabIndex = 31;
            // 
            // lblEjemplarRE
            // 
            this.lblEjemplarRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjemplarRE.AutoSize = true;
            this.tblReserva.SetColumnSpan(this.lblEjemplarRE, 2);
            this.lblEjemplarRE.Location = new System.Drawing.Point(128, 112);
            this.lblEjemplarRE.Name = "lblEjemplarRE";
            this.lblEjemplarRE.Size = new System.Drawing.Size(244, 28);
            this.lblEjemplarRE.TabIndex = 1;
            this.lblEjemplarRE.Text = "Ejemplar:";
            // 
            // btnBuscarEjemplarRE
            // 
            this.btnBuscarEjemplarRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblReserva.SetColumnSpan(this.btnBuscarEjemplarRE, 2);
            this.btnBuscarEjemplarRE.Location = new System.Drawing.Point(128, 143);
            this.btnBuscarEjemplarRE.Name = "btnBuscarEjemplarRE";
            this.btnBuscarEjemplarRE.Size = new System.Drawing.Size(244, 74);
            this.btnBuscarEjemplarRE.TabIndex = 33;
            this.btnBuscarEjemplarRE.Text = "Buscar";
            this.btnBuscarEjemplarRE.UseVisualStyleBackColor = true;
            this.btnBuscarEjemplarRE.Click += new System.EventHandler(this.btnBuscarEjemplarRE_Click);
            // 
            // btnReservarRE
            // 
            this.btnReservarRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblReserva.SetColumnSpan(this.btnReservarRE, 2);
            this.btnReservarRE.Location = new System.Drawing.Point(128, 463);
            this.btnReservarRE.Name = "btnReservarRE";
            this.btnReservarRE.Size = new System.Drawing.Size(244, 74);
            this.btnReservarRE.TabIndex = 32;
            this.btnReservarRE.Text = "Completar";
            this.btnReservarRE.UseVisualStyleBackColor = true;
            // 
            // lblUsuarioRE
            // 
            this.lblUsuarioRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioRE.AutoSize = true;
            this.tblReserva.SetColumnSpan(this.lblUsuarioRE, 2);
            this.lblUsuarioRE.Location = new System.Drawing.Point(128, 272);
            this.lblUsuarioRE.Name = "lblUsuarioRE";
            this.lblUsuarioRE.Size = new System.Drawing.Size(244, 28);
            this.lblUsuarioRE.TabIndex = 34;
            this.lblUsuarioRE.Text = "ID Usuario";
            // 
            // btnQrRE
            // 
            this.btnQrRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblReserva.SetColumnSpan(this.btnQrRE, 2);
            this.btnQrRE.Location = new System.Drawing.Point(128, 303);
            this.btnQrRE.Name = "btnQrRE";
            this.btnQrRE.Size = new System.Drawing.Size(244, 74);
            this.btnQrRE.TabIndex = 35;
            this.btnQrRE.Text = "QR";
            this.btnQrRE.UseVisualStyleBackColor = true;
            this.btnQrRE.Click += new System.EventHandler(this.btnQrRE_Click);
            // 
            // nudIdUsuarioRE
            // 
            this.nudIdUsuarioRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIdUsuarioRE.Location = new System.Drawing.Point(128, 311);
            this.nudIdUsuarioRE.Name = "nudIdUsuarioRE";
            this.nudIdUsuarioRE.Size = new System.Drawing.Size(368, 22);
            this.nudIdUsuarioRE.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(128, 290);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(215, 21);
            this.label26.TabIndex = 8;
            this.label26.Text = "ID usuario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(128, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 35;
            // 
            // tabPrestamo
            // 
            this.tabPrestamo.Controls.Add(this.tblPrestamo);
            this.tabPrestamo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabPrestamo.Location = new System.Drawing.Point(4, 40);
            this.tabPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Name = "tabPrestamo";
            this.tabPrestamo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Size = new System.Drawing.Size(1250, 594);
            this.tabPrestamo.TabIndex = 1;
            this.tabPrestamo.Text = "Préstamo de ejemplares";
            this.tabPrestamo.UseVisualStyleBackColor = true;
            // 
            // tblPrestamo
            // 
            this.tblPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPrestamo.ColumnCount = 5;
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.2482F));
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.389465F));
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.2506F));
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPrestamo.Controls.Add(this.dataGridView1, 3, 1);
            this.tblPrestamo.Controls.Add(this.lblEjemplarPR, 1, 1);
            this.tblPrestamo.Controls.Add(this.btnCompletarPR, 1, 6);
            this.tblPrestamo.Controls.Add(this.textBox3, 1, 5);
            this.tblPrestamo.Controls.Add(this.lblUsuarioPR, 1, 4);
            this.tblPrestamo.Controls.Add(this.btnBuscarPR, 1, 3);
            this.tblPrestamo.Controls.Add(this.textBox4, 1, 2);
            this.tblPrestamo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPrestamo.Location = new System.Drawing.Point(0, 0);
            this.tblPrestamo.Name = "tblPrestamo";
            this.tblPrestamo.RowCount = 8;
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.090615F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.796116F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32686F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.928802F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.090615F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.81877F));
            this.tblPrestamo.Size = new System.Drawing.Size(1250, 601);
            this.tblPrestamo.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.tblPrestamo.SetRowSpan(this.dataGridView1, 7);
            this.dataGridView1.Size = new System.Drawing.Size(773, 521);
            this.dataGridView1.TabIndex = 31;
            // 
            // lblEjemplarPR
            // 
            this.lblEjemplarPR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjemplarPR.AutoSize = true;
            this.lblEjemplarPR.Location = new System.Drawing.Point(128, 120);
            this.lblEjemplarPR.Name = "lblEjemplarPR";
            this.lblEjemplarPR.Size = new System.Drawing.Size(159, 28);
            this.lblEjemplarPR.TabIndex = 1;
            this.lblEjemplarPR.Text = "Ejemplar:";
            // 
            // btnCompletarPR
            // 
            this.btnCompletarPR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompletarPR.Location = new System.Drawing.Point(128, 353);
            this.btnCompletarPR.Name = "btnCompletarPR";
            this.btnCompletarPR.Size = new System.Drawing.Size(159, 42);
            this.btnCompletarPR.TabIndex = 32;
            this.btnCompletarPR.Text = "Completar";
            this.btnCompletarPR.UseVisualStyleBackColor = true;
            this.btnCompletarPR.Click += new System.EventHandler(this.btnCompletarPR_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 34);
            this.textBox3.TabIndex = 34;
            // 
            // lblUsuarioPR
            // 
            this.lblUsuarioPR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioPR.AutoSize = true;
            this.lblUsuarioPR.Location = new System.Drawing.Point(128, 275);
            this.lblUsuarioPR.Name = "lblUsuarioPR";
            this.lblUsuarioPR.Size = new System.Drawing.Size(159, 28);
            this.lblUsuarioPR.TabIndex = 8;
            this.lblUsuarioPR.Text = "ID usuario:";
            // 
            // btnBuscarPR
            // 
            this.btnBuscarPR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPR.Location = new System.Drawing.Point(128, 199);
            this.btnBuscarPR.Name = "btnBuscarPR";
            this.btnBuscarPR.Size = new System.Drawing.Size(159, 34);
            this.btnBuscarPR.TabIndex = 33;
            this.btnBuscarPR.Text = "Búscar";
            this.btnBuscarPR.UseVisualStyleBackColor = true;
            this.btnBuscarPR.Click += new System.EventHandler(this.btnBuscarPR_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(128, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 34);
            this.textBox4.TabIndex = 35;
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.Transparent;
            this.tabBuscar.Controls.Add(this.tblBusqueda);
            this.tabBuscar.Location = new System.Drawing.Point(4, 40);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Size = new System.Drawing.Size(1250, 594);
            this.tabBuscar.TabIndex = 0;
            this.tabBuscar.Text = "Búsqueda de ejemplares";
            // 
            // tblBusqueda
            // 
            this.tblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblBusqueda.AutoSize = true;
            this.tblBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.tblBusqueda.ColumnCount = 7;
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblBusqueda.Controls.Add(this.dgvEjemplaresBU, 1, 3);
            this.tblBusqueda.Controls.Add(this.txtBuscarEjemplarBU, 1, 1);
            this.tblBusqueda.Controls.Add(this.btnBuscarEjemplarBU, 2, 1);
            this.tblBusqueda.Controls.Add(this.chkBusquedaExactaBU, 3, 1);
            this.tblBusqueda.Controls.Add(this.lblFiltroBU, 3, 2);
            this.tblBusqueda.Controls.Add(this.cmbFiltrarEjemplarBU, 4, 2);
            this.tblBusqueda.Controls.Add(this.chkFísicoBU, 5, 1);
            this.tblBusqueda.Controls.Add(this.chkDigitalBU, 5, 2);
            this.tblBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tblBusqueda.Name = "tblBusqueda";
            this.tblBusqueda.RowCount = 5;
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblBusqueda.Size = new System.Drawing.Size(1250, 606);
            this.tblBusqueda.TabIndex = 2;
            // 
            // dgvEjemplaresBU
            // 
            this.dgvEjemplaresBU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEjemplaresBU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBusqueda.SetColumnSpan(this.dgvEjemplaresBU, 5);
            this.dgvEjemplaresBU.Location = new System.Drawing.Point(65, 123);
            this.dgvEjemplaresBU.Name = "dgvEjemplaresBU";
            this.dgvEjemplaresBU.RowHeadersWidth = 62;
            this.dgvEjemplaresBU.RowTemplate.Height = 28;
            this.dgvEjemplaresBU.Size = new System.Drawing.Size(1118, 448);
            this.dgvEjemplaresBU.TabIndex = 4;
            // 
            // txtBuscarEjemplarBU
            // 
            this.txtBuscarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEjemplarBU.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEjemplarBU.Location = new System.Drawing.Point(65, 53);
            this.txtBuscarEjemplarBU.Name = "txtBuscarEjemplarBU";
            this.tblBusqueda.SetRowSpan(this.txtBuscarEjemplarBU, 2);
            this.txtBuscarEjemplarBU.Size = new System.Drawing.Size(744, 43);
            this.txtBuscarEjemplarBU.TabIndex = 0;
            this.txtBuscarEjemplarBU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarEjemplarBU_KeyDown);
            // 
            // btnBuscarEjemplarBU
            // 
            this.btnBuscarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEjemplarBU.Location = new System.Drawing.Point(815, 54);
            this.btnBuscarEjemplarBU.Name = "btnBuscarEjemplarBU";
            this.tblBusqueda.SetRowSpan(this.btnBuscarEjemplarBU, 2);
            this.btnBuscarEjemplarBU.Size = new System.Drawing.Size(56, 42);
            this.btnBuscarEjemplarBU.TabIndex = 3;
            this.btnBuscarEjemplarBU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEjemplarBU.UseVisualStyleBackColor = true;
            this.btnBuscarEjemplarBU.Click += new System.EventHandler(this.btnBuscarEjemplarBU_Click);
            // 
            // chkBusquedaExactaBU
            // 
            this.chkBusquedaExactaBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBusquedaExactaBU.AutoSize = true;
            this.tblBusqueda.SetColumnSpan(this.chkBusquedaExactaBU, 2);
            this.chkBusquedaExactaBU.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBusquedaExactaBU.Location = new System.Drawing.Point(877, 45);
            this.chkBusquedaExactaBU.Name = "chkBusquedaExactaBU";
            this.chkBusquedaExactaBU.Size = new System.Drawing.Size(181, 27);
            this.chkBusquedaExactaBU.TabIndex = 5;
            this.chkBusquedaExactaBU.Text = "Búsqueda exacta";
            this.chkBusquedaExactaBU.UseVisualStyleBackColor = true;
            // 
            // lblFiltroBU
            // 
            this.lblFiltroBU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroBU.AutoSize = true;
            this.lblFiltroBU.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroBU.Location = new System.Drawing.Point(877, 75);
            this.lblFiltroBU.Name = "lblFiltroBU";
            this.lblFiltroBU.Size = new System.Drawing.Size(56, 45);
            this.lblFiltroBU.TabIndex = 6;
            this.lblFiltroBU.Text = "Filtro:";
            // 
            // cmbFiltrarEjemplarBU
            // 
            this.cmbFiltrarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarEjemplarBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarEjemplarBU.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarEjemplarBU.FormattingEnabled = true;
            this.cmbFiltrarEjemplarBU.Location = new System.Drawing.Point(939, 78);
            this.cmbFiltrarEjemplarBU.Name = "cmbFiltrarEjemplarBU";
            this.cmbFiltrarEjemplarBU.Size = new System.Drawing.Size(119, 31);
            this.cmbFiltrarEjemplarBU.TabIndex = 2;
            this.cmbFiltrarEjemplarBU.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarEjemplarBU_SelectedIndexChanged);
            // 
            // chkFísicoBU
            // 
            this.chkFísicoBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFísicoBU.AutoSize = true;
            this.chkFísicoBU.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFísicoBU.Location = new System.Drawing.Point(1064, 45);
            this.chkFísicoBU.Name = "chkFísicoBU";
            this.chkFísicoBU.Size = new System.Drawing.Size(119, 27);
            this.chkFísicoBU.TabIndex = 7;
            this.chkFísicoBU.Text = "Físico";
            this.chkFísicoBU.UseVisualStyleBackColor = true;
            // 
            // chkDigitalBU
            // 
            this.chkDigitalBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDigitalBU.AutoSize = true;
            this.chkDigitalBU.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDigitalBU.Location = new System.Drawing.Point(1064, 78);
            this.chkDigitalBU.Name = "chkDigitalBU";
            this.chkDigitalBU.Size = new System.Drawing.Size(119, 27);
            this.chkDigitalBU.TabIndex = 8;
            this.chkDigitalBU.Text = "Digital";
            this.chkDigitalBU.UseVisualStyleBackColor = true;
            // 
            // tabAdmin
            // 
            this.tabAdmin.AccessibleDescription = "";
            this.tabAdmin.AccessibleName = "";
            this.tabAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAdmin.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabAdmin.CausesValidation = false;
            this.tabAdmin.Controls.Add(this.tabBuscar);
            this.tabAdmin.Controls.Add(this.tabPrestamo);
            this.tabAdmin.Controls.Add(this.tabReserva);
            this.tabAdmin.Controls.Add(this.tabAgregar);
            this.tabAdmin.Controls.Add(this.tabEventos);
            this.tabAdmin.Controls.Add(this.tabUsuarios);
            this.tabAdmin.Controls.Add(this.tabMisionVision);
            this.tabAdmin.Controls.Add(this.tabIntroduccion);
            this.tabAdmin.Controls.Add(this.tabColeccion);
            this.tabAdmin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1258, 638);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.TabStop = false;
            this.tabAdmin.Tag = "";
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            this.tabAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabAdmin_KeyDown);
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tblUsuarios);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 40);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(1250, 594);
            this.tabUsuarios.TabIndex = 9;
            this.tabUsuarios.Text = "Usuarios";
            // 
            // tblUsuarios
            // 
            this.tblUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblUsuarios.ColumnCount = 4;
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUsuarios.Controls.Add(this.lblFotoUsuarioUS, 1, 4);
            this.tblUsuarios.Controls.Add(this.btnDejarDeEditarUS, 0, 12);
            this.tblUsuarios.Controls.Add(this.btnAgregarUS, 0, 12);
            this.tblUsuarios.Controls.Add(this.dgvUsuariosUS, 3, 0);
            this.tblUsuarios.Controls.Add(this.lblNombreUsuarioUS, 0, 0);
            this.tblUsuarios.Controls.Add(this.txtNombreUS, 0, 1);
            this.tblUsuarios.Controls.Add(this.lblInstitucionUsuarioUS, 0, 6);
            this.tblUsuarios.Controls.Add(this.txtInstitucionUS, 0, 7);
            this.tblUsuarios.Controls.Add(this.cmbOcupacionUS, 0, 11);
            this.tblUsuarios.Controls.Add(this.lblOcupacionUsuarioUS, 0, 10);
            this.tblUsuarios.Controls.Add(this.lblContraseniaUsuarioUS, 0, 2);
            this.tblUsuarios.Controls.Add(this.txtContraseñaUS, 0, 3);
            this.tblUsuarios.Controls.Add(this.lblDireccionUsuarioUS, 0, 8);
            this.tblUsuarios.Controls.Add(this.txtDireccionUS, 0, 9);
            this.tblUsuarios.Controls.Add(this.txtEmailUS, 0, 5);
            this.tblUsuarios.Controls.Add(this.lblEmailUsuarioUS, 0, 4);
            this.tblUsuarios.Controls.Add(this.txtTelefonoUS, 1, 1);
            this.tblUsuarios.Controls.Add(this.lblTelefonoUsuarioUS, 1, 0);
            this.tblUsuarios.Controls.Add(this.lblRolUsuarioUS, 1, 2);
            this.tblUsuarios.Controls.Add(this.cmbRolUS, 1, 3);
            this.tblUsuarios.Controls.Add(this.picFotoUS, 1, 5);
            this.tblUsuarios.Controls.Add(this.btnTomarFotoUS, 1, 11);
            this.tblUsuarios.Controls.Add(this.btnCancelarFotoUS, 2, 11);
            this.tblUsuarios.Controls.Add(this.btnActualizarUS, 2, 12);
            this.tblUsuarios.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tblUsuarios.Name = "tblUsuarios";
            this.tblUsuarios.RowCount = 13;
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUsuarios.Size = new System.Drawing.Size(1250, 601);
            this.tblUsuarios.TabIndex = 12;
            // 
            // lblFotoUsuarioUS
            // 
            this.lblFotoUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFotoUsuarioUS.AutoSize = true;
            this.tblUsuarios.SetColumnSpan(this.lblFotoUsuarioUS, 2);
            this.lblFotoUsuarioUS.Location = new System.Drawing.Point(315, 202);
            this.lblFotoUsuarioUS.Name = "lblFotoUsuarioUS";
            this.lblFotoUsuarioUS.Size = new System.Drawing.Size(306, 28);
            this.lblFotoUsuarioUS.TabIndex = 49;
            this.lblFotoUsuarioUS.Text = "Foto";
            // 
            // btnDejarDeEditarUS
            // 
            this.btnDejarDeEditarUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDejarDeEditarUS.Enabled = false;
            this.btnDejarDeEditarUS.Location = new System.Drawing.Point(3, 555);
            this.btnDejarDeEditarUS.Name = "btnDejarDeEditarUS";
            this.btnDejarDeEditarUS.Size = new System.Drawing.Size(306, 43);
            this.btnDejarDeEditarUS.TabIndex = 28;
            this.btnDejarDeEditarUS.Text = "Dejar de editar";
            this.btnDejarDeEditarUS.UseVisualStyleBackColor = true;
            // 
            // dgvUsuariosUS
            // 
            this.dgvUsuariosUS.AllowUserToAddRows = false;
            this.dgvUsuariosUS.AllowUserToDeleteRows = false;
            this.dgvUsuariosUS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosUS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuariosUS.Location = new System.Drawing.Point(627, 3);
            this.dgvUsuariosUS.Name = "dgvUsuariosUS";
            this.dgvUsuariosUS.ReadOnly = true;
            this.dgvUsuariosUS.RowHeadersWidth = 51;
            this.tblUsuarios.SetRowSpan(this.dgvUsuariosUS, 13);
            this.dgvUsuariosUS.Size = new System.Drawing.Size(620, 595);
            this.dgvUsuariosUS.TabIndex = 29;
            this.dgvUsuariosUS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosUS_CellContentClick);
            // 
            // lblNombreUsuarioUS
            // 
            this.lblNombreUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuarioUS.AutoSize = true;
            this.lblNombreUsuarioUS.Location = new System.Drawing.Point(3, 18);
            this.lblNombreUsuarioUS.Name = "lblNombreUsuarioUS";
            this.lblNombreUsuarioUS.Size = new System.Drawing.Size(306, 28);
            this.lblNombreUsuarioUS.TabIndex = 30;
            this.lblNombreUsuarioUS.Text = "Nombre";
            // 
            // txtNombreUS
            // 
            this.txtNombreUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUS.Location = new System.Drawing.Point(3, 49);
            this.txtNombreUS.Name = "txtNombreUS";
            this.txtNombreUS.Size = new System.Drawing.Size(306, 34);
            this.txtNombreUS.TabIndex = 31;
            // 
            // lblInstitucionUsuarioUS
            // 
            this.lblInstitucionUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstitucionUsuarioUS.AutoSize = true;
            this.lblInstitucionUsuarioUS.Location = new System.Drawing.Point(3, 294);
            this.lblInstitucionUsuarioUS.Name = "lblInstitucionUsuarioUS";
            this.lblInstitucionUsuarioUS.Size = new System.Drawing.Size(306, 28);
            this.lblInstitucionUsuarioUS.TabIndex = 36;
            this.lblInstitucionUsuarioUS.Text = "Institución";
            this.lblInstitucionUsuarioUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInstitucionUS
            // 
            this.txtInstitucionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstitucionUS.Location = new System.Drawing.Point(3, 325);
            this.txtInstitucionUS.Name = "txtInstitucionUS";
            this.txtInstitucionUS.Size = new System.Drawing.Size(306, 34);
            this.txtInstitucionUS.TabIndex = 37;
            // 
            // cmbOcupacionUS
            // 
            this.cmbOcupacionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOcupacionUS.FormattingEnabled = true;
            this.cmbOcupacionUS.Location = new System.Drawing.Point(3, 509);
            this.cmbOcupacionUS.Name = "cmbOcupacionUS";
            this.cmbOcupacionUS.Size = new System.Drawing.Size(306, 36);
            this.cmbOcupacionUS.TabIndex = 33;
            // 
            // lblOcupacionUsuarioUS
            // 
            this.lblOcupacionUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOcupacionUsuarioUS.AutoSize = true;
            this.lblOcupacionUsuarioUS.Location = new System.Drawing.Point(3, 478);
            this.lblOcupacionUsuarioUS.Name = "lblOcupacionUsuarioUS";
            this.lblOcupacionUsuarioUS.Size = new System.Drawing.Size(306, 28);
            this.lblOcupacionUsuarioUS.TabIndex = 32;
            this.lblOcupacionUsuarioUS.Text = "Ocupación";
            this.lblOcupacionUsuarioUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContraseniaUsuarioUS
            // 
            this.lblContraseniaUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseniaUsuarioUS.AutoSize = true;
            this.lblContraseniaUsuarioUS.Location = new System.Drawing.Point(3, 110);
            this.lblContraseniaUsuarioUS.Name = "lblContraseniaUsuarioUS";
            this.lblContraseniaUsuarioUS.Size = new System.Drawing.Size(306, 28);
            this.lblContraseniaUsuarioUS.TabIndex = 42;
            this.lblContraseniaUsuarioUS.Text = "Contraseña";
            // 
            // txtContraseñaUS
            // 
            this.txtContraseñaUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaUS.Location = new System.Drawing.Point(3, 141);
            this.txtContraseñaUS.Name = "txtContraseñaUS";
            this.txtContraseñaUS.Size = new System.Drawing.Size(306, 34);
            this.txtContraseñaUS.TabIndex = 43;
            // 
            // lblDireccionUsuarioUS
            // 
            this.lblDireccionUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccionUsuarioUS.AutoSize = true;
            this.lblDireccionUsuarioUS.Location = new System.Drawing.Point(3, 386);
            this.lblDireccionUsuarioUS.Name = "lblDireccionUsuarioUS";
            this.lblDireccionUsuarioUS.Size = new System.Drawing.Size(306, 28);
            this.lblDireccionUsuarioUS.TabIndex = 34;
            this.lblDireccionUsuarioUS.Text = "Dirección";
            // 
            // txtDireccionUS
            // 
            this.txtDireccionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionUS.Location = new System.Drawing.Point(3, 417);
            this.txtDireccionUS.Name = "txtDireccionUS";
            this.txtDireccionUS.Size = new System.Drawing.Size(306, 34);
            this.txtDireccionUS.TabIndex = 35;
            // 
            // txtEmailUS
            // 
            this.txtEmailUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailUS.Location = new System.Drawing.Point(3, 233);
            this.txtEmailUS.Name = "txtEmailUS";
            this.txtEmailUS.Size = new System.Drawing.Size(306, 34);
            this.txtEmailUS.TabIndex = 39;
            // 
            // lblEmailUsuarioUS
            // 
            this.lblEmailUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailUsuarioUS.AutoSize = true;
            this.lblEmailUsuarioUS.Location = new System.Drawing.Point(3, 202);
            this.lblEmailUsuarioUS.Name = "lblEmailUsuarioUS";
            this.lblEmailUsuarioUS.Size = new System.Drawing.Size(306, 28);
            this.lblEmailUsuarioUS.TabIndex = 38;
            this.lblEmailUsuarioUS.Text = "E-mail";
            this.lblEmailUsuarioUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefonoUS
            // 
            this.txtTelefonoUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblUsuarios.SetColumnSpan(this.txtTelefonoUS, 2);
            this.txtTelefonoUS.Location = new System.Drawing.Point(315, 49);
            this.txtTelefonoUS.Name = "txtTelefonoUS";
            this.txtTelefonoUS.Size = new System.Drawing.Size(306, 34);
            this.txtTelefonoUS.TabIndex = 45;
            // 
            // lblTelefonoUsuarioUS
            // 
            this.lblTelefonoUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoUsuarioUS.AutoSize = true;
            this.tblUsuarios.SetColumnSpan(this.lblTelefonoUsuarioUS, 2);
            this.lblTelefonoUsuarioUS.Location = new System.Drawing.Point(315, 18);
            this.lblTelefonoUsuarioUS.Name = "lblTelefonoUsuarioUS";
            this.lblTelefonoUsuarioUS.Size = new System.Drawing.Size(306, 28);
            this.lblTelefonoUsuarioUS.TabIndex = 44;
            this.lblTelefonoUsuarioUS.Text = "Teléfono";
            this.lblTelefonoUsuarioUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRolUsuarioUS
            // 
            this.lblRolUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRolUsuarioUS.AutoSize = true;
            this.tblUsuarios.SetColumnSpan(this.lblRolUsuarioUS, 2);
            this.lblRolUsuarioUS.Location = new System.Drawing.Point(315, 110);
            this.lblRolUsuarioUS.Name = "lblRolUsuarioUS";
            this.lblRolUsuarioUS.Size = new System.Drawing.Size(306, 28);
            this.lblRolUsuarioUS.TabIndex = 40;
            this.lblRolUsuarioUS.Text = "Rol";
            // 
            // cmbRolUS
            // 
            this.cmbRolUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblUsuarios.SetColumnSpan(this.cmbRolUS, 2);
            this.cmbRolUS.FormattingEnabled = true;
            this.cmbRolUS.Location = new System.Drawing.Point(315, 141);
            this.cmbRolUS.Name = "cmbRolUS";
            this.cmbRolUS.Size = new System.Drawing.Size(306, 36);
            this.cmbRolUS.TabIndex = 41;
            // 
            // picFotoUS
            // 
            this.tblUsuarios.SetColumnSpan(this.picFotoUS, 2);
            this.picFotoUS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFotoUS.Image = global::BINAES.Properties.Resources._default;
            this.picFotoUS.Location = new System.Drawing.Point(315, 233);
            this.picFotoUS.Name = "picFotoUS";
            this.tblUsuarios.SetRowSpan(this.picFotoUS, 6);
            this.picFotoUS.Size = new System.Drawing.Size(306, 270);
            this.picFotoUS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoUS.TabIndex = 46;
            this.picFotoUS.TabStop = false;
            this.picFotoUS.Click += new System.EventHandler(this.picFotoUS_Click);
            // 
            // btnTomarFotoUS
            // 
            this.btnTomarFotoUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTomarFotoUS.Location = new System.Drawing.Point(315, 509);
            this.btnTomarFotoUS.Name = "btnTomarFotoUS";
            this.btnTomarFotoUS.Size = new System.Drawing.Size(150, 40);
            this.btnTomarFotoUS.TabIndex = 47;
            this.btnTomarFotoUS.Text = "Tomar foto";
            this.btnTomarFotoUS.UseVisualStyleBackColor = true;
            this.btnTomarFotoUS.Click += new System.EventHandler(this.btnTomarFotoUS_Click);
            // 
            // btnCancelarFotoUS
            // 
            this.btnCancelarFotoUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFotoUS.Enabled = false;
            this.btnCancelarFotoUS.Location = new System.Drawing.Point(471, 509);
            this.btnCancelarFotoUS.Name = "btnCancelarFotoUS";
            this.btnCancelarFotoUS.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarFotoUS.TabIndex = 48;
            this.btnCancelarFotoUS.Text = "Cancelar foto";
            this.btnCancelarFotoUS.UseVisualStyleBackColor = true;
            this.btnCancelarFotoUS.Click += new System.EventHandler(this.btnCancelarFotoUS_Click);
            // 
            // btnActualizarUS
            // 
            this.btnActualizarUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarUS.Location = new System.Drawing.Point(471, 555);
            this.btnActualizarUS.Name = "btnActualizarUS";
            this.btnActualizarUS.Size = new System.Drawing.Size(150, 43);
            this.btnActualizarUS.TabIndex = 50;
            this.btnActualizarUS.Text = "Actualizar";
            this.btnActualizarUS.UseVisualStyleBackColor = true;
            this.btnActualizarUS.Click += new System.EventHandler(this.btnActualizarUS_Click);
            // 
            // tabMisionVision
            // 
            this.tabMisionVision.Controls.Add(this.tblMisionVision);
            this.tabMisionVision.Location = new System.Drawing.Point(4, 40);
            this.tabMisionVision.Name = "tabMisionVision";
            this.tabMisionVision.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisionVision.Size = new System.Drawing.Size(1250, 594);
            this.tabMisionVision.TabIndex = 6;
            this.tabMisionVision.Text = "Mision y Vision";
            this.tabMisionVision.UseVisualStyleBackColor = true;
            // 
            // tblMisionVision
            // 
            this.tblMisionVision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMisionVision.ColumnCount = 1;
            this.tblMisionVision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMisionVision.Controls.Add(this.lblMision, 0, 0);
            this.tblMisionVision.Controls.Add(this.lblVision, 0, 2);
            this.tblMisionVision.Controls.Add(this.lblInfoMision, 0, 1);
            this.tblMisionVision.Controls.Add(this.lblInfoVision, 0, 3);
            this.tblMisionVision.Location = new System.Drawing.Point(0, 0);
            this.tblMisionVision.Name = "tblMisionVision";
            this.tblMisionVision.RowCount = 4;
            this.tblMisionVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMisionVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblMisionVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMisionVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblMisionVision.Size = new System.Drawing.Size(1256, 605);
            this.tblMisionVision.TabIndex = 0;
            // 
            // lblMision
            // 
            this.lblMision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMision.AutoSize = true;
            this.lblMision.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblMision.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMision.Location = new System.Drawing.Point(3, 0);
            this.lblMision.Name = "lblMision";
            this.lblMision.Size = new System.Drawing.Size(1250, 121);
            this.lblMision.TabIndex = 0;
            this.lblMision.Text = " MISIÓN ";
            this.lblMision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVision
            // 
            this.lblVision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVision.AutoSize = true;
            this.lblVision.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblVision.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVision.Location = new System.Drawing.Point(3, 302);
            this.lblVision.Name = "lblVision";
            this.lblVision.Size = new System.Drawing.Size(1250, 121);
            this.lblVision.TabIndex = 1;
            this.lblVision.Text = " VISIÓN ";
            this.lblVision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoMision
            // 
            this.lblInfoMision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoMision.AutoSize = true;
            this.lblInfoMision.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblInfoMision.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMision.Location = new System.Drawing.Point(3, 121);
            this.lblInfoMision.Name = "lblInfoMision";
            this.lblInfoMision.Size = new System.Drawing.Size(1250, 181);
            this.lblInfoMision.TabIndex = 2;
            this.lblInfoMision.Text = resources.GetString("lblInfoMision.Text");
            this.lblInfoMision.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoVision
            // 
            this.lblInfoVision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoVision.AutoSize = true;
            this.lblInfoVision.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblInfoVision.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoVision.Location = new System.Drawing.Point(3, 423);
            this.lblInfoVision.Name = "lblInfoVision";
            this.lblInfoVision.Size = new System.Drawing.Size(1250, 182);
            this.lblInfoVision.TabIndex = 3;
            this.lblInfoVision.Text = resources.GetString("lblInfoVision.Text");
            this.lblInfoVision.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabIntroduccion
            // 
            this.tabIntroduccion.Controls.Add(this.tblQuienesSomos);
            this.tabIntroduccion.Location = new System.Drawing.Point(4, 40);
            this.tabIntroduccion.Name = "tabIntroduccion";
            this.tabIntroduccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntroduccion.Size = new System.Drawing.Size(1250, 594);
            this.tabIntroduccion.TabIndex = 8;
            this.tabIntroduccion.Text = "Introduccion";
            this.tabIntroduccion.UseVisualStyleBackColor = true;
            // 
            // tblQuienesSomos
            // 
            this.tblQuienesSomos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblQuienesSomos.ColumnCount = 1;
            this.tblQuienesSomos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblQuienesSomos.Controls.Add(this.lblQuienesSomosTXT, 0, 1);
            this.tblQuienesSomos.Controls.Add(this.lblQuienesSomosTXT2, 0, 2);
            this.tblQuienesSomos.Controls.Add(this.lblQuienesSomos, 0, 0);
            this.tblQuienesSomos.Location = new System.Drawing.Point(0, 0);
            this.tblQuienesSomos.Name = "tblQuienesSomos";
            this.tblQuienesSomos.RowCount = 3;
            this.tblQuienesSomos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblQuienesSomos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblQuienesSomos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblQuienesSomos.Size = new System.Drawing.Size(1256, 605);
            this.tblQuienesSomos.TabIndex = 0;
            // 
            // lblQuienesSomosTXT
            // 
            this.lblQuienesSomosTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuienesSomosTXT.AutoSize = true;
            this.lblQuienesSomosTXT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblQuienesSomosTXT.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienesSomosTXT.Location = new System.Drawing.Point(3, 121);
            this.lblQuienesSomosTXT.Name = "lblQuienesSomosTXT";
            this.lblQuienesSomosTXT.Size = new System.Drawing.Size(1250, 242);
            this.lblQuienesSomosTXT.TabIndex = 1;
            this.lblQuienesSomosTXT.Text = resources.GetString("lblQuienesSomosTXT.Text");
            this.lblQuienesSomosTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuienesSomosTXT2
            // 
            this.lblQuienesSomosTXT2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuienesSomosTXT2.AutoSize = true;
            this.lblQuienesSomosTXT2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblQuienesSomosTXT2.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienesSomosTXT2.Location = new System.Drawing.Point(3, 363);
            this.lblQuienesSomosTXT2.Name = "lblQuienesSomosTXT2";
            this.lblQuienesSomosTXT2.Size = new System.Drawing.Size(1250, 242);
            this.lblQuienesSomosTXT2.TabIndex = 2;
            this.lblQuienesSomosTXT2.Text = resources.GetString("lblQuienesSomosTXT2.Text");
            this.lblQuienesSomosTXT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuienesSomos
            // 
            this.lblQuienesSomos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuienesSomos.AutoSize = true;
            this.lblQuienesSomos.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblQuienesSomos.Font = new System.Drawing.Font("Nirmala UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienesSomos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuienesSomos.Location = new System.Drawing.Point(3, 0);
            this.lblQuienesSomos.Name = "lblQuienesSomos";
            this.lblQuienesSomos.Size = new System.Drawing.Size(1250, 121);
            this.lblQuienesSomos.TabIndex = 0;
            this.lblQuienesSomos.Text = "Quienes somos?";
            this.lblQuienesSomos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabColeccion
            // 
            this.tabColeccion.Controls.Add(this.tblColeccion);
            this.tabColeccion.Location = new System.Drawing.Point(4, 40);
            this.tabColeccion.Name = "tabColeccion";
            this.tabColeccion.Size = new System.Drawing.Size(1250, 594);
            this.tabColeccion.TabIndex = 9;
            this.tabColeccion.Text = "Colecciones";
            // 
            // tblColeccion
            // 
            this.tblColeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblColeccion.ColumnCount = 4;
            this.tblColeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tblColeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.48F));
            this.tblColeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.84F));
            this.tblColeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.6F));
            this.tblColeccion.Controls.Add(this.lblGeneroColeccionCO, 1, 5);
            this.tblColeccion.Controls.Add(this.lblTipoColeccionCO, 1, 3);
            this.tblColeccion.Controls.Add(this.lblNombreColeccionCO, 1, 1);
            this.tblColeccion.Controls.Add(this.dgvColeccionesCO, 3, 1);
            this.tblColeccion.Controls.Add(this.cmbTipoColeccionCO, 1, 4);
            this.tblColeccion.Controls.Add(this.cmbGeneroColeccionCO, 1, 6);
            this.tblColeccion.Controls.Add(this.txtNombreColeccionCO, 1, 2);
            this.tblColeccion.Controls.Add(this.btnDejarDeEditarCO, 1, 8);
            this.tblColeccion.Controls.Add(this.btnBuscarCO, 1, 11);
            this.tblColeccion.Controls.Add(this.btnAgregarCO, 1, 9);
            this.tblColeccion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblColeccion.Location = new System.Drawing.Point(0, 0);
            this.tblColeccion.Name = "tblColeccion";
            this.tblColeccion.RowCount = 13;
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblColeccion.Size = new System.Drawing.Size(1250, 601);
            this.tblColeccion.TabIndex = 12;
            // 
            // lblGeneroColeccionCO
            // 
            this.lblGeneroColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGeneroColeccionCO.AutoSize = true;
            this.lblGeneroColeccionCO.Location = new System.Drawing.Point(78, 248);
            this.lblGeneroColeccionCO.Name = "lblGeneroColeccionCO";
            this.lblGeneroColeccionCO.Size = new System.Drawing.Size(80, 28);
            this.lblGeneroColeccionCO.TabIndex = 3;
            this.lblGeneroColeccionCO.Text = "Genero:";
            // 
            // lblTipoColeccionCO
            // 
            this.lblTipoColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipoColeccionCO.AutoSize = true;
            this.lblTipoColeccionCO.Location = new System.Drawing.Point(78, 156);
            this.lblTipoColeccionCO.Name = "lblTipoColeccionCO";
            this.lblTipoColeccionCO.Size = new System.Drawing.Size(169, 28);
            this.lblTipoColeccionCO.TabIndex = 2;
            this.lblTipoColeccionCO.Text = "Tipo de colección:";
            // 
            // lblNombreColeccionCO
            // 
            this.lblNombreColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreColeccionCO.AutoSize = true;
            this.lblNombreColeccionCO.Location = new System.Drawing.Point(78, 64);
            this.lblNombreColeccionCO.Name = "lblNombreColeccionCO";
            this.lblNombreColeccionCO.Size = new System.Drawing.Size(89, 28);
            this.lblNombreColeccionCO.TabIndex = 0;
            this.lblNombreColeccionCO.Text = "Nombre:";
            this.lblNombreColeccionCO.Click += new System.EventHandler(this.label47_Click);
            // 
            // dgvColeccionesCO
            // 
            this.dgvColeccionesCO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColeccionesCO.Location = new System.Drawing.Point(582, 49);
            this.dgvColeccionesCO.Name = "dgvColeccionesCO";
            this.dgvColeccionesCO.RowHeadersWidth = 62;
            this.tblColeccion.SetRowSpan(this.dgvColeccionesCO, 12);
            this.dgvColeccionesCO.Size = new System.Drawing.Size(616, 500);
            this.dgvColeccionesCO.TabIndex = 29;
            // 
            // cmbTipoColeccionCO
            // 
            this.cmbTipoColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoColeccionCO.FormattingEnabled = true;
            this.cmbTipoColeccionCO.Location = new System.Drawing.Point(78, 187);
            this.cmbTipoColeccionCO.Name = "cmbTipoColeccionCO";
            this.cmbTipoColeccionCO.Size = new System.Drawing.Size(400, 36);
            this.cmbTipoColeccionCO.TabIndex = 31;
            // 
            // cmbGeneroColeccionCO
            // 
            this.cmbGeneroColeccionCO.FormattingEnabled = true;
            this.cmbGeneroColeccionCO.Location = new System.Drawing.Point(78, 279);
            this.cmbGeneroColeccionCO.Name = "cmbGeneroColeccionCO";
            this.cmbGeneroColeccionCO.Size = new System.Drawing.Size(400, 36);
            this.cmbGeneroColeccionCO.TabIndex = 32;
            // 
            // txtNombreColeccionCO
            // 
            this.txtNombreColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreColeccionCO.Location = new System.Drawing.Point(78, 95);
            this.txtNombreColeccionCO.Name = "txtNombreColeccionCO";
            this.txtNombreColeccionCO.Size = new System.Drawing.Size(400, 34);
            this.txtNombreColeccionCO.TabIndex = 33;
            // 
            // btnDejarDeEditarCO
            // 
            this.btnDejarDeEditarCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDejarDeEditarCO.Enabled = false;
            this.btnDejarDeEditarCO.Location = new System.Drawing.Point(195, 371);
            this.btnDejarDeEditarCO.Name = "btnDejarDeEditarCO";
            this.btnDejarDeEditarCO.Size = new System.Drawing.Size(165, 40);
            this.btnDejarDeEditarCO.TabIndex = 28;
            this.btnDejarDeEditarCO.Text = "Dejar de editar";
            this.btnDejarDeEditarCO.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCO
            // 
            this.btnBuscarCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBuscarCO.Location = new System.Drawing.Point(170, 509);
            this.btnBuscarCO.Name = "btnBuscarCO";
            this.btnBuscarCO.Size = new System.Drawing.Size(215, 40);
            this.btnBuscarCO.TabIndex = 34;
            this.btnBuscarCO.Text = "Colecciones Disponibles";
            this.btnBuscarCO.UseVisualStyleBackColor = true;
            this.btnBuscarCO.Click += new System.EventHandler(this.btnBuscarCO_Click);
            // 
            // btnAgregarCO
            // 
            this.btnAgregarCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAgregarCO.Location = new System.Drawing.Point(195, 417);
            this.btnAgregarCO.Name = "btnAgregarCO";
            this.btnAgregarCO.Size = new System.Drawing.Size(166, 40);
            this.btnAgregarCO.TabIndex = 27;
            this.btnAgregarCO.Text = "Agregar";
            this.btnAgregarCO.UseVisualStyleBackColor = true;
            // 
            // tlpColeccionCO
            // 
            this.tlpColeccionCO.Location = new System.Drawing.Point(0, 0);
            this.tlpColeccionCO.Name = "tlpColeccionCO";
            this.tlpColeccionCO.Size = new System.Drawing.Size(200, 100);
            this.tlpColeccionCO.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 23);
            this.label29.TabIndex = 0;
            // 
            // dgvVistaColeccionCO
            // 
            this.dgvVistaColeccionCO.ColumnHeadersHeight = 34;
            this.dgvVistaColeccionCO.Location = new System.Drawing.Point(0, 0);
            this.dgvVistaColeccionCO.Name = "dgvVistaColeccionCO";
            this.dgvVistaColeccionCO.RowHeadersWidth = 62;
            this.dgvVistaColeccionCO.Size = new System.Drawing.Size(240, 150);
            this.dgvVistaColeccionCO.TabIndex = 0;
            // 
            // txtNombreCO
            // 
            this.txtNombreCO.Location = new System.Drawing.Point(0, 0);
            this.txtNombreCO.Name = "txtNombreCO";
            this.txtNombreCO.Size = new System.Drawing.Size(100, 22);
            this.txtNombreCO.TabIndex = 0;
            // 
            // sspStatus
            // 
            this.sspStatus.BackColor = System.Drawing.SystemColors.Control;
            this.sspStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sspStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sspNombre,
            this.sspRol});
            this.sspStatus.Location = new System.Drawing.Point(0, 638);
            this.sspStatus.Name = "sspStatus";
            this.sspStatus.Size = new System.Drawing.Size(1258, 26);
            this.sspStatus.TabIndex = 2;
            // 
            // sspNombre
            // 
            this.sspNombre.Name = "sspNombre";
            this.sspNombre.Size = new System.Drawing.Size(71, 20);
            this.sspNombre.Text = "Nombre: ";
            // 
            // sspRol
            // 
            this.sspRol.Name = "sspRol";
            this.sspRol.Size = new System.Drawing.Size(38, 20);
            this.sspRol.Text = "Rol: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.sspStatus);
            this.Controls.Add(this.tabAdmin);
            this.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINAES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.tabEventos.ResumeLayout(false);
            this.tblEventos.ResumeLayout(false);
            this.tblEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroAsistentesEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenEV)).EndInit();
            this.tabAgregar.ResumeLayout(false);
            this.tblEjemplares.ResumeLayout(false);
            this.tblEjemplares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresAG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEjemplarAG)).EndInit();
            this.tabReserva.ResumeLayout(false);
            this.tblReserva.ResumeLayout(false);
            this.tblReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdUsuarioRE)).EndInit();
            this.tabPrestamo.ResumeLayout(false);
            this.tblPrestamo.ResumeLayout(false);
            this.tblPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            this.tblBusqueda.ResumeLayout(false);
            this.tblBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresBU)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            this.tblUsuarios.ResumeLayout(false);
            this.tblUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUS)).EndInit();
            this.tabMisionVision.ResumeLayout(false);
            this.tblMisionVision.ResumeLayout(false);
            this.tblMisionVision.PerformLayout();
            this.tabIntroduccion.ResumeLayout(false);
            this.tblQuienesSomos.ResumeLayout(false);
            this.tblQuienesSomos.PerformLayout();
            this.tabColeccion.ResumeLayout(false);
            this.tblColeccion.ResumeLayout(false);
            this.tblColeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColeccionesCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaColeccionCO)).EndInit();
            this.sspStatus.ResumeLayout(false);
            this.sspStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.TabPage tabEventos;
        private System.Windows.Forms.TableLayoutPanel tblEventos;
        private System.Windows.Forms.Button btnAgregarEventoEV;
        private System.Windows.Forms.DataGridView dgvEventosEV;
        private System.Windows.Forms.NumericUpDown nudNumeroAsistentesEV;
        private System.Windows.Forms.Label lblNumeroAsistentesEV;
        private System.Windows.Forms.ComboBox cmbAreaEventoEV;
        private System.Windows.Forms.Label lblAreaEventoEV;
        private System.Windows.Forms.RichTextBox rtbObjetivoEventoEV;
        private System.Windows.Forms.Label lblObjetivosEventoEV;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalizacionEV;
        private System.Windows.Forms.Label lblFechaFinalizacionEventoEV;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioEV;
        private System.Windows.Forms.Label lblFechaInicioEventoEV;
        private System.Windows.Forms.TextBox txtTituloEventoEV;
        private System.Windows.Forms.Label lblTituloEventoEV;
        private System.Windows.Forms.Button btnDejarDeEditarEV;
        private System.Windows.Forms.Label lblImagenEV;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.TableLayoutPanel tblEjemplares;
        private System.Windows.Forms.Button btnSalirEdicionEjemplarAG;
        private System.Windows.Forms.Button btnAgregarEjemplarAG;
        private System.Windows.Forms.TextBox txtEditorialEjemplarAG;
        private System.Windows.Forms.Label lblImagenEjemplarEJ;
        private System.Windows.Forms.Label lblNombreEjemplarEJ;
        private System.Windows.Forms.Label lblAutorEjemplarEJ;
        private System.Windows.Forms.Label lblFechaPublicacionEjemplarEJ;
        private System.Windows.Forms.Label lblIdiomaEjemplarEJ;
        private System.Windows.Forms.Label lblEditorialEjemplarEJ;
        private System.Windows.Forms.Label lblEtiquetasEjemplarEJ;
        private System.Windows.Forms.Label lblFormatoEjemplarEJ;
        private System.Windows.Forms.Label lblTipoColeccionEjemplarEJ;
        private System.Windows.Forms.Label lblCodigoEjemplarEJ;
        private System.Windows.Forms.TextBox txtCodigoEjemplarAG;
        private System.Windows.Forms.ComboBox cmbIdiomaEjemplarAG;
        private System.Windows.Forms.Button btnEtiquetasEjemplarAG;
        private System.Windows.Forms.TextBox txtNombreEjemplarAG;
        private System.Windows.Forms.TextBox txtAutorEjemplarAG;
        private System.Windows.Forms.ComboBox cmbTipoColeccionEjemplarAG;
        private System.Windows.Forms.ComboBox cmbFormatoEjemplarAG;
        private System.Windows.Forms.DataGridView dgvEjemplaresAG;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacionEjemplarAG;
        private System.Windows.Forms.TabPage tabReserva;
        private System.Windows.Forms.TabPage tabPrestamo;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabMisionVision;
        private System.Windows.Forms.TableLayoutPanel tblMisionVision;
        private System.Windows.Forms.Label lblMision;
        private System.Windows.Forms.Label lblVision;
        private System.Windows.Forms.Label lblInfoMision;
        private System.Windows.Forms.Label lblInfoVision;
        private System.Windows.Forms.TableLayoutPanel tblReserva;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblEjemplarRE;
        private System.Windows.Forms.DataGridView dgvReservasRE;
        private System.Windows.Forms.Button btnReservarRE;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabIntroduccion;
        private System.Windows.Forms.TableLayoutPanel tblQuienesSomos;
        private System.Windows.Forms.Label lblQuienesSomos;
        private System.Windows.Forms.Label lblQuienesSomosTXT;
        private System.Windows.Forms.Label lblQuienesSomosTXT2;
        private System.Windows.Forms.PictureBox picImagenEV;
        private System.Windows.Forms.PictureBox picEjemplarAG;
        private System.Windows.Forms.Button btnBuscarEjemplarRE;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.StatusStrip sspStatus;
        private System.Windows.Forms.ToolStripStatusLabel sspNombre;
        private System.Windows.Forms.ToolStripStatusLabel sspRol;
        private System.Windows.Forms.TableLayoutPanel tblPrestamo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEjemplarPR;
        private Button btnCompletarPR;
        private TextBox textBox3;
        private Label lblUsuarioPR;
        private Button btnBuscarPR;
        private TextBox textBox4;
        private System.Windows.Forms.TabPage tabColeccion;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlpColeccionCO;
        private Label label19;
        private Label label20;
        private Label label29;
        private DataGridView dgvVistaColeccionCO;
        private TextBox txtNombreCO;
        private NumericUpDown nudIdUsuarioRE;
        private Label lblUsuarioRE;
        private Button btnQrRE;
        private TableLayoutPanel tblBusqueda;
        private TextBox txtBuscarEjemplarBU;
        private Button btnBuscarEjemplarBU;
        private DataGridView dgvEjemplaresBU;
        private CheckBox chkBusquedaExactaBU;
        private ComboBox cmbFiltrarEjemplarBU;
        private Label lblFiltroBU;
        private CheckBox chkFísicoBU;
        private CheckBox chkDigitalBU;
        private TableLayoutPanel tblUsuarios;
        private Button btnDejarDeEditarUS;
        private Button btnAgregarUS;
        private DataGridView dgvUsuariosUS;
        private Label lblNombreUsuarioUS;
        private TextBox txtNombreUS;
        private Label lblInstitucionUsuarioUS;
        private TextBox txtInstitucionUS;
        private ComboBox cmbOcupacionUS;
        private Label lblOcupacionUsuarioUS;
        private Label lblContraseniaUsuarioUS;
        private TextBox txtContraseñaUS;
        private Label lblDireccionUsuarioUS;
        private TextBox txtDireccionUS;
        private TextBox txtEmailUS;
        private Label lblEmailUsuarioUS;
        private TextBox txtTelefonoUS;
        private Label lblTelefonoUsuarioUS;
        private Label lblRolUsuarioUS;
        private ComboBox cmbRolUS;
        private PictureBox picFotoUS;
        private Label lblFotoUsuarioUS;
        private Button btnTomarFotoUS;
        private Button btnCancelarFotoUS;
        private Button btnEliminarEventoEV;
        private TableLayoutPanel tblColeccion;
        private Button btnDejarDeEditarCO;
        private Button btnAgregarCO;
        private Label lblTipoColeccionCO;
        private Label lblGeneroColeccionCO;
        private Label lblNombreColeccionCO;
        private DataGridView dgvColeccionesCO;
        private ComboBox cmbTipoColeccionCO;
        private ComboBox cmbGeneroColeccionCO;
        private TextBox txtNombreColeccionCO;
        private Button btnBuscarCO;
        private Button btnEditarEventoEV;
        private Button btnActualizarUS;
    }
}