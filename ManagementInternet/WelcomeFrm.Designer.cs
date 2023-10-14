namespace InternetShop
{
    partial class WelcomeFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenMangerForm = new System.Windows.Forms.Button();
            this.btnOpenEmployeeForm = new System.Windows.Forms.Button();
            this.btnOpenClientForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenMangerForm);
            this.panel1.Controls.Add(this.btnOpenEmployeeForm);
            this.panel1.Controls.Add(this.btnOpenClientForm);
            this.panel1.Location = new System.Drawing.Point(141, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 95);
            this.panel1.TabIndex = 0;
            // 
            // btnOpenMangerForm
            // 
            this.btnOpenMangerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenMangerForm.Location = new System.Drawing.Point(398, 23);
            this.btnOpenMangerForm.Name = "btnOpenMangerForm";
            this.btnOpenMangerForm.Size = new System.Drawing.Size(138, 41);
            this.btnOpenMangerForm.TabIndex = 2;
            this.btnOpenMangerForm.Text = "Quản lí";
            this.btnOpenMangerForm.UseVisualStyleBackColor = true;
            // 
            // btnOpenEmployeeForm
            // 
            this.btnOpenEmployeeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenEmployeeForm.Location = new System.Drawing.Point(203, 23);
            this.btnOpenEmployeeForm.Name = "btnOpenEmployeeForm";
            this.btnOpenEmployeeForm.Size = new System.Drawing.Size(138, 41);
            this.btnOpenEmployeeForm.TabIndex = 1;
            this.btnOpenEmployeeForm.Text = "Nhân viên";
            this.btnOpenEmployeeForm.UseVisualStyleBackColor = true;
            this.btnOpenEmployeeForm.Click += new System.EventHandler(this.btnOpenEmployeeForm_Click);
            // 
            // btnOpenClientForm
            // 
            this.btnOpenClientForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenClientForm.Location = new System.Drawing.Point(3, 23);
            this.btnOpenClientForm.Name = "btnOpenClientForm";
            this.btnOpenClientForm.Size = new System.Drawing.Size(137, 41);
            this.btnOpenClientForm.TabIndex = 0;
            this.btnOpenClientForm.Text = "Khách hàng";
            this.btnOpenClientForm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quán NET 3 BET";
            // 
            // WelcomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "WelcomeFrm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenMangerForm;
        private System.Windows.Forms.Button btnOpenEmployeeForm;
        private System.Windows.Forms.Button btnOpenClientForm;
        private System.Windows.Forms.Label label1;
    }
}

