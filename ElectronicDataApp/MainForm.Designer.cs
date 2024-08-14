namespace ElectronicDataApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            btnLogout = new Button();
            btnChangePassword = new Button();
            btnImportData = new Button();
            btnAnalyzeData = new Button();
            btnBackupRestore = new Button();
            btnPredictCustomer = new Button();
            pictureBoxSlider = new PictureBox();
            timerSlider = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSlider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Xin chào admin !";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(685, 14);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(103, 29);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Đăng xuất ";
            btnLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(12, 46);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(140, 29);
            btnChangePassword.TabIndex = 2;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnImportData
            // 
            btnImportData.BackColor = Color.FromArgb(192, 255, 192);
            btnImportData.Image = (Image)resources.GetObject("btnImportData.Image");
            btnImportData.Location = new Point(12, 109);
            btnImportData.Name = "btnImportData";
            btnImportData.Size = new Size(148, 94);
            btnImportData.TabIndex = 3;
            btnImportData.Text = "Nạp dữ liệu";
            btnImportData.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImportData.UseVisualStyleBackColor = false;
            btnImportData.Click += btnImportData_Click;
            // 
            // btnAnalyzeData
            // 
            btnAnalyzeData.BackColor = Color.FromArgb(192, 255, 255);
            btnAnalyzeData.Image = (Image)resources.GetObject("btnAnalyzeData.Image");
            btnAnalyzeData.Location = new Point(225, 109);
            btnAnalyzeData.Name = "btnAnalyzeData";
            btnAnalyzeData.Size = new Size(148, 94);
            btnAnalyzeData.TabIndex = 4;
            btnAnalyzeData.Text = "Thống kê";
            btnAnalyzeData.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAnalyzeData.UseVisualStyleBackColor = false;
            btnAnalyzeData.Click += btnAnalyzeData_Click;
            // 
            // btnBackupRestore
            // 
            btnBackupRestore.BackColor = Color.FromArgb(192, 192, 255);
            btnBackupRestore.Image = (Image)resources.GetObject("btnBackupRestore.Image");
            btnBackupRestore.Location = new Point(12, 267);
            btnBackupRestore.Name = "btnBackupRestore";
            btnBackupRestore.Size = new Size(148, 94);
            btnBackupRestore.TabIndex = 5;
            btnBackupRestore.Text = "Sao lưu dữ liệu";
            btnBackupRestore.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBackupRestore.UseVisualStyleBackColor = false;
            btnBackupRestore.Click += btnBackupRestore_Click;
            // 
            // btnPredictCustomer
            // 
            btnPredictCustomer.BackColor = Color.FromArgb(255, 192, 255);
            btnPredictCustomer.Image = (Image)resources.GetObject("btnPredictCustomer.Image");
            btnPredictCustomer.Location = new Point(225, 267);
            btnPredictCustomer.Name = "btnPredictCustomer";
            btnPredictCustomer.Size = new Size(148, 94);
            btnPredictCustomer.TabIndex = 6;
            btnPredictCustomer.Text = "Khách hàng tiềm năng";
            btnPredictCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPredictCustomer.UseVisualStyleBackColor = false;
            btnPredictCustomer.Click += btnPredictCustomer_Click;
            // 
            // pictureBoxSlider
            // 
            pictureBoxSlider.Location = new Point(449, 98);
            pictureBoxSlider.Name = "pictureBoxSlider";
            pictureBoxSlider.Size = new Size(263, 263);
            pictureBoxSlider.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSlider.TabIndex = 7;
            pictureBoxSlider.TabStop = false;
            // 
            // timerSlider
            // 
            timerSlider.Interval = 2000;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxSlider);
            Controls.Add(btnPredictCustomer);
            Controls.Add(btnBackupRestore);
            Controls.Add(btnAnalyzeData);
            Controls.Add(btnImportData);
            Controls.Add(btnChangePassword);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ hệ thống";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button btnLogout;
        private Button btnChangePassword;
        private Button btnImportData;
        private Button btnAnalyzeData;
        private Button btnBackupRestore;
        private Button btnPredictCustomer;
        private PictureBox pictureBoxSlider;
        private System.Windows.Forms.Timer timerSlider;
    }
}