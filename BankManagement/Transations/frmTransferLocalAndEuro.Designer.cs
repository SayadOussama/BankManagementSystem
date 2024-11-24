namespace BankManagement.Transations
{
    partial class frmTransferLocalAndEuro
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFees = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.ctrlClientWithFIlter2 = new BankManagement.ClientAccount.ctrlClientWithFIlter();
            this.ctrlClientWithFIlter1 = new BankManagement.ClientAccount.ctrlClientWithFIlter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sender Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1037, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Receiver Account";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1971, 53);
            this.lblTitle.TabIndex = 163;
            this.lblTitle.Text = "Local Transfer Amount";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BankManagement.Properties.Resources.Close_321;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1890, 717);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 176;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(960, 630);
            this.lblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(53, 18);
            this.lblFees.TabIndex = 175;
            this.lblFees.Text = "?????";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BankManagement.Properties.Resources.TransationFees;
            this.pictureBox4.Location = new System.Drawing.Point(870, 625);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 174;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 623);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 173;
            this.label7.Text = "Transaction Fees";
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BankManagement.Properties.Resources.money_management;
            this.btnProcess.Location = new System.Drawing.Point(1449, 617);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(122, 49);
            this.btnProcess.TabIndex = 172;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            this.btnProcess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnProcess_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(1118, 623);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(293, 34);
            this.txtAmount.TabIndex = 171;
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            // 
            // ctrlClientWithFIlter2
            // 
            this.ctrlClientWithFIlter2.FilterEnabled = true;
            this.ctrlClientWithFIlter2.Location = new System.Drawing.Point(1007, 141);
            this.ctrlClientWithFIlter2.Name = "ctrlClientWithFIlter2";
            this.ctrlClientWithFIlter2.Size = new System.Drawing.Size(1067, 456);
            this.ctrlClientWithFIlter2.TabIndex = 1;
            // 
            // ctrlClientWithFIlter1
            // 
            this.ctrlClientWithFIlter1.FilterEnabled = true;
            this.ctrlClientWithFIlter1.Location = new System.Drawing.Point(-23, 141);
            this.ctrlClientWithFIlter1.Name = "ctrlClientWithFIlter1";
            this.ctrlClientWithFIlter1.Size = new System.Drawing.Size(1067, 456);
            this.ctrlClientWithFIlter1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransferLocalAndEuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2018, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlClientWithFIlter2);
            this.Controls.Add(this.ctrlClientWithFIlter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTransferLocalAndEuro";
            this.Text = "frmTransferLocalAndEuro";
            this.Load += new System.EventHandler(this.frmTransferLocalAndEuro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientAccount.ctrlClientWithFIlter ctrlClientWithFIlter1;
        private ClientAccount.ctrlClientWithFIlter ctrlClientWithFIlter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}