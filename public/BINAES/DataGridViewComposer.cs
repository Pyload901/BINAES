using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES
{
    public static class DatagridViewComposer
    {
        private static int getId (DataGridView dgv, DataGridViewCellEventArgs e)
        {
            return Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag);
        }
        private static void Eliminar_ClickHandler(object sender, DataGridViewCellEventArgs e, IEliminar DAO)
        {
            DataGridView dgv = (DataGridView)sender;
            DAO.Eliminar(getId(dgv, e));

        }
        private static void Editar_ClickHandler(object sender, DataGridViewCellEventArgs e, IEditar DAO)
        {
            DataGridView dgv = (DataGridView)sender;
            DAO.Actualizar(getId(dgv, e));
        }
        public static void LimpiarDataGridView (DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
        }
        public static void BuildDataGridView_Editar (DataGridView dgv, IEditar DAO) 
        {
            dgv.Columns.Add(new DataGridViewButtonColumn());
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[dgv.Columns.Count - 1].Value = "Editar";
                row.Cells[dgv.Columns.Count - 1].Tag = row.Cells[0].Value;
            }
            dgv.CellClick += delegate (object sender, DataGridViewCellEventArgs e)
            {
                DataGridView senderDgv = (DataGridView)sender;
                if (senderDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Editar")
                    Editar_ClickHandler(sender, e, DAO);
            };
        }
        public static void BuildDataGridView_Eliminar (DataGridView dgv, IEliminar DAO)
        {
            dgv.Columns.Add(new DataGridViewButtonColumn());
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[dgv.Columns.Count - 1].Value = "Eliminar";
                row.Cells[dgv.Columns.Count - 1].Tag = row.Cells[0].Value;
            }
            dgv.CellClick += delegate (object sender, DataGridViewCellEventArgs e)
            {
                DataGridView senderDgv = (DataGridView)sender;
                if (senderDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Eliminar")
                    Eliminar_ClickHandler(sender, e, DAO);
            };
        }

    }
}
