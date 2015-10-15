namespace CSVTool
{
    partial class CSVTool
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuBar_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBar_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBar_File});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(284, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "MenuBar";
            // 
            // MenuBar_File
            // 
            this.MenuBar_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBar_File_Open,
            this.toolStripSeparator1,
            this.MenuBar_File_Exit});
            this.MenuBar_File.Name = "MenuBar_File";
            this.MenuBar_File.Size = new System.Drawing.Size(37, 20);
            this.MenuBar_File.Text = "File";
            // 
            // MenuBar_File_Open
            // 
            this.MenuBar_File_Open.Name = "MenuBar_File_Open";
            this.MenuBar_File_Open.Size = new System.Drawing.Size(152, 22);
            this.MenuBar_File_Open.Text = "Open";
            this.MenuBar_File_Open.Click += new System.EventHandler(this.MenuBar_File_Open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuBar_File_Exit
            // 
            this.MenuBar_File_Exit.Name = "MenuBar_File_Exit";
            this.MenuBar_File_Exit.Size = new System.Drawing.Size(152, 22);
            this.MenuBar_File_Exit.Text = "Exit";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 24);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.Size = new System.Drawing.Size(284, 237);
            this.DataGridView.TabIndex = 1;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // CSVTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "CSVTool";
            this.Text = "CSV Tool";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuBar_File;
        private System.Windows.Forms.ToolStripMenuItem MenuBar_File_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuBar_File_Exit;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

