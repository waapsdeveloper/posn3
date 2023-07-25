using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class ItemListHelper
    {
        SqliteHelper sqliteHelper;
        public ItemListHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "SELECT * FROM calculation_item";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("CalculationItem table fetched successfully");
            return dt;
        }

        public async Task<DataTable> getByCaclulacionId(string caclulacionId)
        {
            string sql = "SELECT * FROM calculation_item ";
            sql += "WHERE caclulacion_id = '" + caclulacionId + "'";

            object[] values = { };
            var result = sqliteHelper.executeData(sql, values);
            return result;
        }

        public async Task<bool> insertAsync(string caclulacionId, int? partnerCodeId = null, string partnerName = null, string oib = null, DateTime? caclulacionDate = null,
                                           string invoice = null, string invoiceModel = null, string paymentMark = null, DateTime? invoiceDate = null, DateTime? deliverDate = null,
                                           DateTime? dueDate = null, decimal? invoiceAmount = null, decimal? payedAmount = null, string status = null, string picture = null,
                                           string accountingShop = null, string postingScheme = null, string codeBook = null, string warehousId = null, string paymentCode = null)
        {
            try
            {
                string sql = "INSERT INTO calculation_item ";
                sql += "(";
                sql += "caclulacion_id";
                if (partnerCodeId.HasValue) sql += ", partner_code_id";
                if (!string.IsNullOrEmpty(partnerName)) sql += ", partner_name";
                if (!string.IsNullOrEmpty(oib)) sql += ", oib";
                if (caclulacionDate.HasValue) sql += ", caclulacion_date";
                if (!string.IsNullOrEmpty(invoice)) sql += ", invoice";
                if (!string.IsNullOrEmpty(invoiceModel)) sql += ", invoice_model";
                if (!string.IsNullOrEmpty(paymentMark)) sql += ", payment_mark";
                if (invoiceDate.HasValue) sql += ", invoice_date";
                if (deliverDate.HasValue) sql += ", deliver_date";
                if (dueDate.HasValue) sql += ", due_date";
                if (invoiceAmount.HasValue) sql += ", invoice_amount";
                if (payedAmount.HasValue) sql += ", payed_amount";
                if (!string.IsNullOrEmpty(status)) sql += ", status";
                if (!string.IsNullOrEmpty(picture)) sql += ", picture";
                if (!string.IsNullOrEmpty(accountingShop)) sql += ", accounting_shop";
                if (!string.IsNullOrEmpty(postingScheme)) sql += ", posting_scheme";
                if (!string.IsNullOrEmpty(codeBook)) sql += ", code_book";
                if (!string.IsNullOrEmpty(warehousId)) sql += ", warehous_id";
                if (!string.IsNullOrEmpty(paymentCode)) sql += ", payment_code";
                sql += ")";
                sql += " VALUES ";
                sql += "(";
                sql += "'" + caclulacionId + "'";
                if (partnerCodeId.HasValue) sql += ", " + partnerCodeId;
                if (!string.IsNullOrEmpty(partnerName)) sql += ", '" + partnerName + "'";
                if (!string.IsNullOrEmpty(oib)) sql += ", '" + oib + "'";
                if (caclulacionDate.HasValue) sql += ", '" + caclulacionDate.Value.ToString("yyyy-MM-dd") + "'";
                if (!string.IsNullOrEmpty(invoice)) sql += ", '" + invoice + "'";
                if (!string.IsNullOrEmpty(invoiceModel)) sql += ", '" + invoiceModel + "'";
                if (!string.IsNullOrEmpty(paymentMark)) sql += ", '" + paymentMark + "'";
                if (invoiceDate.HasValue) sql += ", '" + invoiceDate.Value.ToString("yyyy-MM-dd") + "'";
                if (deliverDate.HasValue) sql += ", '" + deliverDate.Value.ToString("yyyy-MM-dd") + "'";
                if (dueDate.HasValue) sql += ", '" + dueDate.Value.ToString("yyyy-MM-dd") + "'";
                if (invoiceAmount.HasValue) sql += ", " + invoiceAmount;
                if (payedAmount.HasValue) sql += ", " + payedAmount;
                if (!string.IsNullOrEmpty(status)) sql += ", '" + status + "'";
                if (!string.IsNullOrEmpty(picture)) sql += ", '" + picture + "'";
                if (!string.IsNullOrEmpty(accountingShop)) sql += ", '" + accountingShop + "'";
                if (!string.IsNullOrEmpty(postingScheme)) sql += ", '" + postingScheme + "'";
                if (!string.IsNullOrEmpty(codeBook)) sql += ", '" + codeBook + "'";
                if (!string.IsNullOrEmpty(warehousId)) sql += ", '" + warehousId + "'";
                if (!string.IsNullOrEmpty(paymentCode)) sql += ", '" + paymentCode + "'";
                sql += ")";

                object[] values = { };
                var rowsAffected = sqliteHelper.execute(sql, values);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("Insert Error: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> updateAsync(int id, string caclulacionId = null, int? partnerCodeId = null, string partnerName = null, string oib = null, DateTime? caclulacionDate = null,
                                           string invoice = null, string invoiceModel = null, string paymentMark = null, DateTime? invoiceDate = null, DateTime? deliverDate = null,
                                           DateTime? dueDate = null, decimal? invoiceAmount = null, decimal? payedAmount = null, string status = null, string picture = null,
                                           string accountingShop = null, string postingScheme = null, string codeBook = null, string warehousId = null, string paymentCode = null)
        {
            try
            {
                string sql = "UPDATE calculation_item SET ";
                List<string> updateColumns = new List<string>();

                if (caclulacionId != null) updateColumns.Add("caclulacion_id = '" + caclulacionId + "'");
                if (partnerCodeId.HasValue) updateColumns.Add("partner_code_id = " + partnerCodeId);
                if (!string.IsNullOrEmpty(partnerName)) updateColumns.Add("partner_name = '" + partnerName + "'");
                if (!string.IsNullOrEmpty(oib)) updateColumns.Add("oib = '" + oib + "'");
                if (caclulacionDate.HasValue) updateColumns.Add("caclulacion_date = '" + caclulacionDate.Value.ToString("yyyy-MM-dd") + "'");
                if (!string.IsNullOrEmpty(invoice)) updateColumns.Add("invoice = '" + invoice + "'");
                if (!string.IsNullOrEmpty(invoiceModel)) updateColumns.Add("invoice_model = '" + invoiceModel + "'");
                if (!string.IsNullOrEmpty(paymentMark)) updateColumns.Add("payment_mark = '" + paymentMark + "'");
                if (invoiceDate.HasValue) updateColumns.Add("invoice_date = '" + invoiceDate.Value.ToString("yyyy-MM-dd") + "'");
                if (deliverDate.HasValue) updateColumns.Add("deliver_date = '" + deliverDate.Value.ToString("yyyy-MM-dd") + "'");
                if (dueDate.HasValue) updateColumns.Add("due_date = '" + dueDate.Value.ToString("yyyy-MM-dd") + "'");
                if (invoiceAmount.HasValue) updateColumns.Add("invoice_amount = " + invoiceAmount);
                if (payedAmount.HasValue) updateColumns.Add("payed_amount = " + payedAmount);
                if (!string.IsNullOrEmpty(status)) updateColumns.Add("status = '" + status + "'");
                if (!string.IsNullOrEmpty(picture)) updateColumns.Add("picture = '" + picture + "'");
                if (!string.IsNullOrEmpty(accountingShop)) updateColumns.Add("accounting_shop = '" + accountingShop + "'");
                if (!string.IsNullOrEmpty(postingScheme)) updateColumns.Add("posting_scheme = '" + postingScheme + "'");
                if (!string.IsNullOrEmpty(codeBook)) updateColumns.Add("code_book = '" + codeBook + "'");
                if (!string.IsNullOrEmpty(warehousId)) updateColumns.Add("warehous_id = '" + warehousId + "'");
                if (!string.IsNullOrEmpty(paymentCode)) updateColumns.Add("payment_code = '" + paymentCode + "'");

                sql += string.Join(", ", updateColumns);
                sql += " WHERE id = " + id;

                object[] values = { };
                var rowsAffected = sqliteHelper.execute(sql, values);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("Update Error: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> deleteAsync(int id)
        {
            try
            {
                string sql = "DELETE FROM calculation_item ";
                sql += "WHERE id = " + id;

                object[] values = { };
                var rowsAffected = sqliteHelper.execute(sql, values);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                UtilityHelper.consoleLog("Delete Error: " + ex.Message);
                return false;
            }
        }
    }
}
