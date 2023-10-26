namespace ManagementInternet.View
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
            this.btnOpenWorkingSpace = new System.Windows.Forms.Button();
            this.btnOpenClientForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenWorkingSpace);
            this.panel1.Controls.Add(this.btnOpenClientForm);
            this.panel1.Location = new System.Drawing.Point(141, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 95);
            this.panel1.TabIndex = 0;
            // 
            // btnOpenWorkingSpace
            // 
            this.btnOpenWorkingSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenWorkingSpace.Location = new System.Drawing.Point(367, 23);
            this.btnOpenWorkingSpace.Name = "btnOpenWorkingSpace";
            this.btnOpenWorkingSpace.Size = new System.Drawing.Size(138, 41);
            this.btnOpenWorkingSpace.TabIndex = 1;
            this.btnOpenWorkingSpace.Text = "Làm việc";
            this.btnOpenWorkingSpace.UseVisualStyleBackColor = true;
            this.btnOpenWorkingSpace.Click += new System.EventHandler(this.btnOpenEmployeeForm_Click);
            // 
            // btnOpenClientForm
            // 
            this.btnOpenClientForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenClientForm.Location = new System.Drawing.Point(34, 23);
            this.btnOpenClientForm.Name = "btnOpenClientForm";
            this.btnOpenClientForm.Size = new System.Drawing.Size(137, 41);
            this.btnOpenClientForm.TabIndex = 0;
            this.btnOpenClientForm.Text = "Khách hàng";
            this.btnOpenClientForm.UseVisualStyleBackColor = true;
            this.btnOpenClientForm.Click += new System.EventHandler(this.btnOpenClientForm_Click);
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
        private System.Windows.Forms.Button btnOpenWorkingSpace;
        private System.Windows.Forms.Button btnOpenClientForm;
        private System.Windows.Forms.Label label1;
    }
}

