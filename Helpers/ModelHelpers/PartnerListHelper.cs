using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class PartnerListHelper
    {
        SqliteHelper sqliteHelper;
        public PartnerListHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "Select * from partner_list";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("partner_list table list");
            return dt;
        }

        public async Task<bool> insertAsync(string name, string code, string long_name, string address, int? city_id, string mb, string oib, string in_tax_system, string tax_type, bool is_customer, bool is_vendor, string iban, string phone, string telefax, string mobile_phone, string mail, string web, int? customer_account, int? vendor_account, int? person, decimal customer_discount, decimal vendor_discount, int? customer_due_date, int? vendor_due_date, bool active)
        {
            string sql = "INSERT INTO partner_list ";
            sql += "(";
            sql += "name, ";
            sql += "code, ";
            sql += "long_name, ";
            sql += "address, ";
            sql += "city_id, ";
            sql += "mb, ";
            sql += "oib, ";
            sql += "in_tax_system, ";
            sql += "tax_type, ";
            sql += "is_customer, ";
            sql += "is_vendor, ";
            sql += "iban, ";
            sql += "phone, ";
            sql += "telefax, ";
            sql += "mobile_phone, ";
            sql += "mail, ";
            sql += "web, ";
            sql += "customer_account, ";
            sql += "vendor_account, ";
            sql += "person, ";
            sql += "customer_discount, ";
            sql += "vendor_discount, ";
            sql += "customer_due_date, ";
            sql += "vendor_due_date, ";
            sql += "active";
            sql += ")";

            sql += " VALUES ";

            sql += "(";
            sql += "'" + name + "', ";
            sql += "'" + code + "', ";
            sql += "'" + long_name + "', ";
            sql += "'" + address + "', ";
            sql += (city_id.HasValue ? city_id.Value.ToString() : "NULL") + ", ";
            sql += "'" + mb + "', ";
            sql += "'" + oib + "', ";
            sql += "'" + in_tax_system + "', ";
            sql += "'" + tax_type + "', ";
            sql += (is_customer ? "1" : "0") + ", ";
            sql += (is_vendor ? "1" : "0") + ", ";
            sql += "'" + iban + "', ";
            sql += "'" + phone + "', ";
            sql += "'" + telefax + "', ";
            sql += "'" + mobile_phone + "', ";
            sql += "'" + mail + "', ";
            sql += "'" + web + "', ";
            sql += (customer_account.HasValue ? customer_account.Value.ToString() : "NULL") + ", ";
            sql += (vendor_account.HasValue ? vendor_account.Value.ToString() : "NULL") + ", ";
            sql += (person.HasValue ? person.Value.ToString() : "NULL") + ", ";
            sql += customer_discount.ToString() + ", ";
            sql += vendor_discount.ToString() + ", ";
            sql += (customer_due_date.HasValue ? "'" + customer_due_date.Value.ToString() + "'" : "NULL") + ", ";
            sql += (vendor_due_date.HasValue ? "'" + vendor_due_date.Value.ToString() + "'" : "NULL") + ", ";
            sql += (active ? "1" : "0");
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);
            return rowsAffected > 0;
        }

        public async Task<bool> updateAsync(int id, string code, string name, string long_name, string address, int? city_id, string mb, string oib, string in_tax_system, string tax_type, bool is_customer, bool is_vendor, string iban, string phone, string telefax, string mobile_phone, string mail, string web, int? customer_account, int? vendor_account, int? person, decimal customer_discount, decimal vendor_discount, int? customer_due_date, int? vendor_due_date, bool active)
        {
            try
            {
                string sql = "UPDATE partner_list SET ";
                sql += "code = '" + code + "', ";
                sql += "name = '" + name + "', ";
                sql += "long_name = '" + long_name + "', ";
                sql += "address = '" + address + "', ";
                sql += "city_id = " + (city_id.HasValue ? city_id.Value.ToString() : "NULL") + ", ";
                sql += "mb = '" + mb + "', ";
                sql += "oib = '" + oib + "', ";
                sql += "in_tax_system = '" + in_tax_system + "', ";
                sql += "tax_type = '" + tax_type + "', ";
                sql += "is_customer = " + (is_customer ? "1" : "0") + ", ";
                sql += "is_vendor = " + (is_vendor ? "1" : "0") + ", ";
                sql += "iban = '" + iban + "', ";
                sql += "phone = '" + phone + "', ";
                sql += "telefax = '" + telefax + "', ";
                sql += "mobile_phone = '" + mobile_phone + "', ";
                sql += "mail = '" + mail + "', ";
                sql += "web = '" + web + "', ";
                sql += "customer_account = " + (customer_account.HasValue ? customer_account.Value.ToString() : "NULL") + ", ";
                sql += "vendor_account = " + (vendor_account.HasValue ? vendor_account.Value.ToString() : "NULL") + ", ";
                sql += "person = " + (person.HasValue ? person.Value.ToString() : "NULL") + ", ";
                sql += "customer_discount = " + customer_discount.ToString("0.00") + ", ";
                sql += "vendor_discount = " + vendor_discount.ToString("0.00") + ", ";
                sql += "customer_due_date = " + (customer_due_date.HasValue ? customer_due_date.Value.ToString() : "NULL") + ", ";
                sql += "vendor_due_date = " + (vendor_due_date.HasValue ? vendor_due_date.Value.ToString() : "NULL") + ", ";
                sql += "active = " + (active ? "1" : "0") + " ";
                sql += "WHERE id = " + id;

                object[] values = { };

                var rowsAffected = sqliteHelper.execute(sql, values);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("user_update Error: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> deleteAsync(int id) {

            string sql = "DELETE FROM partner_list ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
