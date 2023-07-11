using System.Windows.Forms;

namespace POSN3.Views
{
    partial class UsersView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            searchBarView1 = new components.SearchBarView();
            dataGridView1 = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            UserEmail = new DataGridViewTextBoxColumn();
            RoleList = new DataGridViewComboBoxColumn();
            password = new DataGridViewTextBoxColumn();
            Created_at = new DataGridViewTextBoxColumn();
            Updated_At = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(searchBarView1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 0);
            panel1.TabIndex = 4;
            // 
            // searchBarView1
            // 
            searchBarView1.AutoSize = true;
            searchBarView1.BackColor = Color.FromArgb(254, 250, 224);
            searchBarView1.Dock = DockStyle.Fill;
            searchBarView1.Location = new Point(0, 0);
            searchBarView1.Name = "searchBarView1";
            searchBarView1.Size = new Size(863, 0);
            searchBarView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = Color.FromArgb(254, 250, 224);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(2, 48, 71);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(2, 48, 71);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserId, UserName, UserEmail, RoleList, password, Created_at, Updated_At });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(254, 250, 224);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(863, 442);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "id";
            UserId.HeaderText = "ID";
            UserId.Name = "UserId";
            UserId.Width = 43;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.DataPropertyName = "name";
            UserName.FillWeight = 67.2304459F;
            UserName.HeaderText = "Name";
            UserName.Name = "UserName";
            // 
            // UserEmail
            // 
            UserEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserEmail.DataPropertyName = "email";
            UserEmail.FillWeight = 132.769547F;
            UserEmail.HeaderText = "Email";
            UserEmail.Name = "UserEmail";
            // 
            // RoleList
            // 
            RoleList.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoleList.DataPropertyName = "role_id";
            RoleList.HeaderText = "Role";
            RoleList.Name = "RoleList";
            // 
            // password
            // 
            password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            password.DataPropertyName = "password";
            password.HeaderText = "password";
            password.Name = "password";
            // 
            // Created_at
            // 
            Created_at.DataPropertyName = "created_at";
            Created_at.HeaderText = "Created At";
            Created_at.Name = "Created_at";
            Created_at.Width = 88;
            // 
            // Updated_At
            // 
            Updated_At.DataPropertyName = "updated_at";
            Updated_At.HeaderText = "Updated At";
            Updated_At.Name = "Updated_At";
            Updated_At.Width = 92;
            // 
            // UsersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(254, 250, 224);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "UsersView";
            Size = new Size(863, 442);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel listPanel;
        private Panel addPanel;
        private Panel updatePanel;
        private Panel panel1;
        private components.SearchBarView searchBarView1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserEmail;
        private DataGridViewComboBoxColumn RoleList;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn Created_at;
        private DataGridViewTextBoxColumn Updated_At;
    }
}
