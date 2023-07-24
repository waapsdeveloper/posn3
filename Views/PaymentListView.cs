﻿using POSN3.Helpers.ModelHelpers;
using POSN3.Helpers;
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

namespace POSN3.Views
{
    public partial class PaymentListView : UserControl
    {
        public PaymentListView()
        {
            InitializeComponent();
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
                PaymentListHelper helper = new PaymentListHelper(sqliteHelper);

                DataTable dt = await helper.all();

                dt.Columns["ID"].ReadOnly = true;
                dt.Columns["created_at"].ReadOnly = true;
                dt.Columns["created_at"].ReadOnly = true;


                datatableView1.DataSource = dt;






            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }




        }

        private async void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (datatableView1.CurrentCell.ColumnIndex == 0)
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

        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (datatableView1.CurrentRow != null)
            {
                DataGridViewRow dataGridViewRow = datatableView1.CurrentRow;
                SqliteHelper sqliteHelper = new SqliteHelper();
                PaymentListHelper helper = new PaymentListHelper(sqliteHelper);
                int id = 0;
                if (dataGridViewRow.Cells["id"].Value != DBNull.Value)
                {
                    id = Int32.Parse(dataGridViewRow.Cells["id"].Value.ToString());
                }
                string code = dataGridViewRow.Cells["code"].Value?.ToString(); // Updated: Read the "code" column value.
                string fiscal = dataGridViewRow.Cells["fiscal"].Value?.ToString(); // Updated: Read the "fiscal" column value.
                string name = dataGridViewRow.Cells["name"].Value?.ToString(); // Updated: Read the "name" column value.
                decimal discountPayment = 0;
                if (dataGridViewRow.Cells["discount_payment"].Value != DBNull.Value)
                {
                    discountPayment = Decimal.Parse(dataGridViewRow.Cells["discount_payment"].Value.ToString()); // Updated: Read the "discount_payment" column value.
                }

                // Perform null checks and validation
                if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(fiscal) || string.IsNullOrEmpty(name) || discountPayment == null)
                {
                    // MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //datatableView1.CancelEdit(); // Cancel the cell edit to keep the user in edit mode
                    return;
                }

                if (id == 0)
                {
                    bool r = await helper.InsertAsync(code, fiscal, name, discountPayment); // Updated: Pass the new column values to the insertAsync method.
                    if (r)
                    {
                        datatableView1.BeginInvoke(new Action(() => initalizeData()));
                    }
                }
                else
                {
                    bool r = await helper.UpdateAsync(id, code, fiscal, name, discountPayment); // Updated: Pass the new column values to the updateAsync method.
                    if (r)
                    {
                        datatableView1.BeginInvoke(new Action(() => initalizeData()));
                    }
                }
            }
        }



        private async void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (datatableView1.CurrentRow.Cells["id"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are Sure You Want Delete The User?", "DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqliteHelper sqliteHelper = new SqliteHelper();
                    PaymentListHelper helper = new PaymentListHelper(sqliteHelper);


                    var id = (int)datatableView1.CurrentRow.Cells["id"].Value;
                    bool r = await helper.DeleteAsync(id);                    

                }

            }
        }
    }
}
