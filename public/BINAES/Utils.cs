using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace BINAES
{
    public static class Utils
    {
        public static int getDataGridViewCellId(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            return Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
        }
        public static OpcionesEnumerate VerificarOpcion(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            OpcionesEnumerate result = new OpcionesEnumerate();
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Editar")
            {
                result = OpcionesEnumerate.Editar;
            }
            else if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Eliminar")
                result = OpcionesEnumerate.Eliminar;
            return result;
        }
        public static void SeleccionarImagen(PictureBox pic)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(dialog.FileName);
                }
            }
        }
        public static string GuardarImagen(string ruta, Image imagen)
        {
            string nombreImagen = Path.GetRandomFileName() + ".png";
            imagen.Save(ruta + nombreImagen);
            return nombreImagen;
        }
    }
}
