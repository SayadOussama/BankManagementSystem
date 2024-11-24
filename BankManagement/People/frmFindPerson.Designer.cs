namespace BankManagement.People
{
    partial class frmFindPerson
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
            this.ctrlPersonCardwithFilter1 = new BankManagement.People.ctrlPersonCardwithFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlPersonCardwithFilter1
            // 
            this.ctrlPersonCardwithFilter1.FilterEnable = true;
            this.ctrlPersonCardwithFilter1.Location = new System.Drawing.Point(15, 53);
            this.ctrlPersonCardwithFilter1.Name = "ctrlPersonCardwithFilter1";
            this.ctrlPersonCardwithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardwithFilter1.Size = new System.Drawing.Size(871, 420);
            this.ctrlPersonCardwithFilter1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::BankManagement.Properties.Resources.Close_321;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(757, 481);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 117;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(893, 39);
            this.lblTitle.TabIndex = 118;
            this.lblTitle.Text = "Find";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 522);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonCardwithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFindPerson";
            this.Text = "frmFindPerson";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCardwithFilter ctrlPersonCardwithFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}