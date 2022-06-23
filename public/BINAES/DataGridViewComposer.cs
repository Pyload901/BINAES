using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace BINAES
{
    public static class DataGridViewComposer
    {
        private static List<string> indicesNulos = new List<string>();
        public static int getId (DataGridView dgv, DataGridViewCellEventArgs e)
        {
            return Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag);
        }
        public static void GetNullProperties (object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (var propertie in properties)
            {
                if (propertie.GetValue(obj) == null && !indicesNulos.Contains(propertie.Name))
                {
                    indicesNulos.Add(propertie.Name);
                }
                else if (indicesNulos.Contains(propertie.Name))
                {
                    indicesNulos.Remove(propertie.Name);
                }
            }
        }
        public static void Compose(DataGridView dgv)
        {
            foreach (string i in indicesNulos)
                dgv.Columns.Remove(dgv.Columns[i]);
            indicesNulos.Clear();
        }
        public static void LimpiarDataGridView (DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
        }
        public static void BuildDataGridView_Editar (DataGridView dgv) 
        {
            dgv.Columns.Add(new DataGridViewButtonColumn());
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[dgv.Columns.Count - 1].Value = "Editar";
                row.Cells[dgv.Columns.Count - 1].Tag = row.Cells[0].Value;
            }
        }
        public static void BuildDataGridView_Eliminar (DataGridView dgv)
        {
            dgv.Columns.Add(new DataGridViewButtonColumn());
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[dgv.Columns.Count - 1].Value = "Eliminar";
                row.Cells[dgv.Columns.Count - 1].Tag = row.Cells[0].Value;
            }
        }

    }
}
