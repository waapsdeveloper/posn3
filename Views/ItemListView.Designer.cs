﻿using System.Windows.Forms;

namespace POSN3.Views
{
    partial class ItemListView
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
            searchBarView1 = new components.SearchBarView();
            searchBarView2 = new components.SearchBarView();
            datatableView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datatableView1).BeginInit();
            SuspendLayout();
            // 
            // searchBarView1
            // 
            searchBarView1.AutoSize = true;
            searchBarView1.BackColor = Color.FromArgb(254, 250, 224);
            searchBarView1.Dock = DockStyle.Top;
            searchBarView1.Location = new Point(0, 0);
            searchBarView1.Name = "searchBarView1";
            searchBarView1.Size = new Size(719, 0);
            searchBarView1.TabIndex = 1;
            // 
            // searchBarView2
            // 
            searchBarView2.AutoSize = true;
            searchBarView2.BackColor = Color.FromArgb(254, 250, 224);
            searchBarView2.Dock = DockStyle.Top;
            searchBarView2.Location = new Point(0, 0);
            searchBarView2.Name = "searchBarView2";
            searchBarView2.Size = new Size(719, 0);
            searchBarView2.TabIndex = 2;
            // 
            // datatableView1
            // 
            datatableView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datatableView1.BackgroundColor = Color.FromArgb(254, 250, 224);
            datatableView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datatableView1.Columns.AddRange(new DataGridViewColumn[] { id });
            datatableView1.GridColor = Color.FromArgb(254, 250, 224);
            datatableView1.Location = new Point(0, 0);
            datatableView1.Name = "datatableView1";
            datatableView1.RowTemplate.Height = 25;
            datatableView1.Size = new Size(719, 409);
            datatableView1.TabIndex = 3;
            datatableView1.CellEndEdit += dataGridView1_CellEndEdit;
            datatableView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            datatableView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.Frozen = true;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // ItemListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            Controls.Add(datatableView1);
            Name = "ItemListView";
            Size = new Size(719, 409);
            ((System.ComponentModel.ISupportInitialize)datatableView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private components.SearchBarView searchBarView1;
        private components.SearchBarView searchBarView2;
        private DataGridView datatableView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
    }
}
