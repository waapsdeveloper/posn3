﻿using POSN3.Helpers.ModelHelpers;
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
    public partial class TaxListView : UserControl
    {
        //DataGridViewComboBoxColumn comboBoxColumnAccountIn;
        //DataGridViewComboBoxColumn comboBoxColumnAccountOut;

        public TaxListView()
        {
            InitializeComponent();
            populateAccountComboBox();
            //this.Paint += view_Paint;
            initalizeData();

        }

        private void view_Paint(object sender, PaintEventArgs e)
        {
            UtilityHelper.consoleLog("paint again 112121");
            initalizeData();

        }

        async void initalizeData()
        {

            try
            {

                SqliteHelper sqliteHelper = new SqliteHelper();
                TaxListHelper helper = new TaxListHelper(sqliteHelper);

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
                AccountListHelper roleHelper = new AccountListHelper(sqliteHelper);
                DataTable dt = await roleHelper.all();

                AccountInId.ValueMember = "id";
                AccountInId.DisplayMember = "name";
                AccountInId.DataSource = dt;


                AccountOutId.ValueMember = "id";
                AccountOutId.DisplayMember = "name";
                AccountOutId.DataSource = dt;
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }
        }


        private async void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells["id"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are Sure You Want Delete The User?", "DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqliteHelper sqliteHelper = new SqliteHelper();
                    TaxListHelper helper = new TaxListHelper(sqliteHelper);


                    var id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                    bool r = await helper.deleteAsync(id);
                    //if (r)
                    //{
                    //    initalizeData();
                    //}

                }

            }
        }

        //private async void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    // Check if the validation is for the specific column
        //    if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
        //    {
        //        DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        //        string value = e.FormattedValue.ToString();

        //        // Validate the entered value as a decimal number
        //        decimal decimalValue;
        //        if (!decimal.TryParse(value, out decimalValue))
        //        {
        //            // Display an error message and cancel the validation
        //            dataGridView1.Rows[e.RowIndex].ErrorText = "Invalid decimal number";
        //            e.Cancel = true;
        //        }
        //        else
        //        {
        //            // Clear any error message
        //            dataGridView1.Rows[e.RowIndex].ErrorText = string.Empty;

        //            // Set the value as decimal
        //            cell.Value = decimalValue;
        //        }
        //    }
        //}

        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Perform your desired operation here
            if (dataGridView1.CurrentRow != null)
            {


                DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;

                int id = 0;
                if (dataGridViewRow.Cells["id"].Value != DBNull.Value && dataGridViewRow.Cells["id"].Value != null)
                {
                    id = Int32.Parse(dataGridViewRow.Cells["id"].Value.ToString());
                }


                string name = dataGridViewRow.Cells["name"].Value.ToString();
                string account = dataGridViewRow.Cells["account"].Value.ToString();

                double tax1 = 0.0;
                if (dataGridViewRow.Cells["tax1"].Value != DBNull.Value)
                {
                    tax1 = Convert.ToDouble(dataGridViewRow.Cells["tax1"].Value);
                }

                double tax2 = 0.0;
                if (dataGridViewRow.Cells["tax2"].Value != DBNull.Value)
                {
                    tax2 = Convert.ToDouble(dataGridViewRow.Cells["tax2"].Value);
                }

                double tax3 = 0.0;
                if (dataGridViewRow.Cells["tax3"].Value != DBNull.Value)
                {
                    tax3 = Convert.ToDouble(dataGridViewRow.Cells["tax3"].Value);
                }

                int? account_in_id = null;
                if (dataGridViewRow.Cells["AccountInId"].Value != DBNull.Value)
                {
                    account_in_id = Int32.Parse(dataGridViewRow.Cells["AccountInId"].Value.ToString());
                }

                int? account_out_id = null;
                if (dataGridViewRow.Cells["AccountOutId"].Value != DBNull.Value)
                {
                    account_out_id = Int32.Parse(dataGridViewRow.Cells["AccountOutId"].Value.ToString());
                }

                // Validate required fields before insert or update
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(account) || account_in_id == null || account_out_id == null)
                {
                    //MessageBox.Show("Name and Account fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //dataGridView1.CancelEdit(); // Cancel the cell edit to keep the user in edit mode
                    return;
                }

                SqliteHelper sqliteHelper = new SqliteHelper();
                TaxListHelper helper = new TaxListHelper(sqliteHelper);

                if (id == 0)
                {
                    bool r = await helper.insertAsync(name, account, tax1, tax2, tax3, account_in_id, account_out_id);
                    if (r)
                    {
                        // Use BeginInvoke to defer the update until the control is no longer busy
                        dataGridView1.BeginInvoke(new Action(() => initalizeData()));
                    }
                }
                else
                {
                    bool r = await helper.updateAsync(id, name, account, tax1, tax2, tax3, account_in_id, account_out_id);
                    if (r)
                    {
                        dataGridView1.BeginInvoke(new Action(() => initalizeData()));
                    }
                }

            }
        }

        //private async void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //    if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
        //    {
        //        //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null; // Clear the invalid value
        //        //e.ThrowException = false; // Prevent the exception from being thrown
        //        // MessageBox.Show("Please select a valid value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
