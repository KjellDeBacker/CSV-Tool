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
            this.MenuBarFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBarFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Table = new System.Windows.Forms.DataGridView();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBar_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBarFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarFile});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(284, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "MenuBar";
            // 
            // MenuBarFile
            // 
            this.MenuBarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarFileOpen,
            this.toolStripSeparator2,
            this.MenuBarFileSave,
            this.toolStripSeparator1,
            this.MenuBarFileExit});
            this.MenuBarFile.Name = "MenuBarFile";
            this.MenuBarFile.Size = new System.Drawing.Size(37, 20);
            this.MenuBarFile.Text = "File";
            // 
            // MenuBarFileOpen
            // 
            this.MenuBarFileOpen.Name = "MenuBarFileOpen";
            this.MenuBarFileOpen.Size = new System.Drawing.Size(152, 22);
            this.MenuBarFileOpen.Text = "Open";
            this.MenuBarFileOpen.Click += new System.EventHandler(this.MenuBarFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuBarFileExit
            // 
            this.MenuBarFileExit.Name = "MenuBarFileExit";
            this.MenuBarFileExit.Size = new System.Drawing.Size(152, 22);
            this.MenuBarFileExit.Text = "Exit";
            this.MenuBarFileExit.Click += new System.EventHandler(this.MenuBarFileExit_Click);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 24);
            this.Table.Name = "Table";
            this.Table.RowHeadersVisible = false;
            this.Table.Size = new System.Drawing.Size(284, 237);
            this.Table.TabIndex = 1;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar_Label});
            this.StatusBar.Location = new System.Drawing.Point(0, 239);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(284, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "StatusBar";
            // 
            // StatusBar_Label
            // 
            this.StatusBar_Label.Name = "StatusBar_Label";
            this.StatusBar_Label.Size = new System.Drawing.Size(269, 17);
            this.StatusBar_Label.Spring = true;
            this.StatusBar_Label.Text = "Ready";
            this.StatusBar_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuBarFileSave
            // 
            this.MenuBarFileSave.Name = "MenuBarFileSave";
            this.MenuBarFileSave.Size = new System.Drawing.Size(152, 22);
            this.MenuBarFileSave.Text = "Save";
            this.MenuBarFileSave.Click += new System.EventHandler(this.MenuBarFileSave_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // CSVTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "CSVTool";
            this.Text = "CSV Tool";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuBarFile;
        private System.Windows.Forms.ToolStripMenuItem MenuBarFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuBarFileExit;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar_Label;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuBarFileSave;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

