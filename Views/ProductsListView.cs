using POSN3.Helpers.ModelHelpers;
using POSN3.Helpers;
using POSN3.Views.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Globalization;
using Microsoft.VisualBasic.ApplicationServices;

namespace POSN3.Views
{
    public partial class ProductsListView : UserControl
    {

        public ProductsListView()
        {
            InitializeComponent();
            populateAccountComboBox();
            //this.Paint += view_Paint;
            initalizeData();

        }

        private void view_Paint(object sender, PaintEventArgs e)
        {
            initalizeData();

        }

        async void initalizeData()
        {

            try
            {

                SqliteHelper sqliteHelper = new SqliteHelper();
                ProductsHelper helper = new ProductsHelper(sqliteHelper);

                DataTable dt = await helper.all();

                dt.Columns["id"].ReadOnly = true;
                dt.Columns["created_at"].ReadOnly = true;
                dt.Columns["updated_at"].ReadOnly = true;

                dataGridView1.DataSource = dt;
                dataGridView1.DataError += new DataGridViewDataErrorEventHandler(combobox_DataError);


            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }




        }

        async void populateAccountComboBox()
        {

            try
            {
                //SqliteHelper sqliteHelper = new SqliteHelper();
                //AccountListHelper list1 = new AccountListHelper(sqliteHelper);
                //DataTable dt = await list1.all();

                //AccountId.ValueMember = "id";
                //AccountId.DisplayMember = "name";
                //AccountId.DataSource = dt;

                //UnitMeasureHelper list2 = new UnitMeasureHelper(sqliteHelper);
                //DataTable dt2 = await list2.all();

                //UnitMeasure.ValueMember = "id";
                //UnitMeasure.DisplayMember = "name";
                //UnitMeasure.DataSource = dt2;

                //PriceTypesHelper list3 = new PriceTypesHelper(sqliteHelper);
                //DataTable dt3 = await list3.all();

                //PriceType.ValueMember = "id";
                //PriceType.DisplayMember = "name";
                //PriceType.DataSource = dt3;

                //PartnerListHelper list4 = new PartnerListHelper(sqliteHelper);
                //DataTable dt4 = await list4.all();

                //PartnerId.ValueMember = "id";
                //PartnerId.DisplayMember = "name";
                //PartnerId.DataSource = dt4;

                //TaxListHelper list5 = new TaxListHelper(sqliteHelper);
                //DataTable dt5 = await list5.all();

                //TaxId.ValueMember = "id";
                //TaxId.DisplayMember = "name";
                //TaxId.DataSource = dt5;

                //WarehouseListHelper list6 = new WarehouseListHelper(sqliteHelper);
                //DataTable dt6 = await list6.all();

                //WarehouseId.ValueMember = "id";
                //WarehouseId.DisplayMember = "name";
                //WarehouseId.DataSource = dt6;





            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }
        }


