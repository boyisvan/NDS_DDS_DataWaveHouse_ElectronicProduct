using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ElectronicDataApp
{
    public partial class StatisticsForm : Form
    {
        private string connectionString = "Server=DUCVANCODER;Database=ElectronicData;User Id=sa;Password=123;";

        public StatisticsForm()
        {
            InitializeComponent();
            LoadStatisticsOptions();
        }
        private void LoadStatisticsOptions()
        {
            // Thêm các lựa chọn thống kê vào ComboBox
            comboBoxStatisticsOptions.Items.Add("Thống kê theo chi nhánh");
            comboBoxStatisticsOptions.Items.Add("Thống kê theo vùng miền");
            comboBoxStatisticsOptions.Items.Add("Thống kê theo nhóm sản phẩm");
            comboBoxStatisticsOptions.Items.Add("Thống kê theo loại khách hàng");
            comboBoxStatisticsOptions.SelectedIndex = 0;
        }
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string selectedOption = comboBoxStatisticsOptions.SelectedItem.ToString();
            string query = GetQueryForStatistics(selectedOption);

            if (query != null)
            {
                DisplayStatistics(query);
            }
            else
            {
                MessageBox.Show("Lựa chọn thống kê không hợp lệ.");
            }
        }
        private string GetQueryForStatistics(string option)
        {
            // Trả về câu lệnh SQL phù hợp với tùy chọn thống kê
            switch (option)
            {
                case "Thống kê theo chi nhánh":
                    return "SELECT BranchID, COUNT(*) AS TotalSales FROM Sales GROUP BY BranchID";
                case "Thống kê theo vùng miền":
                    return "SELECT Region, COUNT(*) AS TotalCustomers FROM Customer GROUP BY Region";
                case "Thống kê theo nhóm sản phẩm":
                    return "SELECT CategoryID, SUM(Quantity) AS TotalQuantity FROM Sales JOIN Products ON Sales.ProductID = Products.ProductID GROUP BY CategoryID";
                case "Thống kê theo loại khách hàng":
                    return "SELECT CustomerType, COUNT(*) AS TotalCustomers FROM Customer GROUP BY CustomerType";
                default:
                    return null;
            }
        }

        private void DisplayStatistics(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewStatistics.DataSource = dataTable;
            }
        }
    }
}
