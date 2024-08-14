using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicDataApp
{
    public partial class MainForm : Form
    {
        private List<Image> images = new List<Image>();
        private int currentImageIndex = 0;
        public MainForm()
        {
            InitializeComponent();
            LoadImages();
            InitializeTimer();
            pictureBoxSlider.Image = images[currentImageIndex];

        }
        private void InitializeTimer()
        {
            timerSlider = new System.Windows.Forms.Timer();
            timerSlider.Interval = 3000;
            timerSlider.Tick += timerSlider_Tick; // Gán sự kiện Tick
            timerSlider.Start(); // Bắt đầu Timer
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadImages()
        {
            images.Add(Properties.Resources.sapplew);
            images.Add(Properties.Resources.siphone);
            images.Add(Properties.Resources.smacb);
        }
        private void timerSlider_Tick(object sender, EventArgs e)
        {
            currentImageIndex++;
            if (currentImageIndex >= images.Count)
            {
                currentImageIndex = 0;
            }
            pictureBoxSlider.Image = images[currentImageIndex];
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            ImportData importDataForm = new ImportData();
            importDataForm.ShowDialog();
        }

        private void btnAnalyzeData_Click(object sender, EventArgs e)
        {
            // Mở form thống kê
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
        }

        private void btnPredictCustomer_Click(object sender, EventArgs e)
        {
            // Mở form thống kê
            PotentialCustomersForm potentialCustomersForm = new PotentialCustomersForm();
            potentialCustomersForm.ShowDialog();
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            BackupRestoreForm backupRestoreForm = new BackupRestoreForm();
            backupRestoreForm.ShowDialog();
        }
    }
}
