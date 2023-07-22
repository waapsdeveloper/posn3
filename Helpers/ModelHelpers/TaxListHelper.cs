using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class TaxListHelper
    {
        SqliteHelper sqliteHelper;
        public TaxListHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "Select * from tax_list";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("tax_list table list");
            return dt;
        }

        public async Task<bool> insertAsync(string name, string account, double tax1, double tax2, double tax3, int? account_in_id, int? account_out_id )
        {

            string sql = "INSERT INTO tax_list ";
            sql += "(";
            sql += "account, ";
            sql += "name, ";
            sql += "tax1, ";
            sql += "tax2, ";
            sql += "tax3, ";
            sql += "account_in_id, ";
            sql += "account_out_id";
            sql += ")";
             
            sql += " VALUES ";

            sql += "(";
            sql += "'" + account  + "', ";
            sql += "'" + name  + "', ";
            sql += "" + tax1  + ", ";
            sql += "" + tax2  + ", ";
            sql += "" + tax3  + ", ";
            sql += "" + account_in_id  + ", ";
            sql += "" + account_out_id + " ";
            sql += ")";

            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }

        public async Task<bool> updateAsync(int id, string name, string account, double tax1, double tax2, double tax3, int? account_in_id, int? account_out_id)
        {
            try
            {
                string sql = "UPDATE tax_list SET ";
                sql += "name = '" + name + "', ";
                sql += "account = '" + account + "', ";
                sql += "tax1 = " + tax1 + ", ";
                sql += "tax2 = " + tax2 + ", ";
                sql += "tax3 = " + tax3 + ", ";
                sql += "account_in_id = " + account_in_id + ", ";
                sql += "account_out_id = " + account_out_id + ", ";

                var updated_at = DateTime.Now;
                sql += "updated_at = '" + updated_at + "' ";
                sql += "WHERE id = " + id;

                object[] valuesa = { };

                var ra = sqliteHelper.execute(sql, valuesa);                
                return ra == 0 ? false : true;

            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error:" + ex.Message);
                return false;
            }

        }

        public async Task<bool> deleteAsync(int id) {

            string sql = "DELETE FROM tax_list ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
