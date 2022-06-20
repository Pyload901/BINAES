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
        private static void UpdateDelete_ClickHandler (object sender, DataGridViewCellEventArgs e, ICRUD DAO)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.ColumnIndex == dgv.ColumnCount - 2)
                DAO.Update(getId(dgv, e));
            else if (e.ColumnIndex == dgv.ColumnCount - 1)
                DAO.Delete(getId(dgv, e));
        }
        public static void CleanDataGridView (DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
        }
        public static void BuildDataGridView_UpdateDelete (DataGridView dgv, ICRUD DAO) 
        {
            dgv.Columns.Add(new DataGridViewButtonColumn());
            dgv.Columns.Add(new DataGridViewButtonColumn());
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[dgv.Columns.Count - 2].Value = "Editar";
                row.Cells[dgv.Columns.Count - 2].Tag = row.Cells[0].Value;

                row.Cells[dgv.Columns.Count - 1].Value = "Eliminar";
                row.Cells[dgv.Columns.Count - 1].Tag = row.Cells[0].Value;
            }
            dgv.CellClick += delegate (object sender, DataGridViewCellEventArgs e)
            {
                UpdateDelete_ClickHandler(sender, e, DAO);
            };
        }

    }
}
