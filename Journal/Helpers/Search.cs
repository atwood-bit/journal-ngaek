using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal.Helpers
{
    public static class Search
    {
        public static DataGridView SearchInGrid(DataGridView grid, string field, string value, DataView view)
        {
            try
            {
                view.RowFilter = string.Format("Convert(" + field + ", System.String) LIKE '%{0}%'", value);
                grid.DataSource = view.ToTable();

                return grid;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка поиска");
            }
        }
    }
}
