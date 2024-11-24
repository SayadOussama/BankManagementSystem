namespace BankManagement.People
{
    partial class frmShowPersonInfo
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
            this.ctrlPersonCard1 = new BankManagement.People.ctrlPersonCard();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(848, 53);
            this.lblTitle.TabIndex = 119;
            this.lblTitle.Text = "Person";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(8, 65);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(858, 324);
            this.ctrlPersonCard1.TabIndex = 120;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BankManagement.Properties.Resources.Close_321;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(722, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 121;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPersonInfo";
            this.Text = "Show Person Info";
            this.Load += new System.EventHandler(this.frmShowPersonInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Button button1;
    }
}