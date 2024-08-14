namespace ElectronicDataApp
{
    partial class BackupRestoreForm
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
            btnBackup = new Button();
            btnRestore = new Button();
            SuspendLayout();
            // 
            // comboBoxTables
            // 
            comboBoxTables.FormattingEnabled = true;
            comboBoxTables.Location = new Point(42, 52);
            comboBoxTables.Name = "comboBoxTables";
            comboBoxTables.Size = new Size(179, 28);
            comboBoxTables.TabIndex = 0;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.Lime;
            btnBackup.ForeColor = SystemColors.ButtonHighlight;
            btnBackup.Location = new Point(227, 52);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(97, 30);
            btnBackup.TabIndex = 1;
            btnBackup.Text = "Sao lưu";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestore
            // 
            btnRestore.Image = Properties.Resources.icons8_doughnut_chart_64;
            btnRestore.Location = new Point(73, 135);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(204, 69);
            btnRestore.TabIndex = 2;
            btnRestore.Text = "Khôi phục dữ liệu";
            btnRestore.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRestore.UseVisualStyleBackColor = true;
            // 
            // BackupRestoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 233);
            Controls.Add(btnRestore);
            Controls.Add(btnBackup);
            Controls.Add(comboBoxTables);
            Name = "BackupRestoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sao lưu dữ liệu";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxTables;
        private Button btnBackup;
        private Button btnRestore;
    }
}