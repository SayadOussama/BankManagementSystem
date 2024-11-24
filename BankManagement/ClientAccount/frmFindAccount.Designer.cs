namespace BankManagement.ClientAccount
{
    partial class frmFindAccount
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlClientWithFIlter1 = new BankManagement.ClientAccount.ctrlClientWithFIlter();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::BankManagement.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(945, 516);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 162;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(31, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(979, 53);
            this.lblTitle.TabIndex = 161;
            this.lblTitle.Text = "Find Client Account";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlClientWithFIlter1
            // 
            this.ctrlClientWithFIlter1.FilterEnabled = true;
            this.ctrlClientWithFIlter1.Location = new System.Drawing.Point(6, 65);
            this.ctrlClientWithFIlter1.Name = "ctrlClientWithFIlter1";
           // this.ctrlClientWithFIlter1.ShowAddPerson = true;
            this.ctrlClientWithFIlter1.Size = new System.Drawing.Size(1066, 456);
            this.ctrlClientWithFIlter1.TabIndex = 163;
            // 
            // frmFindAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 567);
            this.Controls.Add(this.ctrlClientWithFIlter1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFindAccount";
            this.Text = "Find Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private ctrlClientWithFIlter ctrlClientWithFIlter1;
    }
}