namespace ManagementInternet.View.Working.Management
{
    partial class RevenueFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRevenueStatistics = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepositMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRechargeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRevenueStatisticsOrder = new System.Windows.Forms.Button();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.btnRevenueOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvRevenueStatisticsOrder = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueStatisticsOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1202, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRevenueStatistics);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker3);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1194, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRevenueStatistics
            // 
            this.btnRevenueStatistics.Location = new System.Drawing.Point(536, 90);
            this.btnRevenueStatistics.Name = "btnRevenueStatistics";
            this.btnRevenueStatistics.Size = new System.Drawing.Size(175, 40);
            this.btnRevenueStatistics.TabIndex = 12;
            this.btnRevenueStatistics.Text = "Thống kê doanh thu";
            this.btnRevenueStatistics.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bắt đầu";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(454, 32);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colAccountName,
            this.colDepositMoney,
            this.colRechargeTime});
            this.dataGridView1.Location = new System.Drawing.Point(15, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 245);
            this.dataGridView1.TabIndex = 7;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Width = 125;
            // 
            // colAccountName
            // 
            this.colAccountName.HeaderText = "Tài khoản";
            this.colAccountName.MinimumWidth = 6;
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Width = 125;
            // 
            // colDepositMoney
            // 
            this.colDepositMoney.HeaderText = "Số tiền nạp";
            this.colDepositMoney.MinimumWidth = 6;
            this.colDepositMoney.Name = "colDepositMoney";
            this.colDepositMoney.Width = 125;
            // 
            // colRechargeTime
            // 
            this.colRechargeTime.HeaderText = "Nạp tiền lúc";
            this.colRechargeTime.MinimumWidth = 6;
            this.colRechargeTime.Name = "colRechargeTime";
            this.colRechargeTime.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRevenueStatisticsOrder);
            this.tabPage2.Controls.Add(this.txtRevenue);
            this.tabPage2.Controls.Add(this.btnRevenueOrder);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dateTimePickerEndDate);
            this.tabPage2.Controls.Add(this.dateTimePickerStartDate);
            this.tabPage2.Controls.Add(this.dgvRevenueStatisticsOrder);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1194, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh thu đồ ăn ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRevenueStatisticsOrder
            // 
            this.btnRevenueStatisticsOrder.Location = new System.Drawing.Point(368, 86);
            this.btnRevenueStatisticsOrder.Name = "btnRevenueStatisticsOrder";
            this.btnRevenueStatisticsOrder.Size = new System.Drawing.Size(175, 40);
            this.btnRevenueStatisticsOrder.TabIndex = 18;
            this.btnRevenueStatisticsOrder.Text = "Thống kê";
            this.btnRevenueStatisticsOrder.UseVisualStyleBackColor = true;
            this.btnRevenueStatisticsOrder.Click += new System.EventHandler(this.btnRevenueStatisticsOrder_Click);
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(797, 104);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(100, 22);
            this.txtRevenue.TabIndex = 14;
            // 
            // btnRevenueOrder
            // 
            this.btnRevenueOrder.Location = new System.Drawing.Point(616, 86);
            this.btnRevenueOrder.Name = "btnRevenueOrder";
            this.btnRevenueOrder.Size = new System.Drawing.Size(175, 40);
            this.btnRevenueOrder.TabIndex = 13;
            this.btnRevenueOrder.Text = "Tính doanh thu";
            this.btnRevenueOrder.UseVisualStyleBackColor = true;
            this.btnRevenueOrder.Click += new System.EventHandler(this.btnbtnRevenueStatisticsOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ ngày";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(432, 53);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndDate.TabIndex = 4;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(149, 52);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStartDate.TabIndex = 3;
            // 
            // dgvRevenueStatisticsOrder
            // 
            this.dgvRevenueStatisticsOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenueStatisticsOrder.Location = new System.Drawing.Point(56, 132);
            this.dgvRevenueStatisticsOrder.Name = "dgvRevenueStatisticsOrder";
            this.dgvRevenueStatisticsOrder.RowHeadersWidth = 51;
            this.dgvRevenueStatisticsOrder.RowTemplate.Height = 24;
            this.dgvRevenueStatisticsOrder.Size = new System.Drawing.Size(1090, 277);
            this.dgvRevenueStatisticsOrder.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doanh thu";
            // 
            // RevenueFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 470);
            this.Controls.Add(this.tabControl1);
            this.Name = "RevenueFrm";
            this.Text = "Doanh thu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueStatisticsOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRevenueStatistics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepositMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRechargeTime;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRevenueStatisticsOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Button btnRevenueOrder;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Button btnRevenueStatisticsOrder;
    }
}