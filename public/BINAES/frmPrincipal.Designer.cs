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
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtNombreUS = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtEmailUS = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtDireccionUS = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtContraseñaUS = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtTelefonoUS = new System.Windows.Forms.TextBox();
            this.btnAgregarUS = new System.Windows.Forms.Button();
            this.txtInstitucionUS = new System.Windows.Forms.TextBox();
            this.cmbOcupacionUS = new System.Windows.Forms.ComboBox();
            this.cmbRolUS = new System.Windows.Forms.ComboBox();
            this.picFotoUS = new System.Windows.Forms.PictureBox();
            this.btnTomarFotoUS = new System.Windows.Forms.Button();
            this.btnCancelarFotoUS = new System.Windows.Forms.Button();
            this.tabEventos = new System.Windows.Forms.TabPage();
            this.tlpAdminEventosEV = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarEV = new System.Windows.Forms.Button();
            this.dgvEventosEV = new System.Windows.Forms.DataGridView();
            this.nudNumeroAsistentesEV = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbTipoSalonEV = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rtbObjetivoEventoEV = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFechaFinalizacionEV = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaInicioEV = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTituloEventoEV = new System.Windows.Forms.TextBox();
            this.btnDejarDeEditarEV = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.picEventos = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalirEdicionEjemplarAG = new System.Windows.Forms.Button();
            this.btnAgregarEjemplarAG = new System.Windows.Forms.Button();
            this.txtEditorialEjemplarAG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEjemplarAG = new System.Windows.Forms.TextBox();
            this.cmbIdiomaEjemplarAG = new System.Windows.Forms.ComboBox();
            this.btnEtiquetasEjemplarAG = new System.Windows.Forms.Button();
            this.txtNombreEjemplarAG = new System.Windows.Forms.TextBox();
            this.txtAutorEjemplarAG = new System.Windows.Forms.TextBox();
            this.cmbTipoColeccionEjemplarAG = new System.Windows.Forms.ComboBox();
            this.cmbFormatoEjemplarAG = new System.Windows.Forms.ComboBox();
            this.dgvEjemplaresAG = new System.Windows.Forms.DataGridView();
            this.dtpFechaPublicacionEjemplarAG = new System.Windows.Forms.DateTimePicker();
            this.picAgregarEjemplar = new System.Windows.Forms.PictureBox();
            this.tabReserva = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReservasRE = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.btnBuscarEjemplarRE = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btnPrestarRE = new System.Windows.Forms.Button();
            this.nudIdUsuarioRE = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPrestamo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscarEjemplarBU = new System.Windows.Forms.TextBox();
            this.cmbFiltrarEjemplarBU = new System.Windows.Forms.ComboBox();
            this.btnBuscarEjemplarBU = new FontAwesome.Sharp.IconButton();
            this.dgvEjemplaresBU = new System.Windows.Forms.DataGridView();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabMisionVision = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMision = new System.Windows.Forms.Label();
            this.lblVision = new System.Windows.Forms.Label();
            this.lblInfoMision = new System.Windows.Forms.Label();
            this.lblInfoVision = new System.Windows.Forms.Label();
            this.tabIntroduccion = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpColeccionCO = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dgvVistaColeccionCO = new System.Windows.Forms.DataGridView();
            this.txtNombreCO = new System.Windows.Forms.TextBox();
            this.cmbTipoColeccionCO = new System.Windows.Forms.ComboBox();
            this.cmbGeneroColeccionCO = new System.Windows.Forms.ComboBox();
            this.btnAgregarCO = new System.Windows.Forms.Button();
            this.btnDejardeEditarCO = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sspStatus = new System.Windows.Forms.StatusStrip();
            this.sspNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.sspRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnIntroPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnMisionVisionPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnReservarPrinpal = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUsuarioPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnAdminEventosPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnAñadirEjemplarPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnPrestamosPrincipal = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelBarraTituloPrincpal = new System.Windows.Forms.Panel();
            this.btnMinimizarPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnRestoreWinPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPrincipal = new FontAwesome.Sharp.IconButton();
            this.txtboxNewBusquedaEjemplarPR = new System.Windows.Forms.TextBox();
            this.txtboxNewCompletarRUsuarioPR = new System.Windows.Forms.TextBox();
            this.tabUsuarios.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUS)).BeginInit();
            this.tabEventos.SuspendLayout();
            this.tlpAdminEventosEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroAsistentesEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventos)).BeginInit();
            this.tabAgregar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresAG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarEjemplar)).BeginInit();
            this.tabReserva.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdUsuarioRE)).BeginInit();
            this.tabPrestamo.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabBuscar.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresBU)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.tabMisionVision.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabIntroduccion.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaColeccionCO)).BeginInit();
            this.sspStatus.SuspendLayout();
            this.panelMenuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraTituloPrincpal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tableLayoutPanel5);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 40);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(1001, 563);
            this.tabUsuarios.TabIndex = 5;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999732F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33098F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33098F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66929F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66929F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999732F));
            this.tableLayoutPanel5.Controls.Add(this.label36, 4, 3);
            this.tableLayoutPanel5.Controls.Add(this.label35, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtNombreUS, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.label34, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtEmailUS, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.label30, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.label37, 3, 5);
            this.tableLayoutPanel5.Controls.Add(this.txtDireccionUS, 3, 6);
            this.tableLayoutPanel5.Controls.Add(this.label38, 4, 5);
            this.tableLayoutPanel5.Controls.Add(this.txtContraseñaUS, 4, 6);
            this.tableLayoutPanel5.Controls.Add(this.label40, 3, 7);
            this.tableLayoutPanel5.Controls.Add(this.label39, 4, 7);
            this.tableLayoutPanel5.Controls.Add(this.txtTelefonoUS, 4, 8);
            this.tableLayoutPanel5.Controls.Add(this.btnAgregarUS, 3, 10);
            this.tableLayoutPanel5.Controls.Add(this.txtInstitucionUS, 3, 8);
            this.tableLayoutPanel5.Controls.Add(this.cmbOcupacionUS, 3, 4);
            this.tableLayoutPanel5.Controls.Add(this.cmbRolUS, 4, 4);
            this.tableLayoutPanel5.Controls.Add(this.picFotoUS, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnTomarFotoUS, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.btnCancelarFotoUS, 2, 10);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 12;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1001, 563);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(635, 138);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(260, 46);
            this.label36.TabIndex = 11;
            this.label36.Text = "Rol:";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(369, 138);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(260, 46);
            this.label35.TabIndex = 10;
            this.label35.Text = "Ocupación:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreUS
            // 
            this.txtNombreUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUS.Location = new System.Drawing.Point(369, 95);
            this.txtNombreUS.Name = "txtNombreUS";
            this.txtNombreUS.Size = new System.Drawing.Size(260, 34);
            this.txtNombreUS.TabIndex = 8;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(369, 46);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(260, 46);
            this.label34.TabIndex = 6;
            this.label34.Text = "Nombre:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmailUS
            // 
            this.txtEmailUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailUS.Location = new System.Drawing.Point(635, 95);
            this.txtEmailUS.Name = "txtEmailUS";
            this.txtEmailUS.Size = new System.Drawing.Size(260, 34);
            this.txtEmailUS.TabIndex = 9;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(635, 46);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(260, 46);
            this.label30.TabIndex = 1;
            this.label30.Text = "E-mail:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(369, 230);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(260, 46);
            this.label37.TabIndex = 14;
            this.label37.Text = "Dirección:";
            // 
            // txtDireccionUS
            // 
            this.txtDireccionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionUS.Location = new System.Drawing.Point(369, 279);
            this.txtDireccionUS.Name = "txtDireccionUS";
            this.txtDireccionUS.Size = new System.Drawing.Size(260, 34);
            this.txtDireccionUS.TabIndex = 16;
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(635, 230);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(260, 46);
            this.label38.TabIndex = 15;
            this.label38.Text = "Contraseña:";
            // 
            // txtContraseñaUS
            // 
            this.txtContraseñaUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaUS.Location = new System.Drawing.Point(635, 279);
            this.txtContraseñaUS.Name = "txtContraseñaUS";
            this.txtContraseñaUS.Size = new System.Drawing.Size(260, 34);
            this.txtContraseñaUS.TabIndex = 17;
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(369, 322);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(260, 46);
            this.label40.TabIndex = 18;
            this.label40.Text = "Institución:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(635, 322);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(260, 46);
            this.label39.TabIndex = 19;
            this.label39.Text = "Teléfono:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefonoUS
            // 
            this.txtTelefonoUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoUS.Location = new System.Drawing.Point(635, 371);
            this.txtTelefonoUS.Name = "txtTelefonoUS";
            this.txtTelefonoUS.Size = new System.Drawing.Size(260, 34);
            this.txtTelefonoUS.TabIndex = 21;
            // 
            // btnAgregarUS
            // 
            this.btnAgregarUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.btnAgregarUS, 2);
            this.btnAgregarUS.Location = new System.Drawing.Point(369, 463);
            this.btnAgregarUS.Name = "btnAgregarUS";
            this.btnAgregarUS.Size = new System.Drawing.Size(526, 40);
            this.btnAgregarUS.TabIndex = 22;
            this.btnAgregarUS.Text = "Agregar";
            this.btnAgregarUS.UseVisualStyleBackColor = true;
            // 
            // txtInstitucionUS
            // 
            this.txtInstitucionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstitucionUS.Location = new System.Drawing.Point(369, 371);
            this.txtInstitucionUS.Name = "txtInstitucionUS";
            this.txtInstitucionUS.Size = new System.Drawing.Size(260, 34);
            this.txtInstitucionUS.TabIndex = 20;
            // 
            // cmbOcupacionUS
            // 
            this.cmbOcupacionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOcupacionUS.FormattingEnabled = true;
            this.cmbOcupacionUS.Location = new System.Drawing.Point(369, 187);
            this.cmbOcupacionUS.Name = "cmbOcupacionUS";
            this.cmbOcupacionUS.Size = new System.Drawing.Size(260, 36);
            this.cmbOcupacionUS.TabIndex = 23;
            // 
            // cmbRolUS
            // 
            this.cmbRolUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRolUS.FormattingEnabled = true;
            this.cmbRolUS.Location = new System.Drawing.Point(635, 187);
            this.cmbRolUS.Name = "cmbRolUS";
            this.cmbRolUS.Size = new System.Drawing.Size(260, 36);
            this.cmbRolUS.TabIndex = 24;
            // 
            // picFotoUS
            // 
            this.picFotoUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.picFotoUS, 2);
            this.picFotoUS.Image = global::BINAES.Properties.Resources.SubirImagen;
            this.picFotoUS.Location = new System.Drawing.Point(103, 95);
            this.picFotoUS.Name = "picFotoUS";
            this.tableLayoutPanel5.SetRowSpan(this.picFotoUS, 6);
            this.picFotoUS.Size = new System.Drawing.Size(260, 270);
            this.picFotoUS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoUS.TabIndex = 25;
            this.picFotoUS.TabStop = false;
            this.picFotoUS.Click += new System.EventHandler(this.picFotoUS_Click);
            // 
            // btnTomarFotoUS
            // 
            this.btnTomarFotoUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTomarFotoUS.Location = new System.Drawing.Point(103, 463);
            this.btnTomarFotoUS.Name = "btnTomarFotoUS";
            this.btnTomarFotoUS.Size = new System.Drawing.Size(127, 40);
            this.btnTomarFotoUS.TabIndex = 6;
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
            this.btnCancelarFotoUS.Location = new System.Drawing.Point(236, 463);
            this.btnCancelarFotoUS.Name = "btnCancelarFotoUS";
            this.btnCancelarFotoUS.Size = new System.Drawing.Size(127, 40);
            this.btnCancelarFotoUS.TabIndex = 26;
            this.btnCancelarFotoUS.Text = "Cancelar foto";
            this.btnCancelarFotoUS.UseVisualStyleBackColor = true;
            this.btnCancelarFotoUS.Click += new System.EventHandler(this.btnCancelarFotoUS_Click);
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.tlpAdminEventosEV);
            this.tabEventos.Location = new System.Drawing.Point(4, 40);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(1001, 563);
            this.tabEventos.TabIndex = 4;
            this.tabEventos.Text = "Eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // tlpAdminEventosEV
            // 
            this.tlpAdminEventosEV.ColumnCount = 3;
            this.tlpAdminEventosEV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.01243F));
            this.tlpAdminEventosEV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.76769F));
            this.tlpAdminEventosEV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.21988F));
            this.tlpAdminEventosEV.Controls.Add(this.btnAgregarEV, 1, 12);
            this.tlpAdminEventosEV.Controls.Add(this.dgvEventosEV, 2, 0);
            this.tlpAdminEventosEV.Controls.Add(this.nudNumeroAsistentesEV, 0, 11);
            this.tlpAdminEventosEV.Controls.Add(this.label17, 0, 10);
            this.tlpAdminEventosEV.Controls.Add(this.cmbTipoSalonEV, 0, 9);
            this.tlpAdminEventosEV.Controls.Add(this.label15, 0, 8);
            this.tlpAdminEventosEV.Controls.Add(this.rtbObjetivoEventoEV, 0, 7);
            this.tlpAdminEventosEV.Controls.Add(this.label16, 0, 6);
            this.tlpAdminEventosEV.Controls.Add(this.dtpFechaFinalizacionEV, 0, 5);
            this.tlpAdminEventosEV.Controls.Add(this.label14, 0, 4);
            this.tlpAdminEventosEV.Controls.Add(this.dtpFechaInicioEV, 0, 3);
            this.tlpAdminEventosEV.Controls.Add(this.label13, 0, 2);
            this.tlpAdminEventosEV.Controls.Add(this.txtTituloEventoEV, 0, 1);
            this.tlpAdminEventosEV.Controls.Add(this.btnDejarDeEditarEV, 0, 12);
            this.tlpAdminEventosEV.Controls.Add(this.label11, 1, 0);
            this.tlpAdminEventosEV.Controls.Add(this.picEventos, 1, 1);
            this.tlpAdminEventosEV.Controls.Add(this.label12, 0, 0);
            this.tlpAdminEventosEV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdminEventosEV.Location = new System.Drawing.Point(0, 0);
            this.tlpAdminEventosEV.Name = "tlpAdminEventosEV";
            this.tlpAdminEventosEV.RowCount = 13;
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpAdminEventosEV.Size = new System.Drawing.Size(1001, 563);
            this.tlpAdminEventosEV.TabIndex = 0;
            // 
            // btnAgregarEV
            // 
            this.btnAgregarEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEV.Location = new System.Drawing.Point(273, 519);
            this.btnAgregarEV.Name = "btnAgregarEV";
            this.btnAgregarEV.Size = new System.Drawing.Size(291, 41);
            this.btnAgregarEV.TabIndex = 22;
            this.btnAgregarEV.Text = "Agregar";
            this.btnAgregarEV.UseVisualStyleBackColor = true;
            this.btnAgregarEV.Click += new System.EventHandler(this.btnAgregarEV_Click);
            // 
            // dgvEventosEV
            // 
            this.dgvEventosEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEventosEV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventosEV.Location = new System.Drawing.Point(570, 3);
            this.dgvEventosEV.Name = "dgvEventosEV";
            this.dgvEventosEV.RowHeadersWidth = 51;
            this.tlpAdminEventosEV.SetRowSpan(this.dgvEventosEV, 13);
            this.dgvEventosEV.Size = new System.Drawing.Size(428, 557);
            this.dgvEventosEV.TabIndex = 26;
            this.dgvEventosEV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventosEV_CellContentClick);
            // 
            // nudNumeroAsistentesEV
            // 
            this.nudNumeroAsistentesEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumeroAsistentesEV.Location = new System.Drawing.Point(3, 476);
            this.nudNumeroAsistentesEV.Name = "nudNumeroAsistentesEV";
            this.nudNumeroAsistentesEV.Size = new System.Drawing.Size(264, 34);
            this.nudNumeroAsistentesEV.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 430);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(264, 43);
            this.label17.TabIndex = 21;
            this.label17.Text = "Número de asistentes:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTipoSalonEV
            // 
            this.cmbTipoSalonEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoSalonEV.FormattingEnabled = true;
            this.cmbTipoSalonEV.Location = new System.Drawing.Point(3, 390);
            this.cmbTipoSalonEV.Name = "cmbTipoSalonEV";
            this.cmbTipoSalonEV.Size = new System.Drawing.Size(264, 36);
            this.cmbTipoSalonEV.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 344);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 43);
            this.label15.TabIndex = 20;
            this.label15.Text = "Tipo de salón: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbObjetivoEventoEV
            // 
            this.rtbObjetivoEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbObjetivoEventoEV.Location = new System.Drawing.Point(3, 304);
            this.rtbObjetivoEventoEV.Name = "rtbObjetivoEventoEV";
            this.rtbObjetivoEventoEV.Size = new System.Drawing.Size(264, 37);
            this.rtbObjetivoEventoEV.TabIndex = 23;
            this.rtbObjetivoEventoEV.Text = "";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(264, 43);
            this.label16.TabIndex = 13;
            this.label16.Text = "Objetivos del evento:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaFinalizacionEV
            // 
            this.dtpFechaFinalizacionEV.Location = new System.Drawing.Point(3, 218);
            this.dtpFechaFinalizacionEV.Name = "dtpFechaFinalizacionEV";
            this.dtpFechaFinalizacionEV.Size = new System.Drawing.Size(264, 34);
            this.dtpFechaFinalizacionEV.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(264, 43);
            this.label14.TabIndex = 18;
            this.label14.Text = "Fecha de finalización:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaInicioEV
            // 
            this.dtpFechaInicioEV.Location = new System.Drawing.Point(3, 132);
            this.dtpFechaInicioEV.Name = "dtpFechaInicioEV";
            this.dtpFechaInicioEV.Size = new System.Drawing.Size(264, 34);
            this.dtpFechaInicioEV.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(264, 43);
            this.label13.TabIndex = 5;
            this.label13.Text = "Fecha de inicio:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTituloEventoEV
            // 
            this.txtTituloEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTituloEventoEV.Location = new System.Drawing.Point(3, 46);
            this.txtTituloEventoEV.Name = "txtTituloEventoEV";
            this.txtTituloEventoEV.Size = new System.Drawing.Size(264, 34);
            this.txtTituloEventoEV.TabIndex = 4;
            // 
            // btnDejarDeEditarEV
            // 
            this.btnDejarDeEditarEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDejarDeEditarEV.Location = new System.Drawing.Point(3, 519);
            this.btnDejarDeEditarEV.Name = "btnDejarDeEditarEV";
            this.btnDejarDeEditarEV.Size = new System.Drawing.Size(264, 41);
            this.btnDejarDeEditarEV.TabIndex = 24;
            this.btnDejarDeEditarEV.Text = "Dejar de editar";
            this.btnDejarDeEditarEV.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(291, 43);
            this.label11.TabIndex = 27;
            this.label11.Text = "Imagen";
            // 
            // picEventos
            // 
            this.picEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEventos.Image = global::BINAES.Properties.Resources.SubirImagen;
            this.picEventos.Location = new System.Drawing.Point(273, 46);
            this.picEventos.Name = "picEventos";
            this.tlpAdminEventosEV.SetRowSpan(this.picEventos, 11);
            this.picEventos.Size = new System.Drawing.Size(291, 467);
            this.picEventos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEventos.TabIndex = 28;
            this.picEventos.TabStop = false;
            this.picEventos.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 43);
            this.label12.TabIndex = 3;
            this.label12.Text = "Titulo del evento:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.tableLayoutPanel1);
            this.tabAgregar.Location = new System.Drawing.Point(4, 40);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Size = new System.Drawing.Size(1001, 563);
            this.tabAgregar.TabIndex = 3;
            this.tabAgregar.Text = "Agregar ejemplar";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalirEdicionEjemplarAG, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarEjemplarAG, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtEditorialEjemplarAG, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigoEjemplarAG, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbIdiomaEjemplarAG, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnEtiquetasEjemplarAG, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreEjemplarAG, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAutorEjemplarAG, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoColeccionEjemplarAG, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbFormatoEjemplarAG, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.dgvEjemplaresAG, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaPublicacionEjemplarAG, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.picAgregarEjemplar, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 563);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnSalirEdicionEjemplarAG
            // 
            this.btnSalirEdicionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirEdicionEjemplarAG.Enabled = false;
            this.btnSalirEdicionEjemplarAG.Location = new System.Drawing.Point(3, 519);
            this.btnSalirEdicionEjemplarAG.Name = "btnSalirEdicionEjemplarAG";
            this.btnSalirEdicionEjemplarAG.Size = new System.Drawing.Size(194, 41);
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
            this.btnAgregarEjemplarAG.Location = new System.Drawing.Point(203, 519);
            this.btnAgregarEjemplarAG.Name = "btnAgregarEjemplarAG";
            this.btnAgregarEjemplarAG.Size = new System.Drawing.Size(194, 41);
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
            this.txtEditorialEjemplarAG.Location = new System.Drawing.Point(203, 46);
            this.txtEditorialEjemplarAG.Name = "txtEditorialEjemplarAG";
            this.txtEditorialEjemplarAG.Size = new System.Drawing.Size(194, 34);
            this.txtEditorialEjemplarAG.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 28);
            this.label10.TabIndex = 9;
            this.label10.Text = "Imagen";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 43);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de publicación";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idioma";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Editorial";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Etiquetas";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Formato";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo de colección";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código ejemplar";
            // 
            // txtCodigoEjemplarAG
            // 
            this.txtCodigoEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoEjemplarAG.Location = new System.Drawing.Point(3, 46);
            this.txtCodigoEjemplarAG.Name = "txtCodigoEjemplarAG";
            this.txtCodigoEjemplarAG.Size = new System.Drawing.Size(194, 34);
            this.txtCodigoEjemplarAG.TabIndex = 10;
            // 
            // cmbIdiomaEjemplarAG
            // 
            this.cmbIdiomaEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdiomaEjemplarAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdiomaEjemplarAG.FormattingEnabled = true;
            this.cmbIdiomaEjemplarAG.Location = new System.Drawing.Point(3, 304);
            this.cmbIdiomaEjemplarAG.Name = "cmbIdiomaEjemplarAG";
            this.cmbIdiomaEjemplarAG.Size = new System.Drawing.Size(194, 36);
            this.cmbIdiomaEjemplarAG.TabIndex = 13;
            // 
            // btnEtiquetasEjemplarAG
            // 
            this.btnEtiquetasEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEtiquetasEjemplarAG.Location = new System.Drawing.Point(3, 476);
            this.btnEtiquetasEjemplarAG.Name = "btnEtiquetasEjemplarAG";
            this.btnEtiquetasEjemplarAG.Size = new System.Drawing.Size(194, 37);
            this.btnEtiquetasEjemplarAG.TabIndex = 15;
            this.btnEtiquetasEjemplarAG.Text = "Seleccionar";
            this.btnEtiquetasEjemplarAG.UseVisualStyleBackColor = true;
            // 
            // txtNombreEjemplarAG
            // 
            this.txtNombreEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreEjemplarAG.Location = new System.Drawing.Point(3, 132);
            this.txtNombreEjemplarAG.Name = "txtNombreEjemplarAG";
            this.txtNombreEjemplarAG.Size = new System.Drawing.Size(194, 34);
            this.txtNombreEjemplarAG.TabIndex = 23;
            // 
            // txtAutorEjemplarAG
            // 
            this.txtAutorEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutorEjemplarAG.Location = new System.Drawing.Point(3, 218);
            this.txtAutorEjemplarAG.Name = "txtAutorEjemplarAG";
            this.txtAutorEjemplarAG.Size = new System.Drawing.Size(194, 34);
            this.txtAutorEjemplarAG.TabIndex = 24;
            // 
            // cmbTipoColeccionEjemplarAG
            // 
            this.cmbTipoColeccionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoColeccionEjemplarAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoColeccionEjemplarAG.FormattingEnabled = true;
            this.cmbTipoColeccionEjemplarAG.Location = new System.Drawing.Point(203, 218);
            this.cmbTipoColeccionEjemplarAG.Name = "cmbTipoColeccionEjemplarAG";
            this.cmbTipoColeccionEjemplarAG.Size = new System.Drawing.Size(194, 36);
            this.cmbTipoColeccionEjemplarAG.TabIndex = 25;
            // 
            // cmbFormatoEjemplarAG
            // 
            this.cmbFormatoEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormatoEjemplarAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormatoEjemplarAG.FormattingEnabled = true;
            this.cmbFormatoEjemplarAG.Location = new System.Drawing.Point(3, 390);
            this.cmbFormatoEjemplarAG.Name = "cmbFormatoEjemplarAG";
            this.cmbFormatoEjemplarAG.Size = new System.Drawing.Size(194, 36);
            this.cmbFormatoEjemplarAG.TabIndex = 26;
            // 
            // dgvEjemplaresAG
            // 
            this.dgvEjemplaresAG.AllowUserToAddRows = false;
            this.dgvEjemplaresAG.AllowUserToDeleteRows = false;
            this.dgvEjemplaresAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplaresAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEjemplaresAG.Location = new System.Drawing.Point(403, 3);
            this.dgvEjemplaresAG.Name = "dgvEjemplaresAG";
            this.dgvEjemplaresAG.ReadOnly = true;
            this.dgvEjemplaresAG.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dgvEjemplaresAG, 13);
            this.dgvEjemplaresAG.Size = new System.Drawing.Size(595, 557);
            this.dgvEjemplaresAG.TabIndex = 29;
            // 
            // dtpFechaPublicacionEjemplarAG
            // 
            this.dtpFechaPublicacionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPublicacionEjemplarAG.Location = new System.Drawing.Point(203, 132);
            this.dtpFechaPublicacionEjemplarAG.Name = "dtpFechaPublicacionEjemplarAG";
            this.dtpFechaPublicacionEjemplarAG.Size = new System.Drawing.Size(194, 34);
            this.dtpFechaPublicacionEjemplarAG.TabIndex = 30;
            // 
            // picAgregarEjemplar
            // 
            this.picAgregarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAgregarEjemplar.Image = global::BINAES.Properties.Resources.SubirImagen;
            this.picAgregarEjemplar.Location = new System.Drawing.Point(203, 304);
            this.picAgregarEjemplar.Name = "picAgregarEjemplar";
            this.tableLayoutPanel1.SetRowSpan(this.picAgregarEjemplar, 5);
            this.picAgregarEjemplar.Size = new System.Drawing.Size(194, 209);
            this.picAgregarEjemplar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAgregarEjemplar.TabIndex = 31;
            this.picAgregarEjemplar.TabStop = false;
            this.picAgregarEjemplar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabReserva
            // 
            this.tabReserva.Controls.Add(this.tableLayoutPanel2);
            this.tabReserva.Location = new System.Drawing.Point(4, 40);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabReserva.Size = new System.Drawing.Size(1001, 563);
            this.tabReserva.TabIndex = 2;
            this.tabReserva.Text = "Reservas de ejemplares";
            this.tabReserva.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.dgvReservasRE, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label23, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarEjemplarRE, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnPrestarRE, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label22, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtboxNewBusquedaEjemplarPR, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtboxNewCompletarRUsuarioPR, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(995, 557);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // dgvReservasRE
            // 
            this.dgvReservasRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservasRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvReservasRE, 6);
            this.dgvReservasRE.Location = new System.Drawing.Point(300, 58);
            this.dgvReservasRE.Name = "dgvReservasRE";
            this.dgvReservasRE.RowHeadersWidth = 51;
            this.tableLayoutPanel2.SetRowSpan(this.dgvReservasRE, 8);
            this.dgvReservasRE.Size = new System.Drawing.Size(588, 434);
            this.dgvReservasRE.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(102, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 21);
            this.label23.TabIndex = 1;
            this.label23.Text = "Ejemplar:";
            // 
            // btnBuscarEjemplarRE
            // 
            this.btnBuscarEjemplarRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.btnBuscarEjemplarRE, 2);
            this.btnBuscarEjemplarRE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEjemplarRE.Location = new System.Drawing.Point(102, 168);
            this.btnBuscarEjemplarRE.Name = "btnBuscarEjemplarRE";
            this.btnBuscarEjemplarRE.Size = new System.Drawing.Size(192, 49);
            this.btnBuscarEjemplarRE.TabIndex = 33;
            this.btnBuscarEjemplarRE.Text = "Búscar";
            this.btnBuscarEjemplarRE.UseVisualStyleBackColor = true;
            this.btnBuscarEjemplarRE.Click += new System.EventHandler(this.btnBuscarEjemplarRE_Click);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label22, 2);
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(102, 291);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(192, 23);
            this.label22.TabIndex = 34;
            this.label22.Text = "ID Usuario:";
            // 
            // btnPrestarRE
            // 
            this.btnPrestarRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.btnPrestarRE, 2);
            this.btnPrestarRE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestarRE.Location = new System.Drawing.Point(102, 388);
            this.btnPrestarRE.Name = "btnPrestarRE";
            this.btnPrestarRE.Size = new System.Drawing.Size(192, 49);
            this.btnPrestarRE.TabIndex = 32;
            this.btnPrestarRE.Text = "Completar";
            this.btnPrestarRE.UseVisualStyleBackColor = true;
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
            this.tabPrestamo.Controls.Add(this.tableLayoutPanel4);
            this.tabPrestamo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabPrestamo.Location = new System.Drawing.Point(4, 40);
            this.tabPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Name = "tabPrestamo";
            this.tabPrestamo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Size = new System.Drawing.Size(1001, 563);
            this.tabPrestamo.TabIndex = 1;
            this.tabPrestamo.Text = "Préstamo de ejemplares";
            this.tabPrestamo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 10;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Controls.Add(this.label18, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox4, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label21, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.textBox3, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 3, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 10;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(995, 555);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(102, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 21);
            this.label18.TabIndex = 1;
            this.label18.Text = "Ejemplar:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.textBox4, 2);
            this.textBox4.Location = new System.Drawing.Point(102, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(192, 34);
            this.textBox4.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel4.SetColumnSpan(this.button1, 2);
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(102, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 39);
            this.button1.TabIndex = 32;
            this.button1.Text = "Completar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.button2, 2);
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(102, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 32);
            this.button2.TabIndex = 33;
            this.button2.Text = "Búscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label21, 2);
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(102, 291);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(192, 23);
            this.label21.TabIndex = 8;
            this.label21.Text = "ID usuario:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.textBox3, 2);
            this.textBox3.Location = new System.Drawing.Point(102, 340);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 34);
            this.textBox3.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel4.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Location = new System.Drawing.Point(300, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel4.SetRowSpan(this.dataGridView1, 8);
            this.dataGridView1.Size = new System.Drawing.Size(588, 434);
            this.dataGridView1.TabIndex = 31;
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.Transparent;
            this.tabBuscar.Controls.Add(this.tableLayoutPanel7);
            this.tabBuscar.Location = new System.Drawing.Point(4, 40);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Size = new System.Drawing.Size(1001, 563);
            this.tabBuscar.TabIndex = 0;
            this.tabBuscar.Text = "Búsqueda de ejemplares";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.Controls.Add(this.txtBuscarEjemplarBU, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.cmbFiltrarEjemplarBU, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnBuscarEjemplarBU, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.dgvEjemplaresBU, 1, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(995, 555);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // txtBuscarEjemplarBU
            // 
            this.txtBuscarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEjemplarBU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEjemplarBU.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarEjemplarBU.Location = new System.Drawing.Point(52, 35);
            this.txtBuscarEjemplarBU.Multiline = true;
            this.txtBuscarEjemplarBU.Name = "txtBuscarEjemplarBU";
            this.txtBuscarEjemplarBU.Size = new System.Drawing.Size(690, 38);
            this.txtBuscarEjemplarBU.TabIndex = 0;
            this.txtBuscarEjemplarBU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarEjemplarBU_KeyDown);
            // 
            // cmbFiltrarEjemplarBU
            // 
            this.cmbFiltrarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarEjemplarBU.BackColor = System.Drawing.Color.White;
            this.cmbFiltrarEjemplarBU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarEjemplarBU.FormattingEnabled = true;
            this.cmbFiltrarEjemplarBU.Location = new System.Drawing.Point(797, 36);
            this.cmbFiltrarEjemplarBU.Name = "cmbFiltrarEjemplarBU";
            this.cmbFiltrarEjemplarBU.Size = new System.Drawing.Size(143, 31);
            this.cmbFiltrarEjemplarBU.TabIndex = 2;
            this.cmbFiltrarEjemplarBU.Text = "Filtro";
            // 
            // btnBuscarEjemplarBU
            // 
            this.btnBuscarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEjemplarBU.FlatAppearance.BorderSize = 0;
            this.btnBuscarEjemplarBU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEjemplarBU.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarEjemplarBU.IconColor = System.Drawing.Color.Black;
            this.btnBuscarEjemplarBU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarEjemplarBU.IconSize = 30;
            this.btnBuscarEjemplarBU.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarEjemplarBU.Location = new System.Drawing.Point(748, 35);
            this.btnBuscarEjemplarBU.Name = "btnBuscarEjemplarBU";
            this.btnBuscarEjemplarBU.Size = new System.Drawing.Size(43, 38);
            this.btnBuscarEjemplarBU.TabIndex = 5;
            this.btnBuscarEjemplarBU.UseVisualStyleBackColor = true;
            this.btnBuscarEjemplarBU.Click += new System.EventHandler(this.btnBusquedaEjemplarBU_Click);
            // 
            // dgvEjemplaresBU
            // 
            this.dgvEjemplaresBU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEjemplaresBU.BackgroundColor = System.Drawing.Color.White;
            this.dgvEjemplaresBU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel7.SetColumnSpan(this.dgvEjemplaresBU, 3);
            this.dgvEjemplaresBU.Location = new System.Drawing.Point(52, 85);
            this.dgvEjemplaresBU.Name = "dgvEjemplaresBU";
            this.dgvEjemplaresBU.RowHeadersWidth = 62;
            this.dgvEjemplaresBU.RowTemplate.Height = 28;
            this.dgvEjemplaresBU.Size = new System.Drawing.Size(888, 438);
            this.dgvEjemplaresBU.TabIndex = 4;
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
            this.tabAdmin.Controls.Add(this.tabPage1);
            this.tabAdmin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.Location = new System.Drawing.Point(253, 40);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1009, 607);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.TabStop = false;
            this.tabAdmin.Tag = "";
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            this.tabAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabAdmin_KeyDown);
            // 
            // tabMisionVision
            // 
            this.tabMisionVision.Controls.Add(this.tableLayoutPanel3);
            this.tabMisionVision.Location = new System.Drawing.Point(4, 40);
            this.tabMisionVision.Name = "tabMisionVision";
            this.tabMisionVision.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisionVision.Size = new System.Drawing.Size(1001, 563);
            this.tabMisionVision.TabIndex = 6;
            this.tabMisionVision.Text = "Mision y Vision";
            this.tabMisionVision.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblMision, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblVision, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblInfoMision, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblInfoVision, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1210, 591);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.lblMision.Size = new System.Drawing.Size(1204, 118);
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
            this.lblVision.Location = new System.Drawing.Point(3, 295);
            this.lblVision.Name = "lblVision";
            this.lblVision.Size = new System.Drawing.Size(1204, 118);
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
            this.lblInfoMision.Location = new System.Drawing.Point(3, 118);
            this.lblInfoMision.Name = "lblInfoMision";
            this.lblInfoMision.Size = new System.Drawing.Size(1204, 177);
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
            this.lblInfoVision.Location = new System.Drawing.Point(3, 413);
            this.lblInfoVision.Name = "lblInfoVision";
            this.lblInfoVision.Size = new System.Drawing.Size(1204, 178);
            this.lblInfoVision.TabIndex = 3;
            this.lblInfoVision.Text = resources.GetString("lblInfoVision.Text");
            this.lblInfoVision.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabIntroduccion
            // 
            this.tabIntroduccion.Controls.Add(this.tableLayoutPanel6);
            this.tabIntroduccion.Location = new System.Drawing.Point(4, 40);
            this.tabIntroduccion.Name = "tabIntroduccion";
            this.tabIntroduccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntroduccion.Size = new System.Drawing.Size(1001, 563);
            this.tabIntroduccion.TabIndex = 8;
            this.tabIntroduccion.Text = "Introduccion";
            this.tabIntroduccion.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label32, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label33, 0, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1210, 591);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.DodgerBlue;
            this.label31.Font = new System.Drawing.Font("Nirmala UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label31.Location = new System.Drawing.Point(3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(1204, 118);
            this.label31.TabIndex = 0;
            this.label31.Text = "Quienes somos?";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label32.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 118);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(1204, 236);
            this.label32.TabIndex = 1;
            this.label32.Text = resources.GetString("label32.Text");
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label33.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(3, 354);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(1204, 237);
            this.label33.TabIndex = 2;
            this.label33.Text = resources.GetString("label33.Text");
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1001, 563);
            this.tabPage1.TabIndex = 9;
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
            // cmbTipoColeccionCO
            // 
            this.cmbTipoColeccionCO.Location = new System.Drawing.Point(0, 0);
            this.cmbTipoColeccionCO.Name = "cmbTipoColeccionCO";
            this.cmbTipoColeccionCO.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoColeccionCO.TabIndex = 0;
            // 
            // cmbGeneroColeccionCO
            // 
            this.cmbGeneroColeccionCO.Location = new System.Drawing.Point(0, 0);
            this.cmbGeneroColeccionCO.Name = "cmbGeneroColeccionCO";
            this.cmbGeneroColeccionCO.Size = new System.Drawing.Size(121, 24);
            this.cmbGeneroColeccionCO.TabIndex = 0;
            // 
            // btnAgregarCO
            // 
            this.btnAgregarCO.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarCO.Name = "btnAgregarCO";
            this.btnAgregarCO.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCO.TabIndex = 0;
            // 
            // btnDejardeEditarCO
            // 
            this.btnDejardeEditarCO.Location = new System.Drawing.Point(0, 0);
            this.btnDejardeEditarCO.Name = "btnDejardeEditarCO";
            this.btnDejardeEditarCO.Size = new System.Drawing.Size(75, 23);
            this.btnDejardeEditarCO.TabIndex = 0;
            // 
            // sspStatus
            // 
            this.sspStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sspStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sspStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sspStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sspNombre,
            this.sspRol});
            this.sspStatus.Location = new System.Drawing.Point(0, 647);
            this.sspStatus.Name = "sspStatus";
            this.sspStatus.Size = new System.Drawing.Size(1262, 26);
            this.sspStatus.TabIndex = 2;
            // 
            // sspNombre
            // 
            this.sspNombre.Name = "sspNombre";
            this.sspNombre.Size = new System.Drawing.Size(76, 20);
            this.sspNombre.Text = "Nombre: ";
            // 
            // sspRol
            // 
            this.sspRol.Name = "sspRol";
            this.sspRol.Size = new System.Drawing.Size(39, 20);
            this.sspRol.Text = "Rol: ";
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenuPrincipal.Controls.Add(this.btnIntroPrincipal);
            this.panelMenuPrincipal.Controls.Add(this.btnMisionVisionPrincipal);
            this.panelMenuPrincipal.Controls.Add(this.btnReservarPrinpal);
            this.panelMenuPrincipal.Controls.Add(this.panel1);
            this.panelMenuPrincipal.Controls.Add(this.btnAddUsuarioPrincipal);
            this.panelMenuPrincipal.Controls.Add(this.btnAdminEventosPrincipal);
            this.panelMenuPrincipal.Controls.Add(this.btnAñadirEjemplarPrincipal);
            this.panelMenuPrincipal.Controls.Add(this.btnPrestamosPrincipal);
            this.panelMenuPrincipal.Controls.Add(this.iconButton1);
            this.panelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(253, 647);
            this.panelMenuPrincipal.TabIndex = 3;
            // 
            // btnIntroPrincipal
            // 
            this.btnIntroPrincipal.FlatAppearance.BorderSize = 0;
            this.btnIntroPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroPrincipal.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIntroPrincipal.IconChar = FontAwesome.Sharp.IconChar.Magic;
            this.btnIntroPrincipal.IconColor = System.Drawing.Color.White;
            this.btnIntroPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIntroPrincipal.IconSize = 32;
            this.btnIntroPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntroPrincipal.Location = new System.Drawing.Point(3, 602);
            this.btnIntroPrincipal.Name = "btnIntroPrincipal";
            this.btnIntroPrincipal.Size = new System.Drawing.Size(250, 45);
            this.btnIntroPrincipal.TabIndex = 8;
            this.btnIntroPrincipal.Text = "Introduccion";
            this.btnIntroPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntroPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIntroPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnMisionVisionPrincipal
            // 
            this.btnMisionVisionPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMisionVisionPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisionVisionPrincipal.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisionVisionPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMisionVisionPrincipal.IconChar = FontAwesome.Sharp.IconChar.Microblog;
            this.btnMisionVisionPrincipal.IconColor = System.Drawing.Color.White;
            this.btnMisionVisionPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMisionVisionPrincipal.IconSize = 32;
            this.btnMisionVisionPrincipal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMisionVisionPrincipal.Location = new System.Drawing.Point(0, 542);
            this.btnMisionVisionPrincipal.Name = "btnMisionVisionPrincipal";
            this.btnMisionVisionPrincipal.Size = new System.Drawing.Size(253, 54);
            this.btnMisionVisionPrincipal.TabIndex = 7;
            this.btnMisionVisionPrincipal.Text = "Mision y Vision";
            this.btnMisionVisionPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisionVisionPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMisionVisionPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnReservarPrinpal
            // 
            this.btnReservarPrinpal.FlatAppearance.BorderSize = 0;
            this.btnReservarPrinpal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservarPrinpal.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarPrinpal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReservarPrinpal.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.btnReservarPrinpal.IconColor = System.Drawing.Color.White;
            this.btnReservarPrinpal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservarPrinpal.IconSize = 32;
            this.btnReservarPrinpal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservarPrinpal.Location = new System.Drawing.Point(3, 493);
            this.btnReservarPrinpal.Name = "btnReservarPrinpal";
            this.btnReservarPrinpal.Size = new System.Drawing.Size(250, 55);
            this.btnReservarPrinpal.TabIndex = 6;
            this.btnReservarPrinpal.Text = "Reservas";
            this.btnReservarPrinpal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservarPrinpal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservarPrinpal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 140);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BINAES.Properties.Resources.LOGOBINAES_nobackground;
            this.pictureBox1.Location = new System.Drawing.Point(45, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUsuarioPrincipal
            // 
            this.btnAddUsuarioPrincipal.FlatAppearance.BorderSize = 0;
            this.btnAddUsuarioPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsuarioPrincipal.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsuarioPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddUsuarioPrincipal.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnAddUsuarioPrincipal.IconColor = System.Drawing.Color.White;
            this.btnAddUsuarioPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddUsuarioPrincipal.IconSize = 32;
            this.btnAddUsuarioPrincipal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddUsuarioPrincipal.Location = new System.Drawing.Point(-1, 433);
            this.btnAddUsuarioPrincipal.Name = "btnAddUsuarioPrincipal";
            this.btnAddUsuarioPrincipal.Size = new System.Drawing.Size(254, 54);
            this.btnAddUsuarioPrincipal.TabIndex = 5;
            this.btnAddUsuarioPrincipal.Text = "Añadir Usuario";
            this.btnAddUsuarioPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUsuarioPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUsuarioPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnAdminEventosPrincipal
            // 
            this.btnAdminEventosPrincipal.FlatAppearance.BorderSize = 0;
            this.btnAdminEventosPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEventosPrincipal.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEventosPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdminEventosPrincipal.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnAdminEventosPrincipal.IconColor = System.Drawing.Color.White;
            this.btnAdminEventosPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdminEventosPrincipal.IconSize = 32;
            this.btnAdminEventosPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminEventosPrincipal.Location = new System.Drawing.Point(3, 346);
            this.btnAdminEventosPrincipal.Name = "btnAdminEventosPrincipal";
            this.btnAdminEventosPrincipal.Size = new System.Drawing.Size(247, 90);
            this.btnAdminEventosPrincipal.TabIndex = 4;
            this.btnAdminEventosPrincipal.Text = "Administrar Eventos";
            this.btnAdminEventosPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminEventosPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnAñadirEjemplarPrincipal
            // 
            this.btnAñadirEjemplarPrincipal.FlatAppearance.BorderSize = 0;
            this.btnAñadirEjemplarPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirEjemplarPrincipal.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEjemplarPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAñadirEjemplarPrincipal.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnAñadirEjemplarPrincipal.IconColor = System.Drawing.Color.White;
            this.btnAñadirEjemplarPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadirEjemplarPrincipal.IconSize = 32;
            this.btnAñadirEjemplarPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirEjemplarPrincipal.Location = new System.Drawing.Point(3, 259);
            this.btnAñadirEjemplarPrincipal.Name = "btnAñadirEjemplarPrincipal";
            this.btnAñadirEjemplarPrincipal.Size = new System.Drawing.Size(250, 81);
            this.btnAñadirEjemplarPrincipal.TabIndex = 3;
            this.btnAñadirEjemplarPrincipal.Text = "Añadir Ejemplar";
            this.btnAñadirEjemplarPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadirEjemplarPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnPrestamosPrincipal
            // 
            this.btnPrestamosPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrestamosPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrestamosPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamosPrincipal.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamosPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrestamosPrincipal.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
            this.btnPrestamosPrincipal.IconColor = System.Drawing.Color.White;
            this.btnPrestamosPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrestamosPrincipal.IconSize = 32;
            this.btnPrestamosPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrestamosPrincipal.Location = new System.Drawing.Point(6, 206);
            this.btnPrestamosPrincipal.Name = "btnPrestamosPrincipal";
            this.btnPrestamosPrincipal.Size = new System.Drawing.Size(244, 56);
            this.btnPrestamosPrincipal.TabIndex = 2;
            this.btnPrestamosPrincipal.Text = "Prestamo";
            this.btnPrestamosPrincipal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrestamosPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrestamosPrincipal.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 146);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(247, 54);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Busqueda";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelBarraTituloPrincpal
            // 
            this.panelBarraTituloPrincpal.Controls.Add(this.btnMinimizarPrincipal);
            this.panelBarraTituloPrincpal.Controls.Add(this.btnRestoreWinPrincipal);
            this.panelBarraTituloPrincpal.Controls.Add(this.btnCerrarPrincipal);
            this.panelBarraTituloPrincpal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTituloPrincpal.Location = new System.Drawing.Point(253, 0);
            this.panelBarraTituloPrincpal.Name = "panelBarraTituloPrincpal";
            this.panelBarraTituloPrincpal.Size = new System.Drawing.Size(1009, 37);
            this.panelBarraTituloPrincpal.TabIndex = 4;
            this.panelBarraTituloPrincpal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTituloPrincpal_MouseDown);
            // 
            // btnMinimizarPrincipal
            // 
            this.btnMinimizarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMinimizarPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarPrincipal.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizarPrincipal.IconColor = System.Drawing.Color.White;
            this.btnMinimizarPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarPrincipal.IconSize = 30;
            this.btnMinimizarPrincipal.Location = new System.Drawing.Point(839, 3);
            this.btnMinimizarPrincipal.Name = "btnMinimizarPrincipal";
            this.btnMinimizarPrincipal.Size = new System.Drawing.Size(53, 34);
            this.btnMinimizarPrincipal.TabIndex = 3;
            this.btnMinimizarPrincipal.UseVisualStyleBackColor = false;
            this.btnMinimizarPrincipal.Click += new System.EventHandler(this.btnMinimizarPrincipal_Click);
            // 
            // btnRestoreWinPrincipal
            // 
            this.btnRestoreWinPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreWinPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreWinPrincipal.FlatAppearance.BorderSize = 0;
            this.btnRestoreWinPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreWinPrincipal.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestoreWinPrincipal.IconColor = System.Drawing.Color.White;
            this.btnRestoreWinPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestoreWinPrincipal.IconSize = 30;
            this.btnRestoreWinPrincipal.Location = new System.Drawing.Point(898, 4);
            this.btnRestoreWinPrincipal.Name = "btnRestoreWinPrincipal";
            this.btnRestoreWinPrincipal.Size = new System.Drawing.Size(53, 34);
            this.btnRestoreWinPrincipal.TabIndex = 2;
            this.btnRestoreWinPrincipal.UseVisualStyleBackColor = false;
            this.btnRestoreWinPrincipal.Click += new System.EventHandler(this.btnRestoreWinPrincipal_Click);
            // 
            // btnCerrarPrincipal
            // 
            this.btnCerrarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarPrincipal.FlatAppearance.BorderSize = 0;
            this.btnCerrarPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPrincipal.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrarPrincipal.IconColor = System.Drawing.Color.White;
            this.btnCerrarPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPrincipal.IconSize = 30;
            this.btnCerrarPrincipal.Location = new System.Drawing.Point(956, 3);
            this.btnCerrarPrincipal.Name = "btnCerrarPrincipal";
            this.btnCerrarPrincipal.Size = new System.Drawing.Size(53, 34);
            this.btnCerrarPrincipal.TabIndex = 0;
            this.btnCerrarPrincipal.UseVisualStyleBackColor = false;
            this.btnCerrarPrincipal.Click += new System.EventHandler(this.btnCerrarPrincipal_Click);
            // 
            // txtboxNewBusquedaEjemplarPR
            // 
            this.txtboxNewBusquedaEjemplarPR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtboxNewBusquedaEjemplarPR, 2);
            this.txtboxNewBusquedaEjemplarPR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewBusquedaEjemplarPR.Location = new System.Drawing.Point(102, 121);
            this.txtboxNewBusquedaEjemplarPR.Name = "txtboxNewBusquedaEjemplarPR";
            this.txtboxNewBusquedaEjemplarPR.Size = new System.Drawing.Size(192, 32);
            this.txtboxNewBusquedaEjemplarPR.TabIndex = 35;
            // 
            // txtboxNewCompletarRUsuarioPR
            // 
            this.txtboxNewCompletarRUsuarioPR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtboxNewCompletarRUsuarioPR, 2);
            this.txtboxNewCompletarRUsuarioPR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewCompletarRUsuarioPR.Location = new System.Drawing.Point(102, 341);
            this.txtboxNewCompletarRUsuarioPR.Name = "txtboxNewCompletarRUsuarioPR";
            this.txtboxNewCompletarRUsuarioPR.Size = new System.Drawing.Size(192, 32);
            this.txtboxNewCompletarRUsuarioPR.TabIndex = 36;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelBarraTituloPrincpal);
            this.Controls.Add(this.panelMenuPrincipal);
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
            this.tabUsuarios.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUS)).EndInit();
            this.tabEventos.ResumeLayout(false);
            this.tlpAdminEventosEV.ResumeLayout(false);
            this.tlpAdminEventosEV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroAsistentesEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventos)).EndInit();
            this.tabAgregar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresAG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarEjemplar)).EndInit();
            this.tabReserva.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdUsuarioRE)).EndInit();
            this.tabPrestamo.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresBU)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.tabMisionVision.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabIntroduccion.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaColeccionCO)).EndInit();
            this.sspStatus.ResumeLayout(false);
            this.sspStatus.PerformLayout();
            this.panelMenuPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraTituloPrincpal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TabPage tabEventos;
        private System.Windows.Forms.TableLayoutPanel tlpAdminEventosEV;
        private System.Windows.Forms.Button btnAgregarEV;
        private System.Windows.Forms.DataGridView dgvEventosEV;
        private System.Windows.Forms.NumericUpDown nudNumeroAsistentesEV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbTipoSalonEV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox rtbObjetivoEventoEV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalizacionEV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioEV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTituloEventoEV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDejarDeEditarEV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalirEdicionEjemplarAG;
        private System.Windows.Forms.Button btnAgregarEjemplarAG;
        private System.Windows.Forms.TextBox txtEditorialEjemplarAG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblMision;
        private System.Windows.Forms.Label lblVision;
        private System.Windows.Forms.Label lblInfoMision;
        private System.Windows.Forms.Label lblInfoVision;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvReservasRE;
        private System.Windows.Forms.Button btnPrestarRE;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabIntroduccion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ComboBox cmbFiltrarEjemplarBU;
        private System.Windows.Forms.TextBox txtBuscarEjemplarBU;
        private System.Windows.Forms.DataGridView dgvEjemplaresBU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtNombreUS;
        private System.Windows.Forms.Button btnTomarFotoUS;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtEmailUS;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtDireccionUS;
        private System.Windows.Forms.TextBox txtContraseñaUS;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtInstitucionUS;
        private System.Windows.Forms.TextBox txtTelefonoUS;
        private System.Windows.Forms.Button btnAgregarUS;
        private System.Windows.Forms.ComboBox cmbOcupacionUS;
        private System.Windows.Forms.ComboBox cmbRolUS;
        private System.Windows.Forms.PictureBox picFotoUS;
        private System.Windows.Forms.PictureBox picEventos;
        private System.Windows.Forms.PictureBox picAgregarEjemplar;
        private System.Windows.Forms.Button btnBuscarEjemplarRE;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCancelarFotoUS;
        private System.Windows.Forms.StatusStrip sspStatus;
        private System.Windows.Forms.ToolStripStatusLabel sspNombre;
        private System.Windows.Forms.ToolStripStatusLabel sspRol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
        private Button button1;
        private TextBox textBox3;
        private Label label21;
        private Button button2;
        private TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tlpColeccionCO;
        private Label label19;
        private Label label20;
        private Label label29;
        private DataGridView dgvVistaColeccionCO;
        private TextBox txtNombreCO;
        private ComboBox cmbTipoColeccionCO;
        private ComboBox cmbGeneroColeccionCO;
        private Button btnAgregarCO;
        private Button btnDejardeEditarCO;
        private NumericUpDown nudIdUsuarioRE;
        private Panel panelMenuPrincipal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnReservarPrinpal;
        private FontAwesome.Sharp.IconButton btnAddUsuarioPrincipal;
        private FontAwesome.Sharp.IconButton btnAdminEventosPrincipal;
        private FontAwesome.Sharp.IconButton btnAñadirEjemplarPrincipal;
        private FontAwesome.Sharp.IconButton btnPrestamosPrincipal;
        private FontAwesome.Sharp.IconButton btnIntroPrincipal;
        private FontAwesome.Sharp.IconButton btnMisionVisionPrincipal;
        private Panel panel1;
        private Panel panelBarraTituloPrincpal;
        private FontAwesome.Sharp.IconButton btnCerrarPrincipal;
        private FontAwesome.Sharp.IconButton btnMinimizarPrincipal;
        private FontAwesome.Sharp.IconButton btnRestoreWinPrincipal;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnBuscarEjemplarBU;
        private Label label22;
        private TextBox txtboxNewBusquedaEjemplarPR;
        private TextBox txtboxNewCompletarRUsuarioPR;
    }
}