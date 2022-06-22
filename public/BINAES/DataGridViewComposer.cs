using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES
{
    public static class DataGridViewComposer
    {
        public static int getId (DataGridView dgv, DataGridViewCellEventArgs e)
        {
            return Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag);
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
