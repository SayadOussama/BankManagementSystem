namespace BankManagement.Applictions
{
    partial class frmApplicationManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvApplicationManagement = new System.Windows.Forms.DataGridView();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCreateLocalAccount = new System.Windows.Forms.Button();
            this.btnEuroAccount = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.accountIndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateLocalToLocalAndEuroAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationManagement)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplicationManagement
            // 
            this.dgvApplicationManagement.AllowUserToAddRows = false;
            this.dgvApplicationManagement.AllowUserToDeleteRows = false;
            this.dgvApplicationManagement.AllowUserToResizeRows = false;
            this.dgvApplicationManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplicationManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationManagement.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplicationManagement.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvApplicationManagement.Location = new System.Drawing.Point(35, 200);
            this.dgvApplicationManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvApplicationManagement.MultiSelect = false;
            this.dgvApplicationManagement.Name = "dgvApplicationManagement";
            this.dgvApplicationManagement.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicationManagement.RowHeadersWidth = 51;
            this.dgvApplicationManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicationManagement.Size = new System.Drawing.Size(1290, 376);
            this.dgvApplicationManagement.TabIndex = 136;
            this.dgvApplicationManagement.TabStop = false;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "ApplicationID",
            "FullName",
            "ApplicationName"});
            this.cbFilterBy.Location = new System.Drawing.Point(125, 168);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(210, 24);
            this.cbFilterBy.TabIndex = 134;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(342, 168);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(256, 22);
            this.txtFilterValue.TabIndex = 133;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 132;
            this.label1.Text = "Filter By:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(52, 121);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1310, 39);
            this.lblTitle.TabIndex = 131;
            this.lblTitle.Text = "Application Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1241, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 159;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(143, 602);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(21, 16);
            this.lblTotalRecords.TabIndex = 161;
            this.lblTotalRecords.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 160;
            this.label5.Text = "# Records:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountIndoToolStripMenuItem,
            this.updateLocalToLocalAndEuroAccountToolStripMenuItem,
            this.renewAccountToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(393, 214);
            // 
            // btnCreateLocalAccount
            // 
            this.btnCreateLocalAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateLocalAccount.Image = global::BankManagement.Properties.Resources.CreateLocalAccount2;
            this.btnCreateLocalAccount.Location = new System.Drawing.Point(1188, 112);
            this.btnCreateLocalAccount.Name = "btnCreateLocalAccount";
            this.btnCreateLocalAccount.Size = new System.Drawing.Size(88, 75);
            this.btnCreateLocalAccount.TabIndex = 163;
            this.btnCreateLocalAccount.UseVisualStyleBackColor = true;
            this.btnCreateLocalAccount.Click += new System.EventHandler(this.btnCreateLocalAccount_Click);
            // 
            // btnEuroAccount
            // 
            this.btnEuroAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEuroAccount.Image = global::BankManagement.Properties.Resources.EuroAndDollar;
            this.btnEuroAccount.Location = new System.Drawing.Point(1282, 112);
            this.btnEuroAccount.Name = "btnEuroAccount";
            this.btnEuroAccount.Size = new System.Drawing.Size(88, 75);
            this.btnEuroAccount.TabIndex = 162;
            this.btnEuroAccount.UseVisualStyleBackColor = true;
            this.btnEuroAccount.Click += new System.EventHandler(this.btnLocalandEuro_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = global::BankManagement.Properties.Resources.mobile_banking;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(601, -24);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(220, 145);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 130;
            this.pbPersonImage.TabStop = false;
            // 
            // accountIndoToolStripMenuItem
            // 
            this.accountIndoToolStripMenuItem.Image = global::BankManagement.Properties.Resources.ContextMenustripinfo;
            this.accountIndoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountIndoToolStripMenuItem.Name = "accountIndoToolStripMenuItem";
            this.accountIndoToolStripMenuItem.Size = new System.Drawing.Size(392, 70);
            this.accountIndoToolStripMenuItem.Text = "Account Info";
            this.accountIndoToolStripMenuItem.Click += new System.EventHandler(this.accountIndoToolStripMenuItem_Click);
            // 
            // updateLocalToLocalAndEuroAccountToolStripMenuItem
            // 
            this.updateLocalToLocalAndEuroAccountToolStripMenuItem.Image = global::BankManagement.Properties.Resources.CreateLocalAndEuroAccount1;
            this.updateLocalToLocalAndEuroAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateLocalToLocalAndEuroAccountToolStripMenuItem.Name = "updateLocalToLocalAndEuroAccountToolStripMenuItem";
            this.updateLocalToLocalAndEuroAccountToolStripMenuItem.Size = new System.Drawing.Size(392, 70);
            this.updateLocalToLocalAndEuroAccountToolStripMenuItem.Text = "Update Local to Local and Euro Account";
            this.updateLocalToLocalAndEuroAccountToolStripMenuItem.Click += new System.EventHandler(this.updateLocalToLocalAndEuroAccountToolStripMenuItem_Click);
            // 
            // renewAccountToolStripMenuItem
            // 
            this.renewAccountToolStripMenuItem.Image = global::BankManagement.Properties.Resources.Renew;
            this.renewAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewAccountToolStripMenuItem.Name = "renewAccountToolStripMenuItem";
            this.renewAccountToolStripMenuItem.Size = new System.Drawing.Size(392, 70);
            this.renewAccountToolStripMenuItem.Text = "Renew Account ";
            this.renewAccountToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.renewAccountToolStripMenuItem.Click += new System.EventHandler(this.renewAccountToolStripMenuItem_Click);
            // 
            // frmApplicationManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 629);
            this.Controls.Add(this.btnCreateLocalAccount);
            this.Controls.Add(this.btnEuroAccount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvApplicationManagement);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmApplicationManagment";
            this.Text = "frmApplicationManagment";
            this.Load += new System.EventHandler(this.frmApplicationManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationManagement)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvApplicationManagement;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateLocalAccount;
        private System.Windows.Forms.Button btnEuroAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountIndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateLocalToLocalAndEuroAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewAccountToolStripMenuItem;
    }
}