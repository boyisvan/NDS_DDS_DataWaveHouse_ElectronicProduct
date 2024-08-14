namespace ElectronicDataApp
{
    partial class ChangePasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmNewPassword = new TextBox();
            btnChangePassword = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(48, 48);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(250, 27);
            txtOldPassword.TabIndex = 0;
            txtOldPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(48, 110);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(250, 27);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(48, 172);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(250, 27);
            txtConfirmNewPassword.TabIndex = 2;
            txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(0, 192, 0);
            btnChangePassword.ForeColor = SystemColors.ButtonHighlight;
            btnChangePassword.Location = new Point(48, 229);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(250, 30);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 25);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 4;
            label1.Text = "Nhập mật khẩu cũ *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 87);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu mới *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 149);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 6;
            label3.Text = "Nhập lại mật khẩu mới *";
            // 
            // ChangePasswordForm
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(348, 271);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnChangePassword);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Mật Khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}