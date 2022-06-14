﻿namespace BINAES
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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tabPrestamo = new System.Windows.Forms.TabPage();
            this.tabReserva = new System.Windows.Forms.TabPage();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalirEdicionEjemplar = new System.Windows.Forms.Button();
            this.btnAgregarEjemplar = new System.Windows.Forms.Button();
            this.txtEditorialEjemplar = new System.Windows.Forms.TextBox();
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
            this.txtCodigoEjemplar = new System.Windows.Forms.TextBox();
            this.cmbIdiomaEjemplar = new System.Windows.Forms.ComboBox();
            this.btnEtiquetasEjemplar = new System.Windows.Forms.Button();
            this.txtNombreEjemplar = new System.Windows.Forms.TextBox();
            this.txtAutorEjemplar = new System.Windows.Forms.TextBox();
            this.cmbTipoColeccionEjemplar = new System.Windows.Forms.ComboBox();
            this.cmbFormatoEjemplar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpFechaPublicacionEjemplar = new System.Windows.Forms.DateTimePicker();
            this.tabEventos = new System.Windows.Forms.TabPage();
            this.tlpAdminEventos = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.búsquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAdmin.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabEventos.SuspendLayout();
            this.tlpAdminEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAdmin.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabAdmin.Controls.Add(this.tabBuscar);
            this.tabAdmin.Controls.Add(this.tabPrestamo);
            this.tabAdmin.Controls.Add(this.tabReserva);
            this.tabAdmin.Controls.Add(this.tabAgregar);
            this.tabAdmin.Controls.Add(this.tabEventos);
            this.tabAdmin.Controls.Add(this.tabUsuarios);
            this.tabAdmin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.Location = new System.Drawing.Point(0, 28);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1264, 655);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.TabStop = false;
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            this.tabAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabAdmin_KeyDown);
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.Transparent;
            this.tabBuscar.Location = new System.Drawing.Point(4, 33);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Size = new System.Drawing.Size(1256, 618);
            this.tabBuscar.TabIndex = 0;
            this.tabBuscar.Text = "Búscar ejemplar";
            // 
            // tabPrestamo
            // 
            this.tabPrestamo.Location = new System.Drawing.Point(4, 33);
            this.tabPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Name = "tabPrestamo";
            this.tabPrestamo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Size = new System.Drawing.Size(1256, 618);
            this.tabPrestamo.TabIndex = 1;
            this.tabPrestamo.Text = "Prestar ejemplar";
            this.tabPrestamo.UseVisualStyleBackColor = true;
            // 
            // tabReserva
            // 
            this.tabReserva.Location = new System.Drawing.Point(4, 33);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabReserva.Size = new System.Drawing.Size(1256, 618);
            this.tabReserva.TabIndex = 2;
            this.tabReserva.Text = "Reservar ejemplar";
            this.tabReserva.UseVisualStyleBackColor = true;
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.tableLayoutPanel1);
            this.tabAgregar.Location = new System.Drawing.Point(4, 33);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Size = new System.Drawing.Size(1256, 618);
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
            this.tableLayoutPanel1.Controls.Add(this.btnSalirEdicionEjemplar, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarEjemplar, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtEditorialEjemplar, 1, 1);
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
            this.tableLayoutPanel1.Controls.Add(this.txtCodigoEjemplar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbIdiomaEjemplar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnEtiquetasEjemplar, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreEjemplar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAutorEjemplar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoColeccionEjemplar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbFormatoEjemplar, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaPublicacionEjemplar, 1, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1253, 618);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnSalirEdicionEjemplar
            // 
            this.btnSalirEdicionEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirEdicionEjemplar.Location = new System.Drawing.Point(3, 567);
            this.btnSalirEdicionEjemplar.Name = "btnSalirEdicionEjemplar";
            this.btnSalirEdicionEjemplar.Size = new System.Drawing.Size(244, 48);
            this.btnSalirEdicionEjemplar.TabIndex = 28;
            this.btnSalirEdicionEjemplar.Text = "Dejar de editar";
            this.btnSalirEdicionEjemplar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEjemplar
            // 
            this.btnAgregarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEjemplar.Location = new System.Drawing.Point(253, 567);
            this.btnAgregarEjemplar.Name = "btnAgregarEjemplar";
            this.btnAgregarEjemplar.Size = new System.Drawing.Size(244, 48);
            this.btnAgregarEjemplar.TabIndex = 27;
            this.btnAgregarEjemplar.Text = "Agregar";
            this.btnAgregarEjemplar.UseVisualStyleBackColor = true;
            // 
            // txtEditorialEjemplar
            // 
            this.txtEditorialEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditorialEjemplar.Location = new System.Drawing.Point(253, 50);
            this.txtEditorialEjemplar.Name = "txtEditorialEjemplar";
            this.txtEditorialEjemplar.Size = new System.Drawing.Size(244, 29);
            this.txtEditorialEjemplar.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Imagen";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de publicación";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idioma";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Editorial";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Etiquetas";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Formato";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo de colección";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código ejemplar";
            // 
            // txtCodigoEjemplar
            // 
            this.txtCodigoEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoEjemplar.Location = new System.Drawing.Point(3, 50);
            this.txtCodigoEjemplar.Name = "txtCodigoEjemplar";
            this.txtCodigoEjemplar.Size = new System.Drawing.Size(244, 29);
            this.txtCodigoEjemplar.TabIndex = 10;
            // 
            // cmbIdiomaEjemplar
            // 
            this.cmbIdiomaEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdiomaEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdiomaEjemplar.FormattingEnabled = true;
            this.cmbIdiomaEjemplar.Location = new System.Drawing.Point(3, 332);
            this.cmbIdiomaEjemplar.Name = "cmbIdiomaEjemplar";
            this.cmbIdiomaEjemplar.Size = new System.Drawing.Size(244, 29);
            this.cmbIdiomaEjemplar.TabIndex = 13;
            // 
            // btnEtiquetasEjemplar
            // 
            this.btnEtiquetasEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEtiquetasEjemplar.Location = new System.Drawing.Point(3, 520);
            this.btnEtiquetasEjemplar.Name = "btnEtiquetasEjemplar";
            this.btnEtiquetasEjemplar.Size = new System.Drawing.Size(244, 41);
            this.btnEtiquetasEjemplar.TabIndex = 15;
            this.btnEtiquetasEjemplar.Text = "Seleccionar";
            this.btnEtiquetasEjemplar.UseVisualStyleBackColor = true;
            // 
            // txtNombreEjemplar
            // 
            this.txtNombreEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreEjemplar.Location = new System.Drawing.Point(3, 144);
            this.txtNombreEjemplar.Name = "txtNombreEjemplar";
            this.txtNombreEjemplar.Size = new System.Drawing.Size(244, 29);
            this.txtNombreEjemplar.TabIndex = 23;
            // 
            // txtAutorEjemplar
            // 
            this.txtAutorEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutorEjemplar.Location = new System.Drawing.Point(3, 238);
            this.txtAutorEjemplar.Name = "txtAutorEjemplar";
            this.txtAutorEjemplar.Size = new System.Drawing.Size(244, 29);
            this.txtAutorEjemplar.TabIndex = 24;
            // 
            // cmbTipoColeccionEjemplar
            // 
            this.cmbTipoColeccionEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoColeccionEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoColeccionEjemplar.FormattingEnabled = true;
            this.cmbTipoColeccionEjemplar.Location = new System.Drawing.Point(253, 238);
            this.cmbTipoColeccionEjemplar.Name = "cmbTipoColeccionEjemplar";
            this.cmbTipoColeccionEjemplar.Size = new System.Drawing.Size(244, 29);
            this.cmbTipoColeccionEjemplar.TabIndex = 25;
            // 
            // cmbFormatoEjemplar
            // 
            this.cmbFormatoEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormatoEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormatoEjemplar.FormattingEnabled = true;
            this.cmbFormatoEjemplar.Location = new System.Drawing.Point(3, 426);
            this.cmbFormatoEjemplar.Name = "cmbFormatoEjemplar";
            this.cmbFormatoEjemplar.Size = new System.Drawing.Size(244, 29);
            this.cmbFormatoEjemplar.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(503, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 13);
            this.dataGridView1.Size = new System.Drawing.Size(747, 612);
            this.dataGridView1.TabIndex = 29;
            // 
            // dtpFechaPublicacionEjemplar
            // 
            this.dtpFechaPublicacionEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPublicacionEjemplar.Location = new System.Drawing.Point(253, 144);
            this.dtpFechaPublicacionEjemplar.Name = "dtpFechaPublicacionEjemplar";
            this.dtpFechaPublicacionEjemplar.Size = new System.Drawing.Size(244, 29);
            this.dtpFechaPublicacionEjemplar.TabIndex = 30;
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.tlpAdminEventos);
            this.tabEventos.Location = new System.Drawing.Point(4, 33);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(1256, 618);
            this.tabEventos.TabIndex = 4;
            this.tabEventos.Text = "Administrar eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            this.tabEventos.Click += new System.EventHandler(this.tabEventos_Click);
            // 
            // tlpAdminEventos
            // 
            this.tlpAdminEventos.ColumnCount = 3;
            this.tlpAdminEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAdminEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAdminEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpAdminEventos.Controls.Add(this.dataGridView2, 1, 0);
            this.tlpAdminEventos.Controls.Add(this.button2, 0, 12);
            this.tlpAdminEventos.Controls.Add(this.button1, 1, 12);
            this.tlpAdminEventos.Controls.Add(this.dataGridView3, 2, 0);
            this.tlpAdminEventos.Controls.Add(this.numericUpDown1, 0, 11);
            this.tlpAdminEventos.Controls.Add(this.label17, 0, 10);
            this.tlpAdminEventos.Controls.Add(this.comboBox1, 0, 9);
            this.tlpAdminEventos.Controls.Add(this.label15, 0, 8);
            this.tlpAdminEventos.Controls.Add(this.richTextBox1, 0, 7);
            this.tlpAdminEventos.Controls.Add(this.label16, 0, 6);
            this.tlpAdminEventos.Controls.Add(this.dateTimePicker2, 0, 5);
            this.tlpAdminEventos.Controls.Add(this.label14, 0, 4);
            this.tlpAdminEventos.Controls.Add(this.dateTimePicker1, 0, 3);
            this.tlpAdminEventos.Controls.Add(this.label13, 0, 2);
            this.tlpAdminEventos.Controls.Add(this.textBox1, 0, 1);
            this.tlpAdminEventos.Controls.Add(this.label12, 0, 0);
            this.tlpAdminEventos.Location = new System.Drawing.Point(0, 0);
            this.tlpAdminEventos.Name = "tlpAdminEventos";
            this.tlpAdminEventos.RowCount = 13;
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAdminEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAdminEventos.Size = new System.Drawing.Size(1256, 618);
            this.tlpAdminEventos.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(379, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.tlpAdminEventos.SetRowSpan(this.dataGridView2, 12);
            this.dataGridView2.Size = new System.Drawing.Size(370, 558);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(370, 47);
            this.label12.TabIndex = 3;
            this.label12.Text = "Titulo del evento:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 29);
            this.textBox1.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(370, 47);
            this.label13.TabIndex = 5;
            this.label13.Text = "Fecha de inicio:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 29);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(370, 47);
            this.label14.TabIndex = 18;
            this.label14.Text = "Fecha de finalización:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 238);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(310, 29);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(370, 47);
            this.label16.TabIndex = 13;
            this.label16.Text = "Objetivos del evento:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 426);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 29);
            this.comboBox1.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(3, 520);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(370, 29);
            this.numericUpDown1.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(370, 47);
            this.label15.TabIndex = 20;
            this.label15.Text = "Tipo de salón: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 470);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(370, 47);
            this.label17.TabIndex = 21;
            this.label17.Text = "Número de asistentes:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 332);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 41);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(3, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(370, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "Dejar de editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(379, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(755, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.tlpAdminEventos.SetRowSpan(this.dataGridView3, 13);
            this.dataGridView3.Size = new System.Drawing.Size(498, 612);
            this.dataGridView3.TabIndex = 26;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Location = new System.Drawing.Point(4, 33);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(1256, 618);
            this.tabUsuarios.TabIndex = 5;
            this.tabUsuarios.Text = "Administrar usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
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
            this.mspMenu.Size = new System.Drawing.Size(1264, 24);
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
            this.búscarToolStripMenuItem.Text = "Búscar [Ctrl + F]";
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.mspMenu);
            this.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mspMenu;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmPrincipal";
            this.Text = "Búscar ejemplar";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabAgregar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabEventos.ResumeLayout(false);
            this.tlpAdminEventos.ResumeLayout(false);
            this.tlpAdminEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.TabPage tabPrestamo;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.TabPage tabReserva;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.TabPage tabEventos;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalirEdicionEjemplar;
        private System.Windows.Forms.Button btnAgregarEjemplar;
        private System.Windows.Forms.TextBox txtEditorialEjemplar;
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
        private System.Windows.Forms.TextBox txtCodigoEjemplar;
        private System.Windows.Forms.ComboBox cmbIdiomaEjemplar;
        private System.Windows.Forms.Button btnEtiquetasEjemplar;
        private System.Windows.Forms.TextBox txtNombreEjemplar;
        private System.Windows.Forms.TextBox txtAutorEjemplar;
        private System.Windows.Forms.ComboBox cmbTipoColeccionEjemplar;
        private System.Windows.Forms.ComboBox cmbFormatoEjemplar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacionEjemplar;
        private System.Windows.Forms.TableLayoutPanel tlpAdminEventos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}