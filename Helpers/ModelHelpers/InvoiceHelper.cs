using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class InvoiceHelper
    {
        SqliteHelper sqliteHelper;
        public InvoiceHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "SELECT * FROM invoices";

            object[] values = { };
            DataTable dt = await sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("Invoices table retrieved successfully");
            return dt;
        }

        public async Task<DataTable> GetByInvoiceNumber(int invoiceNumber)
        {
            string sql = "SELECT * FROM invoices ";
            sql += "WHERE ";
            sql += "invoice_number = ";
            sql += invoiceNumber.ToString();

            object[] values = { };

            var result = await sqliteHelper.executeData(sql, values);
            return result;
        }

        public async Task<bool> insertAsync(
            DateTime? invoice_date,
            int? invoice_number,
            string product_code,
            string product_name,
            int? unit_measure,
            decimal? quantity,
            decimal? retail_price,
            decimal? amount,
            decimal? recompense,
            int? tay_id,
            decimal? tax1_percent,
            decimal? tax1_amount,
            decimal? tax2_percent,
            decimal? tax2_amount,
            decimal? tax3_percent,
            decimal? tax3_amount,
            decimal? discount,
            decimal? discount_amount,
            decimal? discount_cash,
            decimal? discount_payment,
            int? payment_type,
            int? employee_id,
            bool? r1_type,
            int? warehouse_id,
            string payment_device,
            string business_space,
            string zki,
            string jir)
        {
            try
            {
                string sql = "INSERT INTO invoices ";
                sql += "(";

                List<string> columns = new List<string>();
                List<string> values = new List<string>();

                if (invoice_date.HasValue)
                {
                    columns.Add("invoice_date");
                    values.Add($"'{invoice_date.Value.ToString("yyyy-MM-dd")}'");
                }
                if (invoice_number.HasValue)
                {
                    columns.Add("invoice_number");
                    values.Add($"{invoice_number}");
                }
                if (!string.IsNullOrEmpty(product_code))
                {
                    columns.Add("product_code");
                    values.Add($"'{product_code}'");
                }
                if (!string.IsNullOrEmpty(product_name))
                {
                    columns.Add("product_name");
                    values.Add($"'{product_name}'");
                }
                if (unit_measure.HasValue)
                {
                    columns.Add("unit_measure");
                    values.Add($"{unit_measure}");
                }
                if (quantity.HasValue)
                {
                    columns.Add("quantity");
                    values.Add($"{quantity.Value.ToString("0.###")}");
                }
                if (retail_price.HasValue)
                {
                    columns.Add("retail_price");
                    values.Add($"{retail_price.Value.ToString("0.##")}");
                }
                if (amount.HasValue)
                {
                    columns.Add("amount");
                    values.Add($"{amount.Value.ToString("0.##")}");
                }
                if (recompense.HasValue)
                {
                    columns.Add("recompense");
                    values.Add($"{recompense.Value.ToString("0.##")}");
                }
                if (tay_id.HasValue)
                {
                    columns.Add("tay_id");
                    values.Add($"{tay_id}");
                }
                if (tax1_percent.HasValue)
                {
                    columns.Add("tax1_percent");
                    values.Add($"{tax1_percent.Value.ToString("0.##")}");
                }
                if (tax1_amount.HasValue)
                {
                    columns.Add("tax1_amount");
                    values.Add($"{tax1_amount.Value.ToString("0.##")}");
                }
                if (tax2_percent.HasValue)
                {
                    columns.Add("tax2_percent");
                    values.Add($"{tax2_percent.Value.ToString("0.##")}");
                }
                if (tax2_amount.HasValue)
                {
                    columns.Add("tax2_amount");
                    values.Add($"{tax2_amount.Value.ToString("0.##")}");
                }
                if (tax3_percent.HasValue)
                {
                    columns.Add("tax3_percent");
                    values.Add($"{tax3_percent.Value.ToString("0.##")}");
                }
                if (tax3_amount.HasValue)
                {
                    columns.Add("tax3_amount");
                    values.Add($"{tax3_amount.Value.ToString("0.##")}");
                }
                if (discount.HasValue)
                {
                    columns.Add("discount");
                    values.Add($"{discount.Value.ToString("0.##")}");
                }
                if (discount_amount.HasValue)
                {
                    columns.Add("discount_amount");
                    values.Add($"{discount_amount.Value.ToString("0.##")}");
                }
                if (discount_cash.HasValue)
                {
                    columns.Add("discount_cash");
                    values.Add($"{discount_cash.Value.ToString("0.##")}");
                }
                if (discount_payment.HasValue)
                {
                    columns.Add("discount_payment");
                    values.Add($"{discount_payment.Value.ToString("0.##")}");
                }
                if (payment_type.HasValue)
                {
                    columns.Add("payment_type");
                    values.Add($"{payment_type}");
                }
                if (employee_id.HasValue)
                {
                    columns.Add("employee_id");
                    values.Add($"{employee_id}");
                }
                if (r1_type.HasValue)
                {
                    columns.Add("r1_type");
                    values.Add($"{(r1_type.Value ? 1 : 0)}");
                }
                if (warehouse_id.HasValue)
                {
                    columns.Add("warehouse_id");
                    values.Add($"{warehouse_id}");
                }
                if (!string.IsNullOrEmpty(payment_device))
                {
                    columns.Add("payment_device");
                    values.Add($"'{payment_device}'");
                }
                if (!string.IsNullOrEmpty(business_space))
                {
                    columns.Add("business_space");
                    values.Add($"'{business_space}'");
                }
                if (!string.IsNullOrEmpty(zki))
                {
                    columns.Add("zki");
                    values.Add($"'{zki}'");
                }
                if (!string.IsNullOrEmpty(jir))
                {
                    columns.Add("jir");
                    values.Add($"'{jir}'");
                }

                sql += string.Join(", ", columns);
                sql += ")";
                sql += " VALUES ";
                sql += "(";
                sql += string.Join(", ", values);
                sql += ")";

                object[] sqlParams = { };

                var rowsAffected = await sqliteHelper.execute(sql, sqlParams);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("Invoice Insert Error: " + ex.Message);
                return false;
            }
        }


        public async Task<bool> updateAsync(
            int id,
            DateTime? invoice_date,
            int? invoice_number,
            string product_code,
            string product_name,
            int? unit_measure,
            decimal? quantity,
            decimal? retail_price,
            decimal? amount,
            decimal? recompense,
            int? tay_id,
            decimal? tax1_percent,
            decimal? tax1_amount,
            decimal? tax2_percent,
            decimal? tax2_amount,
            decimal? tax3_percent,
            decimal? tax3_amount,
            decimal? discount,
            decimal? discount_amount,
            decimal? discount_cash,
            decimal? discount_payment,
            int? payment_type,
            int? employee_id,
            bool? r1_type,
            int? warehouse_id,
            string payment_device,
            string business_space,
            string zki,
            string jir)
        {
            try
            {
                string sql = "UPDATE invoices SET ";

                List<string> updateStatements = new List<string>();

                if (invoice_date.HasValue)
                    updateStatements.Add($"invoice_date = '{invoice_date.Value.ToString("yyyy-MM-dd")}'");
                if (invoice_number.HasValue)
                    updateStatements.Add($"invoice_number = {invoice_number}");
                if (!string.IsNullOrEmpty(product_code))
                    updateStatements.Add($"product_code = '{product_code}'");
                if (!string.IsNullOrEmpty(product_name))
                    updateStatements.Add($"product_name = '{product_name}'");
                if (unit_measure.HasValue)
                    updateStatements.Add($"unit_measure = {unit_measure}");
                if (quantity.HasValue)
                    updateStatements.Add($"quantity = {quantity.Value.ToString("0.###")}");
                if (retail_price.HasValue)
                    updateStatements.Add($"retail_price = {retail_price.Value.ToString("0.##")}");
                if (amount.HasValue)
                    updateStatements.Add($"amount = {amount.Value.ToString("0.##")}");
                if (recompense.HasValue)
                    updateStatements.Add($"recompense = {recompense.Value.ToString("0.##")}");
                if (tay_id.HasValue)
                    updateStatements.Add($"tay_id = {tay_id}");
                if (tax1_percent.HasValue)
                    updateStatements.Add($"tax1_percent = {tax1_percent.Value.ToString("0.##")}");
                if (tax1_amount.HasValue)
                    updateStatements.Add($"tax1_amount = {tax1_amount.Value.ToString("0.##")}");
                if (tax2_percent.HasValue)
                    updateStatements.Add($"tax2_percent = {tax2_percent.Value.ToString("0.##")}");
                if (tax2_amount.HasValue)
                    updateStatements.Add($"tax2_amount = {tax2_amount.Value.ToString("0.##")}");
                if (tax3_percent.HasValue)
                    updateStatements.Add($"tax3_percent = {tax3_percent.Value.ToString("0.##")}");
                if (tax3_amount.HasValue)
                    updateStatements.Add($"tax3_amount = {tax3_amount.Value.ToString("0.##")}");
                if (discount.HasValue)
                    updateStatements.Add($"discount = {discount.Value.ToString("0.##")}");
                if (discount_amount.HasValue)
                    updateStatements.Add($"discount_amount = {discount_amount.Value.ToString("0.##")}");
                if (discount_cash.HasValue)
                    updateStatements.Add($"discount_cash = {discount_cash.Value.ToString("0.##")}");
                if (discount_payment.HasValue)
                    updateStatements.Add($"discount_payment = {discount_payment.Value.ToString("0.##")}");
                if (payment_type.HasValue)
                    updateStatements.Add($"payment_type = {payment_type}");
                if (employee_id.HasValue)
                    updateStatements.Add($"employee_id = {employee_id}");
                if (r1_type.HasValue)
                    updateStatements.Add($"r1_type = {(r1_type.Value ? 1 : 0)}");
                if (warehouse_id.HasValue)
                    updateStatements.Add($"warehouse_id = {warehouse_id}");
                if (!string.IsNullOrEmpty(payment_device))
                    updateStatements.Add($"payment_device = '{payment_device}'");
                if (!string.IsNullOrEmpty(business_space))
                    updateStatements.Add($"business_space = '{business_space}'");
                if (!string.IsNullOrEmpty(zki))
                    updateStatements.Add($"zki = '{zki}'");
                if (!string.IsNullOrEmpty(jir))
                    updateStatements.Add($"jir = '{jir}'");

                sql += string.Join(", ", updateStatements);
                sql += $" WHERE id = {id}";

                object[] sqlParams = { };

                var rowsAffected = await sqliteHelper.execute(sql, sqlParams);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("Invoice Update Error: " + ex.Message);
                return false;
            }
        }


        public async Task<bool> deleteAsync(int id)
        {
            string sql = "DELETE FROM invoices ";
            sql += $"WHERE id = {id}";

            object[] values = { };

            var rowsAffected = await sqliteHelper.execute(sql, values);
            return rowsAffected > 0;
        }
    }
}
