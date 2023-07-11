namespace POSN3.Views.components
{
    partial class DatatableView
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
            dg67856 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg67856).BeginInit();
            SuspendLayout();
            // 
            // dg67856
            // 
            dg67856.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg67856.Dock = DockStyle.Fill;
            dg67856.Location = new Point(0, 0);
            dg67856.Name = "dg67856";
            dg67856.RowTemplate.Height = 25;
            dg67856.Size = new Size(715, 396);
            dg67856.TabIndex = 0;
            // 
            // DatatableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            Controls.Add(dg67856);
            Name = "DatatableView";
            Size = new Size(715, 396);
            ((System.ComponentModel.ISupportInitialize)dg67856).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg67856;
    }
}
