using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class ProductsListHelper
    {
        SqliteHelper sqliteHelper;
        public ProductsListHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "SELECT * FROM product_list";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("product_list table list");
            return dt;
        }

        public async Task<bool> insertAsync(
            string code = null,
            string barcode = null,
            int? group = null,
            string name = null,
            string long_name = null,
            int? unit_of_measure_id = null,
            int? partner_id = null,
            decimal? vendor_price = null,
            decimal? wholesale_price = null,
            decimal? tax_price = null,
            decimal? retail_price = null,
            decimal? recompense = null,
            decimal? discount = null,
            int? tax_id = null,
            decimal? min_stock = null,
            decimal? max_stock = null,
            decimal? stock = null,
            string bom = null,
            string serial_number = null,
            string product_material = null,
            int? account_sales = null,
            int? account_purchase = null,
            int? account_in = null,
            int? account_out = null,
            int? account_asset = null,
            int? garantie = null,
            byte[] picture = null,
            string services = null,
            decimal? thickness = null,
            decimal? length = null,
            decimal? width = null,
            decimal? weight = null,
            string active = null)
        {
            string sql = "INSERT INTO product_list ";
            sql += "(";

            List<string> columns = new List<string>();
            List<object> columnValues = new List<object>();

            AddColumnIfValueNotNull(columns, columnValues, "code", code);
            AddColumnIfValueNotNull(columns, columnValues, "barcode", barcode);
            AddColumnIfValueNotNull(columns, columnValues, "group", group);
            AddColumnIfValueNotNull(columns, columnValues, "name", name);
            AddColumnIfValueNotNull(columns, columnValues, "long_name", long_name);
            AddColumnIfValueNotNull(columns, columnValues, "unit_of_measure_id", unit_of_measure_id);
            AddColumnIfValueNotNull(columns, columnValues, "partner_id", partner_id);
            AddColumnIfValueNotNull(columns, columnValues, "vendor_price", vendor_price);
            AddColumnIfValueNotNull(columns, columnValues, "wholesale_price", wholesale_price);
            AddColumnIfValueNotNull(columns, columnValues, "tax_price", tax_price);
            AddColumnIfValueNotNull(columns, columnValues, "retail_price", retail_price);
            AddColumnIfValueNotNull(columns, columnValues, "recompense", recompense);
            AddColumnIfValueNotNull(columns, columnValues, "discount", discount);
            AddColumnIfValueNotNull(columns, columnValues, "tax_id", tax_id);
            AddColumnIfValueNotNull(columns, columnValues, "min_stock", min_stock);
            AddColumnIfValueNotNull(columns, columnValues, "max_stock", max_stock);
            AddColumnIfValueNotNull(columns, columnValues, "stock", stock);
            AddColumnIfValueNotNull(columns, columnValues, "bom", bom);
            AddColumnIfValueNotNull(columns, columnValues, "serial_number", serial_number);
            AddColumnIfValueNotNull(columns, columnValues, "product_material", product_material);
            AddColumnIfValueNotNull(columns, columnValues, "account_sales", account_sales);
            AddColumnIfValueNotNull(columns, columnValues, "account_purchase", account_purchase);
            AddColumnIfValueNotNull(columns, columnValues, "account_in", account_in);
            AddColumnIfValueNotNull(columns, columnValues, "account_out", account_out);
            AddColumnIfValueNotNull(columns, columnValues, "account_asset", account_asset);
            AddColumnIfValueNotNull(columns, columnValues, "garantie", garantie);
            AddColumnIfValueNotNull(columns, columnValues, "picture", picture);
            AddColumnIfValueNotNull(columns, columnValues, "services", services);
            AddColumnIfValueNotNull(columns, columnValues, "thickness", thickness);
            AddColumnIfValueNotNull(columns, columnValues, "length", length);
            AddColumnIfValueNotNull(columns, columnValues, "width", width);
            AddColumnIfValueNotNull(columns, columnValues, "weight", weight);
            AddColumnIfValueNotNull(columns, columnValues, "active", active);

            sql += string.Join(", ", columns);
            sql += ") VALUES (";
            sql += string.Join(", ", columnValues);
            sql += ")";

            object[] values = columnValues.ToArray();

            var rowsAffected = sqliteHelper.execute(sql, values);
            return rowsAffected > 0;
        }

        public async Task<bool> updateAsync(int id,
            string code = null,
            string barcode = null,
            int? group = null,
            string name = null,
            string long_name = null,
            int? unit_of_measure_id = null,
            int? partner_id = null,
            decimal? vendor_price = null,
            decimal? wholesale_price = null,
            decimal? tax_price = null,
            decimal? retail_price = null,
            decimal? recompense = null,
            decimal? discount = null,
            int? tax_id = null,
            decimal? min_stock = null,
            decimal? max_stock = null,
            decimal? stock = null,
            string bom = null,
            string serial_number = null,
            string product_material = null,
            int? account_sales = null,
            int? account_purchase = null,
            int? account_in = null,
            int? account_out = null,
            int? account_asset = null,
            int? garantie = null,
            byte[] picture = null,
            string services = null,
            decimal? thickness = null,
            decimal? length = null,
            decimal? width = null,
            decimal? weight = null,
            string active = null)
        {
            try
            {
                string sql = "UPDATE product_list SET ";

                List<string> columns = new List<string>();
                List<object> columnValues = new List<object>();

                AddColumnIfValueNotNull(columns, columnValues, "code", code);
                AddColumnIfValueNotNull(columns, columnValues, "barcode", barcode);
                AddColumnIfValueNotNull(columns, columnValues, "group", group);
                AddColumnIfValueNotNull(columns, columnValues, "name", name);
                AddColumnIfValueNotNull(columns, columnValues, "long_name", long_name);
                AddColumnIfValueNotNull(columns, columnValues, "unit_of_measure_id", unit_of_measure_id);
                AddColumnIfValueNotNull(columns, columnValues, "partner_id", partner_id);
                AddColumnIfValueNotNull(columns, columnValues, "vendor_price", vendor_price);
                AddColumnIfValueNotNull(columns, columnValues, "wholesale_price", wholesale_price);
                AddColumnIfValueNotNull(columns, columnValues, "tax_price", tax_price);
                AddColumnIfValueNotNull(columns, columnValues, "retail_price", retail_price);
                AddColumnIfValueNotNull(columns, columnValues, "recompense", recompense);
                AddColumnIfValueNotNull(columns, columnValues, "discount", discount);
                AddColumnIfValueNotNull(columns, columnValues, "tax_id", tax_id);
                AddColumnIfValueNotNull(columns, columnValues, "min_stock", min_stock);
                AddColumnIfValueNotNull(columns, columnValues, "max_stock", max_stock);
                AddColumnIfValueNotNull(columns, columnValues, "stock", stock);
                AddColumnIfValueNotNull(columns, columnValues, "bom", bom);
                AddColumnIfValueNotNull(columns, columnValues, "serial_number", serial_number);
                AddColumnIfValueNotNull(columns, columnValues, "product_material", product_material);
                AddColumnIfValueNotNull(columns, columnValues, "account_sales", account_sales);
                AddColumnIfValueNotNull(columns, columnValues, "account_purchase", account_purchase);
                AddColumnIfValueNotNull(columns, columnValues, "account_in", account_in);
                AddColumnIfValueNotNull(columns, columnValues, "account_out", account_out);
                AddColumnIfValueNotNull(columns, columnValues, "account_asset", account_asset);
                AddColumnIfValueNotNull(columns, columnValues, "garantie", garantie);
                AddColumnIfValueNotNull(columns, columnValues, "picture", picture);
                AddColumnIfValueNotNull(columns, columnValues, "services", services);
                AddColumnIfValueNotNull(columns, columnValues, "thickness", thickness);
                AddColumnIfValueNotNull(columns, columnValues, "length", length);
                AddColumnIfValueNotNull(columns, columnValues, "width", width);
                AddColumnIfValueNotNull(columns, columnValues, "weight", weight);
                AddColumnIfValueNotNull(columns, columnValues, "active", active);

                sql += string.Join(", ", columns);
                sql += " WHERE id = " + id;

                object[] values = columnValues.ToArray();

                var rowsAffected = sqliteHelper.execute(sql, values);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("Product Update Error: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> deleteAsync(int id)
        {
            string sql = "DELETE FROM product_list ";
            sql += " WHERE id = " + id;
            object[] values = { };

            var rowsAffected = sqliteHelper.execute(sql, values);
            return rowsAffected > 0;
        }

        private void AddColumnIfValueNotNull(List<string> columns, List<object> columnValues, string columnName, object value)
        {
            if (value != null)
            {
                columns.Add(columnName);
                columnValues.Add(value);
            }
        }
    }
}
