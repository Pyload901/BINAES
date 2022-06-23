using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES
{
    public partial class frmLogin : Form
    {
        //Lados del Form

        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);

        }

        //Mover Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Minimizar/mover barra de tareas
        private void tableLayoutPanel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


                // Metodos Privados para redondear el form
                private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
                {
                    GraphicsPath path = new GraphicsPath();
                    float curveSize = radius * 2F;

                    path.StartFigure();
                    path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                    path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                    path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
                    path.CloseFigure();
                    return path;
                }

                private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
                {
                    if (this.WindowState != FormWindowState.Minimized)
                    {
                        using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                        using (Pen penBorder = new Pen(borderColor, borderSize))
                        using (Matrix transform = new Matrix())
                        {
                            graph.SmoothingMode = SmoothingMode.AntiAlias;
                            form.Region = new Region(roundPath);
                            if (borderSize >= 1)
                            {
                                Rectangle rect = form.ClientRectangle;
                                float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                                float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                                transform.Scale(scaleX, scaleY);
                                transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                                graph.Transform = transform;
                                graph.DrawPath(penBorder, roundPath);
                            }
                        }
                    }
                }

                //Evento par praa los bordes
                private void frmLogin_Paint(object sender, PaintEventArgs e)
                {
                    FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
                }
                
                
    }
}
