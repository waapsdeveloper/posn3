using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POSN3.Helpers.ModelHelpers
{
    internal class HeaderHelper
    {
        SqliteHelper sqliteHelper;
        public HeaderHelper(SqliteHelper sqliteHelper)
        {
            this.sqliteHelper = sqliteHelper;
        }

        public async Task<DataTable> all()
        {
            string sql = "SELECT * FROM calculation_header";

            object[] values = { };
            DataTable dt = sqliteHelper.executeData(sql, values);
            UtilityHelper.consoleLog("CalculationHeader table fetched successfully");
            return dt;
        }

        public async Task<DataTable> getByCaclulacionId(string caclulacionId)
        {
            string sql = "SELECT * FROM calculation_header ";
            sql += "WHERE caclulacion_id = '" + caclulacionId + "'";

            object[] values = { };
            var result = sqliteHelper.executeData(sql, values);
            return result;
        }

        public async Task<bool> insertAsync(string caclulacionId = null, string code = null, string name = null, int? unitOfMeasureId = null, decimal? quantity = null,
                                    decimal? thickness = null, decimal? length = null, decimal? width = null, decimal? weight = null, decimal? vendorPrice = null,
                                    decimal? discount1 = null, decimal? discount2 = null, decimal? vendorTax = null, decimal? dependentCost = null, decimal? wholesaleTotal = null,
                                    decimal? margin = null, decimal? amountWithoutTax = null, decimal? priceWithoutTax = null, decimal? recompense = null, int? taxId = null,
                                    decimal? tax1Total = null, decimal? tax2 = null, decimal? tax2Total = null, decimal? retailValue = null, int? retailPriceManual = null,
                                    int? retailPrice = null, string accountRetail = null, string accountAnalytic = null)
        {
            try
            {
                string sql = "INSERT INTO calculation_header ";

                sql += "(";
                Dictionary<string, object> columnValues = new Dictionary<string, object>();

                if (caclulacionId != null)
                    columnValues.Add("caclulacion_id", caclulacionId);

                if (code != null)
                    columnValues.Add("code", code);

                if (name != null)
                    columnValues.Add("name", name);

                // Add other optional parameters here
                if (unitOfMeasureId != null)
                    columnValues.Add("unit_of_measure_id", unitOfMeasureId);

                if (quantity != null)
                    columnValues.Add("quantity", quantity);

                if (thickness != null)
                    columnValues.Add("thickness", thickness);

                if (length != null)
                    columnValues.Add("length", length);

                if (width != null)
                    columnValues.Add("width", width);

                if (weight != null)
                    columnValues.Add("weight", weight);

                if (vendorPrice != null)
                    columnValues.Add("vendor_price", vendorPrice);

                if (discount1 != null)
                    columnValues.Add("discount1", discount1);

                if (discount2 != null)
                    columnValues.Add("discount2", discount2);

                if (vendorTax != null)
                    columnValues.Add("vendor_tax", vendorTax);

                if (dependentCost != null)
                    columnValues.Add("dependent_cost", dependentCost);

                if (wholesaleTotal != null)
                    columnValues.Add("wholesale_total", wholesaleTotal);

                if (margin != null)
                    columnValues.Add("margin", margin);

                if (amountWithoutTax != null)
                    columnValues.Add("amount_without_tax", amountWithoutTax);

                if (priceWithoutTax != null)
                    columnValues.Add("price_without_tax", priceWithoutTax);

                if (recompense != null)
                    columnValues.Add("recompense", recompense);

                if (taxId != null)
                    columnValues.Add("tax_id", taxId);

                if (tax1Total != null)
                    columnValues.Add("tax1_total", tax1Total);

                if (tax2 != null)
                    columnValues.Add("tax2", tax2);

                if (tax2Total != null)
                    columnValues.Add("tax2_total", tax2Total);

                if (retailValue != null)
                    columnValues.Add("retail_value", retailValue);

                if (retailPriceManual != null)
                    columnValues.Add("retail_price_manual", retailPriceManual);

                if (retailPrice != null)
                    columnValues.Add("retail_price", retailPrice);

                if (accountRetail != null)
                    columnValues.Add("account_retail", accountRetail);

                if (accountAnalytic != null)
                    columnValues.Add("account_analytic", accountAnalytic);

                sql += string.Join(", ", columnValues.Keys) + ")";
                sql += " VALUES ";
                sql += "(" + string.Join(", ", columnValues.Values.Select(v => v != null ? "'" + v.ToString() + "'" : "NULL")) + ")";

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


        public async Task<bool> updateAsync(int id, string caclulacionId = null, string code = null, string name = null, int? unitOfMeasureId = null, decimal? quantity = null,
                                    decimal? thickness = null, decimal? length = null, decimal? width = null, decimal? weight = null, decimal? vendorPrice = null,
                                    decimal? discount1 = null, decimal? discount2 = null, decimal? vendorTax = null, decimal? dependentCost = null, decimal? wholesaleTotal = null,
                                    decimal? margin = null, decimal? amountWithoutTax = null, decimal? priceWithoutTax = null, decimal? recompense = null, int? taxId = null,
                                    decimal? tax1Total = null, decimal? tax2 = null, decimal? tax2Total = null, decimal? retailValue = null, int? retailPriceManual = null,
                                    int? retailPrice = null, string accountRetail = null, string accountAnalytic = null)
        {
            try
            {
                string sql = "UPDATE calculation_header SET ";
                List<string> updateColumns = new List<string>();

                if (caclulacionId != null)
                    updateColumns.Add("caclulacion_id = '" + caclulacionId + "'");

                if (code != null)
                    updateColumns.Add("code = '" + code + "'");

                if (name != null)
                    updateColumns.Add("name = '" + name + "'");

                // Add other optional parameters here
                if (unitOfMeasureId != null)
                    updateColumns.Add("unit_of_measure_id = " + unitOfMeasureId.Value);

                if (quantity != null)
                    updateColumns.Add("quantity = " + quantity.Value);

                if (thickness != null)
                    updateColumns.Add("thickness = " + thickness.Value);

                if (length != null)
                    updateColumns.Add("length = " + length.Value);

                if (width != null)
                    updateColumns.Add("width = " + width.Value);

                if (weight != null)
                    updateColumns.Add("weight = " + weight.Value);

                if (vendorPrice != null)
                    updateColumns.Add("vendor_price = " + vendorPrice.Value);

                if (discount1 != null)
                    updateColumns.Add("discount1 = " + discount1.Value);

                if (discount2 != null)
                    updateColumns.Add("discount2 = " + discount2.Value);

                if (vendorTax != null)
                    updateColumns.Add("vendor_tax = " + vendorTax.Value);

                if (dependentCost != null)
                    updateColumns.Add("dependent_cost = " + dependentCost.Value);

                if (wholesaleTotal != null)
                    updateColumns.Add("wholesale_total = " + wholesaleTotal.Value);

                if (margin != null)
                    updateColumns.Add("margin = " + margin.Value);

                if (amountWithoutTax != null)
                    updateColumns.Add("amount_without_tax = " + amountWithoutTax.Value);

                if (priceWithoutTax != null)
                    updateColumns.Add("price_without_tax = " + priceWithoutTax.Value);

                if (recompense != null)
                    updateColumns.Add("recompense = " + recompense.Value);

                if (taxId != null)
                    updateColumns.Add("tax_id = " + taxId.Value);

                if (tax1Total != null)
                    updateColumns.Add("tax1_total = " + tax1Total.Value);

                if (tax2 != null)
                    updateColumns.Add("tax2 = " + tax2.Value);

                if (tax2Total != null)
                    updateColumns.Add("tax2_total = " + tax2Total.Value);

                if (retailValue != null)
                    updateColumns.Add("retail_value = " + retailValue.Value);

                if (retailPriceManual != null)
                    updateColumns.Add("retail_price_manual = " + retailPriceManual.Value);

                if (retailPrice != null)
                    updateColumns.Add("retail_price = " + retailPrice.Value);

                if (accountRetail != null)
                    updateColumns.Add("account_retail = '" + accountRetail + "'");

                if (accountAnalytic != null)
                    updateColumns.Add("account_analytic = '" + accountAnalytic + "'");

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
                string sql = "DELETE FROM calculation_header ";
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
