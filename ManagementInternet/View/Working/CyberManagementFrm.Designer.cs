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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CyberManagementFrm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStripHeader = new System.Windows.Forms.MenuStrip();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStaffManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangeStaffInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowStaffStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemService = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoggout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRevenueStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRefesh = new System.Windows.Forms.ToolStripMenuItem();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddPlayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
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
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.menuStripHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPlayerAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerManagement)).BeginInit();
            this.tabConputerStatusManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDisplayComputer)).BeginInit();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripHeader
            // 
            this.menuStripHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStripHeader.AutoSize = false;
            this.menuStripHeader.BackColor = System.Drawing.Color.Silver;
            this.menuStripHeader.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStripHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangToolStripMenuItem,
            this.ToolStripMenuItemRevenueStatistics,
            this.toolStripMenuItemRefesh});
            this.menuStripHeader.Location = new System.Drawing.Point(-6, 0);
            this.menuStripHeader.Name = "menuStripHeader";
            this.menuStripHeader.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripHeader.Size = new System.Drawing.Size(1121, 28);
            this.menuStripHeader.TabIndex = 1;
            this.menuStripHeader.Text = "menuStrip1";
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddPlayer,
            this.ToolStripMenuItemStaffManagement,
            this.ToolStripMenuItemChangePassword,
            this.ToolStripMenuItemService,
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
            // ToolStripMenuItemStaffManagement
            // 
            this.ToolStripMenuItemStaffManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemChangeStaffInfo,
            this.ToolStripMenuItemAddStaff,
            this.toolStripMenuItemShowStaffStatus});
            this.ToolStripMenuItemStaffManagement.Name = "ToolStripMenuItemStaffManagement";
            this.ToolStripMenuItemStaffManagement.Size = new System.Drawing.Size(248, 26);
            this.ToolStripMenuItemStaffManagement.Text = "Quản lý nhân viên";
            // 
            // ToolStripMenuItemChangeStaffInfo
            // 
            this.ToolStripMenuItemChangeStaffInfo.Name = "ToolStripMenuItemChangeStaffInfo";
            this.ToolStripMenuItemChangeStaffInfo.Size = new System.Drawing.Size(280, 26);
            this.ToolStripMenuItemChangeStaffInfo.Text = "Thay đổi thông tin nhân viên";
            this.ToolStripMenuItemChangeStaffInfo.Click += new System.EventHandler(this.ToolStripMenuItemChangeStaffInfo_Click);
            // 
            // ToolStripMenuItemAddStaff
            // 
            this.ToolStripMenuItemAddStaff.Name = "ToolStripMenuItemAddStaff";
            this.ToolStripMenuItemAddStaff.Size = new System.Drawing.Size(280, 26);
            this.ToolStripMenuItemAddStaff.Text = "Thêm nhân viên";
            this.ToolStripMenuItemAddStaff.Click += new System.EventHandler(this.ToolStripMenuItemAddStaff_Click);
            // 
            // toolStripMenuItemShowStaffStatus
            // 
            this.toolStripMenuItemShowStaffStatus.Name = "toolStripMenuItemShowStaffStatus";
            this.toolStripMenuItemShowStaffStatus.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItemShowStaffStatus.Text = "Xem thông tin nhân viên";
            this.toolStripMenuItemShowStaffStatus.Click += new System.EventHandler(this.toolStripMenuItemShowStaffStatus_Click);
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
            // toolStripMenuItemLoggout
            // 
            this.toolStripMenuItemLoggout.Name = "toolStripMenuItemLoggout";
            this.toolStripMenuItemLoggout.Size = new System.Drawing.Size(248, 26);
            this.toolStripMenuItemLoggout.Text = "Đăng xuất";
            // 
            // ToolStripMenuItemRevenueStatistics
            // 
            this.ToolStripMenuItemRevenueStatistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRevenue});
            this.ToolStripMenuItemRevenueStatistics.Name = "ToolStripMenuItemRevenueStatistics";
            this.ToolStripMenuItemRevenueStatistics.Size = new System.Drawing.Size(92, 24);
            this.ToolStripMenuItemRevenueStatistics.Text = "Doanh thu";
            // 
            // ToolStripMenuItemRevenue
            // 
            this.ToolStripMenuItemRevenue.Name = "ToolStripMenuItemRevenue";
            this.ToolStripMenuItemRevenue.Size = new System.Drawing.Size(191, 26);
            this.ToolStripMenuItemRevenue.Text = "Tính doanh thu";
            this.ToolStripMenuItemRevenue.Click += new System.EventHandler(this.ToolStripMenuItemRevenue_Click);
            // 
            // toolStripMenuItemRefesh
            // 
            this.toolStripMenuItemRefesh.Name = "toolStripMenuItemRefesh";
            this.toolStripMenuItemRefesh.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItemRefesh.Text = "Làm mới";
            this.toolStripMenuItemRefesh.Click += new System.EventHandler(this.toolStripMenuItemRefesh_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddPlayer,
            this.toolStripButtonLogout});
            this.toolStrip1.Location = new System.Drawing.Point(-6, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1121, 41);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddPlayer
            // 
            this.toolStripButtonAddPlayer.Image = global::ManagementInternet.Properties.Resources.thêmNV;
            this.toolStripButtonAddPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddPlayer.Name = "toolStripButtonAddPlayer";
            this.toolStripButtonAddPlayer.Size = new System.Drawing.Size(126, 38);
            this.toolStripButtonAddPlayer.Text = "Thêm hội viên";
            this.toolStripButtonAddPlayer.Click += new System.EventHandler(this.toolStripButtonAddPlayer_Click);
            // 
            // toolStripButtonLogout
            // 
            this.toolStripButtonLogout.Image = global::ManagementInternet.Properties.Resources.logout;
            this.toolStripButtonLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogout.Name = "toolStripButtonLogout";
            this.toolStripButtonLogout.Size = new System.Drawing.Size(101, 38);
            this.toolStripButtonLogout.Text = "Đăng xuất";
            this.toolStripButtonLogout.Click += new System.EventHandler(this.toolStripButtonLogout_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = global::ManagementInternet.Properties.Resources.z4811306491208_41aab65238820f54e4cec5b62681e956;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.MediumSlateBlue;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton3.Size = new System.Drawing.Size(176, 38);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // tabPlayerAccount
            // 
            this.tabPlayerAccount.Controls.Add(this.dgvPlayerManagement);
            this.tabPlayerAccount.Location = new System.Drawing.Point(4, 27);
            this.tabPlayerAccount.Name = "tabPlayerAccount";
            this.tabPlayerAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayerAccount.Size = new System.Drawing.Size(1113, 515);
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
            this.dgvPlayerManagement.Size = new System.Drawing.Size(1095, 489);
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
            this.tabConputerStatusManagement.Size = new System.Drawing.Size(1113, 515);
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
            this.dvgDisplayComputer.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dvgDisplayComputer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgDisplayComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDisplayComputer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colStatus,
            this.colUser,
            this.colStart,
            this.colRemaining,
            this.colGroup});
            this.dvgDisplayComputer.Location = new System.Drawing.Point(2, 3);
            this.dvgDisplayComputer.Name = "dvgDisplayComputer";
            this.dvgDisplayComputer.RowHeadersWidth = 51;
            this.dvgDisplayComputer.RowTemplate.Height = 24;
            this.dvgDisplayComputer.Size = new System.Drawing.Size(1105, 512);
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
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabConputerStatusManagement);
            this.tabMain.Controls.Add(this.tabPlayerAccount);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(-6, 72);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1121, 546);
            this.tabMain.TabIndex = 0;
            // 
            // CyberManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 609);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripHeader);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CyberManagementFrm";
            this.Text = "XCyber";
            this.Load += new System.EventHandler(this.CyberManagementFrm_Load);
            this.menuStripHeader.ResumeLayout(false);
            this.menuStripHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStaffManagement;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemService;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRevenueStatistics;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddPlayer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoggout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRevenue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddPlayer;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogout;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangeStaffInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddStaff;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabConputerStatusManagement;
        private System.Windows.Forms.DataGridView dvgDisplayComputer;
        private System.Windows.Forms.TabPage tabPlayerAccount;
        private System.Windows.Forms.DataGridView dgvPlayerManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRefesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowStaffStatus;
    }
}