namespace ElectronicDataApp
{
    partial class StatisticsForm
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
            comboBoxStatisticsOptions = new ComboBox();
            btnGenerateReport = new Button();
            dataGridViewStatistics = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistics).BeginInit();
            SuspendLayout();
            // 
            // comboBoxStatisticsOptions
            // 
            comboBoxStatisticsOptions.FormattingEnabled = true;
            comboBoxStatisticsOptions.Location = new Point(25, 36);
            comboBoxStatisticsOptions.Name = "comboBoxStatisticsOptions";
            comboBoxStatisticsOptions.Size = new Size(286, 28);
            comboBoxStatisticsOptions.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(326, 35);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(133, 29);
            btnGenerateReport.TabIndex = 1;
            btnGenerateReport.Text = "Tạo thống kê";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dataGridViewStatistics
            // 
            dataGridViewStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatistics.Location = new Point(25, 96);
            dataGridViewStatistics.Name = "dataGridViewStatistics";
            dataGridViewStatistics.RowHeadersWidth = 51;
            dataGridViewStatistics.Size = new Size(449, 271);
            dataGridViewStatistics.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Chọn thống kê *";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 393);
            Controls.Add(label1);
            Controls.Add(dataGridViewStatistics);
            Controls.Add(btnGenerateReport);
            Controls.Add(comboBoxStatisticsOptions);
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê dữ liệu";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxStatisticsOptions;
        private Button btnGenerateReport;
        private DataGridView dataGridViewStatistics;
        private Label label1;
    }
}