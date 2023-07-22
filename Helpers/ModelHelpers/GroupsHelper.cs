using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class GroupsHelper
    {
        SqliteHelper sqliteHelper;
        public GroupsHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "Select * from groups";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Roles table created successful");
            return dt;
        }

        public async Task<DataTable> getByRoleName(string name)
        {
            string sql = "SELECT * FROM groups ";

            sql += " WHERE ";

            sql += "name = ";
            sql += "'" + name + "'";

            object[] valuesa = { };

            var ra = sqliteHelper.executeData(sql, valuesa);
            return ra;
        }

        public async Task<bool> insertAsync(string name, string code, decimal discount_group, DateTime? happy_hour_1, DateTime? happy_hour_2, DateTime? happy_hour_3)
        {
            string sql = "INSERT INTO groups ";
            sql += "(";
            sql += "name, code, discount_group, happy_hour_1, happy_hour_2, happy_hour_3";
            sql += ")";

            sql += " VALUES ";

            sql += "(";
            sql += $"'{name}', '{code}', {discount_group}, ";
            sql += happy_hour_1 != null ? $"'{happy_hour_1.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " : "NULL, ";
            sql += happy_hour_2 != null ? $"'{happy_hour_2.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " : "NULL, ";
            sql += happy_hour_3 != null ? $"'{happy_hour_3.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL";
            sql += ")";

            object[] values = { };

            var result = sqliteHelper.execute(sql, values);
            return result == 0 ? false : true;
        }

        public async Task<bool> updateAsync(int id, string name, string code, decimal discount_group, DateTime? happy_hour_1, DateTime? happy_hour_2, DateTime? happy_hour_3)
        {
            try
            {
                string sql = "UPDATE groups SET ";
                sql += "name = '" + name + "', ";
                sql += "code = '" + code + "', ";
                sql += "discount_group = " + discount_group.ToString("0.00") + ", ";
                sql += "happy_hour_1 = " + (happy_hour_1 != null ? $"'{happy_hour_1.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL") + ", ";
                sql += "happy_hour_2 = " + (happy_hour_2 != null ? $"'{happy_hour_2.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL") + ", ";
                sql += "happy_hour_3 = " + (happy_hour_3 != null ? $"'{happy_hour_3.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL") + ", ";

                var updated_at = DateTime.Now;
                sql += "updated_at = '" + updated_at.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
                sql += "WHERE id = " + id;

                object[] values = { };

                var result = sqliteHelper.execute(sql, values);
                return result == 0 ? false : true;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> deleteAsync(int id) {

            string sql = "DELETE FROM groups ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
