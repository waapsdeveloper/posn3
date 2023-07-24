using System.Windows.Forms;

namespace POSN3.Views
{
    partial class LogListView
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
            datatableView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datatableView1).BeginInit();
            SuspendLayout();
            // 
            // datatableView1
            // 
            datatableView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datatableView1.BackgroundColor = Color.FromArgb(254, 250, 224);
            datatableView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datatableView1.Columns.AddRange(new DataGridViewColumn[] { id, UserId });
            datatableView1.GridColor = Color.FromArgb(254, 250, 224);
            datatableView1.Location = new Point(0, 0);
            datatableView1.Name = "datatableView1";
            datatableView1.RowTemplate.Height = 25;
            datatableView1.Size = new Size(719, 409);
            datatableView1.TabIndex = 3;
            datatableView1.CellEndEdit += dataGridView1_CellEndEditAsync;
            datatableView1.CellValueChanged += dataGridView1_CellValueChanged;
            datatableView1.DataError += dataGridView1_DataError;
            datatableView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            datatableView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "user_id";
            UserId.HeaderText = "user_id";
            UserId.Name = "UserId";
            // 
            // LogListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            Controls.Add(datatableView1);
            Name = "LogListView";
            Size = new Size(719, 409);
            ((System.ComponentModel.ISupportInitialize)datatableView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datatableView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewComboBoxColumn UserId;
    }
}
