namespace ManagementInternet.View.PlayerManagement
{
    partial class AddPlayerFrm
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAddPlayer = new System.Windows.Forms.TabPage();
            this.gBAddPlayer = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAddMoney = new System.Windows.Forms.TabPage();
            this.gBRecharge = new System.Windows.Forms.GroupBox();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.txtAmountOfMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRAccountName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabMain.SuspendLayout();
            this.tabAddPlayer.SuspendLayout();
            this.gBAddPlayer.SuspendLayout();
            this.tabAddMoney.SuspendLayout();
            this.gBRecharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAddPlayer);
            this.tabMain.Controls.Add(this.tabAddMoney);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(615, 411);
            this.tabMain.TabIndex = 4;
            // 
            // tabAddPlayer
            // 
            this.tabAddPlayer.Controls.Add(this.gBAddPlayer);
            this.tabAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddPlayer.Location = new System.Drawing.Point(4, 25);
            this.tabAddPlayer.Name = "tabAddPlayer";
            this.tabAddPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddPlayer.Size = new System.Drawing.Size(607, 382);
            this.tabAddPlayer.TabIndex = 0;
            this.tabAddPlayer.Text = "Thêm hội viên";
            this.tabAddPlayer.UseVisualStyleBackColor = true;
            // 
            // gBAddPlayer
            // 
            this.gBAddPlayer.Controls.Add(this.btnAdd);
            this.gBAddPlayer.Controls.Add(this.txtPassword);
            this.gBAddPlayer.Controls.Add(this.txtAccountName);
            this.gBAddPlayer.Controls.Add(this.txtIdCard);
            this.gBAddPlayer.Controls.Add(this.rbFemale);
            this.gBAddPlayer.Controls.Add(this.rbMale);
            this.gBAddPlayer.Controls.Add(this.label4);
            this.gBAddPlayer.Controls.Add(this.label3);
            this.gBAddPlayer.Controls.Add(this.label2);
            this.gBAddPlayer.Controls.Add(this.label1);
            this.gBAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBAddPlayer.Location = new System.Drawing.Point(112, 34);
            this.gBAddPlayer.Name = "gBAddPlayer";
            this.gBAddPlayer.Size = new System.Drawing.Size(367, 311);
            this.gBAddPlayer.TabIndex = 1;
            this.gBAddPlayer.TabStop = false;
            this.gBAddPlayer.Text = "Tài khoản";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(253, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(211, 24);
            this.txtPassword.TabIndex = 8;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(138, 101);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(211, 24);
            this.txtAccountName.TabIndex = 7;
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(138, 40);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(211, 24);
            this.txtIdCard.TabIndex = 6;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(301, 153);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(48, 22);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(184, 153);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(61, 22);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
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
            // tabAddMoney
            // 
            this.tabAddMoney.Controls.Add(this.gBRecharge);
            this.tabAddMoney.Location = new System.Drawing.Point(4, 25);
            this.tabAddMoney.Name = "tabAddMoney";
            this.tabAddMoney.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddMoney.Size = new System.Drawing.Size(607, 382);
            this.tabAddMoney.TabIndex = 1;
            this.tabAddMoney.Text = "Nạp tiền";
            this.tabAddMoney.UseVisualStyleBackColor = true;
            // 
            // gBRecharge
            // 
            this.gBRecharge.Controls.Add(this.btnRecharge);
            this.gBRecharge.Controls.Add(this.txtAmountOfMoney);
            this.gBRecharge.Controls.Add(this.label7);
            this.gBRecharge.Controls.Add(this.txtRAccountName);
            this.gBRecharge.Controls.Add(this.label6);
            this.gBRecharge.Controls.Add(this.btnSearch);
            this.gBRecharge.Controls.Add(this.txtSearch);
            this.gBRecharge.Controls.Add(this.label5);
            this.gBRecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBRecharge.Location = new System.Drawing.Point(11, 31);
            this.gBRecharge.Name = "gBRecharge";
            this.gBRecharge.Size = new System.Drawing.Size(580, 311);
            this.gBRecharge.TabIndex = 2;
            this.gBRecharge.TabStop = false;
            this.gBRecharge.Text = "Nạp tiền";
            // 
            // btnRecharge
            // 
            this.btnRecharge.Enabled = false;
            this.btnRecharge.Location = new System.Drawing.Point(387, 271);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(96, 34);
            this.btnRecharge.TabIndex = 15;
            this.btnRecharge.Text = "Nạp";
            this.btnRecharge.UseVisualStyleBackColor = true;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // txtAmountOfMoney
            // 
            this.txtAmountOfMoney.Enabled = false;
            this.txtAmountOfMoney.Location = new System.Drawing.Point(263, 208);
            this.txtAmountOfMoney.Name = "txtAmountOfMoney";
            this.txtAmountOfMoney.Size = new System.Drawing.Size(220, 24);
            this.txtAmountOfMoney.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tiền nạp";
            // 
            // txtRAccountName
            // 
            this.txtRAccountName.Enabled = false;
            this.txtRAccountName.Location = new System.Drawing.Point(263, 149);
            this.txtRAccountName.Name = "txtRAccountName";
            this.txtRAccountName.ReadOnly = true;
            this.txtRAccountName.Size = new System.Drawing.Size(220, 24);
            this.txtRAccountName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên tài khoản";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(387, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 34);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(263, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 24);
            this.txtSearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm người chơi";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(527, 451);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 34);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // AddPlayerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 497);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabMain);
            this.Name = "AddPlayerFrm";
            this.Text = "AddPlayerFrm";
            this.tabMain.ResumeLayout(false);
            this.tabAddPlayer.ResumeLayout(false);
            this.gBAddPlayer.ResumeLayout(false);
            this.gBAddPlayer.PerformLayout();
            this.tabAddMoney.ResumeLayout(false);
            this.gBRecharge.ResumeLayout(false);
            this.gBRecharge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAddPlayer;
        private System.Windows.Forms.GroupBox gBAddPlayer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAddMoney;
        private System.Windows.Forms.GroupBox gBRecharge;
        private System.Windows.Forms.Button btnRecharge;
        private System.Windows.Forms.TextBox txtAmountOfMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRAccountName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider error;
    }
}