namespace ElectronicDataApp
{
    partial class ImportData
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
            comboBoxTables = new ComboBox();
            btnSelectFile = new Button();
            btnUploadToSqlServer = new Button();
            label1 = new Label();
            txtFilePath = new Label();
            dataGridViewData = new DataGridView();
            label2 = new Label();
            comboBoxTables1 = new ComboBox();
            btnSelectFile1 = new Button();
            btnDeleteData = new Button();
            label3 = new Label();
            btnTransferData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTables
            // 
            comboBoxTables.FormattingEnabled = true;
            comboBoxTables.Location = new Point(28, 66);
            comboBoxTables.Name = "comboBoxTables";
            comboBoxTables.Size = new Size(268, 28);
            comboBoxTables.TabIndex = 0;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(28, 114);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(268, 29);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "Chọn tệp dữ liệu";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click_1;
            // 
            // btnUploadToSqlServer
            // 
            btnUploadToSqlServer.BackColor = Color.FromArgb(192, 255, 192);
            btnUploadToSqlServer.Location = new Point(28, 178);
            btnUploadToSqlServer.Name = "btnUploadToSqlServer";
            btnUploadToSqlServer.Size = new Size(268, 29);
            btnUploadToSqlServer.TabIndex = 2;
            btnUploadToSqlServer.Text = "Nạp dữ liệu";
            btnUploadToSqlServer.UseVisualStyleBackColor = false;
            btnUploadToSqlServer.Click += btnUploadToSqlServer_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 3;
            label1.Text = "Chọn bảng dữ liệu cần thêm *";
            // 
            // txtFilePath
            // 
            txtFilePath.AutoSize = true;
            txtFilePath.Font = new Font("Times New Roman", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtFilePath.Location = new Point(27, 155);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(98, 15);
            txtFilePath.TabIndex = 4;
            txtFilePath.Text = "đường dẫn tệp ...";
            // 
            // dataGridViewData
            // 
            dataGridViewData.BackgroundColor = SystemColors.Control;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(354, 43);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size(422, 395);
            dataGridViewData.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 255);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 6;
            label2.Text = "Xem dữ liệu";
            // 
            // comboBoxTables1
            // 
            comboBoxTables1.FormattingEnabled = true;
            comboBoxTables1.Location = new Point(28, 278);
            comboBoxTables1.Name = "comboBoxTables1";
            comboBoxTables1.Size = new Size(268, 28);
            comboBoxTables1.TabIndex = 7;
            comboBoxTables1.SelectedIndexChanged += comboBoxTables1_SelectedIndexChanged;
            // 
            // btnSelectFile1
            // 
            btnSelectFile1.BackColor = Color.LightSteelBlue;
            btnSelectFile1.Location = new Point(27, 312);
            btnSelectFile1.Name = "btnSelectFile1";
            btnSelectFile1.Size = new Size(90, 29);
            btnSelectFile1.TabIndex = 8;
            btnSelectFile1.Text = "xem";
            btnSelectFile1.UseVisualStyleBackColor = false;
            btnSelectFile1.Click += btnSelectFile1_Click;
            // 
            // btnDeleteData
            // 
            btnDeleteData.BackColor = Color.Red;
            btnDeleteData.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteData.Image = Properties.Resources.icons8_remove_data_20;
            btnDeleteData.ImageAlign = ContentAlignment.TopLeft;
            btnDeleteData.Location = new Point(123, 312);
            btnDeleteData.Name = "btnDeleteData";
            btnDeleteData.Size = new Size(173, 29);
            btnDeleteData.TabIndex = 9;
            btnDeleteData.Text = "Xóa toàn bộ dữ liệu";
            btnDeleteData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteData.UseVisualStyleBackColor = false;
            btnDeleteData.Click += btnDeleteData_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 15);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 10;
            label3.Text = "Thêm dữ liệu";
            // 
            // btnTransferData
            // 
            btnTransferData.Image = Properties.Resources.icons8_doughnut_chart_64;
            btnTransferData.Location = new Point(27, 369);
            btnTransferData.Name = "btnTransferData";
            btnTransferData.Size = new Size(269, 69);
            btnTransferData.TabIndex = 11;
            btnTransferData.Text = "NẠP DỮ LIỆU DDS";
            btnTransferData.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTransferData.UseVisualStyleBackColor = true;
            btnTransferData.Click += btnTransferData_Click;
            // 
            // ImportData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTransferData);
            Controls.Add(label3);
            Controls.Add(btnDeleteData);
            Controls.Add(btnSelectFile1);
            Controls.Add(comboBoxTables1);
            Controls.Add(label2);
            Controls.Add(dataGridViewData);
            Controls.Add(txtFilePath);
            Controls.Add(label1);
            Controls.Add(btnUploadToSqlServer);
            Controls.Add(btnSelectFile);
            Controls.Add(comboBoxTables);
            Name = "ImportData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dữ liệu hệ thống";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTables;
        private Button btnSelectFile;
        private Button btnUploadToSqlServer;
        private Label label1;
        private Label txtFilePath;
        private DataGridView dataGridViewData;
        private Label label2;
        private ComboBox comboBoxTables1;
        private Button btnSelectFile1;
        private Button btnDeleteData;
        private Label label3;
        private Button btnTransferData;
    }
}