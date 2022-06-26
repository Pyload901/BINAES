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
        public static void GetNullProperties (object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (var propertie in properties)
            {
                if (!indicesNulos.Contains(propertie.Name))
                {
                    if (propertie.GetValue(obj) == null)
                        indicesNulos.Add(propertie.Name);
                    else if (propertie.GetValue(obj).GetType() == typeof(int))
                    {
                        if ((int)propertie.GetValue(obj) == -1)
                            indicesNulos.Add(propertie.Name);
                    }
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
