using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ExcelObj = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Excel;

namespace Unmanaged.Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox textBoxFilePath;
        private Button ButtonLoad;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;

        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NewSheet;
        ExcelObj.Range SheetRange;

        DataTable dt = new DataTable();

        private void Load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog1.FileName;
                workbook = app.Workbooks.Open(openFileDialog1.FileName);
                NewSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                SheetRange = NewSheet.UsedRange;
                for (int column = 1; column <= SheetRange.Columns.Count; column++)
                {
                    dt.Columns.Add(new DataColumn((SheetRange.Cells[1, column] as ExcelObj.Range).Value2.ToString()));
                }
                dt.AcceptChanges();

                string[] ColumnNames = new String[dt.Columns.Count];

                for (int i =0; i < dt.Columns.Count; i++)
                {
                    ColumnNames[0] = dt.Columns[i].ColumnName;
                }

                for (int row = 2; row <= SheetRange.Rows.Count; row++)
                {
                    DataRow dr = dt.NewRow();

                    for (int column = 1; column <= SheetRange.Columns.Count; column++)
                    {
                        if ((SheetRange.Cells[row, column] as ExcelObj.Range).Value2 != 0)
                        {
                            dr[column - 1] = (SheetRange.Cells[row, column] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }

                dataGridView1.DataSource = dt;
                app.Quit();
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
