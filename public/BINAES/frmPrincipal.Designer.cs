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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sspStatus = new System.Windows.Forms.StatusStrip();
            this.sspNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.sspRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnIntroPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnMisionVisionPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnReservarPrinpal = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnAddUsuarioPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnAdminEventosPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnAñadirEjemplarPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnPrestamosPrincipal = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelBarraTituloPrincpal = new System.Windows.Forms.Panel();
            this.btnMinimizarPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnRestoreWinPrincipal = new FontAwesome.Sharp.IconButton();
            this.btnCerrarPrincipal = new FontAwesome.Sharp.IconButton();
            this.sspStatus.SuspendLayout();
            this.panelMenuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelBarraTituloPrincpal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sspStatus
            // 
            this.sspStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sspStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sspStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sspStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sspNombre,
            this.sspRol});
            this.sspStatus.Location = new System.Drawing.Point(0, 651);
            this.sspStatus.Name = "sspStatus";
            this.sspStatus.Size = new System.Drawing.Size(1262, 22);
            this.sspStatus.TabIndex = 2;
            // 
            // sspNombre
            // 
            this.sspNombre.Name = "sspNombre";
            this.sspNombre.Size = new System.Drawing.Size(58, 17);
            this.sspNombre.Text = "Nombre: ";
            // 
            // sspRol
            // 
            this.sspRol.Name = "sspRol";
            this.sspRol.Size = new System.Drawing.Size(32, 17);
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
            this.panelMenuPrincipal.Size = new System.Drawing.Size(253, 651);
            this.panelMenuPrincipal.TabIndex = 3;
            // 
            // btnIntroPrincipal
            // 
            this.btnIntroPrincipal.FlatAppearance.BorderSize = 0;
            this.btnIntroPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnMisionVisionPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnReservarPrinpal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 140);
            this.panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::BINAES.Properties.Resources.LOGOBINAES_nobackground;
            this.picLogo.Location = new System.Drawing.Point(34, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(177, 113);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnAddUsuarioPrincipal
            // 
            this.btnAddUsuarioPrincipal.FlatAppearance.BorderSize = 0;
            this.btnAddUsuarioPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsuarioPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAdminEventosPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAñadirEjemplarPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnPrestamosPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelBarraTituloPrincpal);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Controls.Add(this.sspStatus);
            this.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINAES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseDown);
            this.sspStatus.ResumeLayout(false);
            this.sspStatus.PerformLayout();
            this.panelMenuPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelBarraTituloPrincpal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip sspStatus;
        private System.Windows.Forms.ToolStripStatusLabel sspNombre;
        private System.Windows.Forms.ToolStripStatusLabel sspRol;
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
        private PictureBox picLogo;
    }
}