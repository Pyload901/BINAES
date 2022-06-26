namespace BINAES
{
    partial class frmEscanerQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscanerQR));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEscanear = new System.Windows.Forms.Button();
            this.picEscanerQR = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarScanerQR = new FontAwesome.Sharp.IconButton();
            this.btnMinimizarScanerQR = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEscanerQR)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEscanear, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.picEscanerQR, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 245);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 43);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEscanear
            // 
            this.btnEscanear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEscanear.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscanear.Location = new System.Drawing.Point(220, 199);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(211, 43);
            this.btnEscanear.TabIndex = 2;
            this.btnEscanear.Text = "Escanear";
            this.btnEscanear.UseVisualStyleBackColor = true;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // picEscanerQR
            // 
            this.picEscanerQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.picEscanerQR, 2);
            this.picEscanerQR.Location = new System.Drawing.Point(3, 3);
            this.picEscanerQR.Name = "picEscanerQR";
            this.picEscanerQR.Size = new System.Drawing.Size(428, 190);
            this.picEscanerQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEscanerQR.TabIndex = 4;
            this.picEscanerQR.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnMinimizarScanerQR);
            this.panel1.Controls.Add(this.btnCerrarScanerQR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 41);
            this.panel1.TabIndex = 4;
            // 
            // btnCerrarScanerQR
            // 
            this.btnCerrarScanerQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarScanerQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarScanerQR.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrarScanerQR.IconColor = System.Drawing.Color.White;
            this.btnCerrarScanerQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarScanerQR.IconSize = 30;
            this.btnCerrarScanerQR.Location = new System.Drawing.Point(411, 0);
            this.btnCerrarScanerQR.Name = "btnCerrarScanerQR";
            this.btnCerrarScanerQR.Size = new System.Drawing.Size(47, 41);
            this.btnCerrarScanerQR.TabIndex = 1;
            this.btnCerrarScanerQR.UseVisualStyleBackColor = true;
            this.btnCerrarScanerQR.Click += new System.EventHandler(this.btnCerrarScanerQR_Click);
            // 
            // btnMinimizarScanerQR
            // 
            this.btnMinimizarScanerQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarScanerQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarScanerQR.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizarScanerQR.IconColor = System.Drawing.Color.White;
            this.btnMinimizarScanerQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizarScanerQR.IconSize = 30;
            this.btnMinimizarScanerQR.Location = new System.Drawing.Point(367, 0);
            this.btnMinimizarScanerQR.Name = "btnMinimizarScanerQR";
            this.btnMinimizarScanerQR.Size = new System.Drawing.Size(47, 41);
            this.btnMinimizarScanerQR.TabIndex = 2;
            this.btnMinimizarScanerQR.UseVisualStyleBackColor = true;
            this.btnMinimizarScanerQR.Click += new System.EventHandler(this.btnMinimizarScanerQR_Click);
            // 
            // frmEscanerQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmEscanerQR";
            this.Text = "Escáner QR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEscanerQR_FormClosing);
            this.Load += new System.EventHandler(this.frmEscanerQR_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEscanerQR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.PictureBox picEscanerQR;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCerrarScanerQR;
        private FontAwesome.Sharp.IconButton btnMinimizarScanerQR;
    }
}