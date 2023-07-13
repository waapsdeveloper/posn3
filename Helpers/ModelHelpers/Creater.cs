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
            initializeCityTable();
            initializeGroupTable();
            initializeAppSettingsTable();
            initializeTaxListTable();
            initializeAccountListTable();
            initializeAccountingTable();
            initializePartnerListTable();

            return true;
        }



        bool initializeUsersTable()
        {
            string sql = "CREATE TABLE users";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "name varchar(100), ";
            sql += "email varchar(100), ";
            sql += "password varchar(100), ";
            sql += "role_id INTEGER, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "unique(email) ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("users table created successful");
            return r == 0 ? false : true;


        }

        bool initializeRolesTable()
        {
            string sql = "CREATE TABLE roles";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "name varchar(100), ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "unique(name) ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("roles table created successful");
            return r == 0 ? false : true;

        }

        bool initializeCityTable()
        {
            string sql = "CREATE TABLE cities";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "name varchar(100), ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "unique(name) ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("roles table created successful");
            return r == 0 ? false : true;

        }

        bool initializeGroupTable()
        {
            string sql = "CREATE TABLE groups";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "code varchar(15), ";
            sql += "name varchar(100), ";

            sql += "discount_group decimal(7,2), ";
            sql += "happy_hour_1 DateTime, ";
            sql += "happy_hour_2 DateTime, ";
            sql += "happy_hour_3 DateTime, ";

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
            string sql = "CREATE TABLE app_settings";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "title TEXT UNIQUE, ";
            sql += "description  varchar(200), ";
            sql += "type  varchar(100), ";
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
            string sql = "CREATE TABLE tax_list";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "account varchar(7), ";
            sql += "name varchar(150), ";
            sql += "tax1 decimal(7,2), ";
            sql += "tax2 decimal(7,2), ";
            sql += "tax3 decimal(7,2), ";
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
            string sql = "CREATE TABLE account_list";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "account varchar(15), ";
            sql += "name varchar(150), ";
            sql += "aop varchar(10), ";
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
            string sql = "CREATE TABLE accounting";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "account_id INTEGER, ";
            sql += "partner_id INTEGER, ";
            sql += "account_date DATETIME, ";
            sql += "document_name varchar(70), ";
            sql += "description varchar(120), ";
            sql += "debit decimal(16,2), ";
            sql += "credit decimal(16,2), ";
            
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("accounting table created successful");

            return r == 0 ? false : true;


        }

        bool initializePartnerListTable()
        {
            string sql = "CREATE TABLE partner_list ";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "code VARCHAR(15), ";
            sql += "name VARCHAR(100), ";
            sql += "long_name VARCHAR(120), ";
            sql += "address VARCHAR(100), ";
            sql += "city_id INTEGER, ";
            sql += "mb VARCHAR(13), ";
            sql += "oib VARCHAR(11), ";
            sql += "in_tax_system VARCHAR(2), ";
            sql += "tax_type VARCHAR(2), ";
            sql += "is_customer BIT, ";
            sql += "is_vendor BIT, ";
            sql += "iban VARCHAR(21), ";
            sql += "phone VARCHAR(50), ";
            sql += "telefax VARCHAR(50), ";
            sql += "mobile_phone VARCHAR(50), ";
            sql += "mail VARCHAR(150), ";
            sql += "web VARCHAR(150), ";
            sql += "customer_account INTEGER, ";
            sql += "vendor_account INTEGER, ";
            sql += "person INTEGER, ";
            sql += "customer_discount DECIMAL(7,2), ";
            sql += "vendor_discount DECIMAL(7,2), ";
            sql += "customer_due_date INTEGER, ";
            sql += "vendor_due_date INTEGER, ";            
            sql += "active BIT, ";

            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ";

            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("partner_list table created successfully");

            return r == 0 ? false : true;
        }

    }
}
