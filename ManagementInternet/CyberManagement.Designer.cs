namespace ManagementInternet
{
    partial class CyberManagement
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAddUser = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConputerStatusManagement = new System.Windows.Forms.TabPage();
            this.dvgDisplayStatus = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStripHeader = new System.Windows.Forms.MenuStrip();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHộiViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiThôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tabAddUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabConputerStatusManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDisplayStatus)).BeginInit();
            this.menuStripHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAddUser);
            this.tabMain.Controls.Add(this.tabConputerStatusManagement);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(12, 28);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(993, 532);
            this.tabMain.TabIndex = 0;
            // 
            // tabAddUser
            // 
            this.tabAddUser.Controls.Add(this.groupBox1);
            this.tabAddUser.Location = new System.Drawing.Point(4, 27);
            this.tabAddUser.Name = "tabAddUser";
            this.tabAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUser.Size = new System.Drawing.Size(985, 501);
            this.tabAddUser.TabIndex = 0;
            this.tabAddUser.Text = "Thêm hội viên";
            this.tabAddUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(253, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 24);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 24);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 24);
            this.textBox1.TabIndex = 6;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(301, 153);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 22);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nữ";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(184, 153);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(61, 22);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nam";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCCD";
            // 
            // tabConputerStatusManagement
            // 
            this.tabConputerStatusManagement.Controls.Add(this.dvgDisplayStatus);
            this.tabConputerStatusManagement.Location = new System.Drawing.Point(4, 27);
            this.tabConputerStatusManagement.Name = "tabConputerStatusManagement";
            this.tabConputerStatusManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabConputerStatusManagement.Size = new System.Drawing.Size(985, 501);
            this.tabConputerStatusManagement.TabIndex = 1;
            this.tabConputerStatusManagement.Text = "Quản lí máy";
            this.tabConputerStatusManagement.UseVisualStyleBackColor = true;
            // 
            // dvgDisplayStatus
            // 
            this.dvgDisplayStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDisplayStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDisplayStatus.BackgroundColor = System.Drawing.Color.White;
            this.dvgDisplayStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgDisplayStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDisplayStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colStatus,
            this.colUser,
            this.colStart,
            this.colUsed,
            this.colRemaining,
            this.colGroup});
            this.dvgDisplayStatus.Location = new System.Drawing.Point(3, 3);
            this.dvgDisplayStatus.Name = "dvgDisplayStatus";
            this.dvgDisplayStatus.RowHeadersWidth = 51;
            this.dvgDisplayStatus.RowTemplate.Height = 24;
            this.dvgDisplayStatus.Size = new System.Drawing.Size(979, 492);
            this.dvgDisplayStatus.TabIndex = 3;
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
            this.menuStripHeader.Size = new System.Drawing.Size(1012, 28);
            this.menuStripHeader.TabIndex = 1;
            this.menuStripHeader.Text = "menuStrip1";
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyNhanVienToolStripMenuItem,
            this.thêmHộiViênToolStripMenuItem,
            this.chuyểnNhânViênToolStripMenuItem,
            this.thayĐổiThôngTinNhânViênToolStripMenuItem,
            this.dịchVụToolStripMenuItem,
            this.thôngTinKháchHàngToolStripMenuItem});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            this.quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            this.quanLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.quanLyNhanVienToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // thêmHộiViênToolStripMenuItem
            // 
            this.thêmHộiViênToolStripMenuItem.Name = "thêmHộiViênToolStripMenuItem";
            this.thêmHộiViênToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.thêmHộiViênToolStripMenuItem.Text = "Thêm hội viên";
            // 
            // chuyểnNhânViênToolStripMenuItem
            // 
            this.chuyểnNhânViênToolStripMenuItem.Name = "chuyểnNhânViênToolStripMenuItem";
            this.chuyểnNhânViênToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.chuyểnNhânViênToolStripMenuItem.Text = "Chuyển nhân viên";
            // 
            // thayĐổiThôngTinNhânViênToolStripMenuItem
            // 
            this.thayĐổiThôngTinNhânViênToolStripMenuItem.Name = "thayĐổiThôngTinNhânViênToolStripMenuItem";
            this.thayĐổiThôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.thayĐổiThôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.dịchVụToolStripMenuItem.Text = "Dịch vụ";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
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
            // CyberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 575);
            this.Controls.Add(this.menuStripHeader);
            this.Controls.Add(this.tabMain);
            this.Name = "CyberManagement";
            this.Text = "CyberManagement";
            this.tabMain.ResumeLayout(false);
            this.tabAddUser.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabConputerStatusManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDisplayStatus)).EndInit();
            this.menuStripHeader.ResumeLayout(false);
            this.menuStripHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAddUser;
        private System.Windows.Forms.TabPage tabConputerStatusManagement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dvgDisplayStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.MenuStrip menuStripHeader;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHộiViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiThôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
    }
}