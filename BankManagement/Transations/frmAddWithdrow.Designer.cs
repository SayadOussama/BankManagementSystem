namespace BankManagement.Transations
{
    partial class frmAddWithdraw
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblFees = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAmountType = new System.Windows.Forms.GroupBox();
            this.rbEuro = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.ctrlClientWithFIlter1 = new BankManagement.ClientAccount.ctrlClientWithFIlter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbAmountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(38, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(979, 53);
            this.lblTitle.TabIndex = 162;
            this.lblTitle.Text = "Withdrow Transaction";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(476, 560);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(293, 34);
            this.txtAmount.TabIndex = 164;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 560);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 166;
            this.label7.Text = "Transaction Fees";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BankManagement.Properties.Resources.TransationFees;
            this.pictureBox4.Location = new System.Drawing.Point(228, 562);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 167;
            this.pictureBox4.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BankManagement.Properties.Resources.money_management;
            this.btnProcess.Location = new System.Drawing.Point(807, 554);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(122, 49);
            this.btnProcess.TabIndex = 165;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(318, 567);
            this.lblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(53, 18);
            this.lblFees.TabIndex = 168;
            this.lblFees.Text = "?????";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbAmountType
            // 
            this.gbAmountType.Controls.Add(this.rbEuro);
            this.gbAmountType.Controls.Add(this.rbLocal);
            this.gbAmountType.Location = new System.Drawing.Point(46, 491);
            this.gbAmountType.Name = "gbAmountType";
            this.gbAmountType.Size = new System.Drawing.Size(232, 45);
            this.gbAmountType.TabIndex = 169;
            this.gbAmountType.TabStop = false;
            this.gbAmountType.Text = "Euro";
            // 
            // rbEuro
            // 
            this.rbEuro.AutoSize = true;
            this.rbEuro.Location = new System.Drawing.Point(114, 19);
            this.rbEuro.Name = "rbEuro";
            this.rbEuro.Size = new System.Drawing.Size(56, 20);
            this.rbEuro.TabIndex = 0;
            this.rbEuro.TabStop = true;
            this.rbEuro.Text = "Euro";
            this.rbEuro.UseVisualStyleBackColor = true;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(7, 19);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(61, 20);
            this.rbLocal.TabIndex = 0;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // ctrlClientWithFIlter1
            // 
            this.ctrlClientWithFIlter1.FilterEnabled = true;
            this.ctrlClientWithFIlter1.Location = new System.Drawing.Point(1, 54);
            this.ctrlClientWithFIlter1.Name = "ctrlClientWithFIlter1";
            this.ctrlClientWithFIlter1.Size = new System.Drawing.Size(1054, 431);
            this.ctrlClientWithFIlter1.TabIndex = 163;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BankManagement.Properties.Resources.Close_321;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(939, 630);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 170;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbAmountType);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.ctrlClientWithFIlter1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddWithdraw";
            this.Text = "Add/Withdrow Transation";
            this.Load += new System.EventHandler(this.frmAddWithdrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbAmountType.ResumeLayout(false);
            this.gbAmountType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ClientAccount.ctrlClientWithFIlter ctrlClientWithFIlter1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbAmountType;
        private System.Windows.Forms.RadioButton rbEuro;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.Button button1;
    }
}