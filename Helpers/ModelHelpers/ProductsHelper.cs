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

        public async Task<DataTable> all()
        {
            string sql = "Select * from products";

            object[] values = { };
            DataTable dt = await sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("products table list");
            return dt;
        }

        public async Task<bool> insertAsync(
            DateTime? accounting_date = null,
            string document = null,
            int? account_id = null,
            int? unit_measure = null,
            string? description = null,
            decimal? in_value = null,
            decimal? out_value = null,
            decimal? price = null,
            int? price_type = null,
            decimal? debit = null,
            decimal? credit = null,
            int? partner_id = null,
            int? tax_id = null,
            int? warehouse_id = null)
        {
            string sql = "INSERT INTO products ";

            sql += "(";

            if (accounting_date != null)
            {
                sql += "accounting_date,";
            }
            if (!string.IsNullOrEmpty(document))
            {
                sql += "document,";
            }
            if (account_id.HasValue)
            {
                sql += "account_id,";
            }
            if (unit_measure.HasValue)
            {
                sql += "unit_measure,";
            }
            if (!string.IsNullOrEmpty(description))
            {
                sql += "description,";
            }
            if (in_value.HasValue)
            {
                sql += "in_value,";
            }
            if (out_value.HasValue)
            {
                sql += "out_value,";
            }
            if (price.HasValue)
            {
                sql += "price,";
            }
            if (price_type.HasValue)
            {
                sql += "price_type,";
            }
            if (debit.HasValue)
            {
                sql += "debit,";
            }
            if (credit.HasValue)
            {
                sql += "credit,";
            }
            if (partner_id.HasValue)
            {
                sql += "partner_id,";
            }
            if (tax_id.HasValue)
            {
                sql += "tax_id,";
            }
            if (warehouse_id.HasValue)
            {
                sql += "warehouse_id,";
            }

            if (sql.EndsWith(","))
            {
                sql = sql.TrimEnd(',') + ")";
            }

            sql += " VALUES (";

            if (accounting_date != null)
            {
                sql += $"'{accounting_date}', ";
            }
            if (!string.IsNullOrEmpty(document))
            {
                sql += $"'{document}', ";
            }
            if (account_id.HasValue)
            {
                sql += $"{account_id}, ";
            }
            if (unit_measure.HasValue)
            {
                sql += $"{unit_measure}, ";
            }
            if (!string.IsNullOrEmpty(description))
            {
                sql += $"'{description}', ";
            }
            if (in_value.HasValue)
            {
                sql += $"{in_value.Value.ToString("0.000")}, ";
            }
            if (out_value.HasValue)
            {
                sql += $"{out_value.Value.ToString("0.000")}, ";
            }
            if (price.HasValue)
            {
                sql += $"{price.Value.ToString("0.00")}, ";
            }
            if (price_type.HasValue)
            {
                sql += $"{price_type}, ";
            }
            if (debit.HasValue)
            {
                sql += $"{debit.Value.ToString("0.00")}, ";
            }
            if (credit.HasValue)
            {
                sql += $"{credit.Value.ToString("0.00")}, ";
            }
            if (partner_id.HasValue)
            {
                sql += $"{partner_id}, ";
            }
            if (tax_id.HasValue)
            {
                sql += $"{tax_id}, ";
            }
            if (warehouse_id.HasValue)
            {
                sql += $"{warehouse_id}, ";
            }

            if (sql.EndsWith(", "))
            {
                sql = sql.TrimEnd(',', ' ') + ")";
            }

            object[] values = { };

            var rowsAffected = await sqliteHelper.execute(sql, values);
            return rowsAffected > 0;
        }


        public async Task<bool> updateAsync(int id,
            DateTime? accounting_date,
            string document,
            int? account_id,
            int? unit_measure,
            string description,
            decimal in_value,
            decimal out_value,
            decimal price,
            int? price_type,
            decimal debit,
            decimal credit,
            int? partner_id,
            int? tax_id,
            int? warehouse_id)
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
                sqla += "price_type = " + price_type + ", ";
                sqla += "debit = " + debit.ToString("0.00") + ", ";
                sqla += "credit = " + credit.ToString("0.00") + ", ";
                sqla += "partner_id = " + partner_id + ", ";
                sqla += "tax_id = " + tax_id + ", ";
                sqla += "warehouse_id = " + warehouse_id + " ";               
                sqla += "WHERE id = " + id;

                object[] valuesa = { };

                var ra = await sqliteHelper.execute(sqla, valuesa);
                return ra == 0 ? false : true;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("User Update Error: " + ex.Message);
                return false;
            }
        }


        public async Task<bool> deleteAsync(int id) {

            string sql = "DELETE FROM products ";

            sql += " WHERE ";
            sql += "id = " + id;
            object[] valuesa = { };

            var ra = await sqliteHelper.execute(sql, valuesa);
            return ra == 0 ? false : true;

        }
    }
}
