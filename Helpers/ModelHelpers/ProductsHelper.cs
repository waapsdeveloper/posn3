using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class ProductsHelper
    {
        SqliteHelper sqliteHelper;
        public ProductsHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public DataTable all()
        {
            string sql = "Select * from products";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("products table list");
            return dt;
        }

        public bool insert(
            DateTime? accounting_date,
            string document,
            int? account_id,
            int? unit_measure,
            string description,
            decimal in_value,
            decimal out_value,
            decimal price,
            string price_type,
            decimal debit,
            decimal credit,
            int partner_id,
            int tax_id,
            int warehouse_id)
        {
            string sql = "INSERT INTO products ";
            sql += "(";
            sql += "accounting_date, document, account_id, unit_measure, description, in_value, out_value, price, price_type, debit, credit, partner_id, tax_id, warehouse_id, creation_date, update_date";
            sql += ")";

            sql += " VALUES ";

            sql += "(";
            sql += $"'{accounting_date}', ";
            sql += $"'{document}', ";
            sql += $"{account_id}, ";
            sql += $"{unit_measure}, ";
            sql += $"'{description}', ";
            sql += $"{in_value.ToString("0.000")}, ";
            sql += $"{out_value.ToString("0.000")}, ";
            sql += $"{price.ToString("0.00")}, ";
            sql += $"'{price_type}', ";
            sql += $"{debit.ToString("0.00")}, ";
            sql += $"{credit.ToString("0.00")}, ";
            sql += $"{partner_id}, ";
            sql += $"{tax_id}, ";
            sql += $"{warehouse_id} ";
            sql += ")";

            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);
            return rowsAffected > 0;
        }

        public bool update(int id,
            DateTime? accounting_date,
            string document,
            int? account_id,
            int? unit_measure,
            string description,
            decimal in_value,
            decimal out_value,
            decimal price,
            string price_type,
            decimal debit,
            decimal credit,
            int partner_id,
            int tax_id,
            int warehouse_id)
        {
            try
            {
                string sqla = "UPDATE roles SET ";
                sqla += "accounting_date = '" + accounting_date + "', ";
                sqla += "document = '" + document + "', ";
                sqla += "account_id = " + account_id + ", ";
                sqla += "unit_measure = " + unit_measure + ", ";
                sqla += "description = '" + description + "', ";
                sqla += "in_value = " + in_value.ToString("0.000") + ", ";
                sqla += "out_value = " + out_value.ToString("0.000") + ", ";
                sqla += "price = " + price.ToString("0.00") + ", ";
                sqla += "price_type = '" + price_type + "', ";
                sqla += "debit = " + debit.ToString("0.00") + ", ";
                sqla += "credit = " + credit.ToString("0.00") + ", ";
                sqla += "partner_id = " + partner_id + ", ";
                sqla += "tax_id = " + tax_id + ", ";
                sqla += "warehouse_id = " + warehouse_id + " ";               
                sqla += "WHERE id = " + id;

                object[] valuesa = { };

                var ra = sqliteHelper.execute(sqla, valuesa);
                return ra == 0 ? false : true;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error: " + ex.Message);
                return false;
            }
        }


        public bool delete(int id) {

            string sql = "DELETE FROM products ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
