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
        private static VideoCaptureDevice camara = null;
        private static void camara_NewFrame (object sender, NewFrameEventArgs e, PictureBox pic)
        {
            if (imagen != null)
                imagen.Dispose();
            imagen = (Bitmap)e.Frame.Clone();
            imagen.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pic.Image = imagen;
            
        }
        public static void Seleccionar ()
        {
            using (frmSeleccionCamara ventana = new frmSeleccionCamara())
            {
                ventana.ShowDialog();
            }
        }
        public static void Abrir (PictureBox pic)
        {
            if (Properties.Settings.Default.Camara == "")
                Seleccionar();
            camara = new VideoCaptureDevice(Properties.Settings.Default.Camara);
            camara.Start();
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
    }
}
