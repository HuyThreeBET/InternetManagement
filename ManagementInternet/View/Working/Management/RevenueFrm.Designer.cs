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
            this.txtRevenueR = new System.Windows.Forms.TextBox();
            this.btnRevenueOrderR = new System.Windows.Forms.Button();
            this.btnRevenueStatisticsOrderR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDateR = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDateR = new System.Windows.Forms.DateTimePicker();
            this.dgvDepositeHistory = new System.Windows.Forms.DataGridView();
            this.colSerialOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepositMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRechargeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.btnRevenueStatisticsOrder = new System.Windows.Forms.Button();
            this.btnRevenueOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvRevenueStatisticsOrder = new System.Windows.Forms.DataGridView();
            this.colComputerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositeHistory)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1114, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRevenueR);
            this.tabPage1.Controls.Add(this.btnRevenueOrderR);
            this.tabPage1.Controls.Add(this.btnRevenueStatisticsOrderR);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePickerEndDateR);
            this.tabPage1.Controls.Add(this.dateTimePickerStartDateR);
            this.tabPage1.Controls.Add(this.dgvDepositeHistory);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu tiền nạp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRevenueR
            // 
            this.txtRevenueR.Location = new System.Drawing.Point(737, 38);
            this.txtRevenueR.Name = "txtRevenueR";
            this.txtRevenueR.Size = new System.Drawing.Size(152, 22);
            this.txtRevenueR.TabIndex = 21;
            // 
            // btnRevenueOrderR
            // 
            this.btnRevenueOrderR.Location = new System.Drawing.Point(554, 34);
            this.btnRevenueOrderR.Name = "btnRevenueOrderR";
            this.btnRevenueOrderR.Size = new System.Drawing.Size(138, 26);
            this.btnRevenueOrderR.TabIndex = 20;
            this.btnRevenueOrderR.Text = "Tính doanh thu";
            this.btnRevenueOrderR.UseVisualStyleBackColor = true;
            this.btnRevenueOrderR.Click += new System.EventHandler(this.btnRevenueOrderR_Click);
            // 
            // btnRevenueStatisticsOrderR
            // 
            this.btnRevenueStatisticsOrderR.Location = new System.Drawing.Point(400, 33);
            this.btnRevenueStatisticsOrderR.Name = "btnRevenueStatisticsOrderR";
            this.btnRevenueStatisticsOrderR.Size = new System.Drawing.Size(110, 27);
            this.btnRevenueStatisticsOrderR.TabIndex = 19;
            this.btnRevenueStatisticsOrderR.Text = "Thống kê";
            this.btnRevenueStatisticsOrderR.UseVisualStyleBackColor = true;
            this.btnRevenueStatisticsOrderR.Click += new System.EventHandler(this.btnRevenueStatisticsOrderR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bắt đầu";
            // 
            // dateTimePickerEndDateR
            // 
            this.dateTimePickerEndDateR.Location = new System.Drawing.Point(97, 85);
            this.dateTimePickerEndDateR.Name = "dateTimePickerEndDateR";
            this.dateTimePickerEndDateR.Size = new System.Drawing.Size(258, 22);
            this.dateTimePickerEndDateR.TabIndex = 9;
            // 
            // dateTimePickerStartDateR
            // 
            this.dateTimePickerStartDateR.Location = new System.Drawing.Point(97, 32);
            this.dateTimePickerStartDateR.Name = "dateTimePickerStartDateR";
            this.dateTimePickerStartDateR.Size = new System.Drawing.Size(258, 22);
            this.dateTimePickerStartDateR.TabIndex = 8;
            // 
            // dgvDepositeHistory
            // 
            this.dgvDepositeHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepositeHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositeHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialOrder,
            this.colAccountName,
            this.colDepositMoney,
            this.colRechargeTime});
            this.dgvDepositeHistory.Location = new System.Drawing.Point(0, 152);
            this.dgvDepositeHistory.Name = "dgvDepositeHistory";
            this.dgvDepositeHistory.RowHeadersWidth = 51;
            this.dgvDepositeHistory.RowTemplate.Height = 24;
            this.dgvDepositeHistory.Size = new System.Drawing.Size(1103, 244);
            this.dgvDepositeHistory.TabIndex = 7;
            // 
            // colSerialOrder
            // 
            this.colSerialOrder.HeaderText = "STT";
            this.colSerialOrder.MinimumWidth = 6;
            this.colSerialOrder.Name = "colSerialOrder";
            // 
            // colAccountName
            // 
            this.colAccountName.HeaderText = "Tài khoản";
            this.colAccountName.MinimumWidth = 6;
            this.colAccountName.Name = "colAccountName";
            // 
            // colDepositMoney
            // 
            this.colDepositMoney.HeaderText = "Số tiền nạp";
            this.colDepositMoney.MinimumWidth = 6;
            this.colDepositMoney.Name = "colDepositMoney";
            // 
            // colRechargeTime
            // 
            this.colRechargeTime.HeaderText = "Nạp tiền lúc";
            this.colRechargeTime.MinimumWidth = 6;
            this.colRechargeTime.Name = "colRechargeTime";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtRevenue);
            this.tabPage2.Controls.Add(this.btnRevenueStatisticsOrder);
            this.tabPage2.Controls.Add(this.btnRevenueOrder);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dateTimePickerEndDate);
            this.tabPage2.Controls.Add(this.dateTimePickerStartDate);
            this.tabPage2.Controls.Add(this.dgvRevenueStatisticsOrder);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1106, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh thu đồ ăn ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(775, 23);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(152, 24);
            this.txtRevenue.TabIndex = 19;
            // 
            // btnRevenueStatisticsOrder
            // 
            this.btnRevenueStatisticsOrder.Location = new System.Drawing.Point(407, 23);
            this.btnRevenueStatisticsOrder.Name = "btnRevenueStatisticsOrder";
            this.btnRevenueStatisticsOrder.Size = new System.Drawing.Size(110, 27);
            this.btnRevenueStatisticsOrder.TabIndex = 18;
            this.btnRevenueStatisticsOrder.Text = "Thống kê";
            this.btnRevenueStatisticsOrder.UseVisualStyleBackColor = true;
            this.btnRevenueStatisticsOrder.Click += new System.EventHandler(this.btnRevenueStatisticsOrder_Click);
            // 
            // btnRevenueOrder
            // 
            this.btnRevenueOrder.Location = new System.Drawing.Point(576, 23);
            this.btnRevenueOrder.Name = "btnRevenueOrder";
            this.btnRevenueOrder.Size = new System.Drawing.Size(138, 26);
            this.btnRevenueOrder.TabIndex = 13;
            this.btnRevenueOrder.Text = "Tính doanh thu";
            this.btnRevenueOrder.UseVisualStyleBackColor = true;
            this.btnRevenueOrder.Click += new System.EventHandler(this.btnRevenueOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ ngày";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(85, 67);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(282, 24);
            this.dateTimePickerEndDate.TabIndex = 4;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(85, 20);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(282, 24);
            this.dateTimePickerStartDate.TabIndex = 3;
            // 
            // dgvRevenueStatisticsOrder
            // 
            this.dgvRevenueStatisticsOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenueStatisticsOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenueStatisticsOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colComputerId,
            this.colServiceName,
            this.colPrice,
            this.colQuantity,
            this.colTotalAmount,
            this.colCreatedAt,
            this.colStatus});
            this.dgvRevenueStatisticsOrder.Location = new System.Drawing.Point(8, 106);
            this.dgvRevenueStatisticsOrder.Name = "dgvRevenueStatisticsOrder";
            this.dgvRevenueStatisticsOrder.RowHeadersWidth = 51;
            this.dgvRevenueStatisticsOrder.RowTemplate.Height = 24;
            this.dgvRevenueStatisticsOrder.Size = new System.Drawing.Size(1090, 277);
            this.dgvRevenueStatisticsOrder.TabIndex = 2;
            // 
            // colComputerId
            // 
            this.colComputerId.HeaderText = "Máy";
            this.colComputerId.MinimumWidth = 6;
            this.colComputerId.Name = "colComputerId";
            this.colComputerId.ReadOnly = true;
            // 
            // colServiceName
            // 
            this.colServiceName.HeaderText = "Tên dịch vụ";
            this.colServiceName.MinimumWidth = 6;
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.HeaderText = "Tổng tiền";
            this.colTotalAmount.MinimumWidth = 6;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.HeaderText = "Đặt vào lúc";
            this.colCreatedAt.MinimumWidth = 6;
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(994, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 27);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RevenueFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 480);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "RevenueFrm";
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.RevenueFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositeHistory)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueStatisticsOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDateR;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDateR;
        private System.Windows.Forms.DataGridView dgvDepositeHistory;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvRevenueStatisticsOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Button btnRevenueOrder;
        private System.Windows.Forms.Button btnRevenueStatisticsOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComputerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Button btnRevenueStatisticsOrderR;
        private System.Windows.Forms.TextBox txtRevenueR;
        private System.Windows.Forms.Button btnRevenueOrderR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepositMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRechargeTime;
        private System.Windows.Forms.Button btnExit;
    }
}