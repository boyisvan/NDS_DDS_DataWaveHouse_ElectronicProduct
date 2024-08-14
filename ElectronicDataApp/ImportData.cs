using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace ElectronicDataApp
{
    public partial class ImportData : Form
    {

        private string selectedFilePath;
        private string connectionString;

        public ImportData()
        {
            InitializeComponent();
            LoadTableNames();
        }
        private void LoadTableNames()
        {
            // Danh sách các bảng NDS
            comboBoxTables.Items.Add("Customer");
            comboBoxTables.Items.Add("Products");
            comboBoxTables.Items.Add("ProductCategory");
            comboBoxTables.Items.Add("Branches");
            comboBoxTables.Items.Add("Sales");
            comboBoxTables.SelectedIndex = 0;
            comboBoxTables1.Items.Add("Customer");
            comboBoxTables1.Items.Add("Products");
            comboBoxTables1.Items.Add("ProductCategory");
            comboBoxTables1.Items.Add("Branch");
            comboBoxTables1.Items.Add("Sales");
            comboBoxTables1.Items.Add("Sales_DDS");
            comboBoxTables1.Items.Add("Product_DDS");
            comboBoxTables1.Items.Add("Branch_DDS");
            comboBoxTables1.Items.Add("Customer_DDS");
            comboBoxTables1.SelectedIndex = 0;
        }

        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Access Database Files (*.mdb)|*.mdb|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                txtFilePath.Text = selectedFilePath;
                connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={selectedFilePath};";
                LoadDataFromAccess();
            }
        }
        private void btnSelectFile1_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBoxTables1.SelectedItem.ToString();
            DisplayDataFromTable(selectedTable);
        }
        private void LoadDataFromAccess()
        {
            if (string.IsNullOrEmpty(selectedFilePath))
                return;

            string tableName = comboBoxTables.SelectedItem.ToString();
            string query = $"SELECT * FROM {tableName}";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewData.DataSource = dataTable;
            }
        }
        private void DisplayDataFromTable(string tableName)
        {
            connectionString = "Server=DUCVANCODER;Database=ElectronicData;User Id=sa;Password=123;";
            string query = $"SELECT * FROM {tableName}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewData.DataSource = dataTable;
            }
        }
        private void btnUploadToSqlServer_Click_1(object sender, EventArgs e)
        {
            string tableName = comboBoxTables.SelectedItem.ToString();
            string sqlConnectionString = @"Server=DUCVANCODER;Database=ElectronicData;User Id=sa;Password=123;";

            DataTable dataTable = (DataTable)dataGridViewData.DataSource;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(sqlConnection))
                    {
                        bulkCopy.DestinationTableName = tableName;

                        try
                        {
                            bulkCopy.WriteToServer(dataTable);
                            MessageBox.Show("Dữ liệu đã được nạp vào SQL Server thành công.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để nạp.");
            }
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBoxTables1.SelectedItem.ToString();
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa toàn bộ dữ liệu của bảng '{selectedTable}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteDataFromTable(selectedTable);
                // Cập nhật lại dữ liệu sau khi xóa
                DisplayDataFromTable(selectedTable);
            }
        }
        private void DeleteDataFromTable(string tableName)
        {
            string sqlConnectionString1 = @"Server=DUCVANCODER;Database=ElectronicData;User Id=sa;Password=123;";
            string query = $"DELETE FROM {tableName}";

            using (SqlConnection connection = new SqlConnection(sqlConnectionString1))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnTransferData_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi chuyển đổi
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn chuyển đổi dữ liệu từ NDS sang DDS không?",
                "Xác nhận chuyển đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TransferData();
                MessageBox.Show("Dữ liệu đã được chuyển đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TransferData()
        {
            string query = @"
                TRUNCATE TABLE Customer_DDS;
                TRUNCATE TABLE Product_DDS;
                TRUNCATE TABLE Branch_DDS;
                TRUNCATE TABLE Sales_DDS;

                -- Chuyển dữ liệu từ Customer (NDS) sang Customer_DDS
                INSERT INTO Customer_DDS (CustomerID, CustomerName, Address, Region, CustomerType, Phone, Email)
                SELECT CustomerID, CustomerName, Address, Region, CustomerType, Phone, Email
                FROM Customer;

                -- Chuyển dữ liệu từ Products và ProductCategory (NDS) sang Product_DDS
                INSERT INTO Product_DDS (ProductID, ProductName, CategoryName, BrandID, Price, Stock, Supplier)
                SELECT P.ProductID, P.ProductName, C.CategoryName, P.BrandID, P.Price, P.Stock, P.Supplier
                FROM Products P
                JOIN ProductCategory C ON P.CategoryID = C.CategoryID;

                -- Chuyển dữ liệu từ Branches (NDS) sang Branch_DDS
                INSERT INTO Branch_DDS (BranchID, BranchName, BranchAddress, Region)
                SELECT BranchID, BranchName, BranchAddress, Region
                FROM Branches;

                -- Chuyển dữ liệu từ Sales, Customer, Products, Branches (NDS) sang Sales_DDS
                INSERT INTO Sales_DDS (SalesID, SalesDate, CustomerID, CustomerName, BranchID, BranchName, ProductID, ProductName, CategoryName, Quantity, Revenue)
                SELECT S.SalesID, S.SalesDate, S.CustomerID, C.CustomerName, S.BranchID, B.BranchName, S.ProductID, P.ProductName, PC.CategoryName, S.Quantity, S.Revenue
                FROM Sales S
                JOIN Customer C ON S.CustomerID = C.CustomerID
                JOIN Branches B ON S.BranchID = B.BranchID
                JOIN Products P ON S.ProductID = P.ProductID
                JOIN ProductCategory PC ON P.CategoryID = PC.CategoryID;
            ";
            string sqlConnectionString2 = @"Server=DUCVANCODER;Database=ElectronicData;User Id=sa;Password=123;";
            using (SqlConnection connection = new SqlConnection(sqlConnectionString2))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void comboBoxTables1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
