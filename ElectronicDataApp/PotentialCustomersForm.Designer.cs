namespace ElectronicDataApp
{
    partial class PotentialCustomersForm
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
            txtCustomerTypeStatistics = new TextBox();
            dataGridViewPotentialCustomers = new DataGridView();
            btnShowPotentialCustomers = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPotentialCustomers).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerTypeStatistics
            // 
            txtCustomerTypeStatistics.Location = new Point(298, 30);
            txtCustomerTypeStatistics.Multiline = true;
            txtCustomerTypeStatistics.Name = "txtCustomerTypeStatistics";
            txtCustomerTypeStatistics.ReadOnly = true;
            txtCustomerTypeStatistics.Size = new Size(176, 134);
            txtCustomerTypeStatistics.TabIndex = 0;
            // 
            // dataGridViewPotentialCustomers
            // 
            dataGridViewPotentialCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPotentialCustomers.Location = new Point(38, 184);
            dataGridViewPotentialCustomers.Name = "dataGridViewPotentialCustomers";
            dataGridViewPotentialCustomers.RowHeadersWidth = 51;
            dataGridViewPotentialCustomers.RowTemplate.Height = 25;
            dataGridViewPotentialCustomers.Size = new Size(447, 218);
            dataGridViewPotentialCustomers.TabIndex = 1;
            // 
            // btnShowPotentialCustomers
            // 
            btnShowPotentialCustomers.Location = new Point(38, 134);
            btnShowPotentialCustomers.Name = "btnShowPotentialCustomers";
            btnShowPotentialCustomers.Size = new Size(238, 30);
            btnShowPotentialCustomers.TabIndex = 2;
            btnShowPotentialCustomers.Text = "Hiển thị khách hàng tiềm năng";
            btnShowPotentialCustomers.UseVisualStyleBackColor = true;
            btnShowPotentialCustomers.Click += btnShowPotentialCustomers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Thống kê";
            // 
            // PotentialCustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 418);
            Controls.Add(label1);
            Controls.Add(btnShowPotentialCustomers);
            Controls.Add(dataGridViewPotentialCustomers);
            Controls.Add(txtCustomerTypeStatistics);
            Name = "PotentialCustomersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách hàng tiềm năng";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPotentialCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCustomerTypeStatistics;
        private System.Windows.Forms.DataGridView dataGridViewPotentialCustomers;
        private System.Windows.Forms.Button btnShowPotentialCustomers;
        private Label label1;
    }
}
