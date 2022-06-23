using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BINAES
{
    public static class Utils
    {
        public static int getDataGridViewCellId(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            return Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag);
        }
    }
}
