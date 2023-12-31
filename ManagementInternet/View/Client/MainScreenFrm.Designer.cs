﻿namespace ManagementInternet.View.Client
{
    partial class MainScreenFrm
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
            this.gBInfo = new System.Windows.Forms.GroupBox();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.txtCostService = new System.Windows.Forms.TextBox();
            this.txtCostPlayTime = new System.Windows.Forms.TextBox();
            this.txtRemainTime = new System.Windows.Forms.TextBox();
            this.txtUsedTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gBInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBInfo
            // 
            this.gBInfo.Controls.Add(this.txtTotalTime);
            this.gBInfo.Controls.Add(this.txtCostService);
            this.gBInfo.Controls.Add(this.txtCostPlayTime);
            this.gBInfo.Controls.Add(this.txtRemainTime);
            this.gBInfo.Controls.Add(this.txtUsedTime);
            this.gBInfo.Controls.Add(this.label5);
            this.gBInfo.Controls.Add(this.label4);
            this.gBInfo.Controls.Add(this.label3);
            this.gBInfo.Controls.Add(this.label2);
            this.gBInfo.Controls.Add(this.label1);
            this.gBInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBInfo.Location = new System.Drawing.Point(14, 14);
            this.gBInfo.Name = "gBInfo";
            this.gBInfo.Size = new System.Drawing.Size(405, 343);
            this.gBInfo.TabIndex = 0;
            this.gBInfo.TabStop = false;
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Enabled = false;
            this.txtTotalTime.Location = new System.Drawing.Point(197, 41);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(153, 24);
            this.txtTotalTime.TabIndex = 10;
            // 
            // txtCostService
            // 
            this.txtCostService.Enabled = false;
            this.txtCostService.Location = new System.Drawing.Point(197, 274);
            this.txtCostService.Name = "txtCostService";
            this.txtCostService.ReadOnly = true;
            this.txtCostService.Size = new System.Drawing.Size(153, 24);
            this.txtCostService.TabIndex = 9;
            this.txtCostService.Text = "0.000 VND";
            // 
            // txtCostPlayTime
            // 
            this.txtCostPlayTime.Enabled = false;
            this.txtCostPlayTime.Location = new System.Drawing.Point(197, 212);
            this.txtCostPlayTime.Name = "txtCostPlayTime";
            this.txtCostPlayTime.ReadOnly = true;
            this.txtCostPlayTime.Size = new System.Drawing.Size(153, 24);
            this.txtCostPlayTime.TabIndex = 8;
            // 
            // txtRemainTime
            // 
            this.txtRemainTime.Enabled = false;
            this.txtRemainTime.Location = new System.Drawing.Point(197, 156);
            this.txtRemainTime.Name = "txtRemainTime";
            this.txtRemainTime.ReadOnly = true;
            this.txtRemainTime.Size = new System.Drawing.Size(153, 24);
            this.txtRemainTime.TabIndex = 7;
            // 
            // txtUsedTime
            // 
            this.txtUsedTime.Enabled = false;
            this.txtUsedTime.Location = new System.Drawing.Point(197, 97);
            this.txtUsedTime.Name = "txtUsedTime";
            this.txtUsedTime.ReadOnly = true;
            this.txtUsedTime.Size = new System.Drawing.Size(153, 24);
            this.txtUsedTime.TabIndex = 6;
            this.txtUsedTime.Text = "00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chi phí dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chi phí giờ chơi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian còn lại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian sử dụng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng thời gian";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(14, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 153);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnChangePassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLogout, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnService, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(269, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 67);
            this.button6.TabIndex = 5;
            this.button6.Text = "Tiện ích";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "Khóa máy";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(3, 76);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(126, 67);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(269, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 67);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(136, 3);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(126, 67);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Dịch vụ";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tin nhắn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainScreenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(431, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gBInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainScreenFrm";
            this.Text = "MainScreenFrm";
            this.Load += new System.EventHandler(this.MainScreenFrm_Load);
            this.gBInfo.ResumeLayout(false);
            this.gBInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCostService;
        private System.Windows.Forms.TextBox txtCostPlayTime;
        private System.Windows.Forms.TextBox txtRemainTime;
        private System.Windows.Forms.TextBox txtUsedTime;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTotalTime;
    }
}