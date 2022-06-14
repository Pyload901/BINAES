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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tabPrestamo = new System.Windows.Forms.TabPage();
            this.tabReserva = new System.Windows.Forms.TabPage();
            this.tabAnadir = new System.Windows.Forms.TabPage();
            this.tabEventos = new System.Windows.Forms.TabPage();
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
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAdmin.Controls.Add(this.tabBuscar);
            this.tabAdmin.Controls.Add(this.tabPrestamo);
            this.tabAdmin.Controls.Add(this.tabReserva);
            this.tabAdmin.Controls.Add(this.tabAnadir);
            this.tabAdmin.Controls.Add(this.tabEventos);
            this.tabAdmin.Controls.Add(this.tabUsuarios);
            this.tabAdmin.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.ItemSize = new System.Drawing.Size(132, 30);
            this.tabAdmin.Location = new System.Drawing.Point(0, 28);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1095, 510);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.TabStop = false;
            // 
            // tabBuscar
            // 
            this.tabBuscar.Location = new System.Drawing.Point(4, 34);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBuscar.Size = new System.Drawing.Size(1087, 472);
            this.tabBuscar.TabIndex = 0;
            this.tabBuscar.Text = "Búscar";
            this.tabBuscar.UseVisualStyleBackColor = true;
            // 
            // tabPrestamo
            // 
            this.tabPrestamo.Location = new System.Drawing.Point(4, 5);
            this.tabPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Name = "tabPrestamo";
            this.tabPrestamo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPrestamo.Size = new System.Drawing.Size(1087, 501);
            this.tabPrestamo.TabIndex = 1;
            this.tabPrestamo.Text = "Préstamo";
            this.tabPrestamo.UseVisualStyleBackColor = true;
            // 
            // tabReserva
            // 
            this.tabReserva.Location = new System.Drawing.Point(4, 5);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabReserva.Size = new System.Drawing.Size(1087, 501);
            this.tabReserva.TabIndex = 2;
            this.tabReserva.Text = "Reserva";
            this.tabReserva.UseVisualStyleBackColor = true;
            // 
            // tabAnadir
            // 
            this.tabAnadir.Location = new System.Drawing.Point(4, 5);
            this.tabAnadir.Name = "tabAnadir";
            this.tabAnadir.Size = new System.Drawing.Size(1087, 501);
            this.tabAnadir.TabIndex = 3;
            this.tabAnadir.Text = "Añadir";
            this.tabAnadir.UseVisualStyleBackColor = true;
            // 
            // tabEventos
            // 
            this.tabEventos.Location = new System.Drawing.Point(4, 5);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(1087, 501);
            this.tabEventos.TabIndex = 4;
            this.tabEventos.Text = "Administrar eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Location = new System.Drawing.Point(4, 5);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(1087, 501);
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
            this.mspMenu.Size = new System.Drawing.Size(1095, 24);
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
            this.búscarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.búscarToolStripMenuItem.Tag = "0";
            this.búscarToolStripMenuItem.Text = "Búscar";
            // 
            // prestarToolStripMenuItem
            // 
            this.prestarToolStripMenuItem.Name = "prestarToolStripMenuItem";
            this.prestarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prestarToolStripMenuItem.Tag = "1";
            this.prestarToolStripMenuItem.Text = "Préstamos";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devolucionesToolStripMenuItem.Tag = "2";
            this.devolucionesToolStripMenuItem.Text = "Reservas";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirToolStripMenuItem.Tag = "3";
            this.añadirToolStripMenuItem.Text = "Añadir";
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
            this.ClientSize = new System.Drawing.Size(1095, 536);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.mspMenu);
            this.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mspMenu;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.tabAdmin.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabAnadir;
        private System.Windows.Forms.TabPage tabEventos;
        private System.Windows.Forms.TabPage tabUsuarios;
    }
}