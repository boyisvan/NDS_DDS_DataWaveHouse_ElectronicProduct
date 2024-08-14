using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElectronicDataApp
{
    public partial class PotentialCustomersForm : Form
    {
        private string connectionString = "Server=DUCVANCODER;Database=ElectronicData;User Id=sa;Password=123;";

        public PotentialCustomersForm()
        {
            InitializeComponent();
            LoadCustomerTypeStatistics();
        }

        private void LoadCustomerTypeStatistics()
        {
            string query = "SELECT CustomerType, COUNT(*) AS TotalCustomers FROM Customer GROUP BY CustomerType";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Hiển thị thống kê khách hàng theo loại
                txtCustomerTypeStatistics.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    txtCustomerTypeStatistics.AppendText($"{row["CustomerType"]} - Số lượng: {row["TotalCustomers"]}\n");
                }
            }
        }

        private void btnShowPotentialCustomers_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT TOP 10 C.CustomerID, C.CustomerName, SUM(S.Revenue) AS TotalRevenue
                FROM Sales S
                JOIN Customer C ON S.CustomerID = C.CustomerID
                GROUP BY C.CustomerID, C.CustomerName
                ORDER BY TotalRevenue DESC;
                ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewPotentialCustomers.DataSource = dataTable;
            }
        }
    }
}