        private async void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                e.Control.KeyPress -= DontAllow;
                e.Control.KeyPress += DontAllow;
            }

        }

        private void DontAllow(Object Sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AllowNumbersOnly(Object Sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {

            }
        }

        private async void dataGridView1_UserDeletingRowAsync(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells["id"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are Sure You Want Delete The User?", "DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqliteHelper sqliteHelper = new SqliteHelper();
                    ProductsHelper helper = new ProductsHelper(sqliteHelper);


                    var id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                    bool r = await helper.deleteAsync(id);
                    //if (r)
                    //{
                    //    initalizeData();
                    //}

                }

            }
        }

        private async void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Check if the validation is for the specific column            
        }

        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Perform your desired operation here
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
                SqliteHelper sqliteHelper = new SqliteHelper();
                ProductsListHelper helper = new ProductsListHelper(sqliteHelper);
                int id = 0;
                if (dataGridViewRow.Cells["id"].Value != DBNull.Value)
                {
                    id = Int32.Parse(dataGridViewRow.Cells["id"].Value.ToString());
                }

                string code = dataGridViewRow.Cells["code"].Value?.ToString();
                string barcode = dataGridViewRow.Cells["barcode"].Value?.ToString();
                int? group = dataGridViewRow.Cells["group"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["group"].Value);
                string name = dataGridViewRow.Cells["name"].Value?.ToString();
                string long_name = dataGridViewRow.Cells["long_name"].Value?.ToString();
                int? unit_of_measure_id = dataGridViewRow.Cells["unit_of_measure_id"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["unit_of_measure_id"].Value);
                int? partner_id = dataGridViewRow.Cells["partner_id"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["partner_id"].Value);
                decimal? vendor_price = dataGridViewRow.Cells["vendor_price"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["vendor_price"].Value);
                decimal? wholesale_price = dataGridViewRow.Cells["wholesale_price"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["wholesale_price"].Value);
                decimal? tax_price = dataGridViewRow.Cells["tax_price"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["tax_price"].Value);
                decimal? retail_price = dataGridViewRow.Cells["retail_price"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["retail_price"].Value);
                decimal? recompense = dataGridViewRow.Cells["recompense"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["recompense"].Value);
                decimal? discount = dataGridViewRow.Cells["discount"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["discount"].Value);
                int? tax_id = dataGridViewRow.Cells["tax_id"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["tax_id"].Value);
                decimal? min_stock = dataGridViewRow.Cells["min_stock"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["min_stock"].Value);
                decimal? max_stock = dataGridViewRow.Cells["max_stock"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["max_stock"].Value);
                decimal? stock = dataGridViewRow.Cells["stock"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["stock"].Value);
                string bom = dataGridViewRow.Cells["bom"].Value?.ToString();
                string serial_number = dataGridViewRow.Cells["serial_number"].Value?.ToString();
                string product_material = dataGridViewRow.Cells["product_material"].Value?.ToString();
                int? account_sales = dataGridViewRow.Cells["account_sales"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["account_sales"].Value);
                int? account_purchase = dataGridViewRow.Cells["account_purchase"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["account_purchase"].Value);
                int? account_in = dataGridViewRow.Cells["account_in"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["account_in"].Value);
                int? account_out = dataGridViewRow.Cells["account_out"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["account_out"].Value);
                int? account_asset = dataGridViewRow.Cells["account_asset"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["account_asset"].Value);
                int? garantie = dataGridViewRow.Cells["garantie"].Value == DBNull.Value ? (int?)null : Convert.ToInt32(dataGridViewRow.Cells["garantie"].Value);
                byte[] picture = dataGridViewRow.Cells["picture"].Value == DBNull.Value ? null : (byte[])dataGridViewRow.Cells["picture"].Value;
                string services = dataGridViewRow.Cells["services"].Value?.ToString();
                decimal? thickness = dataGridViewRow.Cells["thickness"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["thickness"].Value);
                decimal? length = dataGridViewRow.Cells["length"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["length"].Value);
                decimal? width = dataGridViewRow.Cells["width"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["width"].Value);
                decimal? weight = dataGridViewRow.Cells["weight"].Value == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dataGridViewRow.Cells["weight"].Value);
                string active = dataGridViewRow.Cells["active"].Value?.ToString();

                if (id == 0)
                {
                    bool r = await helper.insertAsync(
                        code, barcode, group, name, long_name, unit_of_measure_id, partner_id, vendor_price,
                        wholesale_price, tax_price, retail_price, recompense, discount, tax_id, min_stock,
                        max_stock, stock, bom, serial_number, product_material, account_sales, account_purchase,
                        account_in, account_out, account_asset, garantie, picture, services, thickness, length,
                        width, weight, active);

                    if (r)
                    {
                        initalizeData();
                    }
                }
                else
                {
                    bool r = await helper.updateAsync(
                        id, code, barcode, group, name, long_name, unit_of_measure_id, partner_id, vendor_price,
                        wholesale_price, tax_price, retail_price, recompense, discount, tax_id, min_stock,
                        max_stock, stock, bom, serial_number, product_material, account_sales, account_purchase,
                        account_in, account_out, account_asset, garantie, picture, services, thickness, length,
                        width, weight, active);

                    if (r)
                    {
                        initalizeData();
                    }
                }
            }
        }


        void combobox_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // (No need to write anything in here)
        }

        private async void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null; // Clear the invalid value
                //e.ThrowException = false; // Prevent the exception from being thrown
                // MessageBox.Show("Please select a valid value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }


}
