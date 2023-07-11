using POSN3.Helpers;
using POSN3.Helpers.ModelHelpers;
using System.Data;

namespace POSN3.Views
{
    public partial class UsersView : UserControl
    {
        public UsersView()
        {
            InitializeComponent();

            this.Paint += view_Paint;
        }

        private void view_Paint(object sender, PaintEventArgs e)
        {
            populateRoleComboBox();
            initalizeData();
            
        }



        void initalizeData()
        {
            try
            {
                SqliteHelper sqliteHelper = new SqliteHelper();
                UserHelper userHelper = new UserHelper(sqliteHelper);
                DataTable dt = userHelper.all();

                dt.Columns["ID"].ReadOnly = true;
                dt.Columns["created_at"].ReadOnly = true;
                dt.Columns["created_at"].ReadOnly = true;

                dataGridView1.DataSource = dt;
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }
        }

        void populateRoleComboBox()
        {

            try
            {
                SqliteHelper sqliteHelper = new SqliteHelper();
                RoleHelper roleHelper = new RoleHelper(sqliteHelper);
                DataTable dt = roleHelper.all();
                RoleList.ValueMember = "id";
                RoleList.DisplayMember = "name";
                RoleList.DataSource = dt;
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
                SqliteHelper sqliteHelper = new SqliteHelper();
                UserHelper userHelper = new UserHelper(sqliteHelper);
                int id = 0;
                if (dataGridViewRow.Cells["UserId"].Value != DBNull.Value)
                {
                    id = Int32.Parse(dataGridViewRow.Cells["UserId"].Value.ToString());
                }
                string name = dataGridViewRow.Cells["UserName"].Value.ToString();
                string email = dataGridViewRow.Cells["UserEmail"].Value.ToString();
                string password = dataGridViewRow.Cells["password"].Value.ToString();
                int role_id = Int32.Parse(dataGridViewRow.Cells["RoleList"].Value.ToString());
                DateTime created_at = DateTime.Parse(dataGridViewRow.Cells["Created_at"].Value.ToString());
                DateTime updated_at = DateTime.Parse(dataGridViewRow.Cells["Updated_At"].Value.ToString());
                if (id == 0)
                {
                    bool r = userHelper.insert(name, email, password, role_id);
                    if (r)
                    {
                        initalizeData();
                    }
                    else
                    {
                        MessageBox.Show("Added Seccssefully", "DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    bool r = userHelper.update(id, name, email, password, role_id, updated_at);
                    if (r)
                    {
                        initalizeData();
                    }
                    else
                    {
                        MessageBox.Show("Updated Seccssefully", "DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

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

        private void AllowNumbersOnly(Object Sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void DontAllow(Object Sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["UserId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are Sure You Want Delete The User?", "DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }

            }
        }
    }
}
