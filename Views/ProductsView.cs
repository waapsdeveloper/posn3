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
    public partial class ProductsView : UserControl
    {

        public ProductsView()
        {
            InitializeComponent();
            populateAccountComboBox();
            this.Paint += view_Paint;

        }

        private void view_Paint(object sender, PaintEventArgs e)
        {
            initalizeData();

        }

        void initalizeData()
        {

            try
            {

                SqliteHelper sqliteHelper = new SqliteHelper();
                ProductsHelper helper = new ProductsHelper(sqliteHelper);

                DataTable dt = helper.all();

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

        void populateAccountComboBox()
        {

            try
            {
                SqliteHelper sqliteHelper = new SqliteHelper();
                AccountListHelper list1 = new AccountListHelper(sqliteHelper);
                DataTable dt = list1.all();

                AccountId.ValueMember = "id";
                AccountId.DisplayMember = "name";
                AccountId.DataSource = dt;

                UnitMeasureHelper list2 = new UnitMeasureHelper(sqliteHelper);
                DataTable dt2 = list2.all();

                UnitMeasure.ValueMember = "id";
                UnitMeasure.DisplayMember = "name";
                UnitMeasure.DataSource = dt2;



            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }
        }


        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {

            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells["id"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are Sure You Want Delete The User?", "DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqliteHelper sqliteHelper = new SqliteHelper();
                    ProductsHelper helper = new ProductsHelper(sqliteHelper);


                    var id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                    bool r = helper.delete(id);
                    if (r)
                    {
                        initalizeData();
                    }

                }

            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Check if the validation is for the specific column            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Perform your desired operation here
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
                SqliteHelper sqliteHelper = new SqliteHelper();
                ProductsHelper helper = new ProductsHelper(sqliteHelper);
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
                
                decimal price = Decimal.Parse(dataGridViewRow.Cells["price"].Value.ToString());

                decimal price = 0;
                if (dataGridViewRow.Cells["price"].Value != DBNull.Value)
                {
                    price = Convert.ToDecimal(dataGridViewRow.Cells["price"].Value);
                }



                string price_type = dataGridViewRow.Cells["price_type"].Value.ToString();
                decimal debit = Decimal.Parse(dataGridViewRow.Cells["debit"].Value.ToString());
                decimal credit = Decimal.Parse(dataGridViewRow.Cells["credit"].Value.ToString());
                int partner_id = Int32.Parse(dataGridViewRow.Cells["partner_id"].Value.ToString());
                int tax_id = Int32.Parse(dataGridViewRow.Cells["tax_id"].Value.ToString());
                int warehouse_id = Int32.Parse(dataGridViewRow.Cells["warehouse_id"].Value.ToString());

                if (id == 0)
                {
                    bool r = helper.insert(
                        accounting_date,
                        document,
                        account_id,
                        unit_measure,
                        description,
                        in_value,
                        out_value,
                        price,
                        price_type,
                        debit,
                        credit,
                        partner_id,
                        tax_id,
                        warehouse_id);

                    if (r)
                    {
                        initalizeData();
                    }
                }
                else
                {
                    bool r = helper.update(
                        id,
                        accounting_date,
                        document,
                        account_id,
                        unit_measure,
                        description,
                        in_value,
                        out_value,
                        price,
                        price_type,
                        debit,
                        credit,
                        partner_id,
                        tax_id,
                        warehouse_id);

                    if (r)
                    {
                        initalizeData();
                    }
                }
            }
        }

    }
}
