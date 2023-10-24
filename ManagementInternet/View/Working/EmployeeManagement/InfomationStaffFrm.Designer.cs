namespace ManagementInternet.View.Working.EmployeeManagement
{
    partial class InfomationStaffFrm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbInfoStaff = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grbAcc = new System.Windows.Forms.GroupBox();
            this.rbSetManager = new System.Windows.Forms.RadioButton();
            this.rbSetStaff = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbInfoStaff.SuspendLayout();
            this.grbAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(240, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbInfoStaff
            // 
            this.grbInfoStaff.Controls.Add(this.txtName);
            this.grbInfoStaff.Controls.Add(this.grbAcc);
            this.grbInfoStaff.Controls.Add(this.dtpDateOfBirth);
            this.grbInfoStaff.Controls.Add(this.txtSex);
            this.grbInfoStaff.Controls.Add(this.label9);
            this.grbInfoStaff.Controls.Add(this.label11);
            this.grbInfoStaff.Controls.Add(this.label12);
            this.grbInfoStaff.Enabled = false;
            this.grbInfoStaff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbInfoStaff.Location = new System.Drawing.Point(15, 59);
            this.grbInfoStaff.Name = "grbInfoStaff";
            this.grbInfoStaff.Size = new System.Drawing.Size(379, 281);
            this.grbInfoStaff.TabIndex = 10;
            this.grbInfoStaff.TabStop = false;
            this.grbInfoStaff.Text = "Thông tin nhân viên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 24;
            // 
            // grbAcc
            // 
            this.grbAcc.Controls.Add(this.rbSetManager);
            this.grbAcc.Controls.Add(this.rbSetStaff);
            this.grbAcc.Controls.Add(this.label17);
            this.grbAcc.Controls.Add(this.txtPassword);
            this.grbAcc.Controls.Add(this.txtUser);
            this.grbAcc.Controls.Add(this.label14);
            this.grbAcc.Controls.Add(this.label15);
            this.grbAcc.Enabled = false;
            this.grbAcc.Location = new System.Drawing.Point(16, 144);
            this.grbAcc.Name = "grbAcc";
            this.grbAcc.Size = new System.Drawing.Size(342, 123);
            this.grbAcc.TabIndex = 23;
            this.grbAcc.TabStop = false;
            this.grbAcc.Text = "Tài khoản";
            // 
            // rbSetManager
            // 
            this.rbSetManager.AutoSize = true;
            this.rbSetManager.Location = new System.Drawing.Point(209, 87);
            this.rbSetManager.Name = "rbSetManager";
            this.rbSetManager.Size = new System.Drawing.Size(73, 20);
            this.rbSetManager.TabIndex = 20;
            this.rbSetManager.TabStop = true;
            this.rbSetManager.Text = "Quản lý";
            this.rbSetManager.UseVisualStyleBackColor = true;
            // 
            // rbSetStaff
            // 
            this.rbSetStaff.AutoSize = true;
            this.rbSetStaff.Location = new System.Drawing.Point(114, 86);
            this.rbSetStaff.Name = "rbSetStaff";
            this.rbSetStaff.Size = new System.Drawing.Size(88, 20);
            this.rbSetStaff.TabIndex = 19;
            this.rbSetStaff.TabStop = true;
            this.rbSetStaff.Text = "Nhân viên";
            this.rbSetStaff.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Chức vụ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 22);
            this.txtPassword.TabIndex = 17;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(114, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(192, 22);
            this.txtUser.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Tên đăng nhập";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Mật khẩu";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(122, 64);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.dtpDateOfBirth.TabIndex = 19;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(122, 105);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 22);
            this.txtSex.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Giới tính";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ngày sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Họ Tên";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(319, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(301, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(120, 19);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(175, 22);
            this.txtSearchID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập CCCD";
            // 
            // InfomationStaffFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 385);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbInfoStaff);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.label1);
            this.Name = "InfomationStaffFrm";
            this.Text = "InfomationStaff";
            this.grbInfoStaff.ResumeLayout(false);
            this.grbInfoStaff.PerformLayout();
            this.grbAcc.ResumeLayout(false);
            this.grbAcc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbInfoStaff;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grbAcc;
        private System.Windows.Forms.RadioButton rbSetManager;
        private System.Windows.Forms.RadioButton rbSetStaff;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label1;
    }
}