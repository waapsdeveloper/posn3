using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class AccountingHelper
    {
        SqliteHelper sqliteHelper;
        public AccountingHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public DataTable all()
        {
            string sql = "Select * from accounting";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("accounting table list");
            return dt;
        }

        public bool insert(int? account_id, int partner_id, DateTime account_date, string document_name, string description, double debit, double credit)
        {
            string sql = "INSERT INTO accounting ";
            sql += "(";
            sql += "account_id, ";
            sql += "partner_id, ";
            sql += "account_date, ";
            sql += "document_name, ";
            sql += "description, ";
            sql += "debit, ";
            sql += "credit";
            sql += ")";

            sql += " VALUES ";

            sql += "(";
            sql += "" + account_id + ", ";
            sql += "" + partner_id + ", ";
            sql += "'" + account_date.ToString("yyyy-MM-dd HH:mm:ss") + "', ";
            sql += "'" + document_name + "', ";
            sql += "'" + description + "', ";
            sql += "" + debit + ", ";
            sql += "" + credit + " ";
            sql += ")";

            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;
        }

        public bool update(int id, int? account_id, int partner_id, DateTime account_date, string documentName, string description, double debit, double credit)
        {
            try
            {
                string sql = "UPDATE accounting SET ";
                sql += "account_id = " + account_id + ", ";
                sql += "partner_id = " + partner_id + ", ";
                sql += "account_date = '" + account_date.ToString("yyyy-MM-dd HH:mm:ss") + "', ";
                sql += "document_name = '" + documentName + "', ";
                sql += "description = '" + description + "', ";
                sql += "debit = " + debit + ", ";
                sql += "credit = " + credit + ", ";

                var updatedAt = DateTime.Now;
                sql += "updated_at = '" + updatedAt.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
                sql += "WHERE id = " + id;

                object[] values = { };

                var rowsAffected = sqliteHelper.execute(sql, values);
                return rowsAffected == 0 ? false : true;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error: " + ex.Message);
                return false;
            }
        }

        public bool delete(int id) {

            string sql = "DELETE FROM accounting ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
