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
    public partial class GroupsView : UserControl
    {
        public GroupsView()
        {
            InitializeComponent();
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
                GroupsHelper helper = new GroupsHelper(sqliteHelper);

                DataTable dt = helper.all();

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

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Perform your desired operation here
            if (datatableView1.CurrentRow != null)
            {


                DataGridViewRow dataGridViewRow = datatableView1.CurrentRow;
                SqliteHelper sqliteHelper = new SqliteHelper();
                GroupsHelper helper = new GroupsHelper(sqliteHelper);
                int id = 0;
                if (dataGridViewRow.Cells["id"].Value != DBNull.Value)
                {
                    id = Int32.Parse(dataGridViewRow.Cells["id"].Value.ToString());
                }

                string name = dataGridViewRow.Cells["name"].Value.ToString();
                string code = dataGridViewRow.Cells["code"].Value.ToString();
                
                decimal discount_group = 0;
                if (dataGridViewRow.Cells["discount_group"].Value != DBNull.Value)
                {
                    discount_group = Convert.ToDecimal(dataGridViewRow.Cells["discount_group"].Value);
                }

                DateTime? happy_hour_1 = null;
                if (dataGridViewRow.Cells["happy_hour_1"].Value != DBNull.Value)
                {
                    happy_hour_1 = DateTime.Parse(dataGridViewRow.Cells["happy_hour_1"].Value.ToString());
                }

                DateTime? happy_hour_2 = null;
                if (dataGridViewRow.Cells["happy_hour_2"].Value != DBNull.Value)
                {
                    happy_hour_2 = DateTime.Parse(dataGridViewRow.Cells["happy_hour_2"].Value.ToString());
                }

                DateTime? happy_hour_3 = null;
                if (dataGridViewRow.Cells["happy_hour_3"].Value != DBNull.Value)
                {
                    happy_hour_3 = DateTime.Parse(dataGridViewRow.Cells["happy_hour_3"].Value.ToString());
                }

                if (id == 0)
                {
                    bool r = helper.insert(name, code, discount_group, happy_hour_1, happy_hour_2, happy_hour_3);
                    if (r)
                    {
                        initalizeData();
                    }
                }
                else
                {
                    bool r = helper.update(id, name, code, discount_group, happy_hour_1, happy_hour_2, happy_hour_3);
                    if (r)
                    {
                        initalizeData();
                    }
                }

            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (datatableView1.CurrentRow.Cells["id"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are Sure You Want Delete The User?", "DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqliteHelper sqliteHelper = new SqliteHelper();
                    GroupsHelper helper = new GroupsHelper(sqliteHelper);


                    var id = (int)datatableView1.CurrentRow.Cells["id"].Value;
                    bool r = helper.delete(id);
                    if (r)
                    {
                        initalizeData();
                    }

                }

            }
        }
    }
}
