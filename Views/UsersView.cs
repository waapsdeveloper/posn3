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



        async void initalizeData()
        {
            try
            {
                SqliteHelper sqliteHelper = new SqliteHelper();
                UserHelper userHelper = new UserHelper(sqliteHelper);
                DataTable dt = await userHelper.all();

                dt.Columns["ID"].ReadOnly = true;
                dt.Columns["created_at"].ReadOnly = true;
                dt.Columns["updated_at"].ReadOnly = true;

                dataGridView1.DataSource = dt;
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }
        }

        async void populateRoleComboBox()
        {

            try
            {
                SqliteHelper sqliteHelper = new SqliteHelper();
                RoleHelper roleHelper = new RoleHelper(sqliteHelper);
                DataTable dt = await roleHelper.all();
                RoleList.ValueMember = "id";
                RoleList.DisplayMember = "name";
                RoleList.DataSource = dt;
            }
            catch (Exception e)
            {
                UtilityHelper.consoleLog(e.Message);
            }
        }


        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
                    SqliteHelper sqliteHelper = new SqliteHelper();
                    UserHelper userHelper = new UserHelper(sqliteHelper);
                    int id = 0;
                    if (dataGridViewRow.Cells["ID"].Value != DBNull.Value)
                    {
                        id = Int32.Parse(dataGridViewRow.Cells["ID"].Value.ToString());
                    }
                    string name = dataGridViewRow.Cells["name"].Value.ToString();
                    string email = dataGridViewRow.Cells["email"].Value.ToString();
                    string password = dataGridViewRow.Cells["password"].Value.ToString();

                    int? role_id = null;
                    if (dataGridViewRow.Cells["RoleList"].Value != DBNull.Value)
                    {
                        role_id = Int32.Parse(dataGridViewRow.Cells["RoleList"].Value.ToString());
                    }

                    // Perform validation
                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please provide all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (id == 0)
                    {
                        bool r = await userHelper.insertAsync(name, email, password, role_id);
                        if (r)
                        {
                            initalizeData();
                        }
                    }
                    else
                    {
                        bool r = await userHelper.updateAsync(id, name, email, password, role_id);
                        if (r)
                        {
                            initalizeData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["ID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are Sure You Want Delete The User?", "DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }

            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
