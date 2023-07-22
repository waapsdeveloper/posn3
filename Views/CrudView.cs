using POSN3.Helpers.ModelHelpers;
using POSN3.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using POSN3.Views.components;

namespace POSN3.Views
{
    public class CrudView : UserControl
    {
        public DataGridView dataGridView1;
        public string type = "users";
        SqliteHelper sqliteHelper;

        public CrudView()
        {
            sqliteHelper = new SqliteHelper();            
        }

        public void initializeCom()
        {
            dataGridView1 = new DataGridView();
            
        }

        

        public async void initalizeData()
        {

            try
            {

                DataTable? dt = null;
                
                switch (type)
                {
                    case "users":
                        UserHelper userHhelper = new UserHelper(sqliteHelper);
                        dt = await userHhelper.all();
                        break;
                    case "roles":
                        RoleHelper rolehelper = new RoleHelper(sqliteHelper);
                        dt = await rolehelper.all();
                        break;
                }

                
                if (dt != null)
                {
                    dt.Columns["ID"].ReadOnly = true;
                    dt.Columns["created_at"].ReadOnly = true;
                    dt.Columns["created_at"].ReadOnly = true;
                    return;
                }

                dataGridView1.DataSource = dt;






            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }




        }

        protected async Task<DataTable> LoadDataAsync()
        {
            try
            {
                DataTable dt = null;
                switch (type)
                {
                    case "users":
                        // Implement loading data for users if needed
                        break;
                    case "roles":
                        RoleHelper helper = new RoleHelper(sqliteHelper);
                        dt = await helper.all();
                        break;
                }

                return dt;
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
                return null;
            }
        }

        protected void SetReadOnlyColumns(DataTable dt)
        {
            if (dt != null)
            {
                dt.Columns["ID"].ReadOnly = true;
                dt.Columns["created_at"].ReadOnly = true;
                dt.Columns["updated_at"].ReadOnly = true;
            }
        }

        public void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           
        }

        public async void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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

        public async void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells["id"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are Sure You Want Delete The User?", "DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqliteHelper sqliteHelper = new SqliteHelper();
                    RoleHelper helper = new RoleHelper(sqliteHelper);


                    var id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                    bool r = await helper.deleteAsync(id);
                    //if (r)
                    //{
                    //    initalizeData();
                    //}

                }

            }
        }





    }
}
