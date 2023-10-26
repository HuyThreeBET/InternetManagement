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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBAddStaff = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBAddStaff.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 31);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 31);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(298, 8);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(48, 22);
            this.rbFemale.TabIndex = 23;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(171, 8);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(61, 22);
            this.rbMale.TabIndex = 22;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(155, 119);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(265, 24);
            this.dtpDOB.TabIndex = 21;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(155, 72);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 24);
            this.txtFullName.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(155, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 24);
            this.txtId.TabIndex = 19;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(276, 323);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(79, 22);
            this.rbManager.TabIndex = 15;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Quản lý";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 14;
            this.label16.Text = "Chức vụ";
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Checked = true;
            this.rbStaff.Location = new System.Drawing.Point(155, 321);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(94, 22);
            this.rbStaff.TabIndex = 14;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Nhân viên";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(155, 270);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 24);
            this.txtPassword.TabIndex = 13;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(155, 221);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(200, 24);
            this.txtAccountName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên đăng nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "CCCD";
            // 
            // gBAddStaff
            // 
            this.gBAddStaff.Controls.Add(this.panel1);
            this.gBAddStaff.Controls.Add(this.rbManager);
            this.gBAddStaff.Controls.Add(this.btnAdd);
            this.gBAddStaff.Controls.Add(this.label2);
            this.gBAddStaff.Controls.Add(this.btnCancel);
            this.gBAddStaff.Controls.Add(this.label16);
            this.gBAddStaff.Controls.Add(this.rbStaff);
            this.gBAddStaff.Controls.Add(this.txtId);
            this.gBAddStaff.Controls.Add(this.txtFullName);
            this.gBAddStaff.Controls.Add(this.txtPassword);
            this.gBAddStaff.Controls.Add(this.label8);
            this.gBAddStaff.Controls.Add(this.txtAccountName);
            this.gBAddStaff.Controls.Add(this.label3);
            this.gBAddStaff.Controls.Add(this.label7);
            this.gBAddStaff.Controls.Add(this.label4);
            this.gBAddStaff.Controls.Add(this.dtpDOB);
            this.gBAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBAddStaff.Location = new System.Drawing.Point(12, 12);
            this.gBAddStaff.Name = "gBAddStaff";
            this.gBAddStaff.Size = new System.Drawing.Size(452, 419);
            this.gBAddStaff.TabIndex = 26;
            this.gBAddStaff.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Location = new System.Drawing.Point(6, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 37);
            this.panel1.TabIndex = 28;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 31);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // AddStaffFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 489);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gBAddStaff);
            this.Name = "AddStaffFrm";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaffFrm_Load);
            this.gBAddStaff.ResumeLayout(false);
            this.gBAddStaff.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBAddStaff;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panel1;
    }
}