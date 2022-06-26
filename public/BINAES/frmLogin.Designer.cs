
using System;
using System.Windows.Forms;

namespace BINAES
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtContraseniaLogin = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btnIniciarSesionLogin = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizarLogin = new FontAwesome.Sharp.IconButton();
            this.btnSalirLogin = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtContraseniaLogin, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.label29, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.txtUsuarioLogin, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.label30, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.btnIniciarSesionLogin, 1, 8);
            this.tableLayoutPanel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, -16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 10;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(485, 720);
            this.tableLayoutPanel5.TabIndex = 1;
            this.tableLayoutPanel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel5_MouseDown);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Image = global::BINAES.Properties.Resources.LOGOBINAES_nobackground;
            this.pictureBox1.Location = new System.Drawing.Point(100, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel5.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(285, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtContraseniaLogin
            // 
            this.txtContraseniaLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.txtContraseniaLogin, 3);
            this.txtContraseniaLogin.Location = new System.Drawing.Point(100, 507);
            this.txtContraseniaLogin.Name = "txtContraseniaLogin";
            this.txtContraseniaLogin.PasswordChar = '*';
            this.txtContraseniaLogin.Size = new System.Drawing.Size(285, 43);
            this.txtContraseniaLogin.TabIndex = 5;
            this.txtContraseniaLogin.UseSystemPasswordChar = true;
            this.txtContraseniaLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseniaLogin_KeyDown);
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label29, 3);
            this.label29.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(100, 326);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(285, 34);
            this.label29.TabIndex = 2;
            this.label29.Text = "Usuario";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.txtUsuarioLogin, 3);
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogin.Location = new System.Drawing.Point(100, 363);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(285, 41);
            this.txtUsuarioLogin.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label30, 2);
            this.label30.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(100, 470);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(188, 34);
            this.label30.TabIndex = 3;
            this.label30.Text = "Contraseña";
            // 
            // btnIniciarSesionLogin
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.btnIniciarSesionLogin, 3);
            this.btnIniciarSesionLogin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesionLogin.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnIniciarSesionLogin.IconColor = System.Drawing.Color.Black;
            this.btnIniciarSesionLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesionLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesionLogin.Location = new System.Drawing.Point(100, 579);
            this.btnIniciarSesionLogin.Name = "btnIniciarSesionLogin";
            this.btnIniciarSesionLogin.Size = new System.Drawing.Size(285, 60);
            this.btnIniciarSesionLogin.TabIndex = 9;
            this.btnIniciarSesionLogin.Text = "Iniciar Sesion";
            this.btnIniciarSesionLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciarSesionLogin.UseVisualStyleBackColor = true;
            this.btnIniciarSesionLogin.Click += new System.EventHandler(this.btnIniciarSesionLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnMinimizarLogin);
            this.panel2.Controls.Add(this.btnSalirLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 32);
            this.panel2.TabIndex = 8;
            // 
            // btnMinimizarLogin
            // 
            this.btnMinimizarLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarLogin.FlatAppearance.BorderSize = 0;
            this.btnMinimizarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarLogin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizarLogin.IconColor = System.Drawing.Color.White;
            this.btnMinimizarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarLogin.IconSize = 30;
            this.btnMinimizarLogin.Location = new System.Drawing.Point(386, 0);
            this.btnMinimizarLogin.Name = "btnMinimizarLogin";
            this.btnMinimizarLogin.Size = new System.Drawing.Size(42, 38);
            this.btnMinimizarLogin.TabIndex = 2;
            this.btnMinimizarLogin.UseVisualStyleBackColor = true;
            this.btnMinimizarLogin.Click += new System.EventHandler(this.btnMinimizarLogin_Click);
            // 
            // btnSalirLogin
            // 
            this.btnSalirLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirLogin.FlatAppearance.BorderSize = 0;
            this.btnSalirLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirLogin.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSalirLogin.IconColor = System.Drawing.Color.White;
            this.btnSalirLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalirLogin.IconSize = 30;
            this.btnSalirLogin.Location = new System.Drawing.Point(434, 0);
            this.btnSalirLogin.Name = "btnSalirLogin";
            this.btnSalirLogin.Size = new System.Drawing.Size(52, 38);
            this.btnSalirLogin.TabIndex = 1;
            this.btnSalirLogin.UseVisualStyleBackColor = true;
            this.btnSalirLogin.Click += new System.EventHandler(this.btnSalirLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(485, 704);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtContraseniaLogin;
        private PictureBox pictureBox1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnMinimizarLogin;
        private FontAwesome.Sharp.IconButton btnSalirLogin;
        private FontAwesome.Sharp.IconButton btnIniciarSesionLogin;
    }
}

