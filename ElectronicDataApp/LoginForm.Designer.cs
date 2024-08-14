namespace ElectronicDataApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 27);
            label1.Name = "label1";
            label1.Size = new Size(277, 31);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            label2.AccessibleName = "lblUsername ";
            label2.AutoSize = true;
            label2.Location = new Point(38, 87);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập *";
            // 
            // label3
            // 
            label3.AccessibleName = "lblPassword";
            label3.AutoSize = true;
            label3.Location = new Point(38, 186);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu *";
            // 
            // txtUsername
            // 
            txtUsername.AccessibleName = "";
            txtUsername.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(38, 125);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.AccessibleName = "";
            txtPassword.Location = new Point(38, 232);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleGreen;
            btnLogin.Location = new Point(38, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(270, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.R__1_;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(433, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(41, 278);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Nhớ mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(343, 426);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 8;
            label4.Text = "design by @caicuc";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Label label4;
    }
}