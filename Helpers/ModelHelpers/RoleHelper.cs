using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class RoleHelper
    {
        SqliteHelper sqliteHelper;
        public RoleHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public DataTable getByRoleName(string name)
        {
            string sql = "SELECT * FROM roles ";

            sql += " WHERE ";

            sql += "name = ";
            sql += "'" + name + "'";

            object[] valuesa = { };

            var ra = sqliteHelper.executeData(sql, valuesa);
            return ra;
        }

        public bool insert(string name)
        {


            string sql = "INSERT OR IGNORE INTO roles ";
            sql += "(";
            sql += "name";
            sql += ")";
             
            sql += " VALUES ";

            sql += "(";
            sql += "'" + name + "'";
            sql += ")";

            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }

        public bool delete(string name) {

            string sql = "DELETE FROM roles ";

            sql += " WHERE ";
            sql += "name = " + "'" + name + "'";
            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
