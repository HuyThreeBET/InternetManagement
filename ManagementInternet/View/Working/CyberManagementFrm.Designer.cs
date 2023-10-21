namespace ManagementInternet.View.Working
{
    partial class CyberManagementFrm
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStripHeader = new System.Windows.Forms.MenuStrip();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemService = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoggout = new System.Windows.Forms.ToolStripMenuItem();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPlayerAccount = new System.Windows.Forms.TabPage();
            this.dgvPlayerManagement = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabConputerStatusManagement = new System.Windows.Forms.TabPage();
            this.dvgDisplayComputer = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.menuStripHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.tabPlayerAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerManagement)).BeginInit();
            this.tabConputerStatusManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDisplayComputer)).BeginInit();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripHeader
            // 
            this.menuStripHeader.AutoSize = false;
            this.menuStripHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStripHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStripHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangToolStripMenuItem,
            this.heThongToolStripMenuItem,
            this.baoCaoToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.menuStripHeader.Location = new System.Drawing.Point(0, 0);
            this.menuStripHeader.Name = "menuStripHeader";
            this.menuStripHeader.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripHeader.Size = new System.Drawing.Size(1106, 28);
            this.menuStripHeader.TabIndex = 1;
            this.menuStripHeader.Text = "menuStrip1";
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddPlayer,
            this.quanLyNhanVienToolStripMenuItem,
            this.ToolStripMenuItemChangePassword,
            this.ToolStripMenuItemService,
            this.thôngTinKháchHàngToolStripMenuItem,
            this.toolStripMenuItemLoggout});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // toolStripMenuItemAddPlayer
            // 
            this.toolStripMenuItemAddPlayer.Name = "toolStripMenuItemAddPlayer";
            this.toolStripMenuItemAddPlayer.Size = new System.Drawing.Size(248, 26);
            this.toolStripMenuItemAddPlayer.Text = "Thêm hội viên/Nạp tiền";
            this.toolStripMenuItemAddPlayer.Click += new System.EventHandler(this.toolStripMenuItemAddPlayer_Click);
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            this.quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            this.quanLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.quanLyNhanVienToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // ToolStripMenuItemChangePassword
            // 
            this.ToolStripMenuItemChangePassword.Name = "ToolStripMenuItemChangePassword";
            this.ToolStripMenuItemChangePassword.Size = new System.Drawing.Size(248, 26);
            this.ToolStripMenuItemChangePassword.Text = "Đổi mật khẩu";
            this.ToolStripMenuItemChangePassword.Click += new System.EventHandler(this.ToolStripMenuItemChangePassword_Click);
            // 
            // ToolStripMenuItemService
            // 
            this.ToolStripMenuItemService.Name = "ToolStripMenuItemService";
            this.ToolStripMenuItemService.Size = new System.Drawing.Size(248, 26);
            this.ToolStripMenuItemService.Text = "Dịch vụ";
            this.ToolStripMenuItemService.Click += new System.EventHandler(this.ToolStripMenuItemService_Click);
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            // 
            // toolStripMenuItemLoggout
            // 
            this.toolStripMenuItemLoggout.Name = "toolStripMenuItemLoggout";
            this.toolStripMenuItemLoggout.Size = new System.Drawing.Size(248, 26);
            this.toolStripMenuItemLoggout.Text = "Đăng xuất";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // baoCaoToolStripMenuItem
            // 
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.baoCaoToolStripMenuItem.Text = "Báo cáo";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // tabPlayerAccount
            // 
            this.tabPlayerAccount.Controls.Add(this.dgvPlayerManagement);
            this.tabPlayerAccount.Location = new System.Drawing.Point(4, 27);
            this.tabPlayerAccount.Name = "tabPlayerAccount";
            this.tabPlayerAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayerAccount.Size = new System.Drawing.Size(1059, 501);
            this.tabPlayerAccount.TabIndex = 2;
            this.tabPlayerAccount.Text = "Tài khoản người chơi";
            this.tabPlayerAccount.UseVisualStyleBackColor = true;
            // 
            // dgvPlayerManagement
            // 
            this.dgvPlayerManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayerManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colAccountName,
            this.colSex,
            this.colBalance,
            this.colCreatedAt});
            this.dgvPlayerManagement.Location = new System.Drawing.Point(6, 6);
            this.dgvPlayerManagement.Name = "dgvPlayerManagement";
            this.dgvPlayerManagement.RowHeadersWidth = 51;
            this.dgvPlayerManagement.RowTemplate.Height = 24;
            this.dgvPlayerManagement.Size = new System.Drawing.Size(1047, 489);
            this.dgvPlayerManagement.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "Mã căn cước";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colAccountName
            // 
            this.colAccountName.HeaderText = "Tên tài khoản";
            this.colAccountName.MinimumWidth = 6;
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "Giới tính";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            // 
            // colBalance
            // 
            this.colBalance.HeaderText = "Số dư";
            this.colBalance.MinimumWidth = 6;
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.HeaderText = "Tạo vào lúc";
            this.colCreatedAt.MinimumWidth = 6;
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            // 
            // tabConputerStatusManagement
            // 
            this.tabConputerStatusManagement.Controls.Add(this.dvgDisplayComputer);
            this.tabConputerStatusManagement.Location = new System.Drawing.Point(4, 27);
            this.tabConputerStatusManagement.Name = "tabConputerStatusManagement";
            this.tabConputerStatusManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabConputerStatusManagement.Size = new System.Drawing.Size(1059, 501);
            this.tabConputerStatusManagement.TabIndex = 1;
            this.tabConputerStatusManagement.Text = "Quản lí máy";
            this.tabConputerStatusManagement.UseVisualStyleBackColor = true;
            // 
            // dvgDisplayComputer
            // 
            this.dvgDisplayComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDisplayComputer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDisplayComputer.BackgroundColor = System.Drawing.Color.White;
            this.dvgDisplayComputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgDisplayComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDisplayComputer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colStatus,
            this.colUser,
            this.colStart,
            this.colUsed,
            this.colRemaining,
            this.colGroup});
            this.dvgDisplayComputer.Location = new System.Drawing.Point(3, 3);
            this.dvgDisplayComputer.Name = "dvgDisplayComputer";
            this.dvgDisplayComputer.RowHeadersWidth = 51;
            this.dvgDisplayComputer.RowTemplate.Height = 24;
            this.dvgDisplayComputer.Size = new System.Drawing.Size(1053, 492);
            this.dvgDisplayComputer.TabIndex = 3;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên Máy";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Tình trạng";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // colUser
            // 
            this.colUser.HeaderText = "Người dùng";
            this.colUser.MinimumWidth = 6;
            this.colUser.Name = "colUser";
            // 
            // colStart
            // 
            this.colStart.HeaderText = "Thời gian vào";
            this.colStart.MinimumWidth = 6;
            this.colStart.Name = "colStart";
            // 
            // colUsed
            // 
            this.colUsed.HeaderText = "Đã sử dụng";
            this.colUsed.MinimumWidth = 6;
            this.colUsed.Name = "colUsed";
            // 
            // colRemaining
            // 
            this.colRemaining.HeaderText = "Còn lại";
            this.colRemaining.MinimumWidth = 6;
            this.colRemaining.Name = "colRemaining";
            // 
            // colGroup
            // 
            this.colGroup.HeaderText = "Nhóm máy";
            this.colGroup.MinimumWidth = 6;
            this.colGroup.Name = "colGroup";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabConputerStatusManagement);
            this.tabMain.Controls.Add(this.tabPlayerAccount);
            this.tabMain.Controls.Add(this.tabOrder);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(12, 28);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1067, 532);
            this.tabMain.TabIndex = 0;
            // 
            // tabOrder
            // 
            this.tabOrder.Location = new System.Drawing.Point(4, 27);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(1059, 501);
            this.tabOrder.TabIndex = 3;
            this.tabOrder.Text = "Dịch vụ";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // CyberManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 575);
            this.Controls.Add(this.menuStripHeader);
            this.Controls.Add(this.tabMain);
            this.Name = "CyberManagementFrm";
            this.Text = "CyberManagement";
            this.Load += new System.EventHandler(this.CyberManagementFrm_Load);
            this.menuStripHeader.ResumeLayout(false);
            this.menuStripHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.tabPlayerAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerManagement)).EndInit();
            this.tabConputerStatusManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDisplayComputer)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStripHeader;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemService;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabConputerStatusManagement;
        private System.Windows.Forms.DataGridView dvgDisplayComputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.TabPage tabPlayerAccount;
        private System.Windows.Forms.DataGridView dgvPlayerManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddPlayer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoggout;
    }
}