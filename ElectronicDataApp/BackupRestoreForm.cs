using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ElectronicDataApp
{
    public partial class BackupRestoreForm : Form
    {
        private string connectionString = @"Server=DUCVANCODER;Database=ElectronicData;User Id=sa;Password=123;";

        public BackupRestoreForm()
        {
            InitializeComponent();
            LoadTableNames();
        }

        private void LoadTableNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable tables = connection.GetSchema("Tables");
                foreach (DataRow row in tables.Rows)
                {
                    comboBoxTables.Items.Add(row["TABLE_NAME"].ToString());
                }
                if (comboBoxTables.Items.Count > 0)
                {
                    comboBoxTables.SelectedIndex = 0;
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (comboBoxTables.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bảng để sao lưu.");
                return;
            }

            string selectedTable = comboBoxTables.SelectedItem.ToString();
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {selectedTable}", connection);
                adapter.Fill(dataTable);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx|MDB files (*.mdb)|*.mdb",
                Title = "Save an Excel or MDB file"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                if (filePath.EndsWith(".xlsx"))
                {
                    ExportToExcel(dataTable, filePath);
                }
                else if (filePath.EndsWith(".mdb"))
                {
                    ExportToMDB(dataTable, filePath);
                }
            }
        }

        private void ExportToExcel(DataTable dataTable, string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // Xuất tiêu đề cột
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
            }

            // Xuất dữ liệu
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                }
            }

            workbook.SaveAs(filePath);
            workbook.Close();
            excelApp.Quit();

            // Giải phóng tài nguyên
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            MessageBox.Show("Dữ liệu đã được xuất thành công!");
        }

        private void ExportToMDB(DataTable dataTable, string filePath)
        {
            MessageBox.Show("Export to MDB not implemented yet.");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng chuyển đến phần nhập dữ liệu để khôi phục dữ liệu.");
            //Chuyển đến form nhập dữ liệu
            var importForm = new ImportData();
            importForm.ShowDialog();
        }
    }
}
