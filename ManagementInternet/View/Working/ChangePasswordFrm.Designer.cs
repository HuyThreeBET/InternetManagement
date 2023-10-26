namespace ManagementInternet.View.Working.Management
{
    partial class ChangePasswordFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.btnConfirmChangePassword = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.gbChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Enabled = false;
            this.txtAccountName.Location = new System.Drawing.Point(176, 26);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(236, 24);
            this.txtAccountName.TabIndex = 4;
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(176, 192);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(236, 24);
            this.txtConfirmNewPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(176, 135);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(236, 24);
            this.txtNewPassword.TabIndex = 2;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(176, 76);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(236, 24);
            this.txtCurrentPassword.TabIndex = 1;
            // 
            // btnConfirmChangePassword
            // 
            this.btnConfirmChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmChangePassword.Location = new System.Drawing.Point(317, 235);
            this.btnConfirmChangePassword.Name = "btnConfirmChangePassword";
            this.btnConfirmChangePassword.Size = new System.Drawing.Size(95, 27);
            this.btnConfirmChangePassword.TabIndex = 4;
            this.btnConfirmChangePassword.Text = "Xác nhận";
            this.btnConfirmChangePassword.UseVisualStyleBackColor = true;
            this.btnConfirmChangePassword.Click += new System.EventHandler(this.btnConfirmChangePassword_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Controls.Add(this.label1);
            this.gbChangePassword.Controls.Add(this.btnConfirmChangePassword);
            this.gbChangePassword.Controls.Add(this.label2);
            this.gbChangePassword.Controls.Add(this.txtConfirmNewPassword);
            this.gbChangePassword.Controls.Add(this.txtNewPassword);
            this.gbChangePassword.Controls.Add(this.txtCurrentPassword);
            this.gbChangePassword.Controls.Add(this.label3);
            this.gbChangePassword.Controls.Add(this.label4);
            this.gbChangePassword.Controls.Add(this.txtAccountName);
            this.gbChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangePassword.Location = new System.Drawing.Point(12, 12);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Size = new System.Drawing.Size(432, 289);
            this.gbChangePassword.TabIndex = 9;
            this.gbChangePassword.TabStop = false;
            this.gbChangePassword.Text = "Đổi mật khẩu";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ChangePasswordFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbChangePassword);
            this.Name = "ChangePasswordFrm";
            this.Text = "ChangePasswordFrm";
            this.Load += new System.EventHandler(this.ChangePasswordFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.gbChangePassword.ResumeLayout(false);
            this.gbChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Button btnConfirmChangePassword;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbChangePassword;
    }
}