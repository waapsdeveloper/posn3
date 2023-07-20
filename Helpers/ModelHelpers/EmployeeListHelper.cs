using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSN3.Helpers.ModelHelpers
{
    internal class EmployeeListHelper
    {
        SqliteHelper sqliteHelper;

        public EmployeeListHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "SELECT * FROM employees";

            object[] values = { };
            DataTable dt = await sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Employees table fetched successfully");
            return dt;
        }

        public async Task<DataTable> GetByCode(string code)
        {
            string sql = "SELECT * FROM employees";
            sql += " WHERE ";
            sql += "code = ";
            sql += "'" + code + "'";

            object[] values = { };

            var result = await sqliteHelper.executeData(sql, values);
            return result;
        }

        public async Task<bool> insertAsync(string code, string password, string name, string oib, string level)
        {
            string sql = "INSERT INTO employees ";
            sql += "(";
            sql += "code, password, name, oib, level";
            sql += ")";

            sql += " VALUES ";

            sql += "(";
            sql += $"'{code}', '{password}', '{name}', '{oib}', '{level}'";
            sql += ")";

            object[] values = { };

            var result = await sqliteHelper.execute(sql, values);
            return result == 0 ? false : true;
        }

        public async Task<bool> updateAsync(int id, string code = null, string password = null, string name = null, string oib = null, string level = null)
        {
            try
            {
                string sql = "UPDATE employees SET ";

                if (code != null)
                    sql += "code = '" + code + "', ";

                if (password != null)
                    sql += "password = '" + password + "', ";

                if (name != null)
                    sql += "name = '" + name + "', ";

                if (oib != null)
                    sql += "oib = '" + oib + "', ";

                if (level != null)
                    sql += "level = '" + level + "', ";

                var updated_at = DateTime.Now;
                sql += "updated_at = '" + updated_at.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
                sql += "WHERE id = " + id;

                object[] values = { };

                var result = await sqliteHelper.execute(sql, values);
                return result == 0 ? false : true;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("Employee Update Error: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> deleteAsync(int id)
        {
            string sql = "DELETE FROM employees ";
            sql += "WHERE ";
            sql += "id = " + id;

            object[] values = { };

            var result = await sqliteHelper.execute(sql, values);
            return result == 0 ? false : true;
        }
    }
}
