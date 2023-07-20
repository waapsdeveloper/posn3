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

namespace POSN3.Views
{
    public partial class PartnerListView : UserControl
    {

        public PartnerListView()
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
                PartnerListHelper helper = new PartnerListHelper(sqliteHelper);

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

                CustomerAccount.ValueMember = "id";
                CustomerAccount.DisplayMember = "name";
                CustomerAccount.DataSource = dt;


                VendorAccount.ValueMember = "id";
                VendorAccount.DisplayMember = "name";
                VendorAccount.DataSource = dt;

                CityHelper list2 = new CityHelper(sqliteHelper);
                DataTable dt2 = await list2.all();

                Cities.ValueMember = "id";
                Cities.DisplayMember = "name";
                Cities.DataSource = dt2;

                UserHelper list3 = new UserHelper(sqliteHelper);
                DataTable dt3 = await list3.all();

                Users.ValueMember = "id";
                Users.DisplayMember = "name";
                Users.DataSource = dt3;


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
                    PartnerListHelper helper = new PartnerListHelper(sqliteHelper);


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
                PartnerListHelper helper = new PartnerListHelper(sqliteHelper);
                int id = 0;
                if (dataGridViewRow.Cells["id"].Value != DBNull.Value)
                {
                    id = Int32.Parse(dataGridViewRow.Cells["id"].Value.ToString());
                }

                string name = dataGridViewRow.Cells["name"].Value.ToString();
                string code = dataGridViewRow.Cells["code"].Value.ToString();
                string long_name = dataGridViewRow.Cells["long_name"].Value.ToString();
                string address = dataGridViewRow.Cells["address"].Value.ToString();

                string mb = dataGridViewRow.Cells["mb"].Value.ToString();
                string oib = dataGridViewRow.Cells["oib"].Value.ToString();
                string in_tax_system = dataGridViewRow.Cells["in_tax_system"].Value.ToString();
                string tax_type = dataGridViewRow.Cells["tax_type"].Value.ToString();
                bool is_customer = bool.TryParse(dataGridViewRow.Cells["is_customer"].Value.ToString(), out is_customer);
                bool is_vendor = bool.TryParse(dataGridViewRow.Cells["is_vendor"].Value.ToString(), out is_vendor);
                string iban = dataGridViewRow.Cells["iban"].Value.ToString();
                string phone = dataGridViewRow.Cells["phone"].Value.ToString();
                string telefax = dataGridViewRow.Cells["telefax"].Value.ToString();
                string mobile_phone = dataGridViewRow.Cells["mobile_phone"].Value.ToString();
                string mail = dataGridViewRow.Cells["mail"].Value.ToString();
                string web = dataGridViewRow.Cells["web"].Value.ToString();

                int? customer_account = null;
                if (dataGridViewRow.Cells["CustomerAccount"].Value != DBNull.Value)
                {
                    customer_account = Int32.Parse(dataGridViewRow.Cells["CustomerAccount"].Value.ToString());
                }

                int? vendor_account = null;
                if (dataGridViewRow.Cells["VendorAccount"].Value != DBNull.Value)
                {
                    vendor_account = Int32.Parse(dataGridViewRow.Cells["VendorAccount"].Value.ToString());
                }

                int? city_id = null;
                if (dataGridViewRow.Cells["Cities"].Value != DBNull.Value)
                {
                    city_id = Int32.Parse(dataGridViewRow.Cells["Cities"].Value.ToString());
                }

                int? person = null;
                if (dataGridViewRow.Cells["Cities"].Value != DBNull.Value)
                {
                    person = Int32.Parse(dataGridViewRow.Cells["Cities"].Value.ToString());
                }

                decimal customer_discount = 0;
                if (dataGridViewRow.Cells["customer_discount"].Value != DBNull.Value)
                {
                    customer_discount = Convert.ToDecimal(dataGridViewRow.Cells["customer_discount"].Value);
                }

                decimal vendor_discount = 0;
                if (dataGridViewRow.Cells["vendor_discount"].Value != DBNull.Value)
                {
                    vendor_discount = Convert.ToDecimal(dataGridViewRow.Cells["vendor_discount"].Value);
                }


                int? customer_due_date = null;
                if (dataGridViewRow.Cells["customer_due_date"].Value != DBNull.Value)
                {
                    customer_due_date = Int32.Parse(dataGridViewRow.Cells["customer_due_date"].Value.ToString());
                }

                int? vendor_due_date = null;
                if (dataGridViewRow.Cells["vendor_due_date"].Value != DBNull.Value)
                {
                    vendor_due_date = Int32.Parse(dataGridViewRow.Cells["vendor_due_date"].Value.ToString());
                }


                //int customer_due_date = Int32.Parse(dataGridViewRow.Cells["customer_due_date"].Value.ToString());

                bool active = true;
                if (dataGridViewRow.Cells["active"].Value != DBNull.Value)
                {
                    active = Boolean.Parse(dataGridViewRow.Cells["active"].Value.ToString());
                }

                //bool active = Boolean.Parse(dataGridViewRow.Cells["active"].Value.ToString());

                if (id == 0)
                {
                    bool r = await helper.insertAsync(name, code, long_name, address, city_id, mb, oib, in_tax_system, tax_type, is_customer, is_vendor, iban, phone, telefax, mobile_phone, mail, web, customer_account, vendor_account, person, customer_discount, vendor_discount, customer_due_date, vendor_due_date, active);
                    if (r)
                    {
                        initalizeData();
                    }
                }
                else
                {
                    bool r = await helper.updateAsync(id, name, code, long_name, address, city_id, mb, oib, in_tax_system, tax_type, is_customer, is_vendor, iban, phone, telefax, mobile_phone, mail, web, customer_account, vendor_account, person, customer_discount, vendor_discount, customer_due_date, vendor_due_date, active);
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
