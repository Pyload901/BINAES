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
        private static VideoCaptureDevice camara = null;
        private static void camara_NewFrame (object sender, NewFrameEventArgs e, PictureBox pic)
        {
            
            imagen = (Bitmap) pic.Image;
            Bitmap bmp = (Bitmap)e.Frame.Clone();
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pic.Image = bmp;
            if (imagen != null) 
                imagen.Dispose();
        }
        public static void GuardarFoto(Image imagen)
        {
            try
            {
                string filepath = Properties.Resources.RutaImagenesUsuarios + '/' + Path.GetRandomFileName() + ".png";
                if (!Directory.Exists(Properties.Resources.RutaImagenesUsuarios))
                    Directory.CreateDirectory(Properties.Resources.RutaImagenesUsuarios);
            
                while (File.Exists(filepath))
                {
                    filepath = Properties.Resources.RutaImagenesUsuarios + '/' + Path.GetRandomFileName() + ".png";
                }
                imagen.Save(filepath);

            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("No se pudo guardar, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            camara = new VideoCaptureDevice();
            if (Properties.Settings.Default.Camara == "")
                if (!Seleccionar())
                    return;
            camara.Source = Properties.Settings.Default.Camara;
            camara.Start();
            camara.NewFrame += delegate (object sender, NewFrameEventArgs e)
            {
                camara_NewFrame(sender, e, pic);
            };
        }
        public static Bitmap TomarFoto(PictureBox pic)
        {
            camara.SignalToStop();
            return (Bitmap)pic.Image;
        }
        public static void Parar()
        {
            camara.SignalToStop();
        }
        public static void Cerrar(PictureBox pic)
        {
            pic.Image = null;
            if (imagen != null)
                imagen.Dispose();
            camara.SignalToStop();
            camara.WaitForStop();
            camara = null;
        }
        public static bool Activada ()
        {
            bool flag = false;
            if (camara != null && camara.IsRunning)
                flag = true;
            return flag;
        }
    }
}
