using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSN3.Helpers
{
    internal class UtilityHelper
    {
        public static void consoleLog(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }

        public static bool ifColumnExist(DataTable dt, string columnName)
        {
            bool columnExists = false;
            foreach (DataGridViewColumn column in dt.Columns)
            {
                if (column.Name == columnName)
                {
                    columnExists = true;
                    break;
                }
            }

            return columnExists;
        }

        
    }
}
