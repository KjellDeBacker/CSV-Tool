using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CSVTool
{
    public partial class CSVTool : Form
    {
        public CSVTool()
        {
            InitializeComponent();
        }

        public void LoadCSVFile(String path)
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            
            StreamReader file = File.OpenText(path);

            String[] header = file.ReadLine().Split(',');
            Table.ColumnCount = header.Length;

            for (int i = 0; i < Table.ColumnCount; i++)
            {
                Table.Columns[i].Name = header[i];
            }

            String row = "";
            while ((row = file.ReadLine()) != null)
            {
                Table.Rows.Add(row.Split(','));
            }

            file.Close();
        }

        public void SaveCSVFile(String path)
        {
            Boolean temp = Table.AllowUserToAddRows;
            Table.AllowUserToAddRows = false;

            StreamWriter file = new StreamWriter(path);

            List<String> header = new List<String>();

            for (int i = 0; i < Table.ColumnCount; i++)
            {
                header.Add(Table.Columns[i].Name);
            }

            file.WriteLine(String.Join(",", header));

            foreach (DataGridViewRow row in Table.Rows)
            {
                List<String> rowArray = new List<String>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowArray.Add((String)cell.Value);
                }
                file.WriteLine(String.Join(",", rowArray));
            }

            file.Close();

            Table.AllowUserToAddRows = temp;
        }

        private void MenuBarFileOpen_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadCSVFile(OpenFileDialog.FileName);
            }
        }

        private void MenuBarFileSave_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCSVFile(SaveFileDialog.FileName);
            }
        }

        private void MenuBarFileExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
