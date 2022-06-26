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
            this.btnReservarRE = new System.Windows.Forms.Button();
            this.lblUsuarioRE = new System.Windows.Forms.Label();
            this.btnBuscarEjemplarRE = new System.Windows.Forms.Button();
            this.btnQrRE = new System.Windows.Forms.Button();
            this.nudIdUsuarioRE = new System.Windows.Forms.NumericUpDown();
            this.nudIdEjemplarRE = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPrestamo = new System.Windows.Forms.TabPage();
            this.tblPrestamo = new System.Windows.Forms.TableLayoutPanel();
            this.lblEjemplarPR = new System.Windows.Forms.Label();
            this.dgvPrestamosPR = new System.Windows.Forms.DataGridView();
            this.btnBuscarPR = new System.Windows.Forms.Button();
            this.lblUsuarioPR = new System.Windows.Forms.Label();
            this.btnQrPR = new System.Windows.Forms.Button();
            this.btnPrestarPR = new System.Windows.Forms.Button();
            this.nudIdEjemplarPR = new System.Windows.Forms.NumericUpDown();
            this.nudIdUsuarioPR = new System.Windows.Forms.NumericUpDown();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tblBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEjemplaresBU = new System.Windows.Forms.DataGridView();
            this.txtBuscarEjemplarBU = new System.Windows.Forms.TextBox();
            this.chkDigitalBU = new System.Windows.Forms.CheckBox();
            this.btnBuscarEjemplarBU = new System.Windows.Forms.Button();
            this.cmbFiltrarEjemplarBU = new System.Windows.Forms.ComboBox();
            this.lblFiltroBU = new System.Windows.Forms.Label();
            this.chkBusquedaExactaBU = new System.Windows.Forms.CheckBox();
            this.chkFísicoBU = new System.Windows.Forms.CheckBox();
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
            this.lblVision = new System.Windows.Forms.Label();
            this.lblInfoVision = new System.Windows.Forms.Label();
            this.lblMision = new System.Windows.Forms.Label();
            this.lblInfoMision = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIntroPPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnMisionVisionPPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnAddUsuarioPPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnAddEventoPPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnAddEjemplarPPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnReservasPPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnPrestamosPPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnBusquedaPPrincipal = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnMinPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnMaxPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPrincipal = new FontAwesome.Sharp.IconButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudIdEjemplarRE)).BeginInit();
            this.tabPrestamo.SuspendLayout();
            this.tblPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdEjemplarPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdUsuarioPR)).BeginInit();
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
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
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
            this.búsquedaToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.búsquedaToolStripMenuItem.Tag = "";
            this.búsquedaToolStripMenuItem.Text = "Administrador de ejemplares";
            this.búsquedaToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.búsquedaToolStripMenuItem_DropDownItemClicked);
            this.búsquedaToolStripMenuItem.MouseHover += new System.EventHandler(this.búsquedaToolStripMenuItem_MouseHover);
            // 
            // búscarToolStripMenuItem
            // 
            this.búscarToolStripMenuItem.Name = "búscarToolStripMenuItem";
            this.búscarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.búscarToolStripMenuItem.Tag = "0";
            this.búscarToolStripMenuItem.Text = "Buscar [Ctrl + F]";
            // 
            // prestarToolStripMenuItem
            // 
            this.prestarToolStripMenuItem.Name = "prestarToolStripMenuItem";
            this.prestarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.prestarToolStripMenuItem.Tag = "1";
            this.prestarToolStripMenuItem.Text = "Préstamos";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.devolucionesToolStripMenuItem.Tag = "2";
            this.devolucionesToolStripMenuItem.Text = "Reservas";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.añadirToolStripMenuItem.Tag = "3";
            this.añadirToolStripMenuItem.Text = "Agregar [Ctrl + N]";
            // 
            // administradorDeEventosToolStripMenuItem
            // 
            this.administradorDeEventosToolStripMenuItem.Name = "administradorDeEventosToolStripMenuItem";
            this.administradorDeEventosToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.administradorDeEventosToolStripMenuItem.Tag = "4";
            this.administradorDeEventosToolStripMenuItem.Text = "Administrador de eventos";
            // 
            // administradorDeUsuariosToolStripMenuItem
            // 
            this.administradorDeUsuariosToolStripMenuItem.Name = "administradorDeUsuariosToolStripMenuItem";
            this.administradorDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.administradorDeUsuariosToolStripMenuItem.Tag = "5";
            this.administradorDeUsuariosToolStripMenuItem.Text = "Administrador de usuarios";
            // 
            // btnAgregarUS
            // 
            this.btnAgregarUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarUS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUS.Location = new System.Drawing.Point(243, 519);
            this.btnAgregarUS.Name = "btnAgregarUS";
            this.btnAgregarUS.Size = new System.Drawing.Size(114, 45);
            this.btnAgregarUS.TabIndex = 27;
            this.btnAgregarUS.Text = "Agregar";
            this.btnAgregarUS.UseVisualStyleBackColor = true;
            this.btnAgregarUS.Click += new System.EventHandler(this.btnAgregarUS_Click);
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.tblEventos);
            this.tabEventos.Location = new System.Drawing.Point(4, 33);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(964, 567);
            this.tabEventos.TabIndex = 4;
            this.tabEventos.Text = "Eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // tblEventos
            // 
            this.tblEventos.ColumnCount = 5;
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.9834F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.06224F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.75934F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.30705F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.88797F));
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
            this.tblEventos.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tblEventos.Size = new System.Drawing.Size(964, 567);
            this.tblEventos.TabIndex = 0;
            // 
            // dgvEventosEV
            // 
            this.dgvEventosEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEventosEV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventosEV.Location = new System.Drawing.Point(512, 3);
            this.dgvEventosEV.Name = "dgvEventosEV";
            this.dgvEventosEV.RowHeadersWidth = 51;
            this.tblEventos.SetRowSpan(this.dgvEventosEV, 13);
            this.dgvEventosEV.Size = new System.Drawing.Size(449, 561);
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
            this.lblTituloEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEventoEV.Location = new System.Drawing.Point(3, 23);
            this.lblTituloEventoEV.Name = "lblTituloEventoEV";
            this.lblTituloEventoEV.Size = new System.Drawing.Size(272, 20);
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
            this.txtTituloEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloEventoEV.Location = new System.Drawing.Point(3, 46);
            this.txtTituloEventoEV.Name = "txtTituloEventoEV";
            this.txtTituloEventoEV.Size = new System.Drawing.Size(272, 26);
            this.txtTituloEventoEV.TabIndex = 4;
            // 
            // lblFechaInicioEventoEV
            // 
            this.lblFechaInicioEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInicioEventoEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblFechaInicioEventoEV, 2);
            this.lblFechaInicioEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioEventoEV.Location = new System.Drawing.Point(3, 109);
            this.lblFechaInicioEventoEV.Name = "lblFechaInicioEventoEV";
            this.lblFechaInicioEventoEV.Size = new System.Drawing.Size(272, 20);
            this.lblFechaInicioEventoEV.TabIndex = 5;
            this.lblFechaInicioEventoEV.Text = "Fecha de inicio";
            this.lblFechaInicioEventoEV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaInicioEV
            // 
            this.tblEventos.SetColumnSpan(this.dtpFechaInicioEV, 2);
            this.dtpFechaInicioEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioEV.Location = new System.Drawing.Point(3, 132);
            this.dtpFechaInicioEV.Name = "dtpFechaInicioEV";
            this.dtpFechaInicioEV.Size = new System.Drawing.Size(234, 26);
            this.dtpFechaInicioEV.TabIndex = 17;
            // 
            // lblFechaFinalizacionEventoEV
            // 
            this.lblFechaFinalizacionEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFinalizacionEventoEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblFechaFinalizacionEventoEV, 2);
            this.lblFechaFinalizacionEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinalizacionEventoEV.Location = new System.Drawing.Point(3, 195);
            this.lblFechaFinalizacionEventoEV.Name = "lblFechaFinalizacionEventoEV";
            this.lblFechaFinalizacionEventoEV.Size = new System.Drawing.Size(272, 20);
            this.lblFechaFinalizacionEventoEV.TabIndex = 18;
            this.lblFechaFinalizacionEventoEV.Text = "Fecha de finalización";
            this.lblFechaFinalizacionEventoEV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaFinalizacionEV
            // 
            this.tblEventos.SetColumnSpan(this.dtpFechaFinalizacionEV, 2);
            this.dtpFechaFinalizacionEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinalizacionEV.Location = new System.Drawing.Point(3, 218);
            this.dtpFechaFinalizacionEV.Name = "dtpFechaFinalizacionEV";
            this.dtpFechaFinalizacionEV.Size = new System.Drawing.Size(234, 26);
            this.dtpFechaFinalizacionEV.TabIndex = 19;
            // 
            // lblObjetivosEventoEV
            // 
            this.lblObjetivosEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObjetivosEventoEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblObjetivosEventoEV, 2);
            this.lblObjetivosEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivosEventoEV.Location = new System.Drawing.Point(3, 281);
            this.lblObjetivosEventoEV.Name = "lblObjetivosEventoEV";
            this.lblObjetivosEventoEV.Size = new System.Drawing.Size(272, 20);
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
            this.rtbObjetivoEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbObjetivoEventoEV.Location = new System.Drawing.Point(3, 304);
            this.rtbObjetivoEventoEV.Name = "rtbObjetivoEventoEV";
            this.rtbObjetivoEventoEV.Size = new System.Drawing.Size(272, 37);
            this.rtbObjetivoEventoEV.TabIndex = 23;
            this.rtbObjetivoEventoEV.Text = "";
            // 
            // lblAreaEventoEV
            // 
            this.lblAreaEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAreaEventoEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblAreaEventoEV, 2);
            this.lblAreaEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaEventoEV.Location = new System.Drawing.Point(3, 367);
            this.lblAreaEventoEV.Name = "lblAreaEventoEV";
            this.lblAreaEventoEV.Size = new System.Drawing.Size(272, 20);
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
            this.cmbAreaEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaEventoEV.FormattingEnabled = true;
            this.cmbAreaEventoEV.Location = new System.Drawing.Point(3, 390);
            this.cmbAreaEventoEV.Name = "cmbAreaEventoEV";
            this.cmbAreaEventoEV.Size = new System.Drawing.Size(272, 28);
            this.cmbAreaEventoEV.TabIndex = 14;
            // 
            // lblNumeroAsistentesEV
            // 
            this.lblNumeroAsistentesEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroAsistentesEV.AutoSize = true;
            this.tblEventos.SetColumnSpan(this.lblNumeroAsistentesEV, 2);
            this.lblNumeroAsistentesEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAsistentesEV.Location = new System.Drawing.Point(3, 453);
            this.lblNumeroAsistentesEV.Name = "lblNumeroAsistentesEV";
            this.lblNumeroAsistentesEV.Size = new System.Drawing.Size(272, 20);
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
            this.nudNumeroAsistentesEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumeroAsistentesEV.Location = new System.Drawing.Point(3, 476);
            this.nudNumeroAsistentesEV.Name = "nudNumeroAsistentesEV";
            this.nudNumeroAsistentesEV.Size = new System.Drawing.Size(272, 26);
            this.nudNumeroAsistentesEV.TabIndex = 16;
            // 
            // btnDejarDeEditarEV
            // 
            this.btnDejarDeEditarEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDejarDeEditarEV.Enabled = false;
            this.btnDejarDeEditarEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDejarDeEditarEV.Location = new System.Drawing.Point(3, 519);
            this.btnDejarDeEditarEV.Name = "btnDejarDeEditarEV";
            this.btnDejarDeEditarEV.Size = new System.Drawing.Size(176, 45);
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
            this.picImagenEV.Location = new System.Drawing.Point(281, 46);
            this.picImagenEV.Name = "picImagenEV";
            this.tblEventos.SetRowSpan(this.picImagenEV, 11);
            this.picImagenEV.Size = new System.Drawing.Size(225, 467);
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
            this.lblImagenEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenEV.Location = new System.Drawing.Point(281, 23);
            this.lblImagenEV.Name = "lblImagenEV";
            this.lblImagenEV.Size = new System.Drawing.Size(225, 20);
            this.lblImagenEV.TabIndex = 27;
            this.lblImagenEV.Text = "Imagen";
            // 
            // btnEliminarEventoEV
            // 
            this.btnEliminarEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEventoEV.Enabled = false;
            this.btnEliminarEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEventoEV.Location = new System.Drawing.Point(185, 519);
            this.btnEliminarEventoEV.Name = "btnEliminarEventoEV";
            this.btnEliminarEventoEV.Size = new System.Drawing.Size(90, 45);
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
            this.btnAgregarEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEventoEV.Location = new System.Drawing.Point(404, 519);
            this.btnAgregarEventoEV.Name = "btnAgregarEventoEV";
            this.btnAgregarEventoEV.Size = new System.Drawing.Size(102, 45);
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
            this.btnEditarEventoEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEventoEV.Location = new System.Drawing.Point(281, 519);
            this.btnEditarEventoEV.Name = "btnEditarEventoEV";
            this.btnEditarEventoEV.Size = new System.Drawing.Size(117, 45);
            this.btnEditarEventoEV.TabIndex = 30;
            this.btnEditarEventoEV.Text = "Actualizar";
            this.btnEditarEventoEV.UseVisualStyleBackColor = true;
            this.btnEditarEventoEV.Click += new System.EventHandler(this.btnActualizarEventoEV_Click);
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.tblEjemplares);
            this.tabAgregar.Location = new System.Drawing.Point(4, 33);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Size = new System.Drawing.Size(964, 567);
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
            this.tblEjemplares.Size = new System.Drawing.Size(1029, 567);
            this.tblEjemplares.TabIndex = 11;
            // 
            // btnSalirEdicionEjemplarAG
            // 
            this.btnSalirEdicionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirEdicionEjemplarAG.Enabled = false;
            this.btnSalirEdicionEjemplarAG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirEdicionEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirEdicionEjemplarAG.Location = new System.Drawing.Point(3, 519);
            this.btnSalirEdicionEjemplarAG.Name = "btnSalirEdicionEjemplarAG";
            this.btnSalirEdicionEjemplarAG.Size = new System.Drawing.Size(199, 45);
            this.btnSalirEdicionEjemplarAG.TabIndex = 28;
            this.btnSalirEdicionEjemplarAG.Text = "Dejar de editar";
            this.btnSalirEdicionEjemplarAG.UseVisualStyleBackColor = true;
            this.btnSalirEdicionEjemplarAG.Click += new System.EventHandler(this.btnSalirEdicionEjemplarAG_Click);
            // 
            // btnAgregarEjemplarAG
            // 
            this.btnAgregarEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEjemplarAG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEjemplarAG.Location = new System.Drawing.Point(208, 519);
            this.btnAgregarEjemplarAG.Name = "btnAgregarEjemplarAG";
            this.btnAgregarEjemplarAG.Size = new System.Drawing.Size(199, 45);
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
            this.txtEditorialEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorialEjemplarAG.Location = new System.Drawing.Point(208, 46);
            this.txtEditorialEjemplarAG.Name = "txtEditorialEjemplarAG";
            this.txtEditorialEjemplarAG.Size = new System.Drawing.Size(199, 26);
            this.txtEditorialEjemplarAG.TabIndex = 22;
            // 
            // lblImagenEjemplarEJ
            // 
            this.lblImagenEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImagenEjemplarEJ.AutoSize = true;
            this.lblImagenEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenEjemplarEJ.Location = new System.Drawing.Point(208, 281);
            this.lblImagenEjemplarEJ.Name = "lblImagenEjemplarEJ";
            this.lblImagenEjemplarEJ.Size = new System.Drawing.Size(63, 20);
            this.lblImagenEjemplarEJ.TabIndex = 9;
            this.lblImagenEjemplarEJ.Text = "Imagen";
            // 
            // lblNombreEjemplarEJ
            // 
            this.lblNombreEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreEjemplarEJ.AutoSize = true;
            this.lblNombreEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEjemplarEJ.Location = new System.Drawing.Point(3, 109);
            this.lblNombreEjemplarEJ.Name = "lblNombreEjemplarEJ";
            this.lblNombreEjemplarEJ.Size = new System.Drawing.Size(65, 20);
            this.lblNombreEjemplarEJ.TabIndex = 2;
            this.lblNombreEjemplarEJ.Text = "Nombre";
            // 
            // lblAutorEjemplarEJ
            // 
            this.lblAutorEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAutorEjemplarEJ.AutoSize = true;
            this.lblAutorEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorEjemplarEJ.Location = new System.Drawing.Point(3, 195);
            this.lblAutorEjemplarEJ.Name = "lblAutorEjemplarEJ";
            this.lblAutorEjemplarEJ.Size = new System.Drawing.Size(48, 20);
            this.lblAutorEjemplarEJ.TabIndex = 3;
            this.lblAutorEjemplarEJ.Text = "Autor";
            // 
            // lblFechaPublicacionEjemplarEJ
            // 
            this.lblFechaPublicacionEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaPublicacionEjemplarEJ.AutoSize = true;
            this.lblFechaPublicacionEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPublicacionEjemplarEJ.Location = new System.Drawing.Point(208, 111);
            this.lblFechaPublicacionEjemplarEJ.Name = "lblFechaPublicacionEjemplarEJ";
            this.lblFechaPublicacionEjemplarEJ.Size = new System.Drawing.Size(147, 18);
            this.lblFechaPublicacionEjemplarEJ.TabIndex = 7;
            this.lblFechaPublicacionEjemplarEJ.Text = "Fecha de publicación";
            // 
            // lblIdiomaEjemplarEJ
            // 
            this.lblIdiomaEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdiomaEjemplarEJ.AutoSize = true;
            this.lblIdiomaEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaEjemplarEJ.Location = new System.Drawing.Point(3, 281);
            this.lblIdiomaEjemplarEJ.Name = "lblIdiomaEjemplarEJ";
            this.lblIdiomaEjemplarEJ.Size = new System.Drawing.Size(57, 20);
            this.lblIdiomaEjemplarEJ.TabIndex = 4;
            this.lblIdiomaEjemplarEJ.Text = "Idioma";
            // 
            // lblEditorialEjemplarEJ
            // 
            this.lblEditorialEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEditorialEjemplarEJ.AutoSize = true;
            this.lblEditorialEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorialEjemplarEJ.Location = new System.Drawing.Point(208, 23);
            this.lblEditorialEjemplarEJ.Name = "lblEditorialEjemplarEJ";
            this.lblEditorialEjemplarEJ.Size = new System.Drawing.Size(66, 20);
            this.lblEditorialEjemplarEJ.TabIndex = 1;
            this.lblEditorialEjemplarEJ.Text = "Editorial";
            // 
            // lblEtiquetasEjemplarEJ
            // 
            this.lblEtiquetasEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEtiquetasEjemplarEJ.AutoSize = true;
            this.lblEtiquetasEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetasEjemplarEJ.Location = new System.Drawing.Point(3, 453);
            this.lblEtiquetasEjemplarEJ.Name = "lblEtiquetasEjemplarEJ";
            this.lblEtiquetasEjemplarEJ.Size = new System.Drawing.Size(77, 20);
            this.lblEtiquetasEjemplarEJ.TabIndex = 6;
            this.lblEtiquetasEjemplarEJ.Text = "Etiquetas";
            // 
            // lblFormatoEjemplarEJ
            // 
            this.lblFormatoEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormatoEjemplarEJ.AutoSize = true;
            this.lblFormatoEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatoEjemplarEJ.Location = new System.Drawing.Point(3, 367);
            this.lblFormatoEjemplarEJ.Name = "lblFormatoEjemplarEJ";
            this.lblFormatoEjemplarEJ.Size = new System.Drawing.Size(69, 20);
            this.lblFormatoEjemplarEJ.TabIndex = 5;
            this.lblFormatoEjemplarEJ.Text = "Formato";
            // 
            // lblTipoColeccionEjemplarEJ
            // 
            this.lblTipoColeccionEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipoColeccionEjemplarEJ.AutoSize = true;
            this.lblTipoColeccionEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoColeccionEjemplarEJ.Location = new System.Drawing.Point(208, 195);
            this.lblTipoColeccionEjemplarEJ.Name = "lblTipoColeccionEjemplarEJ";
            this.lblTipoColeccionEjemplarEJ.Size = new System.Drawing.Size(131, 20);
            this.lblTipoColeccionEjemplarEJ.TabIndex = 8;
            this.lblTipoColeccionEjemplarEJ.Text = "Tipo de colección";
            // 
            // lblCodigoEjemplarEJ
            // 
            this.lblCodigoEjemplarEJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigoEjemplarEJ.AutoSize = true;
            this.lblCodigoEjemplarEJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEjemplarEJ.Location = new System.Drawing.Point(3, 23);
            this.lblCodigoEjemplarEJ.Name = "lblCodigoEjemplarEJ";
            this.lblCodigoEjemplarEJ.Size = new System.Drawing.Size(123, 20);
            this.lblCodigoEjemplarEJ.TabIndex = 0;
            this.lblCodigoEjemplarEJ.Text = "Código ejemplar";
            // 
            // txtCodigoEjemplarAG
            // 
            this.txtCodigoEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEjemplarAG.Location = new System.Drawing.Point(3, 55);
            this.txtCodigoEjemplarAG.Name = "txtCodigoEjemplarAG";
            this.txtCodigoEjemplarAG.Size = new System.Drawing.Size(199, 19);
            this.txtCodigoEjemplarAG.TabIndex = 10;
            // 
            // cmbIdiomaEjemplarAG
            // 
            this.cmbIdiomaEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdiomaEjemplarAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdiomaEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdiomaEjemplarAG.FormattingEnabled = true;
            this.cmbIdiomaEjemplarAG.Location = new System.Drawing.Point(3, 304);
            this.cmbIdiomaEjemplarAG.Name = "cmbIdiomaEjemplarAG";
            this.cmbIdiomaEjemplarAG.Size = new System.Drawing.Size(199, 28);
            this.cmbIdiomaEjemplarAG.TabIndex = 13;
            // 
            // btnEtiquetasEjemplarAG
            // 
            this.btnEtiquetasEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEtiquetasEjemplarAG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEtiquetasEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtiquetasEjemplarAG.Location = new System.Drawing.Point(3, 476);
            this.btnEtiquetasEjemplarAG.Name = "btnEtiquetasEjemplarAG";
            this.btnEtiquetasEjemplarAG.Size = new System.Drawing.Size(199, 37);
            this.btnEtiquetasEjemplarAG.TabIndex = 15;
            this.btnEtiquetasEjemplarAG.Text = "Seleccionar";
            this.btnEtiquetasEjemplarAG.UseVisualStyleBackColor = true;
            // 
            // txtNombreEjemplarAG
            // 
            this.txtNombreEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEjemplarAG.Location = new System.Drawing.Point(3, 132);
            this.txtNombreEjemplarAG.Name = "txtNombreEjemplarAG";
            this.txtNombreEjemplarAG.Size = new System.Drawing.Size(199, 26);
            this.txtNombreEjemplarAG.TabIndex = 23;
            // 
            // txtAutorEjemplarAG
            // 
            this.txtAutorEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutorEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutorEjemplarAG.Location = new System.Drawing.Point(3, 218);
            this.txtAutorEjemplarAG.Name = "txtAutorEjemplarAG";
            this.txtAutorEjemplarAG.Size = new System.Drawing.Size(199, 26);
            this.txtAutorEjemplarAG.TabIndex = 24;
            // 
            // cmbTipoColeccionEjemplarAG
            // 
            this.cmbTipoColeccionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoColeccionEjemplarAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoColeccionEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoColeccionEjemplarAG.FormattingEnabled = true;
            this.cmbTipoColeccionEjemplarAG.Location = new System.Drawing.Point(208, 218);
            this.cmbTipoColeccionEjemplarAG.Name = "cmbTipoColeccionEjemplarAG";
            this.cmbTipoColeccionEjemplarAG.Size = new System.Drawing.Size(199, 28);
            this.cmbTipoColeccionEjemplarAG.TabIndex = 25;
            // 
            // cmbFormatoEjemplarAG
            // 
            this.cmbFormatoEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormatoEjemplarAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormatoEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormatoEjemplarAG.FormattingEnabled = true;
            this.cmbFormatoEjemplarAG.Location = new System.Drawing.Point(3, 390);
            this.cmbFormatoEjemplarAG.Name = "cmbFormatoEjemplarAG";
            this.cmbFormatoEjemplarAG.Size = new System.Drawing.Size(199, 28);
            this.cmbFormatoEjemplarAG.TabIndex = 26;
            // 
            // dgvEjemplaresAG
            // 
            this.dgvEjemplaresAG.AllowUserToAddRows = false;
            this.dgvEjemplaresAG.AllowUserToDeleteRows = false;
            this.dgvEjemplaresAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplaresAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEjemplaresAG.Location = new System.Drawing.Point(413, 3);
            this.dgvEjemplaresAG.Name = "dgvEjemplaresAG";
            this.dgvEjemplaresAG.ReadOnly = true;
            this.dgvEjemplaresAG.RowHeadersWidth = 51;
            this.tblEjemplares.SetRowSpan(this.dgvEjemplaresAG, 13);
            this.dgvEjemplaresAG.Size = new System.Drawing.Size(613, 561);
            this.dgvEjemplaresAG.TabIndex = 29;
            // 
            // dtpFechaPublicacionEjemplarAG
            // 
            this.dtpFechaPublicacionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPublicacionEjemplarAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPublicacionEjemplarAG.Location = new System.Drawing.Point(208, 132);
            this.dtpFechaPublicacionEjemplarAG.Name = "dtpFechaPublicacionEjemplarAG";
            this.dtpFechaPublicacionEjemplarAG.Size = new System.Drawing.Size(199, 26);
            this.dtpFechaPublicacionEjemplarAG.TabIndex = 30;
            // 
            // picEjemplarAG
            // 
            this.picEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picEjemplarAG.Image = global::BINAES.Properties.Resources._default;
            this.picEjemplarAG.Location = new System.Drawing.Point(208, 304);
            this.picEjemplarAG.Name = "picEjemplarAG";
            this.tblEjemplares.SetRowSpan(this.picEjemplarAG, 5);
            this.picEjemplarAG.Size = new System.Drawing.Size(199, 209);
            this.picEjemplarAG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEjemplarAG.TabIndex = 31;
            this.picEjemplarAG.TabStop = false;
            this.picEjemplarAG.Click += new System.EventHandler(this.picEjemplarAG_Click);
            // 
            // tabReserva
            // 
            this.tabReserva.Controls.Add(this.tblReserva);
            this.tabReserva.Location = new System.Drawing.Point(4, 33);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabReserva.Size = new System.Drawing.Size(964, 567);
            this.tabReserva.TabIndex = 2;
            this.tabReserva.Text = "Reservas de ejemplares";
            this.tabReserva.UseVisualStyleBackColor = true;
            // 
            // tblReserva
            // 
            this.tblReserva.ColumnCount = 6;
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblReserva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblReserva.Controls.Add(this.dgvReservasRE, 4, 1);
            this.tblReserva.Controls.Add(this.lblEjemplarRE, 1, 1);
            this.tblReserva.Controls.Add(this.btnReservarRE, 1, 6);
            this.tblReserva.Controls.Add(this.lblUsuarioRE, 1, 3);
            this.tblReserva.Controls.Add(this.btnBuscarEjemplarRE, 2, 2);
            this.tblReserva.Controls.Add(this.btnQrRE, 2, 4);
            this.tblReserva.Controls.Add(this.nudIdUsuarioRE, 1, 4);
            this.tblReserva.Controls.Add(this.nudIdEjemplarRE, 1, 2);
            this.tblReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblReserva.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblReserva.Location = new System.Drawing.Point(3, 3);
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
            this.tblReserva.Size = new System.Drawing.Size(958, 561);
            this.tblReserva.TabIndex = 12;
            // 
            // dgvReservasRE
            // 
            this.dgvReservasRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservasRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasRE.Location = new System.Drawing.Point(335, 59);
            this.dgvReservasRE.Name = "dgvReservasRE";
            this.dgvReservasRE.RowHeadersWidth = 51;
            this.tblReserva.SetRowSpan(this.dgvReservasRE, 6);
            this.dgvReservasRE.Size = new System.Drawing.Size(568, 438);
            this.dgvReservasRE.TabIndex = 31;
            // 
            // lblEjemplarRE
            // 
            this.lblEjemplarRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjemplarRE.AutoSize = true;
            this.tblReserva.SetColumnSpan(this.lblEjemplarRE, 2);
            this.lblEjemplarRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplarRE.Location = new System.Drawing.Point(50, 110);
            this.lblEjemplarRE.Name = "lblEjemplarRE";
            this.lblEjemplarRE.Size = new System.Drawing.Size(232, 20);
            this.lblEjemplarRE.TabIndex = 1;
            this.lblEjemplarRE.Text = "Ejemplar:";
            // 
            // btnReservarRE
            // 
            this.btnReservarRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblReserva.SetColumnSpan(this.btnReservarRE, 2);
            this.btnReservarRE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservarRE.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarRE.Location = new System.Drawing.Point(50, 429);
            this.btnReservarRE.Name = "btnReservarRE";
            this.btnReservarRE.Size = new System.Drawing.Size(232, 68);
            this.btnReservarRE.TabIndex = 32;
            this.btnReservarRE.Text = "Reservar";
            this.btnReservarRE.UseVisualStyleBackColor = true;
            this.btnReservarRE.Click += new System.EventHandler(this.btnReservarRE_Click);
            // 
            // lblUsuarioRE
            // 
            this.lblUsuarioRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioRE.AutoSize = true;
            this.tblReserva.SetColumnSpan(this.lblUsuarioRE, 2);
            this.lblUsuarioRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioRE.Location = new System.Drawing.Point(50, 258);
            this.lblUsuarioRE.Name = "lblUsuarioRE";
            this.lblUsuarioRE.Size = new System.Drawing.Size(232, 20);
            this.lblUsuarioRE.TabIndex = 34;
            this.lblUsuarioRE.Text = "ID Usuario";
            // 
            // btnBuscarEjemplarRE
            // 
            this.btnBuscarEjemplarRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEjemplarRE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarEjemplarRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEjemplarRE.Location = new System.Drawing.Point(193, 133);
            this.btnBuscarEjemplarRE.Name = "btnBuscarEjemplarRE";
            this.btnBuscarEjemplarRE.Size = new System.Drawing.Size(89, 68);
            this.btnBuscarEjemplarRE.TabIndex = 33;
            this.btnBuscarEjemplarRE.Text = "Buscar";
            this.btnBuscarEjemplarRE.UseVisualStyleBackColor = true;
            this.btnBuscarEjemplarRE.Click += new System.EventHandler(this.btnBuscarEjemplarRE_Click);
            // 
            // btnQrRE
            // 
            this.btnQrRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQrRE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQrRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQrRE.Location = new System.Drawing.Point(193, 281);
            this.btnQrRE.Name = "btnQrRE";
            this.btnQrRE.Size = new System.Drawing.Size(89, 68);
            this.btnQrRE.TabIndex = 35;
            this.btnQrRE.Text = "QR";
            this.btnQrRE.UseVisualStyleBackColor = true;
            this.btnQrRE.Click += new System.EventHandler(this.btnQrRE_Click);
            // 
            // nudIdUsuarioRE
            // 
            this.nudIdUsuarioRE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIdUsuarioRE.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdUsuarioRE.Location = new System.Drawing.Point(50, 300);
            this.nudIdUsuarioRE.Name = "nudIdUsuarioRE";
            this.nudIdUsuarioRE.Size = new System.Drawing.Size(137, 29);
            this.nudIdUsuarioRE.TabIndex = 37;
            // 
            // nudIdEjemplarRE
            // 
            this.nudIdEjemplarRE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIdEjemplarRE.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdEjemplarRE.Location = new System.Drawing.Point(50, 152);
            this.nudIdEjemplarRE.Name = "nudIdEjemplarRE";
            this.nudIdEjemplarRE.Size = new System.Drawing.Size(137, 29);
            this.nudIdEjemplarRE.TabIndex = 36;
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
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(128, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 35;
            // 
            // tabPrestamo
            // 
            this.tabPrestamo.Controls.Add(this.tblPrestamo);
            this.tabPrestamo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabPrestamo.Location = new System.Drawing.Point(4, 33);
            this.tabPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Name = "tabPrestamo";
            this.tabPrestamo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Size = new System.Drawing.Size(964, 567);
            this.tabPrestamo.TabIndex = 1;
            this.tabPrestamo.Text = "Préstamo de ejemplares";
            this.tabPrestamo.UseVisualStyleBackColor = true;
            // 
            // tblPrestamo
            // 
            this.tblPrestamo.ColumnCount = 6;
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblPrestamo.Controls.Add(this.lblEjemplarPR, 1, 1);
            this.tblPrestamo.Controls.Add(this.dgvPrestamosPR, 4, 1);
            this.tblPrestamo.Controls.Add(this.btnBuscarPR, 2, 2);
            this.tblPrestamo.Controls.Add(this.lblUsuarioPR, 1, 3);
            this.tblPrestamo.Controls.Add(this.btnQrPR, 2, 4);
            this.tblPrestamo.Controls.Add(this.btnPrestarPR, 1, 6);
            this.tblPrestamo.Controls.Add(this.nudIdEjemplarPR, 1, 2);
            this.tblPrestamo.Controls.Add(this.nudIdUsuarioPR, 1, 4);
            this.tblPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrestamo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPrestamo.Location = new System.Drawing.Point(3, 4);
            this.tblPrestamo.Name = "tblPrestamo";
            this.tblPrestamo.RowCount = 8;
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.002F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.002F));
            this.tblPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPrestamo.Size = new System.Drawing.Size(958, 559);
            this.tblPrestamo.TabIndex = 13;
            // 
            // lblEjemplarPR
            // 
            this.lblEjemplarPR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjemplarPR.AutoSize = true;
            this.tblPrestamo.SetColumnSpan(this.lblEjemplarPR, 2);
            this.lblEjemplarPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplarPR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEjemplarPR.Location = new System.Drawing.Point(50, 109);
            this.lblEjemplarPR.Name = "lblEjemplarPR";
            this.lblEjemplarPR.Size = new System.Drawing.Size(232, 20);
            this.lblEjemplarPR.TabIndex = 1;
            this.lblEjemplarPR.Text = "Ejemplar:";
            // 
            // dgvPrestamosPR
            // 
            this.dgvPrestamosPR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamosPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosPR.Location = new System.Drawing.Point(335, 58);
            this.dgvPrestamosPR.Name = "dgvPrestamosPR";
            this.dgvPrestamosPR.RowHeadersWidth = 51;
            this.tblPrestamo.SetRowSpan(this.dgvPrestamosPR, 6);
            this.dgvPrestamosPR.Size = new System.Drawing.Size(568, 438);
            this.dgvPrestamosPR.TabIndex = 31;
            // 
            // btnBuscarPR
            // 
            this.btnBuscarPR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarPR.Location = new System.Drawing.Point(193, 132);
            this.btnBuscarPR.Name = "btnBuscarPR";
            this.btnBuscarPR.Size = new System.Drawing.Size(89, 68);
            this.btnBuscarPR.TabIndex = 33;
            this.btnBuscarPR.Text = "Buscar";
            this.btnBuscarPR.UseVisualStyleBackColor = true;
            this.btnBuscarPR.Click += new System.EventHandler(this.btnBuscarPR_Click);
            // 
            // lblUsuarioPR
            // 
            this.lblUsuarioPR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioPR.AutoSize = true;
            this.tblPrestamo.SetColumnSpan(this.lblUsuarioPR, 2);
            this.lblUsuarioPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioPR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuarioPR.Location = new System.Drawing.Point(50, 257);
            this.lblUsuarioPR.Name = "lblUsuarioPR";
            this.lblUsuarioPR.Size = new System.Drawing.Size(232, 20);
            this.lblUsuarioPR.TabIndex = 8;
            this.lblUsuarioPR.Text = "ID Usuario:";
            // 
            // btnQrPR
            // 
            this.btnQrPR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQrPR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQrPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQrPR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQrPR.Location = new System.Drawing.Point(193, 280);
            this.btnQrPR.Name = "btnQrPR";
            this.btnQrPR.Size = new System.Drawing.Size(89, 68);
            this.btnQrPR.TabIndex = 32;
            this.btnQrPR.Text = "QR";
            this.btnQrPR.UseVisualStyleBackColor = true;
            this.btnQrPR.Click += new System.EventHandler(this.btnQrPR_Click);
            // 
            // btnPrestarPR
            // 
            this.btnPrestarPR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPrestamo.SetColumnSpan(this.btnPrestarPR, 2);
            this.btnPrestarPR.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestarPR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrestarPR.Location = new System.Drawing.Point(50, 428);
            this.btnPrestarPR.Name = "btnPrestarPR";
            this.btnPrestarPR.Size = new System.Drawing.Size(232, 68);
            this.btnPrestarPR.TabIndex = 36;
            this.btnPrestarPR.Text = "Prestar";
            this.btnPrestarPR.UseVisualStyleBackColor = true;
            this.btnPrestarPR.Click += new System.EventHandler(this.btnPrestarPR_Click);
            // 
            // nudIdEjemplarPR
            // 
            this.nudIdEjemplarPR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIdEjemplarPR.Location = new System.Drawing.Point(50, 151);
            this.nudIdEjemplarPR.Name = "nudIdEjemplarPR";
            this.nudIdEjemplarPR.Size = new System.Drawing.Size(137, 29);
            this.nudIdEjemplarPR.TabIndex = 34;
            // 
            // nudIdUsuarioPR
            // 
            this.nudIdUsuarioPR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIdUsuarioPR.Location = new System.Drawing.Point(50, 299);
            this.nudIdUsuarioPR.Name = "nudIdUsuarioPR";
            this.nudIdUsuarioPR.Size = new System.Drawing.Size(137, 29);
            this.nudIdUsuarioPR.TabIndex = 35;
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.Transparent;
            this.tabBuscar.Controls.Add(this.tblBusqueda);
            this.tabBuscar.Location = new System.Drawing.Point(4, 33);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Size = new System.Drawing.Size(964, 567);
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
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.540084F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.66245F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.12658F));
            this.tblBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.898734F));
            this.tblBusqueda.Controls.Add(this.dgvEjemplaresBU, 1, 3);
            this.tblBusqueda.Controls.Add(this.txtBuscarEjemplarBU, 1, 1);
            this.tblBusqueda.Controls.Add(this.chkDigitalBU, 5, 2);
            this.tblBusqueda.Controls.Add(this.btnBuscarEjemplarBU, 2, 1);
            this.tblBusqueda.Controls.Add(this.cmbFiltrarEjemplarBU, 4, 2);
            this.tblBusqueda.Controls.Add(this.lblFiltroBU, 3, 2);
            this.tblBusqueda.Controls.Add(this.chkBusquedaExactaBU, 3, 1);
            this.tblBusqueda.Controls.Add(this.chkFísicoBU, 5, 1);
            this.tblBusqueda.Location = new System.Drawing.Point(16, 0);
            this.tblBusqueda.Name = "tblBusqueda";
            this.tblBusqueda.RowCount = 5;
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.06993F));
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.118881F));
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.391608F));
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblBusqueda.Size = new System.Drawing.Size(948, 572);
            this.tblBusqueda.TabIndex = 2;
            // 
            // dgvEjemplaresBU
            // 
            this.dgvEjemplaresBU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEjemplaresBU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBusqueda.SetColumnSpan(this.dgvEjemplaresBU, 5);
            this.dgvEjemplaresBU.Location = new System.Drawing.Point(48, 115);
            this.dgvEjemplaresBU.Name = "dgvEjemplaresBU";
            this.dgvEjemplaresBU.RowHeadersWidth = 62;
            this.dgvEjemplaresBU.RowTemplate.Height = 28;
            this.dgvEjemplaresBU.Size = new System.Drawing.Size(878, 424);
            this.dgvEjemplaresBU.TabIndex = 4;
            this.dgvEjemplaresBU.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjemplaresBU_CellDoubleClick);
            // 
            // txtBuscarEjemplarBU
            // 
            this.txtBuscarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEjemplarBU.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEjemplarBU.Location = new System.Drawing.Point(48, 52);
            this.txtBuscarEjemplarBU.Name = "txtBuscarEjemplarBU";
            this.tblBusqueda.SetRowSpan(this.txtBuscarEjemplarBU, 2);
            this.txtBuscarEjemplarBU.Size = new System.Drawing.Size(536, 36);
            this.txtBuscarEjemplarBU.TabIndex = 0;
            this.txtBuscarEjemplarBU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarEjemplarBU_KeyDown);
            // 
            // chkDigitalBU
            // 
            this.chkDigitalBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDigitalBU.AutoSize = true;
            this.chkDigitalBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDigitalBU.Location = new System.Drawing.Point(836, 67);
            this.chkDigitalBU.Name = "chkDigitalBU";
            this.chkDigitalBU.Size = new System.Drawing.Size(90, 21);
            this.chkDigitalBU.TabIndex = 8;
            this.chkDigitalBU.Text = "Digital";
            this.chkDigitalBU.UseVisualStyleBackColor = true;
            // 
            // btnBuscarEjemplarBU
            // 
            this.btnBuscarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEjemplarBU.Location = new System.Drawing.Point(590, 49);
            this.btnBuscarEjemplarBU.Name = "btnBuscarEjemplarBU";
            this.tblBusqueda.SetRowSpan(this.btnBuscarEjemplarBU, 2);
            this.btnBuscarEjemplarBU.Size = new System.Drawing.Size(39, 42);
            this.btnBuscarEjemplarBU.TabIndex = 3;
            this.btnBuscarEjemplarBU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEjemplarBU.UseVisualStyleBackColor = true;
            this.btnBuscarEjemplarBU.Click += new System.EventHandler(this.btnBuscarEjemplarBU_Click);
            // 
            // cmbFiltrarEjemplarBU
            // 
            this.cmbFiltrarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarEjemplarBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarEjemplarBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarEjemplarBU.FormattingEnabled = true;
            this.cmbFiltrarEjemplarBU.Location = new System.Drawing.Point(697, 67);
            this.cmbFiltrarEjemplarBU.Name = "cmbFiltrarEjemplarBU";
            this.cmbFiltrarEjemplarBU.Size = new System.Drawing.Size(133, 25);
            this.cmbFiltrarEjemplarBU.TabIndex = 2;
            this.cmbFiltrarEjemplarBU.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarEjemplarBU_SelectedIndexChanged);
            // 
            // lblFiltroBU
            // 
            this.lblFiltroBU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroBU.AutoSize = true;
            this.lblFiltroBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroBU.Location = new System.Drawing.Point(635, 64);
            this.lblFiltroBU.Name = "lblFiltroBU";
            this.lblFiltroBU.Size = new System.Drawing.Size(56, 48);
            this.lblFiltroBU.TabIndex = 6;
            this.lblFiltroBU.Text = "Filtro:";
            // 
            // chkBusquedaExactaBU
            // 
            this.chkBusquedaExactaBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBusquedaExactaBU.AutoSize = true;
            this.tblBusqueda.SetColumnSpan(this.chkBusquedaExactaBU, 2);
            this.chkBusquedaExactaBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBusquedaExactaBU.Location = new System.Drawing.Point(635, 40);
            this.chkBusquedaExactaBU.Name = "chkBusquedaExactaBU";
            this.chkBusquedaExactaBU.Size = new System.Drawing.Size(195, 21);
            this.chkBusquedaExactaBU.TabIndex = 5;
            this.chkBusquedaExactaBU.Text = "Búsqueda exacta";
            this.chkBusquedaExactaBU.UseVisualStyleBackColor = true;
            // 
            // chkFísicoBU
            // 
            this.chkFísicoBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFísicoBU.AutoSize = true;
            this.chkFísicoBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFísicoBU.Location = new System.Drawing.Point(836, 40);
            this.chkFísicoBU.Name = "chkFísicoBU";
            this.chkFísicoBU.Size = new System.Drawing.Size(90, 21);
            this.chkFísicoBU.TabIndex = 7;
            this.chkFísicoBU.Text = "Físico";
            this.chkFísicoBU.UseVisualStyleBackColor = true;
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
            this.tabAdmin.Location = new System.Drawing.Point(292, 47);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(972, 604);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.TabStop = false;
            this.tabAdmin.Tag = "";
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            this.tabAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabAdmin_KeyDown);
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tblUsuarios);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 33);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(964, 567);
            this.tabUsuarios.TabIndex = 9;
            this.tabUsuarios.Text = "Usuarios";
            // 
            // tblUsuarios
            // 
            this.tblUsuarios.ColumnCount = 4;
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.27801F));
            this.tblUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.37759F));
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
            this.tblUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tblUsuarios.Size = new System.Drawing.Size(964, 567);
            this.tblUsuarios.TabIndex = 12;
            // 
            // lblFotoUsuarioUS
            // 
            this.lblFotoUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFotoUsuarioUS.AutoSize = true;
            this.tblUsuarios.SetColumnSpan(this.lblFotoUsuarioUS, 2);
            this.lblFotoUsuarioUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoUsuarioUS.Location = new System.Drawing.Point(243, 195);
            this.lblFotoUsuarioUS.Name = "lblFotoUsuarioUS";
            this.lblFotoUsuarioUS.Size = new System.Drawing.Size(241, 20);
            this.lblFotoUsuarioUS.TabIndex = 49;
            this.lblFotoUsuarioUS.Text = "Foto";
            // 
            // btnDejarDeEditarUS
            // 
            this.btnDejarDeEditarUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDejarDeEditarUS.Enabled = false;
            this.btnDejarDeEditarUS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDejarDeEditarUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDejarDeEditarUS.Location = new System.Drawing.Point(3, 519);
            this.btnDejarDeEditarUS.Name = "btnDejarDeEditarUS";
            this.btnDejarDeEditarUS.Size = new System.Drawing.Size(234, 45);
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
            this.dgvUsuariosUS.Location = new System.Drawing.Point(490, 3);
            this.dgvUsuariosUS.Name = "dgvUsuariosUS";
            this.dgvUsuariosUS.ReadOnly = true;
            this.dgvUsuariosUS.RowHeadersWidth = 51;
            this.tblUsuarios.SetRowSpan(this.dgvUsuariosUS, 13);
            this.dgvUsuariosUS.Size = new System.Drawing.Size(471, 561);
            this.dgvUsuariosUS.TabIndex = 29;
            this.dgvUsuariosUS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosUS_CellContentClick);
            // 
            // lblNombreUsuarioUS
            // 
            this.lblNombreUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuarioUS.AutoSize = true;
            this.lblNombreUsuarioUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarioUS.Location = new System.Drawing.Point(3, 23);
            this.lblNombreUsuarioUS.Name = "lblNombreUsuarioUS";
            this.lblNombreUsuarioUS.Size = new System.Drawing.Size(234, 20);
            this.lblNombreUsuarioUS.TabIndex = 30;
            this.lblNombreUsuarioUS.Text = "Nombre";
            // 
            // txtNombreUS
            // 
            this.txtNombreUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUS.Location = new System.Drawing.Point(3, 46);
            this.txtNombreUS.Name = "txtNombreUS";
            this.txtNombreUS.Size = new System.Drawing.Size(234, 26);
            this.txtNombreUS.TabIndex = 31;
            // 
            // lblInstitucionUsuarioUS
            // 
            this.lblInstitucionUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstitucionUsuarioUS.AutoSize = true;
            this.lblInstitucionUsuarioUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstitucionUsuarioUS.Location = new System.Drawing.Point(3, 281);
            this.lblInstitucionUsuarioUS.Name = "lblInstitucionUsuarioUS";
            this.lblInstitucionUsuarioUS.Size = new System.Drawing.Size(234, 20);
            this.lblInstitucionUsuarioUS.TabIndex = 36;
            this.lblInstitucionUsuarioUS.Text = "Institución";
            this.lblInstitucionUsuarioUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInstitucionUS
            // 
            this.txtInstitucionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstitucionUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitucionUS.Location = new System.Drawing.Point(3, 304);
            this.txtInstitucionUS.Name = "txtInstitucionUS";
            this.txtInstitucionUS.Size = new System.Drawing.Size(234, 26);
            this.txtInstitucionUS.TabIndex = 37;
            // 
            // cmbOcupacionUS
            // 
            this.cmbOcupacionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOcupacionUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOcupacionUS.FormattingEnabled = true;
            this.cmbOcupacionUS.Location = new System.Drawing.Point(3, 476);
            this.cmbOcupacionUS.Name = "cmbOcupacionUS";
            this.cmbOcupacionUS.Size = new System.Drawing.Size(234, 28);
            this.cmbOcupacionUS.TabIndex = 33;
            // 
            // lblOcupacionUsuarioUS
            // 
            this.lblOcupacionUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOcupacionUsuarioUS.AutoSize = true;
            this.lblOcupacionUsuarioUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacionUsuarioUS.Location = new System.Drawing.Point(3, 453);
            this.lblOcupacionUsuarioUS.Name = "lblOcupacionUsuarioUS";
            this.lblOcupacionUsuarioUS.Size = new System.Drawing.Size(234, 20);
            this.lblOcupacionUsuarioUS.TabIndex = 32;
            this.lblOcupacionUsuarioUS.Text = "Ocupación";
            this.lblOcupacionUsuarioUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContraseniaUsuarioUS
            // 
            this.lblContraseniaUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseniaUsuarioUS.AutoSize = true;
            this.lblContraseniaUsuarioUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniaUsuarioUS.Location = new System.Drawing.Point(3, 109);
            this.lblContraseniaUsuarioUS.Name = "lblContraseniaUsuarioUS";
            this.lblContraseniaUsuarioUS.Size = new System.Drawing.Size(234, 20);
            this.lblContraseniaUsuarioUS.TabIndex = 42;
            this.lblContraseniaUsuarioUS.Text = "Contraseña";
            // 
            // txtContraseñaUS
            // 
            this.txtContraseñaUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaUS.Location = new System.Drawing.Point(3, 132);
            this.txtContraseñaUS.Name = "txtContraseñaUS";
            this.txtContraseñaUS.Size = new System.Drawing.Size(234, 26);
            this.txtContraseñaUS.TabIndex = 43;
            // 
            // lblDireccionUsuarioUS
            // 
            this.lblDireccionUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccionUsuarioUS.AutoSize = true;
            this.lblDireccionUsuarioUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionUsuarioUS.Location = new System.Drawing.Point(3, 367);
            this.lblDireccionUsuarioUS.Name = "lblDireccionUsuarioUS";
            this.lblDireccionUsuarioUS.Size = new System.Drawing.Size(234, 20);
            this.lblDireccionUsuarioUS.TabIndex = 34;
            this.lblDireccionUsuarioUS.Text = "Dirección";
            // 
            // txtDireccionUS
            // 
            this.txtDireccionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionUS.Location = new System.Drawing.Point(3, 390);
            this.txtDireccionUS.Name = "txtDireccionUS";
            this.txtDireccionUS.Size = new System.Drawing.Size(234, 26);
            this.txtDireccionUS.TabIndex = 35;
            // 
            // txtEmailUS
            // 
            this.txtEmailUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUS.Location = new System.Drawing.Point(3, 218);
            this.txtEmailUS.Name = "txtEmailUS";
            this.txtEmailUS.Size = new System.Drawing.Size(234, 26);
            this.txtEmailUS.TabIndex = 39;
            // 
            // lblEmailUsuarioUS
            // 
            this.lblEmailUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailUsuarioUS.AutoSize = true;
            this.lblEmailUsuarioUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsuarioUS.Location = new System.Drawing.Point(3, 195);
            this.lblEmailUsuarioUS.Name = "lblEmailUsuarioUS";
            this.lblEmailUsuarioUS.Size = new System.Drawing.Size(234, 20);
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
            this.txtTelefonoUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoUS.Location = new System.Drawing.Point(243, 46);
            this.txtTelefonoUS.Name = "txtTelefonoUS";
            this.txtTelefonoUS.Size = new System.Drawing.Size(241, 26);
            this.txtTelefonoUS.TabIndex = 45;
            // 
            // lblTelefonoUsuarioUS
            // 
            this.lblTelefonoUsuarioUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoUsuarioUS.AutoSize = true;
            this.tblUsuarios.SetColumnSpan(this.lblTelefonoUsuarioUS, 2);
            this.lblTelefonoUsuarioUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoUsuarioUS.Location = new System.Drawing.Point(243, 23);
            this.lblTelefonoUsuarioUS.Name = "lblTelefonoUsuarioUS";
            this.lblTelefonoUsuarioUS.Size = new System.Drawing.Size(241, 20);
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
            this.lblRolUsuarioUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsuarioUS.Location = new System.Drawing.Point(243, 109);
            this.lblRolUsuarioUS.Name = "lblRolUsuarioUS";
            this.lblRolUsuarioUS.Size = new System.Drawing.Size(241, 20);
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
            this.cmbRolUS.Location = new System.Drawing.Point(243, 132);
            this.cmbRolUS.Name = "cmbRolUS";
            this.cmbRolUS.Size = new System.Drawing.Size(241, 29);
            this.cmbRolUS.TabIndex = 41;
            // 
            // picFotoUS
            // 
            this.tblUsuarios.SetColumnSpan(this.picFotoUS, 2);
            this.picFotoUS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFotoUS.Image = global::BINAES.Properties.Resources._default;
            this.picFotoUS.Location = new System.Drawing.Point(243, 218);
            this.picFotoUS.Name = "picFotoUS";
            this.tblUsuarios.SetRowSpan(this.picFotoUS, 6);
            this.picFotoUS.Size = new System.Drawing.Size(241, 252);
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
            this.btnTomarFotoUS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTomarFotoUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomarFotoUS.Location = new System.Drawing.Point(243, 476);
            this.btnTomarFotoUS.Name = "btnTomarFotoUS";
            this.btnTomarFotoUS.Size = new System.Drawing.Size(114, 37);
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
            this.btnCancelarFotoUS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarFotoUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFotoUS.Location = new System.Drawing.Point(363, 476);
            this.btnCancelarFotoUS.Name = "btnCancelarFotoUS";
            this.btnCancelarFotoUS.Size = new System.Drawing.Size(121, 37);
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
            this.btnActualizarUS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUS.Location = new System.Drawing.Point(363, 519);
            this.btnActualizarUS.Name = "btnActualizarUS";
            this.btnActualizarUS.Size = new System.Drawing.Size(121, 45);
            this.btnActualizarUS.TabIndex = 50;
            this.btnActualizarUS.Text = "Actualizar";
            this.btnActualizarUS.UseVisualStyleBackColor = true;
            this.btnActualizarUS.Click += new System.EventHandler(this.btnActualizarUS_Click);
            // 
            // tabMisionVision
            // 
            this.tabMisionVision.Controls.Add(this.tblMisionVision);
            this.tabMisionVision.Location = new System.Drawing.Point(4, 33);
            this.tabMisionVision.Name = "tabMisionVision";
            this.tabMisionVision.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisionVision.Size = new System.Drawing.Size(964, 567);
            this.tabMisionVision.TabIndex = 6;
            this.tabMisionVision.Text = "Mision y Vision";
            this.tabMisionVision.UseVisualStyleBackColor = true;
            // 
            // tblMisionVision
            // 
            this.tblMisionVision.ColumnCount = 1;
            this.tblMisionVision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMisionVision.Controls.Add(this.lblVision, 0, 2);
            this.tblMisionVision.Controls.Add(this.lblInfoVision, 0, 3);
            this.tblMisionVision.Controls.Add(this.lblMision, 0, 0);
            this.tblMisionVision.Controls.Add(this.lblInfoMision, 0, 1);
            this.tblMisionVision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMisionVision.Location = new System.Drawing.Point(3, 3);
            this.tblMisionVision.Name = "tblMisionVision";
            this.tblMisionVision.RowCount = 4;
            this.tblMisionVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMisionVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblMisionVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMisionVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblMisionVision.Size = new System.Drawing.Size(958, 561);
            this.tblMisionVision.TabIndex = 0;
            // 
            // lblVision
            // 
            this.lblVision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVision.AutoSize = true;
            this.lblVision.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVision.Location = new System.Drawing.Point(3, 280);
            this.lblVision.Name = "lblVision";
            this.lblVision.Size = new System.Drawing.Size(952, 112);
            this.lblVision.TabIndex = 1;
            this.lblVision.Text = " VISIÓN ";
            this.lblVision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoVision
            // 
            this.lblInfoVision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoVision.AutoSize = true;
            this.lblInfoVision.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblInfoVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoVision.Location = new System.Drawing.Point(3, 392);
            this.lblInfoVision.Name = "lblInfoVision";
            this.lblInfoVision.Size = new System.Drawing.Size(952, 169);
            this.lblInfoVision.TabIndex = 3;
            this.lblInfoVision.Text = resources.GetString("lblInfoVision.Text");
            this.lblInfoVision.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMision
            // 
            this.lblMision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMision.AutoSize = true;
            this.lblMision.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblMision.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMision.Location = new System.Drawing.Point(3, 0);
            this.lblMision.Name = "lblMision";
            this.lblMision.Size = new System.Drawing.Size(952, 112);
            this.lblMision.TabIndex = 0;
            this.lblMision.Text = " MISIÓN ";
            this.lblMision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoMision
            // 
            this.lblInfoMision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoMision.AutoSize = true;
            this.lblInfoMision.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblInfoMision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMision.Location = new System.Drawing.Point(3, 112);
            this.lblInfoMision.Name = "lblInfoMision";
            this.lblInfoMision.Size = new System.Drawing.Size(952, 168);
            this.lblInfoMision.TabIndex = 2;
            this.lblInfoMision.Text = resources.GetString("lblInfoMision.Text");
            this.lblInfoMision.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabIntroduccion
            // 
            this.tabIntroduccion.Controls.Add(this.tblQuienesSomos);
            this.tabIntroduccion.Location = new System.Drawing.Point(4, 33);
            this.tabIntroduccion.Name = "tabIntroduccion";
            this.tabIntroduccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntroduccion.Size = new System.Drawing.Size(964, 567);
            this.tabIntroduccion.TabIndex = 8;
            this.tabIntroduccion.Text = "Introduccion";
            this.tabIntroduccion.UseVisualStyleBackColor = true;
            // 
            // tblQuienesSomos
            // 
            this.tblQuienesSomos.ColumnCount = 1;
            this.tblQuienesSomos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblQuienesSomos.Controls.Add(this.lblQuienesSomosTXT, 0, 1);
            this.tblQuienesSomos.Controls.Add(this.lblQuienesSomosTXT2, 0, 2);
            this.tblQuienesSomos.Controls.Add(this.lblQuienesSomos, 0, 0);
            this.tblQuienesSomos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblQuienesSomos.Location = new System.Drawing.Point(3, 3);
            this.tblQuienesSomos.Name = "tblQuienesSomos";
            this.tblQuienesSomos.RowCount = 3;
            this.tblQuienesSomos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblQuienesSomos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblQuienesSomos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblQuienesSomos.Size = new System.Drawing.Size(958, 561);
            this.tblQuienesSomos.TabIndex = 0;
            // 
            // lblQuienesSomosTXT
            // 
            this.lblQuienesSomosTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuienesSomosTXT.AutoSize = true;
            this.lblQuienesSomosTXT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblQuienesSomosTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienesSomosTXT.Location = new System.Drawing.Point(3, 112);
            this.lblQuienesSomosTXT.Name = "lblQuienesSomosTXT";
            this.lblQuienesSomosTXT.Size = new System.Drawing.Size(952, 224);
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
            this.lblQuienesSomosTXT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienesSomosTXT2.Location = new System.Drawing.Point(3, 336);
            this.lblQuienesSomosTXT2.Name = "lblQuienesSomosTXT2";
            this.lblQuienesSomosTXT2.Size = new System.Drawing.Size(952, 225);
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
            this.lblQuienesSomos.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienesSomos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuienesSomos.Location = new System.Drawing.Point(3, 0);
            this.lblQuienesSomos.Name = "lblQuienesSomos";
            this.lblQuienesSomos.Size = new System.Drawing.Size(952, 112);
            this.lblQuienesSomos.TabIndex = 0;
            this.lblQuienesSomos.Text = "Quienes somos?";
            this.lblQuienesSomos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabColeccion
            // 
            this.tabColeccion.Controls.Add(this.tblColeccion);
            this.tabColeccion.Location = new System.Drawing.Point(4, 33);
            this.tabColeccion.Name = "tabColeccion";
            this.tabColeccion.Size = new System.Drawing.Size(964, 567);
            this.tabColeccion.TabIndex = 9;
            this.tabColeccion.Text = "Colecciones";
            // 
            // tblColeccion
            // 
            this.tblColeccion.ColumnCount = 5;
            this.tblColeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.691757F));
            this.tblColeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.81138F));
            this.tblColeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.43723F));
            this.tblColeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.84636F));
            this.tblColeccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.21327F));
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
            this.tblColeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblColeccion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblColeccion.Location = new System.Drawing.Point(0, 0);
            this.tblColeccion.Name = "tblColeccion";
            this.tblColeccion.RowCount = 14;
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.256894F));
            this.tblColeccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660377F));
            this.tblColeccion.Size = new System.Drawing.Size(964, 567);
            this.tblColeccion.TabIndex = 12;
            // 
            // lblGeneroColeccionCO
            // 
            this.lblGeneroColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGeneroColeccionCO.AutoSize = true;
            this.lblGeneroColeccionCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroColeccionCO.Location = new System.Drawing.Point(57, 226);
            this.lblGeneroColeccionCO.Name = "lblGeneroColeccionCO";
            this.lblGeneroColeccionCO.Size = new System.Drawing.Size(67, 20);
            this.lblGeneroColeccionCO.TabIndex = 3;
            this.lblGeneroColeccionCO.Text = "Genero:";
            // 
            // lblTipoColeccionCO
            // 
            this.lblTipoColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipoColeccionCO.AutoSize = true;
            this.lblTipoColeccionCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoColeccionCO.Location = new System.Drawing.Point(57, 144);
            this.lblTipoColeccionCO.Name = "lblTipoColeccionCO";
            this.lblTipoColeccionCO.Size = new System.Drawing.Size(135, 20);
            this.lblTipoColeccionCO.TabIndex = 2;
            this.lblTipoColeccionCO.Text = "Tipo de colección:";
            // 
            // lblNombreColeccionCO
            // 
            this.lblNombreColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreColeccionCO.AutoSize = true;
            this.lblNombreColeccionCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColeccionCO.Location = new System.Drawing.Point(57, 62);
            this.lblNombreColeccionCO.Name = "lblNombreColeccionCO";
            this.lblNombreColeccionCO.Size = new System.Drawing.Size(69, 20);
            this.lblNombreColeccionCO.TabIndex = 0;
            this.lblNombreColeccionCO.Text = "Nombre:";
            // 
            // dgvColeccionesCO
            // 
            this.dgvColeccionesCO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColeccionesCO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColeccionesCO.Location = new System.Drawing.Point(425, 44);
            this.dgvColeccionesCO.Name = "dgvColeccionesCO";
            this.dgvColeccionesCO.RowHeadersWidth = 62;
            this.tblColeccion.SetRowSpan(this.dgvColeccionesCO, 12);
            this.dgvColeccionesCO.Size = new System.Drawing.Size(484, 486);
            this.dgvColeccionesCO.TabIndex = 29;
            // 
            // cmbTipoColeccionCO
            // 
            this.cmbTipoColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoColeccionCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoColeccionCO.FormattingEnabled = true;
            this.cmbTipoColeccionCO.Location = new System.Drawing.Point(57, 167);
            this.cmbTipoColeccionCO.Name = "cmbTipoColeccionCO";
            this.cmbTipoColeccionCO.Size = new System.Drawing.Size(291, 28);
            this.cmbTipoColeccionCO.TabIndex = 31;
            // 
            // cmbGeneroColeccionCO
            // 
            this.cmbGeneroColeccionCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroColeccionCO.FormattingEnabled = true;
            this.cmbGeneroColeccionCO.Location = new System.Drawing.Point(57, 249);
            this.cmbGeneroColeccionCO.Name = "cmbGeneroColeccionCO";
            this.cmbGeneroColeccionCO.Size = new System.Drawing.Size(291, 28);
            this.cmbGeneroColeccionCO.TabIndex = 32;
            // 
            // txtNombreColeccionCO
            // 
            this.txtNombreColeccionCO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreColeccionCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreColeccionCO.Location = new System.Drawing.Point(57, 85);
            this.txtNombreColeccionCO.Name = "txtNombreColeccionCO";
            this.txtNombreColeccionCO.Size = new System.Drawing.Size(291, 26);
            this.txtNombreColeccionCO.TabIndex = 33;
            // 
            // btnDejarDeEditarCO
            // 
            this.btnDejarDeEditarCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDejarDeEditarCO.Enabled = false;
            this.btnDejarDeEditarCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDejarDeEditarCO.Location = new System.Drawing.Point(120, 331);
            this.btnDejarDeEditarCO.Name = "btnDejarDeEditarCO";
            this.btnDejarDeEditarCO.Size = new System.Drawing.Size(165, 35);
            this.btnDejarDeEditarCO.TabIndex = 28;
            this.btnDejarDeEditarCO.Text = "Dejar de editar";
            this.btnDejarDeEditarCO.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCO
            // 
            this.btnBuscarCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBuscarCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCO.Location = new System.Drawing.Point(95, 454);
            this.btnBuscarCO.Name = "btnBuscarCO";
            this.btnBuscarCO.Size = new System.Drawing.Size(215, 35);
            this.btnBuscarCO.TabIndex = 34;
            this.btnBuscarCO.Text = "Colecciones Disponibles";
            this.btnBuscarCO.UseVisualStyleBackColor = true;
            this.btnBuscarCO.Click += new System.EventHandler(this.btnBuscarCO_Click);
            // 
            // btnAgregarCO
            // 
            this.btnAgregarCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAgregarCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCO.Location = new System.Drawing.Point(119, 372);
            this.btnAgregarCO.Name = "btnAgregarCO";
            this.btnAgregarCO.Size = new System.Drawing.Size(166, 35);
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
            this.txtNombreCO.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCO.TabIndex = 0;
            // 
            // sspStatus
            // 
            this.sspStatus.BackColor = System.Drawing.SystemColors.Control;
            this.sspStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sspStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sspNombre,
            this.sspRol});
            this.sspStatus.Location = new System.Drawing.Point(0, 659);
            this.sspStatus.Name = "sspStatus";
            this.sspStatus.Size = new System.Drawing.Size(1264, 22);
            this.sspStatus.TabIndex = 2;
            // 
            // sspNombre
            // 
            this.sspNombre.Name = "sspNombre";
            this.sspNombre.Size = new System.Drawing.Size(57, 17);
            this.sspNombre.Text = "Nombre: ";
            // 
            // sspRol
            // 
            this.sspRol.Name = "sspRol";
            this.sspRol.Size = new System.Drawing.Size(30, 17);
            this.sspRol.Text = "Rol: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIntroPPrincipal);
            this.panel1.Controls.Add(this.btnMisionVisionPPrincipal);
            this.panel1.Controls.Add(this.btnAddUsuarioPPrincipal);
            this.panel1.Controls.Add(this.btnAddEventoPPrincipal);
            this.panel1.Controls.Add(this.btnAddEjemplarPPrincipal);
            this.panel1.Controls.Add(this.btnReservasPPrincipal);
            this.panel1.Controls.Add(this.btnPrestamosPPrincipal);
            this.panel1.Controls.Add(this.btnBusquedaPPrincipal);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 659);
            this.panel1.TabIndex = 3;
            // 
            // btnIntroPPrincipal
            // 
            this.btnIntroPPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnIntroPPrincipal.FlatAppearance.BorderSize = 0;
            this.btnIntroPPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroPPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroPPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnIntroPPrincipal.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnIntroPPrincipal.IconColor = System.Drawing.Color.White;
            this.btnIntroPPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIntroPPrincipal.IconSize = 40;
            this.btnIntroPPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntroPPrincipal.Location = new System.Drawing.Point(3, 228);
            this.btnIntroPPrincipal.Name = "btnIntroPPrincipal";
            this.btnIntroPPrincipal.Size = new System.Drawing.Size(292, 54);
            this.btnIntroPPrincipal.TabIndex = 8;
            this.btnIntroPPrincipal.Text = "Introduccion";
            this.btnIntroPPrincipal.UseVisualStyleBackColor = false;
            // 
            // btnMisionVisionPPrincipal
            // 
            this.btnMisionVisionPPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnMisionVisionPPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMisionVisionPPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisionVisionPPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisionVisionPPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnMisionVisionPPrincipal.IconChar = FontAwesome.Sharp.IconChar.Medapps;
            this.btnMisionVisionPPrincipal.IconColor = System.Drawing.Color.White;
            this.btnMisionVisionPPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMisionVisionPPrincipal.IconSize = 40;
            this.btnMisionVisionPPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisionVisionPPrincipal.Location = new System.Drawing.Point(3, 168);
            this.btnMisionVisionPPrincipal.Name = "btnMisionVisionPPrincipal";
            this.btnMisionVisionPPrincipal.Size = new System.Drawing.Size(303, 54);
            this.btnMisionVisionPPrincipal.TabIndex = 7;
            this.btnMisionVisionPPrincipal.Text = "Mision y Vision";
            this.btnMisionVisionPPrincipal.UseVisualStyleBackColor = false;
            // 
            // btnAddUsuarioPPrincipal
            // 
            this.btnAddUsuarioPPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUsuarioPPrincipal.FlatAppearance.BorderSize = 0;
            this.btnAddUsuarioPPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsuarioPPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsuarioPPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnAddUsuarioPPrincipal.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAddUsuarioPPrincipal.IconColor = System.Drawing.Color.White;
            this.btnAddUsuarioPPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddUsuarioPPrincipal.IconSize = 40;
            this.btnAddUsuarioPPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUsuarioPPrincipal.Location = new System.Drawing.Point(6, 534);
            this.btnAddUsuarioPPrincipal.Name = "btnAddUsuarioPPrincipal";
            this.btnAddUsuarioPPrincipal.Size = new System.Drawing.Size(303, 59);
            this.btnAddUsuarioPPrincipal.TabIndex = 6;
            this.btnAddUsuarioPPrincipal.Text = "Añadir Usuario";
            this.btnAddUsuarioPPrincipal.UseVisualStyleBackColor = false;
            // 
            // btnAddEventoPPrincipal
            // 
            this.btnAddEventoPPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEventoPPrincipal.FlatAppearance.BorderSize = 0;
            this.btnAddEventoPPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEventoPPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEventoPPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnAddEventoPPrincipal.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnAddEventoPPrincipal.IconColor = System.Drawing.Color.White;
            this.btnAddEventoPPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddEventoPPrincipal.IconSize = 40;
            this.btnAddEventoPPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEventoPPrincipal.Location = new System.Drawing.Point(6, 466);
            this.btnAddEventoPPrincipal.Name = "btnAddEventoPPrincipal";
            this.btnAddEventoPPrincipal.Size = new System.Drawing.Size(303, 62);
            this.btnAddEventoPPrincipal.TabIndex = 5;
            this.btnAddEventoPPrincipal.Text = "Añadir Evento";
            this.btnAddEventoPPrincipal.UseVisualStyleBackColor = false;
            // 
            // btnAddEjemplarPPrincipal
            // 
            this.btnAddEjemplarPPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEjemplarPPrincipal.FlatAppearance.BorderSize = 0;
            this.btnAddEjemplarPPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEjemplarPPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEjemplarPPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnAddEjemplarPPrincipal.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btnAddEjemplarPPrincipal.IconColor = System.Drawing.Color.White;
            this.btnAddEjemplarPPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddEjemplarPPrincipal.IconSize = 40;
            this.btnAddEjemplarPPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEjemplarPPrincipal.Location = new System.Drawing.Point(3, 594);
            this.btnAddEjemplarPPrincipal.Name = "btnAddEjemplarPPrincipal";
            this.btnAddEjemplarPPrincipal.Size = new System.Drawing.Size(331, 58);
            this.btnAddEjemplarPPrincipal.TabIndex = 4;
            this.btnAddEjemplarPPrincipal.Text = "Añadir Ejemplar";
            this.btnAddEjemplarPPrincipal.UseVisualStyleBackColor = false;
            // 
            // btnReservasPPrincipal
            // 
            this.btnReservasPPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnReservasPPrincipal.FlatAppearance.BorderSize = 0;
            this.btnReservasPPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservasPPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservasPPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnReservasPPrincipal.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnReservasPPrincipal.IconColor = System.Drawing.Color.White;
            this.btnReservasPPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservasPPrincipal.IconSize = 40;
            this.btnReservasPPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservasPPrincipal.Location = new System.Drawing.Point(6, 403);
            this.btnReservasPPrincipal.Name = "btnReservasPPrincipal";
            this.btnReservasPPrincipal.Size = new System.Drawing.Size(289, 60);
            this.btnReservasPPrincipal.TabIndex = 3;
            this.btnReservasPPrincipal.Text = "Reservas";
            this.btnReservasPPrincipal.UseVisualStyleBackColor = false;
            // 
            // btnPrestamosPPrincipal
            // 
            this.btnPrestamosPPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnPrestamosPPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrestamosPPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamosPPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamosPPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrestamosPPrincipal.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.btnPrestamosPPrincipal.IconColor = System.Drawing.Color.White;
            this.btnPrestamosPPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrestamosPPrincipal.IconSize = 40;
            this.btnPrestamosPPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamosPPrincipal.Location = new System.Drawing.Point(6, 338);
            this.btnPrestamosPPrincipal.Name = "btnPrestamosPPrincipal";
            this.btnPrestamosPPrincipal.Size = new System.Drawing.Size(289, 59);
            this.btnPrestamosPPrincipal.TabIndex = 2;
            this.btnPrestamosPPrincipal.Text = "Prestamos";
            this.btnPrestamosPPrincipal.UseVisualStyleBackColor = false;
            // 
            // btnBusquedaPPrincipal
            // 
            this.btnBusquedaPPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnBusquedaPPrincipal.FlatAppearance.BorderSize = 0;
            this.btnBusquedaPPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaPPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaPPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnBusquedaPPrincipal.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBusquedaPPrincipal.IconColor = System.Drawing.Color.White;
            this.btnBusquedaPPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusquedaPPrincipal.IconSize = 40;
            this.btnBusquedaPPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaPPrincipal.Location = new System.Drawing.Point(3, 279);
            this.btnBusquedaPPrincipal.Name = "btnBusquedaPPrincipal";
            this.btnBusquedaPPrincipal.Size = new System.Drawing.Size(289, 60);
            this.btnBusquedaPPrincipal.TabIndex = 1;
            this.btnBusquedaPPrincipal.Text = "Busqueda";
            this.btnBusquedaPPrincipal.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 156);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BINAES.Properties.Resources.LOGOBINAES_nobackground;
            this.pictureBox1.Location = new System.Drawing.Point(48, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.btnMinPrincipal);
            this.panelPrincipal.Controls.Add(this.btnMaxPrincipal);
            this.panelPrincipal.Controls.Add(this.btnCerrarPrincipal);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrincipal.Location = new System.Drawing.Point(292, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(972, 40);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPrincipal_MouseDown);
            // 
            // btnMinPrincipal
            // 
            this.btnMinPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMinPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinPrincipal.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinPrincipal.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinPrincipal.IconColor = System.Drawing.Color.White;
            this.btnMinPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinPrincipal.IconSize = 30;
            this.btnMinPrincipal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinPrincipal.Location = new System.Drawing.Point(832, 3);
            this.btnMinPrincipal.Name = "btnMinPrincipal";
            this.btnMinPrincipal.Size = new System.Drawing.Size(47, 42);
            this.btnMinPrincipal.TabIndex = 3;
            this.btnMinPrincipal.UseVisualStyleBackColor = true;
            this.btnMinPrincipal.Click += new System.EventHandler(this.btnMinPrincipal_Click);
            // 
            // btnMaxPrincipal
            // 
            this.btnMaxPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMaxPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxPrincipal.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaxPrincipal.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaxPrincipal.IconColor = System.Drawing.Color.White;
            this.btnMaxPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxPrincipal.IconSize = 30;
            this.btnMaxPrincipal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaxPrincipal.Location = new System.Drawing.Point(876, 3);
            this.btnMaxPrincipal.Name = "btnMaxPrincipal";
            this.btnMaxPrincipal.Size = new System.Drawing.Size(47, 42);
            this.btnMaxPrincipal.TabIndex = 2;
            this.btnMaxPrincipal.UseVisualStyleBackColor = true;
            this.btnMaxPrincipal.Click += new System.EventHandler(this.btnMaxPrincipal_Click);
            // 
            // btnCerrarPrincipal
            // 
            this.btnCerrarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPrincipal.FlatAppearance.BorderSize = 0;
            this.btnCerrarPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPrincipal.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarPrincipal.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrarPrincipal.IconColor = System.Drawing.Color.White;
            this.btnCerrarPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPrincipal.IconSize = 30;
            this.btnCerrarPrincipal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarPrincipal.Location = new System.Drawing.Point(920, 3);
            this.btnCerrarPrincipal.Name = "btnCerrarPrincipal";
            this.btnCerrarPrincipal.Size = new System.Drawing.Size(52, 42);
            this.btnCerrarPrincipal.TabIndex = 0;
            this.btnCerrarPrincipal.UseVisualStyleBackColor = true;
            this.btnCerrarPrincipal.Click += new System.EventHandler(this.btnCerrarPrincipal_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel1);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudIdEjemplarRE)).EndInit();
            this.tabPrestamo.ResumeLayout(false);
            this.tblPrestamo.ResumeLayout(false);
            this.tblPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosPR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdEjemplarPR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdUsuarioPR)).EndInit();
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
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvPrestamosPR;
        private System.Windows.Forms.Label lblEjemplarPR;
        private Button btnQrPR;
        private Label lblUsuarioPR;
        private Button btnBuscarPR;
        private System.Windows.Forms.TabPage tabColeccion;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlpColeccionCO;
        private Label label19;
        private Label label20;
        private Label label29;
        private DataGridView dgvVistaColeccionCO;
        private TextBox txtNombreCO;
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
        private NumericUpDown nudIdEjemplarRE;
        private NumericUpDown nudIdUsuarioRE;
        private Panel panel1;
        private Panel panel3;
        private Panel panelPrincipal;
        private FontAwesome.Sharp.IconButton btnMinPrincipal;
        private FontAwesome.Sharp.IconButton btnMaxPrincipal;
        private FontAwesome.Sharp.IconButton btnCerrarPrincipal;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnAddUsuarioPPrincipal;
        private FontAwesome.Sharp.IconButton btnAddEventoPPrincipal;
        private FontAwesome.Sharp.IconButton btnAddEjemplarPPrincipal;
        private FontAwesome.Sharp.IconButton btnReservasPPrincipal;
        private FontAwesome.Sharp.IconButton btnPrestamosPPrincipal;
        private FontAwesome.Sharp.IconButton btnBusquedaPPrincipal;
        private FontAwesome.Sharp.IconButton btnMisionVisionPPrincipal;
        private FontAwesome.Sharp.IconButton btnIntroPPrincipal;
        private Button btnPrestarPR;
        private NumericUpDown nudIdEjemplarPR;
        private NumericUpDown nudIdUsuarioPR;
    }
}