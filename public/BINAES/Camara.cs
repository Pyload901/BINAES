using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace BINAES
{
    public static class Camara
    {
        private static Bitmap imagen = null;
        private static Bitmap imagenRedimensionada = null;
        private static VideoCaptureDevice camara = null;
        private static void Resize(Size tamañoDestino)
        {
            float porcentaje = 0;
            float cambioAltura = 0;
            float cambioAncho = 0;
            cambioAncho = (float)tamañoDestino.Width / (float)imagen.Width;
            cambioAltura = (float)tamañoDestino.Height / (float)imagen.Height;
            porcentaje = (cambioAncho < cambioAltura ? cambioAncho : cambioAltura);
            int nuevaAltura = (int)(imagen.Height * porcentaje);
            int nuevoAncho = (int)(imagen.Width * porcentaje);
            imagenRedimensionada = new Bitmap(nuevoAncho, nuevaAltura);
            Graphics g = Graphics.FromImage(imagenRedimensionada);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(imagen, 0, 0, nuevoAncho, nuevaAltura);
            g.Dispose();
        }
        private static void camara_NewFrame (object sender, NewFrameEventArgs e, PictureBox pic)
        {
            if (imagen != null)
                imagen.Dispose();
            if (imagenRedimensionada != null)
                imagenRedimensionada.Dispose();

            imagen = (Bitmap)e.Frame.Clone();
            imagen.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Resize(pic.Size);
            pic.Image = imagenRedimensionada;
            
        }
        public static bool Seleccionar ()
        {
            using (frmSeleccionCamara ventana = new frmSeleccionCamara())
            {
                bool flag = false;
                DialogResult resultado = ventana.ShowDialog();
                if (resultado == DialogResult.OK)
                    flag = true;
                return flag;
            }
        }
        public static void Abrir (PictureBox pic)
        {
            if (Properties.Settings.Default.Camara == "")
                if (!Seleccionar())
                    return;
            camara.Source = Properties.Settings.Default.Camara;
            camara.Start();
            Console.WriteLine("Inicializada la camara");
            camara.NewFrame += delegate (object sender, NewFrameEventArgs e)
            {
                camara_NewFrame(sender, e, pic);
            };
        }
        public static void TomarFoto(PictureBox pic)
        {
            camara.SignalToStop();
            Bitmap imagen = (Bitmap)pic.Image;
        }
        public static void Cerrar(PictureBox pic)
        {
            camara.SignalToStop();
            camara.WaitForStop();
        }
        public static bool Activada ()
        {
            return camara.IsRunning;
        }
    }
}
