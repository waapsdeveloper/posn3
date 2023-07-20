using POSN3.Helpers;
using POSN3.Helpers.ModelHelpers;
using System.Data;

namespace POSN3.Views
{
    public partial class InvoiceListView : UserControl
    {

        public InvoiceListView()
        {
            InitializeComponent();
            populateAccountComboBox();
            this.Paint += view_Paint;

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
                InvoiceHelper helper = new InvoiceHelper(sqliteHelper);

                DataTable dt = await helper.all();

                dt.Columns["id"].ReadOnly = true;
                dt.Columns["created_at"].ReadOnly = true;
                dt.Columns["updated_at"].ReadOnly = true;

                dataGridView1.DataSource = dt;                


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
                SqliteHelper sqliteHelper = new SqliteHelper();
                AccountListHelper list1 = new AccountListHelper(sqliteHelper);
                DataTable dt = await list1.all();

                //AccountId.ValueMember = "id";
                //AccountId.DisplayMember = "name";
                //AccountId.DataSource = dt;

                UnitMeasureHelper list2 = new UnitMeasureHelper(sqliteHelper);
                DataTable dt2 = await list2.all();

                UnitMeasure.ValueMember = "id";
                UnitMeasure.DisplayMember = "name";
                UnitMeasure.DataSource = dt2;

                PriceTypesHelper list3 = new PriceTypesHelper(sqliteHelper);
                DataTable dt3 = await list3.all();

                //PriceType.ValueMember = "id";
                //PriceType.DisplayMember = "name";
                //PriceType.DataSource = dt3;

                PartnerListHelper list4 = new PartnerListHelper(sqliteHelper);
                DataTable dt4 = await list4.all();

                //PartnerId.ValueMember = "id";
                //PartnerId.DisplayMember = "name";
                //PartnerId.DataSource = dt4;

                TaxListHelper list5 = new TaxListHelper(sqliteHelper);
                DataTable dt5 = await list5.all();

                TaxId.ValueMember = "id";
                TaxId.DisplayMember = "name";
                TaxId.DataSource = dt5;

                WarehouseListHelper list6 = new WarehouseListHelper(sqliteHelper);
                DataTable dt6 = await list6.all();

                WarehouseId.ValueMember = "id";
                WarehouseId.DisplayMember = "name";
                WarehouseId.DataSource = dt6;





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

        private async void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells["id"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are Sure You Want Delete The User?", "DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqliteHelper sqliteHelper = new SqliteHelper();
                    InvoiceHelper helper = new InvoiceHelper(sqliteHelper);


                    var id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                    bool r = await helper.deleteAsync(id);
                    if (r)
                    {
                        initalizeData();
                    }

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
                InvoiceHelper helper = new InvoiceHelper(sqliteHelper);
                int id = 0;
                if (dataGridViewRow.Cells["id"].Value != DBNull.Value)
                {
                    id = Int32.Parse(dataGridViewRow.Cells["id"].Value.ToString());
                }

                //DateTime accounting_date = DateTime.Parse(dataGridViewRow.Cells["accounting_date"].Value.ToString());

                DateTime? accounting_date = null;
                if (dataGridViewRow.Cells["accounting_date"].Value != DBNull.Value)
                {
                    accounting_date = DateTime.Parse(dataGridViewRow.Cells["accounting_date"].Value.ToString());
                }

                string document = dataGridViewRow.Cells["document"].Value.ToString();

                int? account_id = null;
                if (dataGridViewRow.Cells["AccountId"].Value != DBNull.Value)
                {
                    account_id = Int32.Parse(dataGridViewRow.Cells["AccountId"].Value.ToString());
                }

                int? unit_measure = null;
                if (dataGridViewRow.Cells["UnitMeasure"].Value != DBNull.Value)
                {
                    unit_measure = Int32.Parse(dataGridViewRow.Cells["UnitMeasure"].Value.ToString());
                }

                string description = dataGridViewRow.Cells["description"].Value.ToString();

                decimal in_value = 0;
                if (dataGridViewRow.Cells["in_value"].Value != DBNull.Value)
                {
                    in_value = Convert.ToDecimal(dataGridViewRow.Cells["in_value"].Value);
                }

                decimal out_value = 0;
                if (dataGridViewRow.Cells["out_value"].Value != DBNull.Value)
                {
                    out_value = Convert.ToDecimal(dataGridViewRow.Cells["out_value"].Value);
                }

                // Populating the remaining variables based on your provided parameters
                DateTime? invoice_date = null;
                if (dataGridViewRow.Cells["invoiceDate"].Value != DBNull.Value)
                {
                    invoice_date = DateTime.Parse(dataGridViewRow.Cells["invoiceDate"].Value.ToString());
                }

                int? invoice_number = null;
                if (dataGridViewRow.Cells["invoiceNumber"].Value != DBNull.Value)
                {
                    invoice_number = Int32.Parse(dataGridViewRow.Cells["invoiceNumber"].Value.ToString());
                }

                string product_code = dataGridViewRow.Cells["productCode"].Value.ToString();
                string product_name = dataGridViewRow.Cells["productName"].Value.ToString();

                int? unit_of_measure_id = null;
                if (dataGridViewRow.Cells["unitOfMeasureId"].Value != DBNull.Value)
                {
                    unit_of_measure_id = Int32.Parse(dataGridViewRow.Cells["unitOfMeasureId"].Value.ToString());
                }

                decimal? quantity = null;
                if (dataGridViewRow.Cells["quantity"].Value != DBNull.Value)
                {
                    quantity = Convert.ToDecimal(dataGridViewRow.Cells["quantity"].Value);
                }

                decimal? retail_price = null;
                if (dataGridViewRow.Cells["retailPrice"].Value != DBNull.Value)
                {
                    retail_price = Convert.ToDecimal(dataGridViewRow.Cells["retailPrice"].Value);
                }

                decimal? amount = null;
                if (dataGridViewRow.Cells["amount"].Value != DBNull.Value)
                {
                    amount = Convert.ToDecimal(dataGridViewRow.Cells["amount"].Value);
                }

                decimal? recompense = null;
                if (dataGridViewRow.Cells["recompense"].Value != DBNull.Value)
                {
                    recompense = Convert.ToDecimal(dataGridViewRow.Cells["recompense"].Value);
                }

                int? tay_id = null;
                if (dataGridViewRow.Cells["tayId"].Value != DBNull.Value)
                {
                    tay_id = Int32.Parse(dataGridViewRow.Cells["tayId"].Value.ToString());
                }

                decimal? tax1_percent = null;
                if (dataGridViewRow.Cells["tax1Percent"].Value != DBNull.Value)
                {
                    tax1_percent = Convert.ToDecimal(dataGridViewRow.Cells["tax1Percent"].Value);
                }

                decimal? tax1_amount = null;
                if (dataGridViewRow.Cells["tax1Amount"].Value != DBNull.Value)
                {
                    tax1_amount = Convert.ToDecimal(dataGridViewRow.Cells["tax1Amount"].Value);
                }

                decimal? tax2_percent = null;
                if (dataGridViewRow.Cells["tax2Percent"].Value != DBNull.Value)
                {
                    tax2_percent = Convert.ToDecimal(dataGridViewRow.Cells["tax2Percent"].Value);
                }

                decimal? tax2_amount = null;
                if (dataGridViewRow.Cells["tax2Amount"].Value != DBNull.Value)
                {
                    tax2_amount = Convert.ToDecimal(dataGridViewRow.Cells["tax2Amount"].Value);
                }

                decimal? tax3_percent = null;
                if (dataGridViewRow.Cells["tax3Percent"].Value != DBNull.Value)
                {
                    tax3_percent = Convert.ToDecimal(dataGridViewRow.Cells["tax3Percent"].Value);
                }

                decimal? tax3_amount = null;
                if (dataGridViewRow.Cells["tax3Amount"].Value != DBNull.Value)
                {
                    tax3_amount = Convert.ToDecimal(dataGridViewRow.Cells["tax3Amount"].Value);
                }

                decimal? discount = null;
                if (dataGridViewRow.Cells["discount"].Value != DBNull.Value)
                {
                    discount = Convert.ToDecimal(dataGridViewRow.Cells["discount"].Value);
                }

                decimal? discount_amount = null;
                if (dataGridViewRow.Cells["discountAmount"].Value != DBNull.Value)
                {
                    discount_amount = Convert.ToDecimal(dataGridViewRow.Cells["discountAmount"].Value);
                }

                decimal? discount_cash = null;
                if (dataGridViewRow.Cells["discountCash"].Value != DBNull.Value)
                {
                    discount_cash = Convert.ToDecimal(dataGridViewRow.Cells["discountCash"].Value);
                }

                decimal? discount_payment = null;
                if (dataGridViewRow.Cells["discountPayment"].Value != DBNull.Value)
                {
                    discount_payment = Convert.ToDecimal(dataGridViewRow.Cells["discountPayment"].Value);
                }

                int? payment_type = null;
                if (dataGridViewRow.Cells["paymentType"].Value != DBNull.Value)
                {
                    payment_type = Int32.Parse(dataGridViewRow.Cells["paymentType"].Value.ToString());
                }

                int? employee_id = null;
                if (dataGridViewRow.Cells["employeeId"].Value != DBNull.Value)
                {
                    employee_id = Int32.Parse(dataGridViewRow.Cells["employeeId"].Value.ToString());
                }

                bool? r1_type = null;
                if (dataGridViewRow.Cells["r1Type"].Value != DBNull.Value)
                {
                    r1_type = Convert.ToBoolean(dataGridViewRow.Cells["r1Type"].Value);
                }

                int? warehouse_id = null;
                if (dataGridViewRow.Cells["warehouseId"].Value != DBNull.Value)
                {
                    warehouse_id = Int32.Parse(dataGridViewRow.Cells["warehouseId"].Value.ToString());
                }

                string payment_device = dataGridViewRow.Cells["paymentDevice"].Value.ToString();
                string business_space = dataGridViewRow.Cells["businessSpace"].Value.ToString();
                string zki = dataGridViewRow.Cells["zki"].Value.ToString();
                string jir = dataGridViewRow.Cells["jir"].Value.ToString();

                

                if (id == 0)
                {
                    // Call the insert function with the populated variables
                    bool r = await helper.insertAsync(
                        invoice_date,
                        invoice_number,
                        product_code,
                        product_name,
                        unit_measure,
                        quantity,
                        retail_price,
                        amount,
                        recompense,
                        tay_id,
                        tax1_percent,
                        tax1_amount,
                        tax2_percent,
                        tax2_amount,
                        tax3_percent,
                        tax3_amount,
                        discount,
                        discount_amount,
                        discount_cash,
                        discount_payment,
                        payment_type,
                        employee_id,
                        r1_type,
                        warehouse_id,
                        payment_device,
                        business_space,
                        zki,
                        jir
                    );



                    if (r)
                    {
                        initalizeData();
                    }
                }
                else
                {
                    bool r = await helper.updateAsync(
                        id,
                        invoice_date,
                        invoice_number,
                        product_code,
                        product_name,
                        unit_of_measure_id,
                        quantity,
                        retail_price,
                        amount,
                        recompense,
                        tay_id,
                        tax1_percent,
                        tax1_amount,
                        tax2_percent,
                        tax2_amount,
                        tax3_percent,
                        tax3_amount,
                        discount,
                        discount_amount,
                        discount_cash,
                        discount_payment,
                        payment_type,
                        employee_id,
                        r1_type,
                        warehouse_id,
                        payment_device,
                        business_space,
                        zki,
                        jir);

                    if (r)
                    {
                        initalizeData();
                    }
                }
            }
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
