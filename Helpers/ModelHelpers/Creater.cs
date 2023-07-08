using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSN3.Helpers.ModelHelpers
{
    internal class Creater
    {
        SqliteHelper sqliteHelper;
        public Creater(SqliteHelper sqliteHelper) {
            this.sqliteHelper = sqliteHelper;
        }
        public void initialize()
        {
            createDatabase();
        }

        bool createDatabase()
        {
            initializeUsersTable();
            initializeRolesTable();
            initializeAppSettingsTable();
            initializeTaxListTable();
            initializeAccountListTable();
            initializeAccountingTable();

            return true;
        }



        bool initializeUsersTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS users";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY, ";
            sql += "name TEXT, ";
            sql += "email TEXT, ";
            sql += "password TEXT, ";
            sql += "role_id INTEGER, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("users table created successful");
            return r == 0 ? false : true;


        }

        bool initializeRolesTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS roles";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY, ";
            sql += "name TEXT, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "unique(name) ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("roles table created successful");
            return r == 0 ? false : true;

        }

        bool initializeAppSettingsTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS app_settings";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY, ";
            sql += "title TEXT UNIQUE, ";
            sql += "description TEXT, ";
            sql += "type TEXT, ";
            sql += "value INTEGER, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("AppSettings table created successful");

            return r == 0 ? false : true;


        }

        bool initializeTaxListTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS tax_list";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY, ";
            sql += "account TEXT, ";
            sql += "name TEXT, ";
            sql += "tax1 TEXT, ";
            sql += "tax2 TEXT, ";
            sql += "tax3 TEXT, ";
            sql += "account_in_id INTEGER, ";
            sql += "account_out_id INTEGER, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("tax list table created successful");

            return r == 0 ? false : true;


        }

        bool initializeAccountListTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS account_list";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY, ";
            sql += "account TEXT, ";
            sql += "name TEXT, ";
            sql += "aop TEXT, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("account list table created successful");

            return r == 0 ? false : true;


        }

        bool initializeAccountingTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS accounting";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY, ";
            sql += "account_id TEXT, ";
            sql += "account_date TEXT, ";
            sql += "document_name TEXT, ";
            sql += "description TEXT, ";
            sql += "debit TEXT, ";
            sql += "credit TEXT, ";
            sql += "partner_id INTEGER, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("accounting table created successful");

            return r == 0 ? false : true;


        }

    }
}
