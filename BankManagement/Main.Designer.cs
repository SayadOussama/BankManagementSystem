namespace BankManagement
{
    partial class frmMain
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
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LeftSidePanel = new System.Windows.Forms.Panel();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPeopleMangement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClientManagement = new System.Windows.Forms.Button();
            this.btnChangeUserPassword = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLocalAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLocalandEuroAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateLocalToEuroAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferLocalAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferEuroAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LeftSidePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.White;
            this.pHeader.Controls.Add(this.lblDateAndTime);
            this.pHeader.Controls.Add(this.btnClose);
            this.pHeader.Controls.Add(this.lblCurrentUser);
            this.pHeader.Controls.Add(this.label1);
            this.pHeader.Controls.Add(this.pictureBox1);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1336, 80);
            this.pHeader.TabIndex = 0;
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDateAndTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateAndTime.Location = new System.Drawing.Point(766, 14);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(107, 38);
            this.lblDateAndTime.TabIndex = 4;
            this.lblDateAndTime.Text = "?????";
            this.lblDateAndTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateAndTime.Click += new System.EventHandler(this.lblDateAndTime_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::BankManagement.Properties.Resources.Off;
            this.btnClose.Location = new System.Drawing.Point(1253, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 80);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentUser.Location = new System.Drawing.Point(159, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(60, 22);
            this.lblCurrentUser.TabIndex = 2;
            this.lblCurrentUser.Text = "?????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "User :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::BankManagement.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.Color.White;
            this.LeftSidePanel.Controls.Add(this.btnFindPerson);
            this.LeftSidePanel.Controls.Add(this.panel3);
            this.LeftSidePanel.Controls.Add(this.btnAddNewPerson);
            this.LeftSidePanel.Controls.Add(this.button2);
            this.LeftSidePanel.Controls.Add(this.btnPeopleMangement);
            this.LeftSidePanel.Controls.Add(this.panel1);
            this.LeftSidePanel.Controls.Add(this.btnClientManagement);
            this.LeftSidePanel.Controls.Add(this.btnChangeUserPassword);
            this.LeftSidePanel.Controls.Add(this.btnAddNewUser);
            this.LeftSidePanel.Controls.Add(this.btnUserManagement);
            this.LeftSidePanel.Controls.Add(this.btnDashbord);
            this.LeftSidePanel.Controls.Add(this.panel2);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 80);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(332, 886);
            this.LeftSidePanel.TabIndex = 1;
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPerson.ForeColor = System.Drawing.Color.Black;
            this.btnFindPerson.Image = global::BankManagement.Properties.Resources.FindPerson;
            this.btnFindPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindPerson.Location = new System.Drawing.Point(-3, 278);
            this.btnFindPerson.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnFindPerson.Size = new System.Drawing.Size(332, 73);
            this.btnFindPerson.TabIndex = 17;
            this.btnFindPerson.Text = "Find Person";
            this.btnFindPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 619);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 71);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BankManagement.Properties.Resources.Clients;
            this.pictureBox4.Location = new System.Drawing.Point(0, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 71);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(153, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clients";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewPerson.Image = global::BankManagement.Properties.Resources.AddNewPerson;
            this.btnAddNewPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewPerson.Location = new System.Drawing.Point(-3, 212);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(332, 71);
            this.btnAddNewPerson.TabIndex = 16;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::BankManagement.Properties.Resources.FindClientwithCard;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-3, 760);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(332, 71);
            this.button2.TabIndex = 13;
            this.button2.Text = "Find Client with Card";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPeopleMangement
            // 
            this.btnPeopleMangement.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeopleMangement.ForeColor = System.Drawing.Color.Black;
            this.btnPeopleMangement.Image = global::BankManagement.Properties.Resources.PeopleManagment;
            this.btnPeopleMangement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeopleMangement.Location = new System.Drawing.Point(0, 139);
            this.btnPeopleMangement.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnPeopleMangement.Name = "btnPeopleMangement";
            this.btnPeopleMangement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnPeopleMangement.Size = new System.Drawing.Size(329, 73);
            this.btnPeopleMangement.TabIndex = 15;
            this.btnPeopleMangement.Text = "People Management";
            this.btnPeopleMangement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeopleMangement.UseVisualStyleBackColor = true;
            this.btnPeopleMangement.Click += new System.EventHandler(this.btnPeopleMangement_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 71);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BankManagement.Properties.Resources.group;
            this.pictureBox3.Location = new System.Drawing.Point(0, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 71);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(159, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "People";
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientManagement.ForeColor = System.Drawing.Color.Black;
            this.btnClientManagement.Image = global::BankManagement.Properties.Resources.ClientManagement;
            this.btnClientManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientManagement.Location = new System.Drawing.Point(0, 687);
            this.btnClientManagement.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnClientManagement.Size = new System.Drawing.Size(329, 73);
            this.btnClientManagement.TabIndex = 12;
            this.btnClientManagement.Text = "Clients Management";
            this.btnClientManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientManagement.UseVisualStyleBackColor = true;
            this.btnClientManagement.Click += new System.EventHandler(this.btnClientManagement_Click);
            // 
            // btnChangeUserPassword
            // 
            this.btnChangeUserPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUserPassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangeUserPassword.Image = global::BankManagement.Properties.Resources.searchUser;
            this.btnChangeUserPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeUserPassword.Location = new System.Drawing.Point(-3, 553);
            this.btnChangeUserPassword.Name = "btnChangeUserPassword";
            this.btnChangeUserPassword.Size = new System.Drawing.Size(332, 71);
            this.btnChangeUserPassword.TabIndex = 11;
            this.btnChangeUserPassword.Text = "Change User Password";
            this.btnChangeUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeUserPassword.UseVisualStyleBackColor = true;
            this.btnChangeUserPassword.Click += new System.EventHandler(this.btnChangeUserPassword_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewUser.Image = global::BankManagement.Properties.Resources.AddNewUser;
            this.btnAddNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewUser.Location = new System.Drawing.Point(-3, 486);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(332, 71);
            this.btnAddNewUser.TabIndex = 10;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.Black;
            this.btnUserManagement.Image = global::BankManagement.Properties.Resources.Usermanagement;
            this.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 413);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnUserManagement.Size = new System.Drawing.Size(329, 73);
            this.btnUserManagement.TabIndex = 9;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnDashbord
            // 
            this.btnDashbord.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.Color.Black;
            this.btnDashbord.Image = global::BankManagement.Properties.Resources.dashboard1;
            this.btnDashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashbord.Location = new System.Drawing.Point(3, 0);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(329, 71);
            this.btnDashbord.TabIndex = 8;
            this.btnDashbord.Text = "Dashbord";
            this.btnDashbord.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 71);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankManagement.Properties.Resources.usersMore;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 71);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(121, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Users";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(332, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1004, 98);
            this.panel4.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.transactionListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationManagementToolStripMenuItem,
            this.createLocalAccountToolStripMenuItem,
            this.createLocalandEuroAccountToolStripMenuItem,
            this.updateLocalToEuroAccountToolStripMenuItem,
            this.renewAccountToolStripMenuItem});
            this.applicationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.applicationToolStripMenuItem.Image = global::BankManagement.Properties.Resources.Application12;
            this.applicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(170, 68);
            this.applicationToolStripMenuItem.Text = "Applications";
            // 
            // applicationManagementToolStripMenuItem
            // 
            this.applicationManagementToolStripMenuItem.Image = global::BankManagement.Properties.Resources.applicationMangment5;
            this.applicationManagementToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationManagementToolStripMenuItem.Name = "applicationManagementToolStripMenuItem";
            this.applicationManagementToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.applicationManagementToolStripMenuItem.Text = "Application Management";
            this.applicationManagementToolStripMenuItem.Click += new System.EventHandler(this.applicationManagementToolStripMenuItem_Click);
            // 
            // createLocalAccountToolStripMenuItem
            // 
            this.createLocalAccountToolStripMenuItem.Image = global::BankManagement.Properties.Resources.CreateLocalAccount2;
            this.createLocalAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.createLocalAccountToolStripMenuItem.Name = "createLocalAccountToolStripMenuItem";
            this.createLocalAccountToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.createLocalAccountToolStripMenuItem.Text = "Create Local Account";
            this.createLocalAccountToolStripMenuItem.Click += new System.EventHandler(this.createLocalAccountToolStripMenuItem_Click);
            // 
            // createLocalandEuroAccountToolStripMenuItem
            // 
            this.createLocalandEuroAccountToolStripMenuItem.Image = global::BankManagement.Properties.Resources.euroAccount;
            this.createLocalandEuroAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.createLocalandEuroAccountToolStripMenuItem.Name = "createLocalandEuroAccountToolStripMenuItem";
            this.createLocalandEuroAccountToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.createLocalandEuroAccountToolStripMenuItem.Text = "Create Local end Euro Account ";
            this.createLocalandEuroAccountToolStripMenuItem.Click += new System.EventHandler(this.createEuroAccountToolStripMenuItem_Click);
            // 
            // updateLocalToEuroAccountToolStripMenuItem
            // 
            this.updateLocalToEuroAccountToolStripMenuItem.Image = global::BankManagement.Properties.Resources.CreateLocalAndEuroAccount;
            this.updateLocalToEuroAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateLocalToEuroAccountToolStripMenuItem.Name = "updateLocalToEuroAccountToolStripMenuItem";
            this.updateLocalToEuroAccountToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.updateLocalToEuroAccountToolStripMenuItem.Text = "Update Local  To Euro Account ";
            this.updateLocalToEuroAccountToolStripMenuItem.Click += new System.EventHandler(this.updateLocalToEuroAccountToolStripMenuItem_Click);
            // 
            // renewAccountToolStripMenuItem
            // 
            this.renewAccountToolStripMenuItem.Image = global::BankManagement.Properties.Resources.Renew;
            this.renewAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewAccountToolStripMenuItem.Name = "renewAccountToolStripMenuItem";
            this.renewAccountToolStripMenuItem.Size = new System.Drawing.Size(344, 70);
            this.renewAccountToolStripMenuItem.Text = "Renew Account ";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAmountToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.transferLocalAmountToolStripMenuItem,
            this.transferEuroAmountToolStripMenuItem});
            this.transactionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.transactionsToolStripMenuItem.Image = global::BankManagement.Properties.Resources.Transactions1;
            this.transactionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(168, 68);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // addAmountToolStripMenuItem
            // 
            this.addAmountToolStripMenuItem.Image = global::BankManagement.Properties.Resources.Add;
            this.addAmountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addAmountToolStripMenuItem.Name = "addAmountToolStripMenuItem";
            this.addAmountToolStripMenuItem.Size = new System.Drawing.Size(288, 70);
            this.addAmountToolStripMenuItem.Text = "Add Amount ";
            this.addAmountToolStripMenuItem.Click += new System.EventHandler(this.addAmountToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Image = global::BankManagement.Properties.Resources.WithDraw;
            this.withdrawToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(288, 70);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // transferLocalAmountToolStripMenuItem
            // 
            this.transferLocalAmountToolStripMenuItem.Image = global::BankManagement.Properties.Resources.transfer;
            this.transferLocalAmountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transferLocalAmountToolStripMenuItem.Name = "transferLocalAmountToolStripMenuItem";
            this.transferLocalAmountToolStripMenuItem.Size = new System.Drawing.Size(288, 70);
            this.transferLocalAmountToolStripMenuItem.Text = "Transfer Local Amount ";
            this.transferLocalAmountToolStripMenuItem.Click += new System.EventHandler(this.transferLocalAmountToolStripMenuItem_Click);
            // 
            // transferEuroAmountToolStripMenuItem
            // 
            this.transferEuroAmountToolStripMenuItem.Image = global::BankManagement.Properties.Resources.TransferEuroAmount;
            this.transferEuroAmountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transferEuroAmountToolStripMenuItem.Name = "transferEuroAmountToolStripMenuItem";
            this.transferEuroAmountToolStripMenuItem.Size = new System.Drawing.Size(288, 70);
            this.transferEuroAmountToolStripMenuItem.Text = "Transfer Euro Amount";
            this.transferEuroAmountToolStripMenuItem.Click += new System.EventHandler(this.transferEuroAmountToolStripMenuItem_Click);
            // 
            // transactionListToolStripMenuItem
            // 
            this.transactionListToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.transactionListToolStripMenuItem.Image = global::BankManagement.Properties.Resources.ListTransaction;
            this.transactionListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionListToolStripMenuItem.Name = "transactionListToolStripMenuItem";
            this.transactionListToolStripMenuItem.Size = new System.Drawing.Size(192, 68);
            this.transactionListToolStripMenuItem.Text = "Transaction List ";
            this.transactionListToolStripMenuItem.Click += new System.EventHandler(this.transactionListToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1336, 966);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LeftSidePanel);
            this.Controls.Add(this.pHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LeftSidePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel LeftSidePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnChangeUserPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClientManagement;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnPeopleMangement;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLocalAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLocalandEuroAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateLocalToEuroAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferLocalAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferEuroAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionListToolStripMenuItem;
    }
}

