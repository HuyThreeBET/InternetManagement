namespace ManagementInternet.View.Working.EmployeeManagement
{
    partial class ShowAllInfoStaffFrm
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
            this.dgvStaffInfo = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffInfo
            // 
            this.dgvStaffInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFullName,
            this.colBirthDay,
            this.colStatus,
            this.colDayStart,
            this.colDayOff});
            this.dgvStaffInfo.Location = new System.Drawing.Point(14, 14);
            this.dgvStaffInfo.Name = "dgvStaffInfo";
            this.dgvStaffInfo.RowHeadersWidth = 51;
            this.dgvStaffInfo.RowTemplate.Height = 24;
            this.dgvStaffInfo.Size = new System.Drawing.Size(1058, 479);
            this.dgvStaffInfo.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "CCCD";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Họ tên";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colBirthDay
            // 
            this.colBirthDay.HeaderText = "Ngày sinh";
            this.colBirthDay.MinimumWidth = 6;
            this.colBirthDay.Name = "colBirthDay";
            this.colBirthDay.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colDayStart
            // 
            this.colDayStart.HeaderText = "Ngày vào làm";
            this.colDayStart.MinimumWidth = 6;
            this.colDayStart.Name = "colDayStart";
            this.colDayStart.ReadOnly = true;
            // 
            // colDayOff
            // 
            this.colDayOff.HeaderText = "Ngày nghỉ";
            this.colDayOff.MinimumWidth = 6;
            this.colDayOff.Name = "colDayOff";
            this.colDayOff.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(968, 506);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ShowAllInfoStaffFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 544);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvStaffInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ShowAllInfoStaffFrm";
            this.Text = "ShowAllInfoStaffFrm";
            this.Load += new System.EventHandler(this.ShowAllInfoStaffFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayOff;
        private System.Windows.Forms.Button btnExit;
    }
}