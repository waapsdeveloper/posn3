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

namespace POSN3.Views
{
    public partial class EmployeeListView : UserControl
    {
        public EmployeeListView()
        {
            InitializeComponent();
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
                EmployeeListHelper helper = new EmployeeListHelper(sqliteHelper);

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

        private async void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (datatableView1.CurrentRow != null)
            {  

            }
        }

        private async void dataGridView1_CellEndEditAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (datatableView1.CurrentRow != null)
            {
                DataGridViewRow dataGridViewRow = datatableView1.CurrentRow;
                SqliteHelper sqliteHelper = new SqliteHelper();
                EmployeeListHelper helper = new EmployeeListHelper(sqliteHelper);
                int id = 0;
                if (dataGridViewRow.Cells["id"].Value != DBNull.Value)
                {
                    id = Int32.Parse(dataGridViewRow.Cells["id"].Value.ToString());
                }

                string code = dataGridViewRow.Cells["code"].Value.ToString();
                string password = dataGridViewRow.Cells["password"].Value.ToString();
                string name = dataGridViewRow.Cells["name"].Value.ToString();
                string oib = dataGridViewRow.Cells["oib"].Value.ToString();
                string level = dataGridViewRow.Cells["level"].Value.ToString();

                if (id == 0)
                {
                    bool r = await helper.insertAsync(code, password, name, oib, level);
                    if (r)
                    {
                        initalizeData();
                    }
                }
                else
                {
                    bool r = await helper.updateAsync(id, code, password, name, oib, level);
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
                    EmployeeListHelper helper = new EmployeeListHelper(sqliteHelper);


                    var id = (int)datatableView1.CurrentRow.Cells["id"].Value;
                    bool r = await helper.deleteAsync(id);
                    if (r)
                    {
                        initalizeData();
                    }

                }

            }
        }
    }
}
