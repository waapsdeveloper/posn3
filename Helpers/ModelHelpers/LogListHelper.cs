using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSN3.Helpers.ModelHelpers
{
    internal class LogListHelper
    {
        SqliteHelper sqliteHelper;

        public LogListHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "SELECT * FROM logs";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Messages table fetched successfully");
            return dt;
        }

        public async Task<DataTable> GetByCode(string code)
        {
            string sql = "SELECT * FROM logs";
            sql += " WHERE ";
            sql += "code = ";
            sql += "'" + code + "'";

            object[] values = { };

            var result = sqliteHelper.executeData(sql, values);
            return result;
        }

        public async Task<bool> insert(string programName = null, int? userId = null, string menuName = null, DateTime? beginDate = null, DateTime? endDate = null)
        {
            string sql = "INSERT INTO logs ";

            StringBuilder columns = new StringBuilder();
            StringBuilder values = new StringBuilder();

            if (programName != null)
            {
                columns.Append("program_name, ");
                values.Append($"'{programName}', ");
            }

            if (userId != null)
            {
                columns.Append("user_id, ");
                values.Append($"{userId}, ");
            }

            if (menuName != null)
            {
                columns.Append("menu_name, ");
                values.Append($"'{menuName}', ");
            }

            if (beginDate != null)
            {
                columns.Append("begin_date, ");
                values.Append($"'{beginDate.Value.ToString("yyyy-MM-dd HH:mm:ss")}', ");
            }

            if (endDate != null)
            {
                columns.Append("end_date, ");
                values.Append($"'{endDate.Value.ToString("yyyy-MM-dd HH:mm:ss")}', ");
            }

            // Remove trailing commas
            if (columns.Length > 0)
            {
                columns.Length -= 2;
                values.Length -= 2;
            }

            sql += $"({columns.ToString()}) VALUES ({values.ToString()})";

            object[] paramValues = { };

            var result = sqliteHelper.execute(sql, paramValues);
            return result == 0 ? false : true;
        }


        public async Task<bool> update(int id, string programName = null, int? userId = null, string menuName = null, DateTime? beginDate = null, DateTime? endDate = null)
        {
            try
            {
                string sql = "UPDATE logs SET ";

                if (programName != null)
                    sql += "program_name = '" + programName + "', ";

                if (userId != null)
                    sql += "user_id = " + userId + ", ";

                if (menuName != null)
                    sql += "menu_name = '" + menuName + "', ";

                if (beginDate != null)
                    sql += "begin_date = '" + beginDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', ";

                if (endDate != null)
                    sql += "end_date = '" + endDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', ";

                var updated_at = DateTime.Now;
                sql += "updated_at = '" + updated_at.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
                sql += "WHERE id = " + id;

                object[] values = { };

                var result = sqliteHelper.execute(sql, values);
                return result == 0 ? false : true;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("Message Update Error: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> delete(int id)
        {
            string sql = "DELETE FROM logs ";
            sql += "WHERE ";
            sql += "id = " + id;

            object[] values = { };

            var result = sqliteHelper.execute(sql, values);
            return result == 0 ? false : true;
        }
    }
}
