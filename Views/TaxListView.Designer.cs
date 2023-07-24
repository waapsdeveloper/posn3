﻿using POSN3.Views.components;

namespace POSN3.Views
{
    partial class TaxListView
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
            name = new DataGridViewTextBoxColumn();
            account = new DataGridViewTextBoxColumn();
            AccountInId = new DataGridViewComboBoxColumn();
            AccountOutId = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(254, 250, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, account, AccountInId, AccountOutId });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(254, 250, 224);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView3";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(787, 490);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            //dataGridView1.DataError += dataGridView1_DataError;
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
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "name *";
            name.Name = "name";
            // 
            // account
            // 
            account.DataPropertyName = "account";
            account.HeaderText = "account *";
            account.MaxInputLength = 7;
            account.Name = "account";
            // 
            // AccountInId
            // 
            AccountInId.DataPropertyName = "account_in_id";
            AccountInId.HeaderText = "account_in_id *";
            AccountInId.Name = "AccountInId";
            // 
            // AccountOutId
            // 
            AccountOutId.DataPropertyName = "account_out_id";
            AccountOutId.HeaderText = "account_out_id *";
            AccountOutId.Name = "AccountOutId";
            // 
            // TaxListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            Controls.Add(dataGridView1);
            Name = "TaxListView";
            Size = new Size(787, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn UserList;
        private DataGridViewTextBoxColumn id;
        private DataGridViewComboBoxColumn AccountInId;
        private DataGridViewComboBoxColumn AccountOutId;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn account;
    }
}
