﻿using System.ComponentModel;
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
            this.label12 = new System.Windows.Forms.Label();
            this.btnDejarDeEditarEV = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.picEventos = new System.Windows.Forms.PictureBox();
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
            this.btnPrestarRE = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btnQrRE = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nudIdUsuarioRE = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPrestamo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEjemplaresBU = new System.Windows.Forms.DataGridView();
            this.txtBuscarEjemplarBU = new System.Windows.Forms.TextBox();
            this.btnBuscarEjemplarBU = new System.Windows.Forms.Button();
            this.chkBusquedaExactaBU = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbFiltrarEjemplarBU = new System.Windows.Forms.ComboBox();
            this.chkFísicoBU = new System.Windows.Forms.CheckBox();
            this.chkDigitalBU = new System.Windows.Forms.CheckBox();
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
            this.mspMenu.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.SuspendLayout();
            // 
            // mspMenu
            // 
            this.mspMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mspMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.búsquedaToolStripMenuItem,
            this.administradorDeEventosToolStripMenuItem,
            this.administradorDeUsuariosToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mspMenu.Size = new System.Drawing.Size(1258, 33);
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
            this.búsquedaToolStripMenuItem.Size = new System.Drawing.Size(257, 29);
            this.búsquedaToolStripMenuItem.Tag = "";
            this.búsquedaToolStripMenuItem.Text = "Administrador de ejemplares";
            this.búsquedaToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.búsquedaToolStripMenuItem_DropDownItemClicked);
            this.búsquedaToolStripMenuItem.MouseHover += new System.EventHandler(this.búsquedaToolStripMenuItem_MouseHover);
            // 
            // búscarToolStripMenuItem
            // 
            this.búscarToolStripMenuItem.Name = "búscarToolStripMenuItem";
            this.búscarToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.búscarToolStripMenuItem.Tag = "0";
            this.búscarToolStripMenuItem.Text = "Buscar [Ctrl + F]";
            // 
            // prestarToolStripMenuItem
            // 
            this.prestarToolStripMenuItem.Name = "prestarToolStripMenuItem";
            this.prestarToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.prestarToolStripMenuItem.Tag = "1";
            this.prestarToolStripMenuItem.Text = "Préstamos";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.devolucionesToolStripMenuItem.Tag = "2";
            this.devolucionesToolStripMenuItem.Text = "Reservas";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.añadirToolStripMenuItem.Tag = "3";
            this.añadirToolStripMenuItem.Text = "Agregar [Ctrl + N]";
            // 
            // administradorDeEventosToolStripMenuItem
            // 
            this.administradorDeEventosToolStripMenuItem.Name = "administradorDeEventosToolStripMenuItem";
            this.administradorDeEventosToolStripMenuItem.Size = new System.Drawing.Size(234, 29);
            this.administradorDeEventosToolStripMenuItem.Tag = "4";
            this.administradorDeEventosToolStripMenuItem.Text = "Administrador de eventos";
            // 
            // administradorDeUsuariosToolStripMenuItem
            // 
            this.administradorDeUsuariosToolStripMenuItem.Name = "administradorDeUsuariosToolStripMenuItem";
            this.administradorDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(238, 29);
            this.administradorDeUsuariosToolStripMenuItem.Tag = "5";
            this.administradorDeUsuariosToolStripMenuItem.Text = "Administrador de usuarios";
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tableLayoutPanel5);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 44);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(1250, 589);
            this.tabUsuarios.TabIndex = 5;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1256, 606);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(796, 150);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(328, 50);
            this.label36.TabIndex = 11;
            this.label36.Text = "Rol:";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(462, 150);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(328, 50);
            this.label35.TabIndex = 10;
            this.label35.Text = "Ocupación:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreUS
            // 
            this.txtNombreUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUS.Location = new System.Drawing.Point(462, 103);
            this.txtNombreUS.Name = "txtNombreUS";
            this.txtNombreUS.Size = new System.Drawing.Size(328, 39);
            this.txtNombreUS.TabIndex = 8;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(462, 50);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(328, 50);
            this.label34.TabIndex = 6;
            this.label34.Text = "Nombre:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmailUS
            // 
            this.txtEmailUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailUS.Location = new System.Drawing.Point(796, 103);
            this.txtEmailUS.Name = "txtEmailUS";
            this.txtEmailUS.Size = new System.Drawing.Size(328, 39);
            this.txtEmailUS.TabIndex = 9;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(796, 50);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(328, 50);
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
            this.label37.Location = new System.Drawing.Point(462, 250);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(328, 50);
            this.label37.TabIndex = 14;
            this.label37.Text = "Dirección:";
            // 
            // txtDireccionUS
            // 
            this.txtDireccionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionUS.Location = new System.Drawing.Point(462, 303);
            this.txtDireccionUS.Name = "txtDireccionUS";
            this.txtDireccionUS.Size = new System.Drawing.Size(328, 39);
            this.txtDireccionUS.TabIndex = 16;
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(796, 250);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(328, 50);
            this.label38.TabIndex = 15;
            this.label38.Text = "Contraseña:";
            // 
            // txtContraseñaUS
            // 
            this.txtContraseñaUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaUS.Location = new System.Drawing.Point(796, 303);
            this.txtContraseñaUS.Name = "txtContraseñaUS";
            this.txtContraseñaUS.Size = new System.Drawing.Size(328, 39);
            this.txtContraseñaUS.TabIndex = 17;
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(462, 350);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(328, 50);
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
            this.label39.Location = new System.Drawing.Point(796, 350);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(328, 50);
            this.label39.TabIndex = 19;
            this.label39.Text = "Teléfono:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefonoUS
            // 
            this.txtTelefonoUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoUS.Location = new System.Drawing.Point(796, 403);
            this.txtTelefonoUS.Name = "txtTelefonoUS";
            this.txtTelefonoUS.Size = new System.Drawing.Size(328, 39);
            this.txtTelefonoUS.TabIndex = 21;
            // 
            // btnAgregarUS
            // 
            this.btnAgregarUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.btnAgregarUS, 2);
            this.btnAgregarUS.Location = new System.Drawing.Point(462, 503);
            this.btnAgregarUS.Name = "btnAgregarUS";
            this.btnAgregarUS.Size = new System.Drawing.Size(662, 44);
            this.btnAgregarUS.TabIndex = 22;
            this.btnAgregarUS.Text = "Agregar";
            this.btnAgregarUS.UseVisualStyleBackColor = true;
            // 
            // txtInstitucionUS
            // 
            this.txtInstitucionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstitucionUS.Location = new System.Drawing.Point(462, 403);
            this.txtInstitucionUS.Name = "txtInstitucionUS";
            this.txtInstitucionUS.Size = new System.Drawing.Size(328, 39);
            this.txtInstitucionUS.TabIndex = 20;
            // 
            // cmbOcupacionUS
            // 
            this.cmbOcupacionUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOcupacionUS.FormattingEnabled = true;
            this.cmbOcupacionUS.Location = new System.Drawing.Point(462, 203);
            this.cmbOcupacionUS.Name = "cmbOcupacionUS";
            this.cmbOcupacionUS.Size = new System.Drawing.Size(328, 40);
            this.cmbOcupacionUS.TabIndex = 23;
            // 
            // cmbRolUS
            // 
            this.cmbRolUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRolUS.FormattingEnabled = true;
            this.cmbRolUS.Location = new System.Drawing.Point(796, 203);
            this.cmbRolUS.Name = "cmbRolUS";
            this.cmbRolUS.Size = new System.Drawing.Size(328, 40);
            this.cmbRolUS.TabIndex = 24;
            // 
            // picFotoUS
            // 
            this.picFotoUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.picFotoUS, 2);
            this.picFotoUS.Image = global::BINAES.Properties.Resources.SubirImagen;
            this.picFotoUS.Location = new System.Drawing.Point(128, 103);
            this.picFotoUS.Name = "picFotoUS";
            this.tableLayoutPanel5.SetRowSpan(this.picFotoUS, 6);
            this.picFotoUS.Size = new System.Drawing.Size(328, 294);
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
            this.btnTomarFotoUS.Location = new System.Drawing.Point(128, 503);
            this.btnTomarFotoUS.Name = "btnTomarFotoUS";
            this.btnTomarFotoUS.Size = new System.Drawing.Size(161, 44);
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
            this.btnCancelarFotoUS.Location = new System.Drawing.Point(295, 503);
            this.btnCancelarFotoUS.Name = "btnCancelarFotoUS";
            this.btnCancelarFotoUS.Size = new System.Drawing.Size(161, 44);
            this.btnCancelarFotoUS.TabIndex = 26;
            this.btnCancelarFotoUS.Text = "Cancelar foto";
            this.btnCancelarFotoUS.UseVisualStyleBackColor = true;
            this.btnCancelarFotoUS.Click += new System.EventHandler(this.btnCancelarFotoUS_Click);
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.tlpAdminEventosEV);
            this.tabEventos.Location = new System.Drawing.Point(4, 44);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(1250, 589);
            this.tabEventos.TabIndex = 4;
            this.tabEventos.Text = "Eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // tlpAdminEventosEV
            // 
            this.tlpAdminEventosEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tlpAdminEventosEV.Controls.Add(this.label12, 0, 0);
            this.tlpAdminEventosEV.Controls.Add(this.btnDejarDeEditarEV, 0, 12);
            this.tlpAdminEventosEV.Controls.Add(this.label11, 1, 0);
            this.tlpAdminEventosEV.Controls.Add(this.picEventos, 1, 1);
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
            this.tlpAdminEventosEV.Size = new System.Drawing.Size(1250, 601);
            this.tlpAdminEventosEV.TabIndex = 0;
            // 
            // btnAgregarEV
            // 
            this.btnAgregarEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEV.Location = new System.Drawing.Point(340, 555);
            this.btnAgregarEV.Name = "btnAgregarEV";
            this.btnAgregarEV.Size = new System.Drawing.Size(366, 43);
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
            this.dgvEventosEV.Location = new System.Drawing.Point(712, 3);
            this.dgvEventosEV.Name = "dgvEventosEV";
            this.dgvEventosEV.RowHeadersWidth = 51;
            this.tlpAdminEventosEV.SetRowSpan(this.dgvEventosEV, 13);
            this.dgvEventosEV.Size = new System.Drawing.Size(535, 595);
            this.dgvEventosEV.TabIndex = 26;
            this.dgvEventosEV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventosEV_CellContentClick);
            // 
            // nudNumeroAsistentesEV
            // 
            this.nudNumeroAsistentesEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumeroAsistentesEV.Location = new System.Drawing.Point(3, 509);
            this.nudNumeroAsistentesEV.Name = "nudNumeroAsistentesEV";
            this.nudNumeroAsistentesEV.Size = new System.Drawing.Size(331, 39);
            this.nudNumeroAsistentesEV.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 460);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(331, 46);
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
            this.cmbTipoSalonEV.Location = new System.Drawing.Point(3, 417);
            this.cmbTipoSalonEV.Name = "cmbTipoSalonEV";
            this.cmbTipoSalonEV.Size = new System.Drawing.Size(331, 40);
            this.cmbTipoSalonEV.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(331, 46);
            this.label15.TabIndex = 20;
            this.label15.Text = "Tipo de salón: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbObjetivoEventoEV
            // 
            this.rtbObjetivoEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbObjetivoEventoEV.Location = new System.Drawing.Point(3, 325);
            this.rtbObjetivoEventoEV.Name = "rtbObjetivoEventoEV";
            this.rtbObjetivoEventoEV.Size = new System.Drawing.Size(331, 40);
            this.rtbObjetivoEventoEV.TabIndex = 23;
            this.rtbObjetivoEventoEV.Text = "";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(331, 46);
            this.label16.TabIndex = 13;
            this.label16.Text = "Objetivos del evento:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaFinalizacionEV
            // 
            this.dtpFechaFinalizacionEV.Location = new System.Drawing.Point(3, 233);
            this.dtpFechaFinalizacionEV.Name = "dtpFechaFinalizacionEV";
            this.dtpFechaFinalizacionEV.Size = new System.Drawing.Size(310, 39);
            this.dtpFechaFinalizacionEV.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(331, 46);
            this.label14.TabIndex = 18;
            this.label14.Text = "Fecha de finalización:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaInicioEV
            // 
            this.dtpFechaInicioEV.Location = new System.Drawing.Point(3, 141);
            this.dtpFechaInicioEV.Name = "dtpFechaInicioEV";
            this.dtpFechaInicioEV.Size = new System.Drawing.Size(310, 39);
            this.dtpFechaInicioEV.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(331, 46);
            this.label13.TabIndex = 5;
            this.label13.Text = "Fecha de inicio:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTituloEventoEV
            // 
            this.txtTituloEventoEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTituloEventoEV.Location = new System.Drawing.Point(3, 49);
            this.txtTituloEventoEV.Name = "txtTituloEventoEV";
            this.txtTituloEventoEV.Size = new System.Drawing.Size(331, 39);
            this.txtTituloEventoEV.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(331, 46);
            this.label12.TabIndex = 3;
            this.label12.Text = "Titulo del evento:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDejarDeEditarEV
            // 
            this.btnDejarDeEditarEV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDejarDeEditarEV.Location = new System.Drawing.Point(3, 555);
            this.btnDejarDeEditarEV.Name = "btnDejarDeEditarEV";
            this.btnDejarDeEditarEV.Size = new System.Drawing.Size(331, 43);
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
            this.label11.Location = new System.Drawing.Point(340, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(366, 46);
            this.label11.TabIndex = 27;
            this.label11.Text = "Imagen";
            // 
            // picEventos
            // 
            this.picEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEventos.Image = global::BINAES.Properties.Resources.SubirImagen;
            this.picEventos.Location = new System.Drawing.Point(340, 49);
            this.picEventos.Name = "picEventos";
            this.tlpAdminEventosEV.SetRowSpan(this.picEventos, 11);
            this.picEventos.Size = new System.Drawing.Size(366, 500);
            this.picEventos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEventos.TabIndex = 28;
            this.picEventos.TabStop = false;
            this.picEventos.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.tableLayoutPanel1);
            this.tabAgregar.Location = new System.Drawing.Point(4, 44);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Size = new System.Drawing.Size(1250, 589);
            this.tabAgregar.TabIndex = 3;
            this.tabAgregar.Text = "Agregar ejemplar";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1250, 600);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnSalirEdicionEjemplarAG
            // 
            this.btnSalirEdicionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirEdicionEjemplarAG.Enabled = false;
            this.btnSalirEdicionEjemplarAG.Location = new System.Drawing.Point(3, 555);
            this.btnSalirEdicionEjemplarAG.Name = "btnSalirEdicionEjemplarAG";
            this.btnSalirEdicionEjemplarAG.Size = new System.Drawing.Size(244, 42);
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
            this.btnAgregarEjemplarAG.Size = new System.Drawing.Size(244, 42);
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
            this.txtEditorialEjemplarAG.Size = new System.Drawing.Size(244, 39);
            this.txtEditorialEjemplarAG.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Imagen";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de publicación";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idioma";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Editorial";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Etiquetas";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Formato";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo de colección";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código ejemplar";
            // 
            // txtCodigoEjemplarAG
            // 
            this.txtCodigoEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoEjemplarAG.Location = new System.Drawing.Point(3, 49);
            this.txtCodigoEjemplarAG.Name = "txtCodigoEjemplarAG";
            this.txtCodigoEjemplarAG.Size = new System.Drawing.Size(244, 39);
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
            this.cmbIdiomaEjemplarAG.Size = new System.Drawing.Size(244, 40);
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
            this.txtNombreEjemplarAG.Size = new System.Drawing.Size(244, 39);
            this.txtNombreEjemplarAG.TabIndex = 23;
            // 
            // txtAutorEjemplarAG
            // 
            this.txtAutorEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutorEjemplarAG.Location = new System.Drawing.Point(3, 233);
            this.txtAutorEjemplarAG.Name = "txtAutorEjemplarAG";
            this.txtAutorEjemplarAG.Size = new System.Drawing.Size(244, 39);
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
            this.cmbTipoColeccionEjemplarAG.Size = new System.Drawing.Size(244, 40);
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
            this.cmbFormatoEjemplarAG.Size = new System.Drawing.Size(244, 40);
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
            this.tableLayoutPanel1.SetRowSpan(this.dgvEjemplaresAG, 13);
            this.dgvEjemplaresAG.Size = new System.Drawing.Size(744, 594);
            this.dgvEjemplaresAG.TabIndex = 29;
            // 
            // dtpFechaPublicacionEjemplarAG
            // 
            this.dtpFechaPublicacionEjemplarAG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPublicacionEjemplarAG.Location = new System.Drawing.Point(253, 141);
            this.dtpFechaPublicacionEjemplarAG.Name = "dtpFechaPublicacionEjemplarAG";
            this.dtpFechaPublicacionEjemplarAG.Size = new System.Drawing.Size(244, 39);
            this.dtpFechaPublicacionEjemplarAG.TabIndex = 30;
            // 
            // picAgregarEjemplar
            // 
            this.picAgregarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAgregarEjemplar.Image = global::BINAES.Properties.Resources.SubirImagen;
            this.picAgregarEjemplar.Location = new System.Drawing.Point(253, 325);
            this.picAgregarEjemplar.Name = "picAgregarEjemplar";
            this.tableLayoutPanel1.SetRowSpan(this.picAgregarEjemplar, 5);
            this.picAgregarEjemplar.Size = new System.Drawing.Size(244, 224);
            this.picAgregarEjemplar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAgregarEjemplar.TabIndex = 31;
            this.picAgregarEjemplar.TabStop = false;
            this.picAgregarEjemplar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabReserva
            // 
            this.tabReserva.Controls.Add(this.tableLayoutPanel2);
            this.tabReserva.Location = new System.Drawing.Point(4, 44);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabReserva.Size = new System.Drawing.Size(1250, 589);
            this.tabReserva.TabIndex = 2;
            this.tabReserva.Text = "Reservas de ejemplares";
            this.tabReserva.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.dgvReservasRE, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label23, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarEjemplarRE, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnPrestarRE, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label22, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnQrRE, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown1, 1, 4);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.002F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33267F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.002F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1247, 557);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // dgvReservasRE
            // 
            this.dgvReservasRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservasRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasRE.Location = new System.Drawing.Point(437, 58);
            this.dgvReservasRE.Name = "dgvReservasRE";
            this.dgvReservasRE.RowHeadersWidth = 51;
            this.tableLayoutPanel2.SetRowSpan(this.dgvReservasRE, 6);
            this.dgvReservasRE.Size = new System.Drawing.Size(679, 438);
            this.dgvReservasRE.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label23, 2);
            this.label23.Location = new System.Drawing.Point(127, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(242, 32);
            this.label23.TabIndex = 1;
            this.label23.Text = "Ejemplar:";
            // 
            // btnBuscarEjemplarRE
            // 
            this.btnBuscarEjemplarRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.btnBuscarEjemplarRE, 2);
            this.btnBuscarEjemplarRE.Location = new System.Drawing.Point(127, 132);
            this.btnBuscarEjemplarRE.Name = "btnBuscarEjemplarRE";
            this.btnBuscarEjemplarRE.Size = new System.Drawing.Size(242, 68);
            this.btnBuscarEjemplarRE.TabIndex = 33;
            this.btnBuscarEjemplarRE.Text = "Buscar";
            this.btnBuscarEjemplarRE.UseVisualStyleBackColor = true;
            this.btnBuscarEjemplarRE.Click += new System.EventHandler(this.btnBuscarEjemplarRE_Click);
            // 
            // btnPrestarRE
            // 
            this.btnPrestarRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.btnPrestarRE, 2);
            this.btnPrestarRE.Location = new System.Drawing.Point(127, 428);
            this.btnPrestarRE.Name = "btnPrestarRE";
            this.btnPrestarRE.Size = new System.Drawing.Size(242, 68);
            this.btnPrestarRE.TabIndex = 32;
            this.btnPrestarRE.Text = "Completar";
            this.btnPrestarRE.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label22, 2);
            this.label22.Location = new System.Drawing.Point(127, 245);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(242, 32);
            this.label22.TabIndex = 34;
            this.label22.Text = "ID Usuario";
            // 
            // btnQrRE
            // 
            this.btnQrRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQrRE.Location = new System.Drawing.Point(251, 280);
            this.btnQrRE.Name = "btnQrRE";
            this.btnQrRE.Size = new System.Drawing.Size(118, 68);
            this.btnQrRE.TabIndex = 35;
            this.btnQrRE.Text = "QR";
            this.btnQrRE.UseVisualStyleBackColor = true;
            this.btnQrRE.Click += new System.EventHandler(this.btnQrRE_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(127, 280);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(118, 39);
            this.numericUpDown1.TabIndex = 36;
            // 
            // nudIdUsuarioRE
            // 
            this.nudIdUsuarioRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIdUsuarioRE.Location = new System.Drawing.Point(128, 311);
            this.nudIdUsuarioRE.Name = "nudIdUsuarioRE";
            this.nudIdUsuarioRE.Size = new System.Drawing.Size(368, 26);
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
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(128, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 26);
            this.textBox2.TabIndex = 35;
            // 
            // tabPrestamo
            // 
            this.tabPrestamo.Controls.Add(this.tableLayoutPanel4);
            this.tabPrestamo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabPrestamo.Location = new System.Drawing.Point(4, 44);
            this.tabPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Name = "tabPrestamo";
            this.tabPrestamo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Size = new System.Drawing.Size(1250, 589);
            this.tabPrestamo.TabIndex = 1;
            this.tabPrestamo.Text = "Préstamo de ejemplares";
            this.tabPrestamo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.2482F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.389465F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.2506F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label18, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.textBox3, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label21, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBox4, 1, 2);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, -1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.090615F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.796116F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32686F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.928802F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.090615F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.81877F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1247, 601);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel4.SetRowSpan(this.dataGridView1, 7);
            this.dataGridView1.Size = new System.Drawing.Size(771, 521);
            this.dataGridView1.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(127, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 32);
            this.label18.TabIndex = 1;
            this.label18.Text = "Ejemplar:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(127, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Completar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 39);
            this.textBox3.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(127, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(159, 32);
            this.label21.TabIndex = 8;
            this.label21.Text = "ID usuario:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(127, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 34);
            this.button2.TabIndex = 33;
            this.button2.Text = "Búscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(127, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 39);
            this.textBox4.TabIndex = 35;
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.Transparent;
            this.tabBuscar.Controls.Add(this.tableLayoutPanel7);
            this.tabBuscar.Location = new System.Drawing.Point(4, 44);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Size = new System.Drawing.Size(1250, 589);
            this.tabBuscar.TabIndex = 0;
            this.tabBuscar.Text = "Búsqueda de ejemplares";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.Controls.Add(this.dgvEjemplaresBU, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.txtBuscarEjemplarBU, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnBuscarEjemplarBU, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.chkBusquedaExactaBU, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.label24, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.cmbFiltrarEjemplarBU, 4, 2);
            this.tableLayoutPanel7.Controls.Add(this.chkFísicoBU, 5, 1);
            this.tableLayoutPanel7.Controls.Add(this.chkDigitalBU, 5, 2);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1250, 557);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // dgvEjemplaresBU
            // 
            this.dgvEjemplaresBU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEjemplaresBU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel7.SetColumnSpan(this.dgvEjemplaresBU, 5);
            this.dgvEjemplaresBU.Location = new System.Drawing.Point(65, 112);
            this.dgvEjemplaresBU.Name = "dgvEjemplaresBU";
            this.dgvEjemplaresBU.RowHeadersWidth = 62;
            this.dgvEjemplaresBU.RowTemplate.Height = 28;
            this.dgvEjemplaresBU.Size = new System.Drawing.Size(1118, 411);
            this.dgvEjemplaresBU.TabIndex = 4;
            // 
            // txtBuscarEjemplarBU
            // 
            this.txtBuscarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEjemplarBU.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEjemplarBU.Location = new System.Drawing.Point(65, 43);
            this.txtBuscarEjemplarBU.Name = "txtBuscarEjemplarBU";
            this.tableLayoutPanel7.SetRowSpan(this.txtBuscarEjemplarBU, 2);
            this.txtBuscarEjemplarBU.Size = new System.Drawing.Size(744, 50);
            this.txtBuscarEjemplarBU.TabIndex = 0;
            this.txtBuscarEjemplarBU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarEjemplarBU_KeyDown);
            // 
            // btnBuscarEjemplarBU
            // 
            this.btnBuscarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEjemplarBU.Location = new System.Drawing.Point(815, 47);
            this.btnBuscarEjemplarBU.Name = "btnBuscarEjemplarBU";
            this.tableLayoutPanel7.SetRowSpan(this.btnBuscarEjemplarBU, 2);
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
            this.tableLayoutPanel7.SetColumnSpan(this.chkBusquedaExactaBU, 2);
            this.chkBusquedaExactaBU.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBusquedaExactaBU.Location = new System.Drawing.Point(877, 33);
            this.chkBusquedaExactaBU.Name = "chkBusquedaExactaBU";
            this.chkBusquedaExactaBU.Size = new System.Drawing.Size(181, 32);
            this.chkBusquedaExactaBU.TabIndex = 5;
            this.chkBusquedaExactaBU.Text = "Búsqueda exacta";
            this.chkBusquedaExactaBU.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(877, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 41);
            this.label24.TabIndex = 6;
            this.label24.Text = "Filtro:";
            // 
            // cmbFiltrarEjemplarBU
            // 
            this.cmbFiltrarEjemplarBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarEjemplarBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarEjemplarBU.FormattingEnabled = true;
            this.cmbFiltrarEjemplarBU.Location = new System.Drawing.Point(939, 71);
            this.cmbFiltrarEjemplarBU.Name = "cmbFiltrarEjemplarBU";
            this.cmbFiltrarEjemplarBU.Size = new System.Drawing.Size(119, 40);
            this.cmbFiltrarEjemplarBU.TabIndex = 2;
            this.cmbFiltrarEjemplarBU.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarEjemplarBU_SelectedIndexChanged);
            // 
            // chkFísicoBU
            // 
            this.chkFísicoBU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFísicoBU.AutoSize = true;
            this.chkFísicoBU.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFísicoBU.Location = new System.Drawing.Point(1064, 33);
            this.chkFísicoBU.Name = "chkFísicoBU";
            this.chkFísicoBU.Size = new System.Drawing.Size(119, 32);
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
            this.chkDigitalBU.Location = new System.Drawing.Point(1064, 71);
            this.chkDigitalBU.Name = "chkDigitalBU";
            this.chkDigitalBU.Size = new System.Drawing.Size(119, 32);
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
            this.tabAdmin.Controls.Add(this.tabPage1);
            this.tabAdmin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.Location = new System.Drawing.Point(0, 28);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1258, 637);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.TabStop = false;
            this.tabAdmin.Tag = "";
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            this.tabAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabAdmin_KeyDown);
            // 
            // tabMisionVision
            // 
            this.tabMisionVision.Controls.Add(this.tableLayoutPanel3);
            this.tabMisionVision.Location = new System.Drawing.Point(4, 44);
            this.tabMisionVision.Name = "tabMisionVision";
            this.tabMisionVision.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisionVision.Size = new System.Drawing.Size(1250, 589);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1256, 604);
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
            this.lblMision.Size = new System.Drawing.Size(1250, 120);
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
            this.lblVision.Location = new System.Drawing.Point(3, 301);
            this.lblVision.Name = "lblVision";
            this.lblVision.Size = new System.Drawing.Size(1250, 120);
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
            this.lblInfoMision.Location = new System.Drawing.Point(3, 120);
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
            this.lblInfoVision.Location = new System.Drawing.Point(3, 421);
            this.lblInfoVision.Name = "lblInfoVision";
            this.lblInfoVision.Size = new System.Drawing.Size(1250, 183);
            this.lblInfoVision.TabIndex = 3;
            this.lblInfoVision.Text = resources.GetString("lblInfoVision.Text");
            this.lblInfoVision.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabIntroduccion
            // 
            this.tabIntroduccion.Controls.Add(this.tableLayoutPanel6);
            this.tabIntroduccion.Location = new System.Drawing.Point(4, 44);
            this.tabIntroduccion.Name = "tabIntroduccion";
            this.tabIntroduccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntroduccion.Size = new System.Drawing.Size(1250, 589);
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
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1256, 604);
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
            this.label31.Size = new System.Drawing.Size(1250, 120);
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
            this.label32.Location = new System.Drawing.Point(3, 120);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(1250, 241);
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
            this.label33.Location = new System.Drawing.Point(3, 361);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(1250, 243);
            this.label33.TabIndex = 2;
            this.label33.Text = resources.GetString("label33.Text");
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1250, 589);
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
            this.txtNombreCO.Size = new System.Drawing.Size(100, 26);
            this.txtNombreCO.TabIndex = 0;
            // 
            // cmbTipoColeccionCO
            // 
            this.cmbTipoColeccionCO.Location = new System.Drawing.Point(0, 0);
            this.cmbTipoColeccionCO.Name = "cmbTipoColeccionCO";
            this.cmbTipoColeccionCO.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoColeccionCO.TabIndex = 0;
            // 
            // cmbGeneroColeccionCO
            // 
            this.cmbGeneroColeccionCO.Location = new System.Drawing.Point(0, 0);
            this.cmbGeneroColeccionCO.Name = "cmbGeneroColeccionCO";
            this.cmbGeneroColeccionCO.Size = new System.Drawing.Size(121, 28);
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
            this.sspStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sspStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sspNombre,
            this.sspRol});
            this.sspStatus.Location = new System.Drawing.Point(0, 632);
            this.sspStatus.Name = "sspStatus";
            this.sspStatus.Size = new System.Drawing.Size(1258, 32);
            this.sspStatus.TabIndex = 2;
            // 
            // sspNombre
            // 
            this.sspNombre.Name = "sspNombre";
            this.sspNombre.Size = new System.Drawing.Size(87, 25);
            this.sspNombre.Text = "Nombre: ";
            // 
            // sspRol
            // 
            this.sspRol.Name = "sspRol";
            this.sspRol.Size = new System.Drawing.Size(46, 25);
            this.sspRol.Text = "Rol: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.sspStatus);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.mspMenu);
            this.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mspMenu;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmPrincipal";
            this.Text = "BINAES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private Label label22;
        private Button btnQrRE;
        private NumericUpDown numericUpDown1;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox txtBuscarEjemplarBU;
        private Button btnBuscarEjemplarBU;
        private DataGridView dgvEjemplaresBU;
        private CheckBox chkBusquedaExactaBU;
        private ComboBox cmbFiltrarEjemplarBU;
        private Label label24;
        private CheckBox chkFísicoBU;
        private CheckBox chkDigitalBU;
    }
}