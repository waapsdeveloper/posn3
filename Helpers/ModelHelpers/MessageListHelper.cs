using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSN3.Helpers.ModelHelpers
{
    internal class MessageListHelper
    {
        SqliteHelper sqliteHelper;

        public MessageListHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "SELECT * FROM messages";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Messages table fetched successfully");
            return dt;
        }

        public async Task<DataTable> GetByCode(string code)
        {
            string sql = "SELECT * FROM messages";
            sql += " WHERE ";
            sql += "code = ";
            sql += "'" + code + "'";

            object[] values = { };

            var result = sqliteHelper.executeData(sql, values);
            return result;
        }

        public async Task<bool> insert(string message, int? invoice_id)
        {
            string sql = "INSERT INTO messages ";
            sql += "(";
            sql += "message, invoice_id";
            sql += ")";

            sql += " VALUES ";

            sql += "(";
            sql += $"'{message}', {invoice_id}";
            sql += ")";

            object[] values = { };

            var result = sqliteHelper.execute(sql, values);
            return result == 0 ? false : true;
        }

        public async Task<bool> updateAsync(int id, string message = null, int? invoice_id = null)
        {
            try
            {
                string sql = "UPDATE messages SET ";

                if (message != null)
                    sql += "message = '" + message + "', ";

                if (invoice_id != null)
                    sql += "invoice_id = " + invoice_id + ", ";

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

        public async Task<bool> deleteAsync(int id)
        {
            string sql = "DELETE FROM messages ";
            sql += "WHERE ";
            sql += "id = " + id;

            object[] values = { };

            var result = sqliteHelper.execute(sql, values);
            return result == 0 ? false : true;
        }
    }
}
