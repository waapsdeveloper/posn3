﻿using System;
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

        public DataTable all()
        {
            string sql = "Select * from roles";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Roles table created successful");
            return dt;
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

            string sql = "INSERT INTO roles ";
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

        public bool update(int id, string name)
        {
            try
            {
                string sqla = "UPDATE roles SET ";
                sqla += "name = '" + name + "', ";

                var updated_at = DateTime.Now;
                sqla += "updated_at = '" + updated_at + "' ";
                sqla += "WHERE id = " + id;

                object[] valuesa = { };

                var ra = sqliteHelper.execute(sqla, valuesa);                
                return ra == 0 ? false : true;

            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error:" + ex.Message);
                return false;
            }

        }

        public bool delete(int id) {

            string sql = "DELETE FROM roles ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
