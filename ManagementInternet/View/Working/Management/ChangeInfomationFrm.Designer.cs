﻿namespace ManagementInternet.View.Working.Management
{
    partial class ChangeInfomationFrm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBAddStaff = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBYes = new System.Windows.Forms.RadioButton();
            this.rdBNo = new System.Windows.Forms.RadioButton();
            this.gBAddStaff.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(385, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 34);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(170, 18);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(197, 24);
            this.txtInfo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập CCCD";
            // 
            // gBAddStaff
            // 
            this.gBAddStaff.Controls.Add(this.panel2);
            this.gBAddStaff.Controls.Add(this.panel1);
            this.gBAddStaff.Controls.Add(this.rbManager);
            this.gBAddStaff.Controls.Add(this.btnModify);
            this.gBAddStaff.Controls.Add(this.btnCancel);
            this.gBAddStaff.Controls.Add(this.label16);
            this.gBAddStaff.Controls.Add(this.rbStaff);
            this.gBAddStaff.Controls.Add(this.txtFullName);
            this.gBAddStaff.Controls.Add(this.label3);
            this.gBAddStaff.Controls.Add(this.label4);
            this.gBAddStaff.Controls.Add(this.dtpDOB);
            this.gBAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBAddStaff.Location = new System.Drawing.Point(15, 48);
            this.gBAddStaff.Name = "gBAddStaff";
            this.gBAddStaff.Size = new System.Drawing.Size(469, 383);
            this.gBAddStaff.TabIndex = 27;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới tính";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Enabled = false;
            this.rbMale.Location = new System.Drawing.Point(171, 8);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(61, 22);
            this.rbMale.TabIndex = 22;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Enabled = false;
            this.rbFemale.Location = new System.Drawing.Point(298, 8);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(48, 22);
            this.rbFemale.TabIndex = 23;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Enabled = false;
            this.rbManager.Location = new System.Drawing.Point(276, 231);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(79, 22);
            this.rbManager.TabIndex = 15;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Quản lý";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(380, 352);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(89, 31);
            this.btnModify.TabIndex = 25;
            this.btnModify.Text = "Sửa";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(267, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 31);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 14;
            this.label16.Text = "Chức vụ";
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Checked = true;
            this.rbStaff.Enabled = false;
            this.rbStaff.Location = new System.Drawing.Point(155, 231);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(94, 22);
            this.rbStaff.TabIndex = 14;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Nhân viên";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(155, 41);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 24);
            this.txtFullName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày sinh";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Location = new System.Drawing.Point(155, 101);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(308, 24);
            this.dtpDOB.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 31);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cho nghỉ việc";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdBNo);
            this.panel2.Controls.Add(this.rdBYes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 48);
            this.panel2.TabIndex = 30;
            // 
            // rdBYes
            // 
            this.rdBYes.AutoSize = true;
            this.rdBYes.Location = new System.Drawing.Point(171, 11);
            this.rdBYes.Name = "rdBYes";
            this.rdBYes.Size = new System.Drawing.Size(49, 22);
            this.rdBYes.TabIndex = 30;
            this.rdBYes.TabStop = true;
            this.rdBYes.Text = "Có";
            this.rdBYes.UseVisualStyleBackColor = true;
            // 
            // rdBNo
            // 
            this.rdBNo.AutoSize = true;
            this.rdBNo.Location = new System.Drawing.Point(270, 13);
            this.rdBNo.Name = "rdBNo";
            this.rdBNo.Size = new System.Drawing.Size(72, 22);
            this.rdBNo.TabIndex = 31;
            this.rdBNo.TabStop = true;
            this.rdBNo.Text = "Không";
            this.rdBNo.UseVisualStyleBackColor = true;
            // 
            // ChangeInfomationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 496);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gBAddStaff);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label1);
            this.Name = "ChangeInfomationFrm";
            this.Text = "InfomationStaff";
            this.gBAddStaff.ResumeLayout(false);
            this.gBAddStaff.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBAddStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBNo;
        private System.Windows.Forms.RadioButton rdBYes;
    }
}