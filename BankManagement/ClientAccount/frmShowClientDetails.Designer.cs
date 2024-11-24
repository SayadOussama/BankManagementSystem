namespace BankManagement.ClientAccount
{
    partial class frmShowClientDetails
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlClientDetails1 = new BankManagement.ClientAccount.ctrlClientDetails();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(29, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(979, 53);
            this.lblTitle.TabIndex = 123;
            this.lblTitle.Text = "Client Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlClientDetails1
            // 
            this.ctrlClientDetails1.Location = new System.Drawing.Point(12, 77);
            this.ctrlClientDetails1.Name = "ctrlClientDetails1";
            this.ctrlClientDetails1.Size = new System.Drawing.Size(1030, 352);
            this.ctrlClientDetails1.TabIndex = 124;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::BankManagement.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(904, 434);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 160;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 485);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlClientDetails1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmShowClientDetails";
            this.Text = "Show Client Details";
            this.Load += new System.EventHandler(this.frmShowClientDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlClientDetails ctrlClientDetails1;
        private System.Windows.Forms.Button btnClose;
    }
}