namespace BankManagement.Applictions
{
    partial class frmAddUpdateClientAccount
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardwithFilter1 = new BankManagement.People.ctrlPersonCardwithFilter();
            this.btnPersonInfoNext = new System.Windows.Forms.Button();
            this.tpCreateAccountClient = new System.Windows.Forms.TabPage();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtLocalDeposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEuroDeposit = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcUserInfo.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpCreateAccountClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(2, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1147, 39);
            this.lblTitle.TabIndex = 74;
            this.lblTitle.Text = "Add New Client Account ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tpPersonalInfo);
            this.tcUserInfo.Controls.Add(this.tpCreateAccountClient);
            this.tcUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUserInfo.Location = new System.Drawing.Point(12, 67);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(1137, 621);
            this.tcUserInfo.TabIndex = 75;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.ctrlPersonCardwithFilter1);
            this.tpPersonalInfo.Controls.Add(this.btnPersonInfoNext);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 31);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(1129, 586);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardwithFilter1
            // 
            this.ctrlPersonCardwithFilter1.FilterEnable = true;
            this.ctrlPersonCardwithFilter1.Location = new System.Drawing.Point(2, 7);
            this.ctrlPersonCardwithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCardwithFilter1.Name = "ctrlPersonCardwithFilter1";
            this.ctrlPersonCardwithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardwithFilter1.Size = new System.Drawing.Size(1120, 517);
            this.ctrlPersonCardwithFilter1.TabIndex = 121;
            // 
            // btnPersonInfoNext
            // 
            this.btnPersonInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonInfoNext.Image = global::BankManagement.Properties.Resources.Next_32;
            this.btnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonInfoNext.Location = new System.Drawing.Point(953, 541);
            this.btnPersonInfoNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonInfoNext.Name = "btnPersonInfoNext";
            this.btnPersonInfoNext.Size = new System.Drawing.Size(126, 37);
            this.btnPersonInfoNext.TabIndex = 120;
            this.btnPersonInfoNext.Text = "Next";
            this.btnPersonInfoNext.UseVisualStyleBackColor = true;
            this.btnPersonInfoNext.Click += new System.EventHandler(this.btnPersonInfoNext_Click);
            // 
            // tpCreateAccountClient
            // 
            this.tpCreateAccountClient.Controls.Add(this.lblExpirationDate);
            this.tpCreateAccountClient.Controls.Add(this.label9);
            this.tpCreateAccountClient.Controls.Add(this.lblCreationDate);
            this.tpCreateAccountClient.Controls.Add(this.label3);
            this.tpCreateAccountClient.Controls.Add(this.pictureBox5);
            this.tpCreateAccountClient.Controls.Add(this.lblApplicationFees);
            this.tpCreateAccountClient.Controls.Add(this.label7);
            this.tpCreateAccountClient.Controls.Add(this.pictureBox1);
            this.tpCreateAccountClient.Controls.Add(this.lblApplicationID);
            this.tpCreateAccountClient.Controls.Add(this.label6);
            this.tpCreateAccountClient.Controls.Add(this.pictureBox2);
            this.tpCreateAccountClient.Controls.Add(this.lblAccountID);
            this.tpCreateAccountClient.Controls.Add(this.label4);
            this.tpCreateAccountClient.Controls.Add(this.chkIsActive);
            this.tpCreateAccountClient.Controls.Add(this.txtLocalDeposit);
            this.tpCreateAccountClient.Controls.Add(this.label1);
            this.tpCreateAccountClient.Controls.Add(this.label2);
            this.tpCreateAccountClient.Controls.Add(this.txtEuroDeposit);
            this.tpCreateAccountClient.Controls.Add(this.pictureBox8);
            this.tpCreateAccountClient.Controls.Add(this.pictureBox3);
            this.tpCreateAccountClient.Location = new System.Drawing.Point(4, 31);
            this.tpCreateAccountClient.Name = "tpCreateAccountClient";
            this.tpCreateAccountClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreateAccountClient.Size = new System.Drawing.Size(1129, 586);
            this.tpCreateAccountClient.TabIndex = 1;
            this.tpCreateAccountClient.Text = "Create Account Client";
            this.tpCreateAccountClient.UseVisualStyleBackColor = true;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(432, 381);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(145, 25);
            this.lblExpirationDate.TabIndex = 154;
            this.lblExpirationDate.Text = "dd/mmm/yyyy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(205, 381);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 25);
            this.label9.TabIndex = 153;
            this.label9.Text = "Expiration Date:";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(431, 330);
            this.lblCreationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(145, 25);
            this.lblCreationDate.TabIndex = 152;
            this.lblCreationDate.Text = "dd/mmm/yyyy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 151;
            this.label3.Text = "Creation Date:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BankManagement.Properties.Resources.money_32___2;
            this.pictureBox5.Location = new System.Drawing.Point(391, 280);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 150;
            this.pictureBox5.TabStop = false;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(431, 280);
            this.lblApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(48, 25);
            this.lblApplicationFees.TabIndex = 149;
            this.lblApplicationFees.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 148;
            this.label7.Text = "Application Fees:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManagement.Properties.Resources.Number_321;
            this.pictureBox1.Location = new System.Drawing.Point(367, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(407, 149);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(48, 25);
            this.lblApplicationID.TabIndex = 146;
            this.lblApplicationID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 145;
            this.label6.Text = "Application ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankManagement.Properties.Resources.Number_321;
            this.pictureBox2.Location = new System.Drawing.Point(368, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 143;
            this.pictureBox2.TabStop = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.Location = new System.Drawing.Point(408, 109);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(48, 25);
            this.lblAccountID.TabIndex = 142;
            this.lblAccountID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 141;
            this.label4.Text = "Account ID:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(209, 436);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(99, 26);
            this.chkIsActive.TabIndex = 140;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtLocalDeposit
            // 
            this.txtLocalDeposit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLocalDeposit.Location = new System.Drawing.Point(408, 199);
            this.txtLocalDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocalDeposit.MaxLength = 50;
            this.txtLocalDeposit.Name = "txtLocalDeposit";
            this.txtLocalDeposit.Size = new System.Drawing.Size(257, 28);
            this.txtLocalDeposit.TabIndex = 131;
            this.txtLocalDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalDeposit_KeyPress);
            this.txtLocalDeposit.Validating += new System.ComponentModel.CancelEventHandler(this.txtLocalDeposit_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 133;
            this.label1.Text = "Local Deposit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 134;
            this.label2.Text = "Euro Deposit:";
            // 
            // txtEuroDeposit
            // 
            this.txtEuroDeposit.Location = new System.Drawing.Point(407, 237);
            this.txtEuroDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEuroDeposit.MaxLength = 50;
            this.txtEuroDeposit.Name = "txtEuroDeposit";
            this.txtEuroDeposit.Size = new System.Drawing.Size(258, 28);
            this.txtEuroDeposit.TabIndex = 132;
            this.txtEuroDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEuroDeposit_KeyPress);
            this.txtEuroDeposit.Validating += new System.ComponentModel.CancelEventHandler(this.txtEuroDeposit_Validating);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::BankManagement.Properties.Resources.dollarCurrency1;
            this.pictureBox8.Location = new System.Drawing.Point(370, 197);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 136;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BankManagement.Properties.Resources.EuroCurrenty;
            this.pictureBox3.Location = new System.Drawing.Point(369, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 135;
            this.pictureBox3.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::BankManagement.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(878, 692);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 159;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::BankManagement.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1012, 692);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 158;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateClientAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 737);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcUserInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmAddUpdateClientAccount";
            this.Text = "Add Update Client Account";
            this.Load += new System.EventHandler(this.frmAddUpdateClientAccount_Load);
            this.tcUserInfo.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpCreateAccountClient.ResumeLayout(false);
            this.tpCreateAccountClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.Button btnPersonInfoNext;
        private System.Windows.Forms.TabPage tpCreateAccountClient;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtLocalDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEuroDeposit;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label7;
        private People.ctrlPersonCardwithFilter ctrlPersonCardwithFilter1;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}