using System;
using System.IO;
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
        private static VideoCaptureDevice camara = new VideoCaptureDevice();
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
            /*if (imagen != null)
                imagen.Dispose();
            if (imagenRedimensionada != null)
                imagenRedimensionada.Dispose();*/

            imagen = (Bitmap)e.Frame.Clone();
            imagen.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Resize(pic.Size);
            pic.Image = imagenRedimensionada;
        }
        public static void GuardarFoto(Image imagen)
        {
            string filepath = Properties.Resources.UsersImagesPath + '/' + Path.GetRandomFileName() + ".png";
            if (!Directory.Exists(Properties.Resources.UsersImagesPath))
                Directory.CreateDirectory(Properties.Resources.UsersImagesPath);
            
            while (File.Exists(filepath))
            {
                filepath = Properties.Resources.UsersImagesPath + '/' + Path.GetRandomFileName() + ".png";
            }
            imagen.Save(filepath);
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
                else
                    camara.Source = Properties.Settings.Default.Camara;
            camara.Start();
            try
            {
                camara.NewFrame += delegate (object sender, NewFrameEventArgs e)
                {
                    camara_NewFrame(sender, e, pic);
                };

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                imagen.Dispose();
                imagenRedimensionada.Dispose();
            }
        }
        public static Bitmap TomarFoto()
        {
            camara.SignalToStop();
            return imagen;
        }
        public static void Cerrar()
        {
            camara.SignalToStop();
            camara.WaitForStop();
        }
        public static void Reanudar ()
        {
            camara.Start();
        }
        public static bool Activada ()
        {
            return camara.IsRunning;
        }
    }
}
