using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class PriceTypesHelper
    {
        SqliteHelper sqliteHelper;
        public PriceTypesHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "Select * from price_types";

            object[] values = { };
            DataTable dt = await sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Roles table created successful");
            return dt;
        }

        public async Task<DataTable> getByRoleName(string name)
        {
            string sql = "SELECT * FROM price_types ";

            sql += " WHERE ";

            sql += "name = ";
            sql += "'" + name + "'";

            object[] valuesa = { };

            var ra = await sqliteHelper.executeData(sql, valuesa);
            return ra;
        }

        public async Task<bool> insertAsync(string name)
        {

            string sql = "INSERT INTO price_types ";
            sql += "(";
            sql += "name";
            sql += ")";
             
            sql += " VALUES ";

            sql += "(";
            sql += "'" + name + "'";
            sql += ")";

            object[] valuesa = { };

            var ra = await sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }

        public async Task<bool> updateAsync(int id, string name)
        {
            try
            {
                string sqla = "UPDATE price_types SET ";
                sqla += "name = '" + name + "', ";

                var updated_at = DateTime.Now;
                sqla += "updated_at = '" + updated_at + "' ";
                sqla += "WHERE id = " + id;

                object[] valuesa = { };

                var ra = await sqliteHelper.execute(sqla, valuesa);                
                return ra == 0 ? false : true;

            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error:" + ex.Message);
                return false;
            }

        }

        public async Task<bool> deleteAsync(int id) {

            string sql = "DELETE FROM price_types ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = await sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
