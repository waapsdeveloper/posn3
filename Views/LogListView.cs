using POSN3.Helpers.ModelHelpers;
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
using System.IO;

namespace POSN3.Views
{
    public partial class LogListView : UserControl
    {
        public LogListView()
        {
            InitializeComponent();
            // this.Paint += view_Paint;
            populateAccountComboBox();
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
                LogListHelper helper = new LogListHelper(sqliteHelper);

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

        async void populateAccountComboBox()
        {

            try
            {
                SqliteHelper sqliteHelper = new SqliteHelper();
                UserHelper list2 = new UserHelper(sqliteHelper);
                DataTable dt2 = await list2.all();

                UserId.ValueMember = "id";
                UserId.DisplayMember = "name";
                UserId.DataSource = dt2;

                

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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (datatableView1.CurrentRow != null)
            {

            }
        }

        private async void dataGridView1_CellEndEditAsync(object sender, DataGridViewCellEventArgs e)
        {

            // Perform your desired operation here
            if (datatableView1.CurrentRow != null)
            {


                DataGridViewRow dataGridViewRow = datatableView1.CurrentRow;
                SqliteHelper sqliteHelper = new SqliteHelper();
                LogListHelper helper = new LogListHelper(sqliteHelper);
                int id = 0;
                if (dataGridViewRow.Cells["id"].Value != DBNull.Value)
                {
                    id = Int32.Parse(dataGridViewRow.Cells["id"].Value.ToString());
                }

                string message = dataGridViewRow.Cells["message"].Value.ToString();

                int? invoice_id = null;
                if (dataGridViewRow.Cells["InvoiceId"].Value != DBNull.Value)
                {
                    invoice_id = Int32.Parse(dataGridViewRow.Cells["InvoiceId"].Value.ToString());
                }


                if (id == 0)
                {
                    bool r = await helper.insert(message, invoice_id);
                    if (r)
                    {
                        initalizeData();
                    }
                }
                else
                {
                    bool r = await helper.update(id, message, invoice_id);
                    if (r)
                    {
                        initalizeData();
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
                    LogListHelper helper = new LogListHelper(sqliteHelper);


                    var id = (int)datatableView1.CurrentRow.Cells["id"].Value;
                    bool r = await helper.delete(id);
                    //if (r)
                    //{
                    //    initalizeData();
                    //}

                }

            }
        }

        private async void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (datatableView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null; // Clear the invalid value
                //e.ThrowException = false; // Prevent the exception from being thrown
                // MessageBox.Show("Please select a valid value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
