using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class PaymentListTableHelper
    {
        SqliteHelper sqliteHelper;
        public PaymentListTableHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> All()
        {
            string sql = "SELECT * FROM payment_list";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("payment_list table list");
            return dt;
        }

        public async Task<bool> InsertAsync(string code = null, string fiscal = null, string name = null, decimal? discount_payment = null)
        {
            string sql = "INSERT INTO payment_list ";
            sql += "(";
            List<string> columns = new List<string>();
            List<string> valuePlaceholders = new List<string>();

            if (!string.IsNullOrEmpty(code))
            {
                columns.Add("code");
                valuePlaceholders.Add("'" + code + "'");
            }

            if (!string.IsNullOrEmpty(fiscal))
            {
                columns.Add("fiscal");
                valuePlaceholders.Add("'" + fiscal + "'");
            }

            if (!string.IsNullOrEmpty(name))
            {
                columns.Add("name");
                valuePlaceholders.Add("'" + name + "'");
            }

            if (discount_payment != null)
            {
                columns.Add("discount_payment");
                valuePlaceholders.Add(((decimal)discount_payment).ToString());
            }

            sql += string.Join(", ", columns);
            sql += ")";
            sql += " VALUES ";
            sql += "(";
            sql += string.Join(", ", valuePlaceholders);
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);
            return rowsAffected > 0;
        }

        public async Task<bool> UpdateAsync(int id, string code = null, string fiscal = null, string name = null, decimal? discount_payment = null)
        {
            try
            {
                string sql = "UPDATE payment_list SET ";
                List<string> updates = new List<string>();

                if (!string.IsNullOrEmpty(code))
                {
                    updates.Add("code = '" + code + "'");
                }

                if (!string.IsNullOrEmpty(fiscal))
                {
                    updates.Add("fiscal = '" + fiscal + "'");
                }

                if (!string.IsNullOrEmpty(name))
                {
                    updates.Add("name = '" + name + "'");
                }

                if (discount_payment != null)
                {
                    updates.Add("discount_payment = " + ((decimal)discount_payment).ToString());
                }

                if (updates.Count > 0)
                {
                    sql += string.Join(", ", updates);
                    var updated_at = DateTime.Now;
                    sql += ", updated_at = '" + updated_at + "' ";
                    sql += "WHERE id = " + id;

                    object[] values = { };

                    var rowsAffected = sqliteHelper.execute(sql, values);
                    return rowsAffected > 0;
                }
                else
                {
                    return true; // If no updates needed, consider it a success.
                }
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("Payment List Update Error: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            string sql = "DELETE FROM payment_list ";
            sql += "WHERE id = " + id;

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);
            return rowsAffected > 0;
        }
    }
}
