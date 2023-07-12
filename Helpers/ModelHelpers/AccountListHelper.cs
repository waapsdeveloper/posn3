using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class AccountListHelper
    {
        SqliteHelper sqliteHelper;
        public AccountListHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public DataTable all()
        {
            string sql = "Select * from account_list";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("account_list table list");
            return dt;
        }

        public bool insert(string name, string account, string aop)
        {

            string sql = "INSERT INTO account_list ";
            sql += "(";
            sql += "account, ";
            sql += "name, ";            
            sql += "aop";
            sql += ")";
             
            sql += " VALUES ";

            sql += "(";
            sql += "'" + account  + "', ";
            sql += "'" + name  + "', ";
            sql += "'" + aop + "' ";            
            sql += ")";

            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }

        public bool update(int id, string name, string account, string aop)
        {
            try
            {
                string sql = "UPDATE account_list SET ";
                sql += "name = '" + name + "', ";
                sql += "account = '" + account + "', ";
                sql += "aop = '" + aop + "', ";

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

        public bool delete(int id) {

            string sql = "DELETE FROM account_list ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
