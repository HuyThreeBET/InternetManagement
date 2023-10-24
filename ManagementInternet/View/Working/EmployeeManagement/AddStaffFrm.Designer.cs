namespace ManagementInternet.View.Working.EmployeeManagement
{
    partial class AddStaffFrm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.txtIDadd = new System.Windows.Forms.TextBox();
            this.grbAccount = new System.Windows.Forms.GroupBox();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtUserNew = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(326, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(245, 308);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 24;
            this.btnCancel1.Text = "Hủy";
            this.btnCancel1.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(260, 113);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(45, 20);
            this.rbFemale.TabIndex = 23;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(152, 111);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 20);
            this.rbMale.TabIndex = 22;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(152, 83);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 21;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(152, 52);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(200, 22);
            this.txtNameAdd.TabIndex = 20;
            // 
            // txtIDadd
            // 
            this.txtIDadd.Location = new System.Drawing.Point(152, 27);
            this.txtIDadd.Name = "txtIDadd";
            this.txtIDadd.Size = new System.Drawing.Size(200, 22);
            this.txtIDadd.TabIndex = 19;
            // 
            // grbAccount
            // 
            this.grbAccount.Controls.Add(this.rbManager);
            this.grbAccount.Controls.Add(this.label16);
            this.grbAccount.Controls.Add(this.rbStaff);
            this.grbAccount.Controls.Add(this.txtPasswordNew);
            this.grbAccount.Controls.Add(this.txtUserNew);
            this.grbAccount.Controls.Add(this.label7);
            this.grbAccount.Controls.Add(this.label8);
            this.grbAccount.Location = new System.Drawing.Point(18, 144);
            this.grbAccount.Name = "grbAccount";
            this.grbAccount.Size = new System.Drawing.Size(383, 158);
            this.grbAccount.TabIndex = 18;
            this.grbAccount.TabStop = false;
            this.grbAccount.Text = "Tài khoản";
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(242, 110);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(73, 20);
            this.rbManager.TabIndex = 15;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Quản lý";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Chức vụ";
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Location = new System.Drawing.Point(134, 108);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(88, 20);
            this.rbStaff.TabIndex = 14;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Nhân viên";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Location = new System.Drawing.Point(134, 68);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(200, 22);
            this.txtPasswordNew.TabIndex = 13;
            // 
            // txtUserNew
            // 
            this.txtUserNew.Location = new System.Drawing.Point(134, 30);
            this.txtUserNew.Name = "txtUserNew";
            this.txtUserNew.Size = new System.Drawing.Size(200, 22);
            this.txtUserNew.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên đăng nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "CCCD";
            // 
            // AddStaffFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 353);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtNameAdd);
            this.Controls.Add(this.txtIDadd);
            this.Controls.Add(this.grbAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddStaffFrm";
            this.Text = "AddStaff";
            this.grbAccount.ResumeLayout(false);
            this.grbAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.TextBox txtIDadd;
        private System.Windows.Forms.GroupBox grbAccount;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtUserNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}