namespace POSN3.Views
{
    partial class PartnerListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            UserList = new DataGridViewComboBoxColumn();
            id = new DataGridViewTextBoxColumn();
            Users = new DataGridViewComboBoxColumn();
            Cities = new DataGridViewComboBoxColumn();
            VendorAccount = new DataGridViewComboBoxColumn();
            CustomerAccount = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(254, 250, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Users, Cities, VendorAccount, CustomerAccount });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(254, 250, 224);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(787, 490);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // UserList
            // 
            UserList.Name = "UserList";
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            // 
            // Users
            // 
            Users.DataPropertyName = "person";
            Users.HeaderText = "user";
            Users.Name = "Users";
            // 
            // Cities
            // 
            Cities.DataPropertyName = "city_id";
            Cities.HeaderText = "city";
            Cities.Name = "Cities";
            // 
            // VendorAccount
            // 
            VendorAccount.DataPropertyName = "vendor_account";
            VendorAccount.HeaderText = "vendor_account";
            VendorAccount.Name = "VendorAccount";
            VendorAccount.Resizable = DataGridViewTriState.True;
            VendorAccount.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CustomerAccount
            // 
            CustomerAccount.DataPropertyName = "customer_account";
            CustomerAccount.HeaderText = "customer_account";
            CustomerAccount.Name = "CustomerAccount";
            CustomerAccount.Resizable = DataGridViewTriState.True;
            CustomerAccount.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PartnerListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            Controls.Add(dataGridView1);
            Name = "PartnerListView";
            Size = new Size(787, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn UserList;
        private DataGridViewTextBoxColumn id;
        private DataGridViewComboBoxColumn Cities;
        private DataGridViewComboBoxColumn VendorAccount;
        private DataGridViewComboBoxColumn CustomerAccount;
        private DataGridViewComboBoxColumn Users;
    }
}
