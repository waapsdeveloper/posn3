namespace POSN3.Views
{
    partial class ProductsView
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
            AccountId = new DataGridViewComboBoxColumn();
            UnitMeasure = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(254, 250, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, AccountId, UnitMeasure });
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
            // AccountId
            // 
            AccountId.DataPropertyName = "account_id";
            AccountId.HeaderText = "account_id";
            AccountId.Name = "AccountId";
            // 
            // UnitMeasure
            // 
            UnitMeasure.DataPropertyName = "unit_measure";
            UnitMeasure.HeaderText = "unit_measure";
            UnitMeasure.Name = "UnitMeasure";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            Controls.Add(dataGridView1);
            Name = "ProductsView";
            Size = new Size(787, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn UserList;
        private DataGridViewTextBoxColumn id;
        private DataGridViewComboBoxColumn AccountId;
        private DataGridViewComboBoxColumn UnitMeasure;
    }
}
