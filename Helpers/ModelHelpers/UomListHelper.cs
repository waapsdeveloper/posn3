using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class UomListHelper
    {
        SqliteHelper sqliteHelper;
        public UomListHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "SELECT * FROM uom_list";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("UOMList table data retrieved successfully");
            return dt;
        }

        public async Task<DataTable> getByUomName(string name)
        {
            string sql = "SELECT * FROM uom_list ";

            sql += " WHERE ";

            sql += "name = ";
            sql += "'" + name + "'";

            object[] valuesa = { };

            var ra = sqliteHelper.executeData(sql, valuesa);
            return ra;
        }

        public async Task<bool> insertAsync(string code, string name, int? baseUnit, decimal? ratio)
        {
            string sql = "INSERT INTO uom_list ";
            sql += "(";
            StringBuilder columns = new StringBuilder("code, name");
            StringBuilder columnValues = new StringBuilder("'" + code + "', '" + name + "'");

            if (baseUnit.HasValue)
            {
                columns.Append(", base_unit");
                columnValues.Append(", " + baseUnit.Value);
            }

            if (ratio.HasValue)
            {
                columns.Append(", ratio");
                columnValues.Append(", " + ratio.Value);
            }

            sql += columns.ToString();
            sql += ") VALUES ";
            sql += "(";
            sql += columnValues.ToString();
            sql += ")";

            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;
        }

        public async Task<bool> updateAsync(int id, string code, string name, int? baseUnit, decimal? ratio)
        {
            try
            {
                string sqla = "UPDATE uom_list SET ";
                StringBuilder updateValues = new StringBuilder("code = '" + code + "', name = '" + name + "'");

                if (baseUnit.HasValue)
                {
                    updateValues.Append(", base_unit = " + baseUnit.Value);
                }

                if (ratio.HasValue)
                {
                    updateValues.Append(", ratio = " + ratio.Value);
                }

                sqla += updateValues.ToString();
                sqla += " WHERE ID = " + id;

                object[] valuesa = { };

                var ra = sqliteHelper.execute(sqla, valuesa);
                return ra == 0 ? false : true;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("UOM Update Error:" + ex.Message);
                return false;
            }
        }

        public async Task<bool> deleteAsync(int id)
        {
            string sql = "DELETE FROM uom_list ";
            sql += "WHERE ID = " + id;

            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;
        }
    }
}
