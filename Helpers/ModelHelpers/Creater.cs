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
        private SqliteHelper sqliteHelper;
        public Creater(SqliteHelper sqliteHelper) {
            this.sqliteHelper = sqliteHelper;
        }
        public void initialize()
        {
            createDatabase();
        }

        private bool createDatabase()
        {
            InitializeUsersTable();
            initializeRolesTableAsync();
            initializeCityTableAsync();
            initializeUnitMeasuresTableAsync();
            initializeGroupTableAsync();
            initializeAppSettingsTableAsync();
            initializeTaxListTableAsync();
            initializeAccountListTableAsync();
            initializeAccountingTableAsync();
            initializePartnerListTableAsync();
            initializeProductsTableAsync();
            initializePriceTypeTable();
            initializePriceTypesTableAsync();
            initializeWarehouseTableAsync();
            initializeInvoiceTableAsync();
            InitializeEmployeeListTable();
            InitializeMessagesTableAsync();
            InitializeLogTableAsync();
            InitializePaymentListTableAsync();
            InitializeProductListTableAsync();

            return true;
        }

        private async Task<bool> InitializeUsersTable()
        {
            string sql = "CREATE TABLE users";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "name varchar(100), ";
            sql += "email varchar(100), ";
            sql += "password varchar(100), ";
            sql += "role_id INTEGER, ";
            sql += "is_login INTEGER DEFAULT 0, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "unique(email) ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("users table created successful");
            return r == 0 ? false : true;


        }

        private async Task<bool> initializeRolesTableAsync()
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

        private async Task<bool> initializeCityTableAsync()
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

        private async Task<bool> initializePriceTypesTableAsync()
        {
            string sql = "CREATE TABLE price_types";
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

        private async Task<bool> initializeUnitMeasuresTableAsync()
        {
            string sql = "CREATE TABLE unit_measures";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "name varchar(100), ";
            sql += "code varchar(100), ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "unique(name) ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("roles table created successful");
            return r == 0 ? false : true;

        }

        private async Task<bool> initializeWarehouseTableAsync()
        {
            string sql = "CREATE TABLE warehouse_list";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "name varchar(100), ";
            sql += "code varchar(100), ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "unique(name) ";
            sql += ")";

            Object[] values = { };

            var r = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("roles table created successful");
            return r == 0 ? false : true;

        }

        private async Task<bool> initializeGroupTableAsync()
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

        private async Task<bool> initializeAppSettingsTableAsync()
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

        private async Task<bool> initializeTaxListTableAsync()
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

        private async Task<bool> initializeAccountListTableAsync()
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

        private async Task<bool> initializeAccountingTableAsync()
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

        private async Task<bool> initializePartnerListTableAsync()
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

        private async Task<bool> initializeProductsTableAsync()
        {
            string sql = "CREATE TABLE products";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "accounting_date DATETIME, ";
            sql += "document varchar(70), ";
            sql += "account_id INTEGER, ";
            sql += "unit_measure INTEGER, ";
            sql += "description varchar(150), ";
            sql += "in_value NUMERIC(16,3), ";
            sql += "out_value NUMERIC(16,3), ";
            sql += "price NUMERIC(16,2), ";
            sql += "price_type  varchar(50), ";
            sql += "debit NUMERIC(16,2), ";
            sql += "credit NUMERIC(16,2), ";
            sql += "partner_id INTEGER, ";
            sql += "tax_id INTEGER, ";
            sql += "warehouse_id INTEGER, ";

            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ";
            sql += ")";

            Object[] values = { };

            var result = sqliteHelper.execute(sql, values);
            UtilityHelper.consoleLog("products table created successfully");

            return result == 0 ? false : true;
        }

        private void initializePriceTypeTable()
        {

        }

        private async Task<bool> initializeInvoiceTableAsync()
        {
            string sql = "CREATE TABLE invoices ";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "invoice_date DATETIME, ";
            sql += "invoice_number INTEGER, ";
            sql += "product_code VARCHAR(13), ";
            sql += "product_name VARCHAR(70), ";
            sql += "unit_measure INTEGER, ";
            sql += "quantity NUMERIC(15,3), ";
            sql += "retail_price NUMERIC(16,2), ";
            sql += "amount NUMERIC(16,2), ";
            sql += "recompense NUMERIC(6,2), ";
            sql += "tax_id INTEGER, ";
            sql += "tax1_percent NUMERIC(7,2), ";
            sql += "tax1_amount NUMERIC(16,2), ";
            sql += "tax2_percent NUMERIC(7,2), ";
            sql += "tax2_amount NUMERIC(16,2), ";
            sql += "tax3_percent NUMERIC(7,2), ";
            sql += "tax3_amount NUMERIC(16,2), ";
            sql += "discount NUMERIC(7,2), ";
            sql += "discount_amount NUMERIC(16,2), ";
            sql += "discount_cash NUMERIC(16,2), ";
            sql += "discount_payment NUMERIC(16,2), ";
            sql += "payment_type INTEGER, ";
            sql += "employee_id INTEGER, ";
            sql += "r1_type INTEGER, ";
            sql += "warehouse_id INTEGER, ";
            sql += "payment_device VARCHAR(25), ";
            sql += "business_space VARCHAR(25), ";
            sql += "zki VARCHAR(32), ";
            sql += "jir VARCHAR(36), ";

            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ";

            sql += ")";

            Object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("invoices table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create invoices table");
                return false;
            }
        }

        private async Task<bool> InitializeEmployeeListTable()
        {
            string sql = "CREATE TABLE employees ";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "code VARCHAR(25), ";
            sql += "password VARCHAR(75), ";
            sql += "name VARCHAR(75), ";
            sql += "oib VARCHAR(11), ";
            sql += "level VARCHAR(3), ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP";
            sql += ")";

            Object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("employeelist table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create employeelist table");
                return false;
            }
        }

        public async Task<bool> InitializeMessagesTableAsync()
        {
            string sql = "CREATE TABLE messages ";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "message VARCHAR(150), ";
            sql += "invoice_id INTEGER, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP";
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("Messages table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create Messages table");
                return false;
            }
        }



        public async Task<bool> InitializeLogTableAsync()
        {
            string sql = "CREATE TABLE logs ";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "program_name VARCHAR(25), ";
            sql += "user_id INTEGER, ";
            sql += "menu_name VARCHAR(50), ";
            sql += "begin_date DATETIME, ";
            sql += "end_date DATETIME, ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP";
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("Logs table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create Logs table");
                return false;
            }
        }



        public async Task<bool> InitializePaymentListTableAsync()
        {
            string sql = "CREATE TABLE payment_list ";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "code VARCHAR(7), ";
            sql += "fiscal VARCHAR(3), ";
            sql += "name VARCHAR(75), ";
            sql += "discount_payment DECIMAL(7,2), ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP";
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("PaymentList table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create PaymentList table");
                return false;
            }
        }


        public async Task<bool> InitializeProductListTableAsync()
        {
            string sql = "CREATE TABLE product_list ";
            sql += "(";
            sql += "id INTEGER PRIMARY KEY IDENTITY, ";
            sql += "code VARCHAR(13), ";
            sql += "barcode VARCHAR(50), ";
            sql += "group INTEGER, ";
            sql += "name VARCHAR(70), ";
            sql += "long_name VARCHAR(120), ";
            sql += "unit_of_measure_id INTEGER, ";
            sql += "partner_id INTEGER, ";
            sql += "vendor_price DECIMAL(16,2), ";
            sql += "wholesale_price DECIMAL(16,2), ";
            sql += "tax_price DECIMAL(16,2), ";
            sql += "retail_price DECIMAL(16,2), ";
            sql += "recompense DECIMAL(6,2), ";
            sql += "discount DECIMAL(10,2), ";
            sql += "tax_id INTEGER, ";
            sql += "min_stock DECIMAL(16,4), ";
            sql += "max_stock DECIMAL(16,4), ";
            sql += "stock DECIMAL(16,4), ";
            sql += "bom VARCHAR(3), ";
            sql += "serial_number VARCHAR(150), ";
            sql += "product_material VARCHAR(3), ";
            sql += "account_sales INTEGER, ";
            sql += "account_purchase INTEGER, ";
            sql += "account_in INTEGER, ";
            sql += "account_out INTEGER, ";
            sql += "account_asset INTEGER, ";
            sql += "garantie INTEGER, ";
            sql += "picture IMAGE, ";
            sql += "services VARCHAR(3), ";
            sql += "thickness DECIMAL(16,2), ";
            sql += "length DECIMAL(16,2), ";
            sql += "width DECIMAL(16,2), ";
            sql += "weight DECIMAL(16,2), ";
            sql += "active VARCHAR(3), ";
            sql += "created_at DATETIME DEFAULT CURRENT_TIMESTAMP, ";
            sql += "updated_at DATETIME DEFAULT CURRENT_TIMESTAMP";
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("ProductList table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create ProductList table");
                return false;
            }
        }



        public async Task<bool> InitializeUOMListTableAsync()
        {
            string sql = "CREATE TABLE uom_list ";
            sql += "(";
            sql += "ID INTEGER PRIMARY KEY IDENTITY, ";
            sql += "Code VARCHAR(7), ";
            sql += "Name VARCHAR(150), ";
            sql += "BaseUnit INTEGER, ";
            sql += "Ratio DECIMAL(16,7)";
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("UOMList table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create UOMList table");
                return false;
            }
        }

        public async Task<bool> InitializePERSONListTableAsync()
        {
            string sql = "CREATE TABLE person_list ";
            sql += "(";
            sql += "ID INTEGER PRIMARY KEY IDENTITY, ";
            sql += "Sifra VARCHAR(25), ";
            sql += "Lozinka VARCHAR(75), ";
            sql += "Naziv VARCHAR(75), ";
            sql += "OIB VARCHAR(11), ";
            sql += "Nivo VARCHAR(3)";
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("PERSONList table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create PERSONList table");
                return false;
            }
        }



        public async Task<bool> InitializeCalculationItemTableAsync()
        {
            string sql = "CREATE TABLE calculation_item ";
            sql += "(";
            sql += "ID INTEGER, ";
            sql += "CaclulacionID VARCHAR(20), ";
            sql += "PartnerCodeID INTEGER, ";
            sql += "PartnerName VARCHAR(30), ";
            sql += "OIB VARCHAR(11), ";
            sql += "CaclulacionDate DATE, ";
            sql += "Invoice VARCHAR(50), ";
            sql += "InvoiceModel VARCHAR(50), ";
            sql += "PaymentMark VARCHAR(4), ";
            sql += "InvoiceDate DATE, ";
            sql += "DeliverDate DATE, ";
            sql += "DueDate DATE, ";
            sql += "InvoiceAmount DECIMAL(12,2), ";
            sql += "Decimal1 DECIMAL(12,2), ";
            sql += "Decimal2 DECIMAL(12,2), ";
            sql += "Decimal3 DECIMAL(12,2), ";
            sql += "Decimal4 DECIMAL(12,2), ";
            sql += "Decimal5 DECIMAL(12,2), ";
            sql += "Decimal6 DECIMAL(12,2), ";
            sql += "Decimal7 DECIMAL(12,2), ";
            sql += "Decimal8 DECIMAL(12,2), ";
            sql += "Decimal9 DECIMAL(13,2), ";
            sql += "Decimal10 DECIMAL(12,2), ";
            sql += "Decimal11 DECIMAL(13,2), ";
            sql += "Decimal12 DECIMAL(13,2), ";
            sql += "Decimal13 DECIMAL(13,2), ";
            sql += "Decimal14 DECIMAL(13,2), ";
            sql += "Decimal15 DECIMAL(13,2), ";
            sql += "PayedAmount DECIMAL(13,2), ";
            sql += "Status VARCHAR(1), ";
            sql += "Picture VARCHAR(20), ";
            sql += "AccountingShop VARCHAR(3), ";
            sql += "PostingScheme VARCHAR(5), ";
            sql += "CodeBook VARCHAR(8), ";
            sql += "WarehousID VARCHAR(3), ";
            sql += "PaymentCode VARCHAR(3)";
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("CalculationItem table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create CalculationItem table");
                return false;
            }
        }


        public async Task<bool> InitializeCalculationHeaderTableAsync()
        {
            string sql = "CREATE TABLE calculation_header ";
            sql += "(";
            sql += "ID INTEGER, ";
            sql += "CaclulacionID VARCHAR(20), ";
            sql += "Code VARCHAR(13), ";
            sql += "Name VARCHAR(70), ";
            sql += "UnitOfMeasureID INTEGER, ";
            sql += "Quantity DECIMAL(15,3), ";
            sql += "Decimal1 DECIMAL(13,4), ";
            sql += "Thickness DECIMAL(12,2), ";
            sql += "Length DECIMAL(12,2), ";
            sql += "Width DECIMAL(12,2), ";
            sql += "Weight DECIMAL(12,2), ";
            sql += "VendorPrice DECIMAL(13,4), ";
            sql += "Discount1 DECIMAL(7,2), ";
            sql += "Decimal2 DECIMAL(12,2), ";
            sql += "Discount2 DECIMAL(7,2), ";
            sql += "Decimal3 DECIMAL(12,2), ";
            sql += "VendorTax DECIMAL(12,2), ";
            sql += "DependentCost DECIMAL(12,2), ";
            sql += "WholeSaleTotal DECIMAL(12,2), ";
            sql += "Margin DECIMAL(12,2), ";
            sql += "Decimal4 DECIMAL(12,2), ";
            sql += "AmountWithoutTax DECIMAL(12,2), ";
            sql += "PriceWithoutTax DECIMAL(12,2), ";
            sql += "Recompense DECIMAL(12,2), ";
            sql += "Decimal5 VARCHAR(4), ";
            sql += "TaxID INTEGER, ";
            sql += "Tax1Total DECIMAL(12,2), ";
            sql += "Tax2 DECIMAL(6,2), ";
            sql += "Tax2Total DECIMAL(12,2), ";
            sql += "RetailValue DECIMAL(12,2), ";
            sql += "RetailPriceManual INTEGER, ";
            sql += "RetailPrice INTEGER, ";
            sql += "AccountRetail VARCHAR(8), ";
            sql += "AccountAnalitic VARCHAR(8)";
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);

            if (rowsAffected >= 0)
            {
                UtilityHelper.consoleLog("CalculationHeader table created successfully");
                return true;
            }
            else
            {
                UtilityHelper.consoleLog("Failed to create CalculationHeader table");
                return false;
            }
        }



    }
}
