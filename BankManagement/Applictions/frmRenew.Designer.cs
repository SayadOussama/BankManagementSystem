namespace BankManagement.Applictions
{
    partial class frmRenew
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
            this.ctrlClientDetails1 = new BankManagement.ClientAccount.ctrlClientDetails();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlClientDetails1
            // 
            this.ctrlClientDetails1.Location = new System.Drawing.Point(3, 12);
            this.ctrlClientDetails1.Name = "ctrlClientDetails1";
            this.ctrlClientDetails1.Size = new System.Drawing.Size(1030, 352);
            this.ctrlClientDetails1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::BankManagement.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(698, 372);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 37);
            this.btnClose.TabIndex = 159;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Image = global::BankManagement.Properties.Resources.Renew_Driving_License_32;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(873, 372);
            this.btnRenew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(153, 37);
            this.btnRenew.TabIndex = 158;
            this.btnRenew.Text = "Renew";
            this.btnRenew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // frmRenew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 417);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.ctrlClientDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRenew";
            this.Text = "Renew";
            this.Load += new System.EventHandler(this.frmRenew_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ClientAccount.ctrlClientDetails ctrlClientDetails1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRenew;
    }
}