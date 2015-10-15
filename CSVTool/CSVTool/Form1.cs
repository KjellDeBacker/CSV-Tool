using System;
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

        private void MenuBar_File_Open_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = File.OpenText(OpenFileDialog.FileName);

                String[] Headers = sr.ReadLine().Split(',');
                DataGridView.ColumnCount = Headers.Length;

                for (int i = 0; i < Headers.Length; i++)
                {
                    DataGridView.Columns[i].Name = Headers[i];
                }

                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    DataGridView.Rows.Add(s.Split(','));
                }
            }
        }
    }
}
