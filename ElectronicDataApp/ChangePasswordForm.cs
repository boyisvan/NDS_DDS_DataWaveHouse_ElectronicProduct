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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPassword.Text;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Mật khẩu mới không khớp.");
                return;
            }

            string connectionString = "Data Source=DUCVANCODER;Initial Catalog=ElectronicData;Persist Security Info=True;User ID=sa;Password=123";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PasswordHash FROM Users WHERE Username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", "admin"); // Thay bằng tên người dùng hiện tại
                string oldPasswordHash = (string)command.ExecuteScalar();

                // So sánh mật khẩu cũ
                if (oldPasswordHash != oldPassword)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.");
                    return;
                }

                // Cập nhật mật khẩu mới
                query = "UPDATE Users SET PasswordHash = @newPasswordHash WHERE Username = @username";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@newPasswordHash", newPassword);
                command.Parameters.AddWithValue("@username", "admin"); 
                command.ExecuteNonQuery();

                MessageBox.Show("Mật khẩu đã được thay đổi thành công.");
            }
        }



    }
}
